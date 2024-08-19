using CoreProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
            MyDbContext _db;
            public ProductsController(MyDbContext db)
            {
                _db = db;
            }
            [HttpGet]
            public IActionResult Get()
            {
                var products = _db.Products.Include(p=> p.Category).ToList();
                return Ok(products);
            }
        [HttpGet("{ById}")]
        public IActionResult Get(int id)
            {
            var products = _db.Products.Include(p => p.Category).FirstOrDefault(p => p.CategoryId==id);
              return Ok(products);
            }
        }
}
