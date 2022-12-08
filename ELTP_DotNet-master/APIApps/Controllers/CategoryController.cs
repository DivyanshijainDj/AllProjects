using APIApps.models;
using APIApps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IDbAccessService<Category, int> categoryService;
        public CategoryController(IDbAccessService<Category, int> categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await categoryService.GetAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> PostData()
        {
            await categoryService.CreateAsync(new Category
            {
                BasePrice = 1111,
                CategoryId = 11,
                CategoryName = "eleven"
            });
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutData()
        {
            await categoryService.UpdateAsync(39122, new Category { BasePrice = 88888, CategoryId = 39122, CategoryName = "SuperGang" });
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRecord()
        {
            await categoryService.DeleteAsync(101010);
            return Ok();
        }

    }
}
