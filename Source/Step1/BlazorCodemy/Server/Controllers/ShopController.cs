using BlazorCodemy.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCodemy.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        

        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<ShopElement> Get()
        {
            List<ShopElement> list = new List<ShopElement>();
            list.Add(new ShopElement() { Name = "Iron man", Description = "desc 1", ImageUrl = "", Price = 150 });
            list.Add(new ShopElement() { Name = "Thor", Description = "desc 1", ImageUrl = "", Price = 200 });
            list.Add(new ShopElement() { Name = "Doctor strange", Description = "desc 1", ImageUrl = "", Price =50 });
            return list;
            
        }
    }
}