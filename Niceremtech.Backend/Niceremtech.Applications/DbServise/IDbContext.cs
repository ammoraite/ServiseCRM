namespace DbTests
{
    public interface IDbContext
    {

        Task<int> SaveChangesAsync ( CancellationToken cancellationToken );
    }
}