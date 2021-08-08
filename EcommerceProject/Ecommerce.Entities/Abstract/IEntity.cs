using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract
{
   public interface IEntity
    {
        // It will be in the corresponding tables in the database.
        public int Id { get; set; }
    }
}
