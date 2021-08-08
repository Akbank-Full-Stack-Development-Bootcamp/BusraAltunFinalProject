using Ecommerce.Business.Abstract;
using Ecommerce.Entities.DataTransferObjects.BookDataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
       private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await bookService.GetListAsync();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await bookService.GetByIdAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] BookAddDto bookAddDto)
        {
            var result = await bookService.AddAsync(bookAddDto);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] BookUpdatedDto bookUpdatedDto)
        {
            var result = await bookService.UpdateAsync(bookUpdatedDto);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await bookService.DeleteAsync(id);
            if (result)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest(false);
            }
        }

    }
}
