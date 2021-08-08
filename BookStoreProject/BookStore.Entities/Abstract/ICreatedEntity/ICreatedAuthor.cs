using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Abstract.ICreatedEntity
{
    public interface ICreatedAuthor
    {
        public int CreatedAuthorId { get; set; }
        public DateTime CreatedAuthorDate { get; set; }
    }
}
