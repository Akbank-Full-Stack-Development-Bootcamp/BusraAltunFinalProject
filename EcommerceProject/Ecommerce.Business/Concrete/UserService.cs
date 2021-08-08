using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DataTransferObjects.UserDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal userDal;

        public UserService(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public async Task<UserDto> AddAsync(UserAddDto userAddDto)
        {
            User user = new User()
            {
                UserName = userAddDto.UserName,
                FirstName = userAddDto.FirstName,
                LastName = userAddDto.LastName,
                Email = userAddDto.Email,
                Password = userAddDto.Password,
                Gender = userAddDto.Gender,
                DateOfBirth = userAddDto.DateOfBirth,
                Address = userAddDto.Address,
                //Todo: CreatedUserDate and CreatedUserId will edit
                CreatedUserId = 1,
                CreatedUserDate = DateTime.Now,
            };
            var userAdd = await userDal.AddAsync(user);
            UserDto userDto = new UserDto()
            {
                Id = userAdd.Id,
                UserName = userAdd.UserName,
                FirstName = userAdd.FirstName,
                LastName = userAdd.LastName,
                Email = userAdd.Email,
                Gender = userAdd.Gender,
                DateOfBirth = userAdd.DateOfBirth,
                Address = userAdd.Address,
            };

            return userDto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var getUser = await userDal.GetAsync(x => x.Id == id);
            return await userDal.DeleteAsync(id);
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await userDal.GetAsync(x => x.Id == id);
            if(user != null)
            {
                UserDto userDto = new UserDto()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Gender = user.Gender,
                    DateOfBirth = user.DateOfBirth,
                    Address = user.Address
                };
                return userDto;
            }
            return null;

        }

        public async Task<IEnumerable<UserDetailDto>> GetListAsync()
        {
            List<UserDetailDto> userDetailDtos = new List<UserDetailDto>();
            var response = await userDal.GetListAsync();
            foreach (var item in response.ToList())
            {
                 userDetailDtos.Add(  new UserDetailDto()
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Password = item.Password,
                    Gender = item.Gender == true ? "Female" : "Male",
                    DateOfBirth = item.DateOfBirth,
                    Address = item.Address,
                    Role = item.Role,                
                });
            }
            return userDetailDtos;
        }

        public async Task<UserUpdatedDto> UpdateAsync(UserUpdatedDto userUpdatedDto)
        {
            var getUser = await userDal.GetAsync(x => x.Id == userUpdatedDto.Id);
            User user = new User()
            {
                Id = userUpdatedDto.Id,
                UserName = userUpdatedDto.UserName,
                FirstName = userUpdatedDto.FirstName,
                LastName = userUpdatedDto.LastName,
                Email = userUpdatedDto.Email,
                Password = userUpdatedDto.Password,
                Gender = userUpdatedDto.Gender,
                DateOfBirth = userUpdatedDto.DateOfBirth,
                Address = userUpdatedDto.Address,
                CreatedUserDate = getUser.CreatedUserDate,
                CreatedUserId = getUser.CreatedUserId,
                UpdatedUserDate = DateTime.Now,
                UpdatedUserId = 1
            }; 
            
            var userUpdate = await userDal.UpdateAsync(user);
            UserUpdatedDto userUpdatedDto1 = new UserUpdatedDto()
            {
                Id = userUpdate.Id,
                UserName = userUpdate.UserName,
                FirstName = userUpdate.FirstName,
                LastName = userUpdate.LastName,
                Email = userUpdate.Email,
                Password = userUpdate.Password,
                Gender = userUpdate.Gender,
                DateOfBirth = userUpdate.DateOfBirth,
                Address = userUpdate.Address       
            };

            return userUpdatedDto1;
        }
    }
}
