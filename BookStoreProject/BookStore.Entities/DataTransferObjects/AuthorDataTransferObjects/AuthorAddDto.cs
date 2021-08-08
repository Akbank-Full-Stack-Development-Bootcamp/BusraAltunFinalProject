using Ecommerce.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.DataTransferObjects.AuthorDataTransferObjects
{
   public class AuthorAddDto : IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public string Poster { get; set; }
        public int Id { get; set; }
    }
}
