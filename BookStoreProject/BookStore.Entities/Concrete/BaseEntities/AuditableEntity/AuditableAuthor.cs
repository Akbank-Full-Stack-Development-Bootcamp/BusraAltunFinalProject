using Ecommerce.Entities.Abstract.ICreatedEntity;
using Ecommerce.Entities.Abstract.IUpdatedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity
{
    public class AuditableAuthor : BaseEntity, ICreatedAuthor, IUpdatedAuthor
    {
        public int CreatedAuthorId { get; set; }
        public DateTime CreatedAuthorDate { get; set; }
        public int? UpdatedAuthorId { get; set; }
        public DateTime? UpdatedAuthorDate { get; set; }
    }
}
