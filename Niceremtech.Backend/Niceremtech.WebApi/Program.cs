using DbTests;

using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using Niceremtech.WebApi;

using NiceRemtech.Persistence.DbServise;

using Serilog;
using Serilog.Events;



#pragma warning disable U2U1001 // Stateless classes can be static
Log.Logger=new LoggerConfiguration ( )

   .CreateBootstrapLogger ( ); //означает, что глобальный логер будет заменен на вариант из Host.UseSerilog
#pragma warning restore U2U1001 // Stateless classes can be static
Log.Information ("Starting up");

try
{
    #region Builder
    var builder = WebApplication.CreateBuilder (args);


    builder.Host.UseSerilog (( ctx, conf ) =>
    {
        conf
            .MinimumLevel.Debug ( ) //<- Минимальный уровень для всех приемников
            .WriteTo.File ("log-.txt", rollingInterval: RollingInterval.Day)
            .ReadFrom.Configuration (builder.Configuration)
            .WriteTo.Console (restrictedToMinimumLevel: LogEventLevel.Information);
    });
    builder.Services.AddHttpLogging (opt =>
    {
        opt.LoggingFields=HttpLoggingFields.RequestHeaders|
                          HttpLoggingFields.ResponseHeaders|
                          HttpLoggingFields.RequestBody|
                          HttpLoggingFields.ResponseBody;
    });

    builder.Services.AddServisesWithIOptionConfigure (builder);
    builder.Services.AddDbContext<NiceremtechDbContext> (opt =>
    {

        opt.LogTo (( a ) => Log.Logger.Information (a));
        opt.UseNpgsql (builder.Configuration["PostgressConnetionString"]);

    });

    //builder.Services.Configure<OptionsEmailSender> (builder.Configuration.GetSection ("OptionsEmailDataEvent"));

    // Add services to the container.

    var app = builder.Build ( );
    #endregion

    app.UseStaticFiles ( );
    app.UseHttpLogging ( );
    app.UseSerilogRequestLogging ( );

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment ( ))
    {
        app.UseExceptionHandler ("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts ( );
    }

    app.UseHttpsRedirection ( );
    app.UseStaticFiles ( );

    app.UseRouting ( );

    app.UseAuthorization ( );

    app.MapControllerRoute (
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.UseSerilogRequestLogging ( );

   
    app.Run ( );
}
catch (Exception E)
{
    Log.Fatal (E, "Сервер рухнул!");
}
finally
{
    Log.Information ("Shut down complete");
    Log.CloseAndFlush ( );
}