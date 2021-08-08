using Ecommerce.Entities.Concrete.BaseEntities;
using Ecommerce.Entities.Concrete.BaseEntities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concrete
{
    public class Book : AuditableBook
    {
        //public int Id { get; set; }
        public string BookName { get; set; }
       // public int AuthorId { get; set; }
        public string Publisher { get; set; }
        public bool Cover { get; set; }
        public string PaperType { get; set; }
        public string PaperNumber { get; set; }
        public string Poster { get; set; }
        public long BarcodeNumber { get; set; }
        public string Size { get; set; }
        public DateTime İssueDate { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }

        //Navigation Property
        //Navigation Property
        //public virtual Genre BookGenre { get; set; }
        public virtual Author BookAuthor { get; set; }
        public virtual Order BookOrder { get; set; }

        public virtual IList<BookAuthor> Authors { get; set; }
        public virtual IList<BookOrder> Orders { get; set; }

    }
}
