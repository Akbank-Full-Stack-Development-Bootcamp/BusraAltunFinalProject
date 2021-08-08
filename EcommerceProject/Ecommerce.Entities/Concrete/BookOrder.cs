using Ecommerce.Entities.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
   public class BookOrder
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
