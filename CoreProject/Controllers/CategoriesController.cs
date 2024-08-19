using CoreProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        MyDbContext _db;
        public CategoriesController(MyDbContext db)
        {
            _db = db;
        } 
        [HttpGet]
        public IActionResult Get()
        {
            var all = _db.Categories.ToList();
            return Ok(all);
        }

        [HttpGet("ById")]
        public IActionResult Get(int id)
        {
            var byId = _db.Categories.Find(id);
            return Ok(byId);
        }
    }
}
