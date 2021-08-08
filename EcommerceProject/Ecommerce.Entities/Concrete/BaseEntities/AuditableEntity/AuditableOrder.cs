using Ecommerce.Entities.Abstract.ICreatedEntity;
using Ecommerce.Entities.Abstract.IUpdatedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity
{
    public class AuditableOrder : ICreatedOrder, IUpdatedOrder
    {
        public int CreatedOrderId { get; set; }
        public DateTime CreatedOrderDate { get; set; }
        public int? UpdatedOrderId { get; set; }
        public DateTime? UpdatedOrderDate { get; set; }
    }
}
