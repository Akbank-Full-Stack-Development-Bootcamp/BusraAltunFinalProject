using Ecommerce.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.DataTransferObjects.BookDataTransferObjects
{
    public class BookAddDto : IDto
    {
        public string BookName { get; set; }
        public int AuthorId { get; set; }
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
        public int Id { get; set; }
    }
}
