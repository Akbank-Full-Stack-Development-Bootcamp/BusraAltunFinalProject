using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract.IUpdatedEntity
{
   public interface IUpdatedBook
    {
        public int? UpdatedBookId { get; set; }
        public DateTime? UpdatedBookDate { get; set; }
    }
}
