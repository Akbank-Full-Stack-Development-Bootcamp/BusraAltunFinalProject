using Ecommerce.Business.Abstract;
using Ecommerce.Entities.DataTransferObjects.AuthorDataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await authorService.GetListAsync();
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
            var result = await authorService.GetByIdAsync(id);
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
        public async Task<IActionResult> Add([FromBody] AuthorAddDto authorAddDto)
        {
            var result = await authorService.AddAsync(authorAddDto);
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
        public async Task<IActionResult> Update([FromBody] AuthorUpdatedDto authorUpdatedDto)
        {
            var result = await authorService.UpdateAsync(authorUpdatedDto);
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
            var result = await authorService.DeleteAsync(id);
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
