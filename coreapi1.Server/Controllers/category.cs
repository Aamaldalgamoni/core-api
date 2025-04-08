using coreapi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreapi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class category : ControllerBase
    {
        private readonly MyDbContext _a;

        public category(MyDbContext a)
        {
            _a = a;
        }


        [HttpGet]
        public IActionResult getcategory()
        {
            var categ = _a.Categories.ToList();
            return Ok(categ);//200
        }

        [HttpGet("getcategory by id")]
        public IActionResult getcategorybyid(int id)
        {
         
           var catid = _a.Categories.FirstOrDefault(x => x.CategoryId == id);
       if(catid!=null)
            {
                return Ok(catid);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getcategory by name")]

        public IActionResult getcategorybyname(string name)
        {
            var catname = _a.Categories.FirstOrDefault(x => x.CategoryName == name);
            if(catname!=null)
            {
                return Ok(catname);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getcategoryfirstone")]

        public IActionResult getcategoryfirstone()
        {
            var firstcateg = _a.Categories.First();
            return Ok(firstcateg);
        }




    }
}
