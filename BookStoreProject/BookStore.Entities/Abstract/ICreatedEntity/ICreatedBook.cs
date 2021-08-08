using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract.ICreatedEntity
{
   public interface ICreatedBook
    {
        public int CreatedBookId { get; set; }
        public DateTime CreatedBookDate { get; set; }
    }
}
