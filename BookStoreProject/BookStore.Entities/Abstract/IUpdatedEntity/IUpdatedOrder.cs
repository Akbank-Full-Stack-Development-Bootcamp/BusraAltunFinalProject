using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract.IUpdatedEntity
{
   public interface IUpdatedOrder
    {
        public int? UpdatedOrderId { get; set; }
        public DateTime? UpdatedOrderDate { get; set; }
    }
}
