using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract.ICreatedEntity
{
    public interface ICreatedOrder
    {
        public int CreatedOrderId { get; set; }
        public DateTime CreatedOrderDate { get; set; }
    }
}
