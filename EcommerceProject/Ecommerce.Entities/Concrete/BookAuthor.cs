using Ecommerce.Entities.Concrete.BaseEntities;
using Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
   public class BookAuthor : AuditableBookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
