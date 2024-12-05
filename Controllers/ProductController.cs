namespace backend.Controllers
{
    using backend.Abstraction.Models;
    using backend.Business.Interface;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("")]
    public class ProductController: ControllerBase
    {
        private readonly IProductBusiness business;
        public ProductController(IProductBusiness business) 
        {
            this.business = business;
        }

        [HttpGet]
        [Route("get-products")]
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
                return this.StatusCode(500, "Internal server error!");
            }
        }
    }
}
