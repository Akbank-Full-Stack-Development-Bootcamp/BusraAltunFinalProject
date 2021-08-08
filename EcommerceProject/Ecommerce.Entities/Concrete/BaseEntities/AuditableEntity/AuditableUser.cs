using Ecommerce.Entities.Abstract.ICreatedEntity;
using Ecommerce.Entities.Abstract.IUpdatedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity
{
    public class AuditableUser : BaseEntity, ICreatedUser, IUpdatedUser
    {
        public int CreatedUserId { get; set; }
        public DateTime CreatedUserDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedUserDate { get; set; }
    }
}
