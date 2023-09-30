using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DbTests;

namespace NiceRemtech.Persistence.DbServise
{
    public static class DbInitialise
    {
        public static void Initialise( NiceremtechDbContext dbContext )
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
