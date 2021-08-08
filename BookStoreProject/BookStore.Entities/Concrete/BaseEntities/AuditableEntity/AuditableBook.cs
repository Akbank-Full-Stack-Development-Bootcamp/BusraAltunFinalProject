using Ecommerce.Entities.Abstract.ICreatedEntity;
using Ecommerce.Entities.Abstract.IUpdatedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity
{
    public class AuditableBook : BaseEntity, ICreatedBook, IUpdatedBook
    {
        public int CreatedBookId { get; set; }
        public DateTime CreatedBookDate { get; set; }
        public int? UpdatedBookId { get; set; }
        public DateTime? UpdatedBookDate { get; set; }
    }
}
