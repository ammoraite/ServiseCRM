using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Models.Users;

namespace Entities.Models.WorkSpareEntity
{
    public class Provider
    {
        public Guid Id { get; set; }    
        public User? User { get; set;}
        public Company? Company { get; set;}
    }
}
