using DbTests;

using Entities.Models.Accounts;
using Entities.Models.Users;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace NiceRemtech.WebApi.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly NiceremtechDbContext _dbContext;
        public UserController( NiceremtechDbContext dbContext)
        {
            _dbContext= dbContext;
        
        }
        [HttpGet ("i")]
       public ActionResult i ( [FromRoute] string name)
        {
            _dbContext.Users.Add (new User ( )
            {
                PersonalData= new PersonalData
                {
                    Name= name
                }
            });
            return Ok ( );
        }
    }
}