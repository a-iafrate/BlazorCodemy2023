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
            list.Add(new ShopElement() { Name = "Iron man", Description = "desc 1", ImageUrl = "https://i.ebayimg.com/images/g/UTUAAOSwor5kS1YY/s-l500.jpg", Price = 150 });
            list.Add(new ShopElement() { Name = "Thor", Description = "desc 1", ImageUrl = "https://funkoeurope.com/cdn/shop/products/63732a_Marvel_Thor_POPDiecast_GLAM-WEB_600x.png", Price = 200 });
            list.Add(new ShopElement() { Name = "Doctor strange", Description = "desc 1", ImageUrl = "https://i.ebayimg.com/images/g/XRIAAOSw~I1iVp1R/s-l500.jpg", Price =50 });
            return list;
            
        }
    }
}