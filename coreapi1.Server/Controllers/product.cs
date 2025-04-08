using coreapi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreapi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class product : ControllerBase
    {
        private readonly MyDbContext _a;

        public product(MyDbContext a)
        {
            _a = a;
        }


        [HttpGet]
        public IActionResult productall()
        {
            var productt = _a.Products.ToList();
            return Ok(productt);//200
        }

        [HttpGet("product by id")]
        public IActionResult productbyid(int id)
        {

            var proid = _a.Products.FirstOrDefault(x => x.ProductId == id);
            if (proid != null)
            {
                return Ok(proid);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("product by name")]

        public IActionResult productbyname(string name)
        {
            var proname = _a.Products.FirstOrDefault(x => x.ProductName == name);
            if (proname != null)
            {
                return Ok(proname);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("productfirstone")]

        public IActionResult productfirstone()
        {
            var firstproduct = _a.Products.First();
            return Ok(firstproduct);
        }


    }
}
