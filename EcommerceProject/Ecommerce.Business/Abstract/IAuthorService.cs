using Ecommerce.Entities.DataTransferObjects.AuthorDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Abstract
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDetailDto>> GetListAsync();
        Task<AuthorDto> GetByIdAsync(int id);
        Task<AuthorDto> AddAsync(AuthorAddDto authorAddDto);
        Task<AuthorUpdatedDto> UpdateAsync(AuthorUpdatedDto authorUpdatedDto);
        Task<bool> DeleteAsync(int id);
    }
}
