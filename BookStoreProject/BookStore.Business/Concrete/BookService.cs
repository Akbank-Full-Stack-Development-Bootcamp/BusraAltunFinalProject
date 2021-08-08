using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;
using Ecommerce.Entities.DataTransferObjects.BookDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Concrete
{
    public class BookService : IBookService
    {
        private readonly IBookDal bookDal;

        public BookService(IBookDal bookDal)
        {
            this.bookDal = bookDal;
        }
        public async Task<BookDto> AddAsync(BookAddDto bookAddDto)
        {


            Book book = new Book()
            {
                Id = bookAddDto.Id,
                BookName = bookAddDto.BookName,
                BarcodeNumber= bookAddDto.BarcodeNumber,
                Cover = bookAddDto.Cover,
                GenreId = bookAddDto.GenreId,
                PaperNumber = bookAddDto.PaperNumber,
                PaperType = bookAddDto.PaperType,
                Poster = bookAddDto.Poster,
                Publisher = bookAddDto.Publisher,
                Price = bookAddDto.Price,
                Size = bookAddDto.Size,
                İssueDate = bookAddDto.İssueDate,      
                
                //Todo: CreatedAuthorDate and CreatedAuthorId will edit
                CreatedBookId = 1,
                CreatedBookDate = DateTime.Now


            };
            var bookAdd = await bookDal.AddAsync(book);
            BookDto bookDto = new BookDto()
            {
                Id = bookAdd.Id,
                BookName = bookAdd.BookName,
                BarcodeNumber = bookAdd.BarcodeNumber,
                Cover = bookAdd.Cover,
                GenreId = bookAdd.GenreId,
                PaperNumber = bookAdd.PaperNumber,
                Poster = bookAdd.Poster,
                Publisher = bookAdd.Publisher,
                Price = bookAdd.Price,
                İssueDate = bookAdd.İssueDate,
                AuthorId = 1
            };

            return bookDto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var getBook = await bookDal.GetAsync(x => x.Id == id);
            return await bookDal.DeleteAsync(id);
        }

        public async Task<BookDto> GetByIdAsync(int id)
        {
            var book = await bookDal.GetAsync(x => x.Id == id);
            BookDto bookDto = new BookDto()
            {
                Id = book.Id,
                BookName = book.BookName,
                BarcodeNumber = book.BarcodeNumber,
                Cover = book.Cover,
                GenreId = book.GenreId,
                PaperNumber = book.PaperNumber,
                Poster = book.Poster,
                Publisher = book.Publisher,
                Price = book.Price,
                İssueDate = book.İssueDate,
                AuthorId = 1
            };

            return bookDto;
        }

        public async Task<IEnumerable<BookDetailDto>> GetListAsync()
        {


            List<BookDetailDto> bookDetailDtos = new List<BookDetailDto>();
            var response = await bookDal.GetListAsync();
            foreach (var item in response.ToList())
            {
                bookDetailDtos.Add(new BookDetailDto()
                {
                    AuthorId = 1,
                    BookName = item.BookName,
                    BarcodeNumber = item.BarcodeNumber,
                    Cover = item.Cover == true ? "HardCover" : "PaperBack",
                    GenreId = item.GenreId,
                    PaperNumber = item.PaperNumber,
                    PaperType = item.PaperType,
                    Poster = item.Poster,
                    Publisher = item.Publisher,
                    Price = item.Price,
                    Size = item.Size,
                    İssueDate = item.İssueDate
                    
                });
            }
            return bookDetailDtos;
        }

        public async Task<BookUpdatedDto> UpdateAsync(BookUpdatedDto bookUpdatedDto)
        {

            var getBook = await bookDal.GetAsync(x => x.Id == bookUpdatedDto.Id);
            Book book = new Book()
            {
                    Id = bookUpdatedDto.Id,
                    BookName = bookUpdatedDto.BookName,
                    BarcodeNumber = bookUpdatedDto.BarcodeNumber,
                    Cover = bookUpdatedDto.Cover,
                    GenreId = bookUpdatedDto.GenreId,
                    PaperNumber = bookUpdatedDto.PaperNumber,
                    PaperType = bookUpdatedDto.PaperType,
                    Poster = bookUpdatedDto.Poster,
                    Publisher = bookUpdatedDto.Publisher,
                    Price = bookUpdatedDto.Price,
                    Size = bookUpdatedDto.Size,
                    İssueDate = bookUpdatedDto.İssueDate,
                    CreatedBookDate = getBook.CreatedBookDate,
                    CreatedBookId = getBook.CreatedBookId,
                    UpdatedBookDate = DateTime.Now,
                    UpdatedBookId = 1
                    
            };

            var bookUpdate = await bookDal.UpdateAsync(book);
            BookUpdatedDto bookUpdatedDto1 = new BookUpdatedDto()
            {

                Id = bookUpdate.Id,
                BookName = bookUpdate.BookName,
                BarcodeNumber = bookUpdate.BarcodeNumber,
                Cover = bookUpdate.Cover,
                GenreId = bookUpdate.GenreId,
                PaperNumber = bookUpdate.PaperNumber,
                PaperType = bookUpdate.PaperType,
                Poster = bookUpdate.Poster,
                Publisher = bookUpdate.Publisher,
                Price = bookUpdate.Price,
                Size = bookUpdate.Size,
                İssueDate = bookUpdate.İssueDate,
                AuthorId =1
            };

            return bookUpdatedDto1;
        }
    }
}
