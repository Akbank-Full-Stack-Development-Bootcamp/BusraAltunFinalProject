using Ecommerce.Entities.DataTransferObjects.UserDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserDetailDto>> GetListAsync();
        Task<UserDto> GetByIdAsync(int id);
        Task<UserDto> AddAsync(UserAddDto userAddDto);
        Task<UserUpdatedDto> UpdateAsync(UserUpdatedDto userUpdatedDto);
        Task<bool> DeleteAsync(int id);
    }
}
