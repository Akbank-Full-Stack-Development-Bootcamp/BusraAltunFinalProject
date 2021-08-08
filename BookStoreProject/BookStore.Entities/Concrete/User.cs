using Ecommerce.Entities.Concrete.BaseEntities;
using Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
    public class User : AuditableUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public bool Role { get; set; }

    }
}
