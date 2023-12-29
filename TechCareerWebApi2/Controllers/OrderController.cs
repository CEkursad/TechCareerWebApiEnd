using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerWebApi2.Context;

namespace TechCareerWebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        TechCareerDbContext1 _context;

        public OrderController()
        {
            _context = new TechCareerDbContext1();
        }


        [HttpGet]
        public IActionResult Get()
        {
            
            var orders = _context.Orders.Include(x => x.Users).ToList();
            return Ok(orders);
        }
    }
}
