using Ecommerce.Entities.DataTransferObjects.BookDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Abstract
{
   public interface IBookService
    {
        Task<IEnumerable<BookDetailDto>> GetListAsync();
        Task<BookDto> GetByIdAsync(int id);
        Task<BookDto> AddAsync(BookAddDto bookAddDto);
        Task<BookUpdatedDto> UpdateAsync(BookUpdatedDto bookUpdatedDto);
        Task<bool> DeleteAsync(int id);
    }
}
