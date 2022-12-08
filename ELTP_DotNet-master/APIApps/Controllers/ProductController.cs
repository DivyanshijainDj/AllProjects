using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIApps.models;
using APIApps.Services;

namespace APIApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IDbAccessService<Product, int> productService;
        public ProductController(IDbAccessService<Product, int> productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await productService.GetAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> PostData()
        {
            await productService.CreateAsync(new Product
            {
               // ProductUniqueId=7,
                ProductId="Prod-007",
                ProductName="sports",
                Description="badminton racket",
                Price=1200,
                CategoryId=1002,
                Manufacturer="yonex"
                
            });
            return Ok();
        }

        //[HttpPut]
        //public async Task<IActionResult> PutData()
        //{
        //    await productService.UpdateAsync(8, new Product {
        //        ProductUniqueId = 8,
        //        ProductId = "Prod-007",
        //        ProductName = "sports_Specific",
        //        Description = "badminton racket",
        //        Price = 1200,
        //        CategoryId = 1002,
        //        Manufacturer = "yonex"

        //    });
        //    return Ok();
        //}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Product pro)
        {
            var result = await productService.UpdateAsync(id, pro);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRecord()
        {
            await productService.DeleteAsync(6);
            return Ok();
        }

    }
}

