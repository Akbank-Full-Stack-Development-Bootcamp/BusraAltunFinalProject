using Ecommerce.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.DataTransferObjects.BookDataTransferObjects
{
   public class BookDto : IDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public string Publisher { get; set; }
        public bool Cover { get; set; }
        public string PaperNumber { get; set; }
        public string Poster { get; set; }
        public long BarcodeNumber { get; set; }
        public DateTime İssueDate { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }
    }
}
