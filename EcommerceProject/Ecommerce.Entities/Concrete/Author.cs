using Ecommerce.Entities.Abstract;
using Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
    public class Author : AuditableAuthor
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public string Poster { get; set; }

        public virtual IList<BookAuthor> Books { get; set; }
    }
}
