using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DataTransferObjects.AuthorDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Concrete
{
    public class AuthorService : IAuthorService
    {

        private readonly IAuthorDal authorDal;

        public AuthorService(IAuthorDal authorDal)
        {
            this.authorDal = authorDal;
        }
        public async Task<AuthorDto> AddAsync(AuthorAddDto authorAddDto)
        {

            Author author = new Author()
            {
               Id = authorAddDto.Id,
               Name = authorAddDto.Name,
               Surname = authorAddDto.Surname,
               Bio = authorAddDto.Bio,
               Poster = authorAddDto.Poster,
                //Todo: CreatedAuthorDate and CreatedAuthorId will edit
                CreatedAuthorId = 1,
               CreatedAuthorDate = DateTime.Now
               

            };
            var authorAdd = await authorDal.AddAsync(author);
            AuthorDto authorDto = new AuthorDto()
            {
                Id = authorAdd.Id,
                Name = authorAdd.Name,
                Surname = authorAdd.Surname,
            };

            return authorDto;
        }

        public async  Task<bool> DeleteAsync(int id)
        {
            var getAuthor = await authorDal.GetAsync(x => x.Id == id);
            return await authorDal.DeleteAsync(id);
        }

        public async Task<AuthorDto> GetByIdAsync(int id)
        {
            var author = await authorDal.GetAsync(x => x.Id == id);
            AuthorDto authorDto = new AuthorDto()
            {
                Id = author.Id,
                Name = author.Name,
                Surname = author.Surname
            };

            return authorDto;
        }

        public async Task<IEnumerable<AuthorDetailDto>> GetListAsync()
        {

            List<AuthorDetailDto> authorDetailDtos = new List<AuthorDetailDto>();
            var response = await authorDal.GetListAsync();
            foreach (var item in response.ToList())
            {
                authorDetailDtos.Add(new AuthorDetailDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    Bio = item.Bio,
                    Poster = item.Poster
                });
            }
            return authorDetailDtos;
        }

        public async Task<AuthorUpdatedDto> UpdateAsync(AuthorUpdatedDto authorUpdatedDto)
        {

            var getAuthor = await authorDal.GetAsync(x => x.Id == authorUpdatedDto.Id);
            Author author = new Author()
            {
                Id = authorUpdatedDto.Id,
                Name = authorUpdatedDto.Name,
                Surname = authorUpdatedDto.Surname,
                Bio = authorUpdatedDto.Bio,
                Poster = authorUpdatedDto.Poster,
                CreatedAuthorDate = getAuthor.CreatedAuthorDate,
                CreatedAuthorId = getAuthor.CreatedAuthorId,
                UpdatedAuthorDate = DateTime.Now,
                UpdatedAuthorId = 1,          
                
            };

            var authorUpdate = await authorDal.UpdateAsync(author);
            AuthorUpdatedDto authorUpdatedDto1 = new AuthorUpdatedDto()
            {
                Id = authorUpdate.Id,
                Name = authorUpdate.Name,
                Surname = authorUpdate.Surname,
                Bio = authorUpdate.Bio,
                Poster = authorUpdate.Poster

            };

            return authorUpdatedDto1;
        }
    }
}
