using backend.Business.Interface;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController: ControllerBase
    {
        private readonly ICategoryBusiness business;
        public CategoryController(ICategoryBusiness business)
        {
            this.business = business;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var result = await this.business.GetAllCategories();
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
    }
}
