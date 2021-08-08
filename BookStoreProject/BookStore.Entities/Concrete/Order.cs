using Ecommerce.Entities.Concrete.BaseEntities;
using Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
  public class Order : AuditableOrder
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual IList<BookOrder> Books { get; set; }
    }
}
