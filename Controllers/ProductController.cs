namespace backend.Controllers
{
    using backend.Abstraction.Models;
    using backend.Business.Interface;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("products")]
    public class ProductController: ControllerBase
    {
        private readonly IProductBusiness business;
        public ProductController(IProductBusiness business) 
        {
            this.business = business;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var result = await this.business.GetProducts();
                if (result == null || !result.Any())
                {
                    return this.StatusCode(StatusCodes.Status404NotFound);
                }
                return this.StatusCode(200, result);
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> SetProduct([FromBody] Product product)
        {
            try
            {
                var result = await this.business.AddProduct(product);
                if (!result)
                {
                    return this.StatusCode(StatusCodes.Status404NotFound);
                }
                return this.StatusCode(200, new
                {
                    message = "Product saved Successfully!"
                });
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            try
            {
                var result = await this.business.DeleteProduct(id);
                if (!result)
                {
                    return this.StatusCode(StatusCodes.Status404NotFound);
                }
                return this.StatusCode(200, new
                {
                    message = "Product deleted Successfully!"
                });
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            try
            {
                var result = await this.business.UpdateProduct(product);
                if (!result)
                {
                    return this.StatusCode(StatusCodes.Status404NotFound);
                }
                return this.StatusCode(200, new
                {
                    message = "Product deleted Successfully!"
                });
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
