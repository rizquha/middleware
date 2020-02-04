using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Middleware.Models;

namespace Middleware.Controllers
{
    [Route("/todo")]
    public class TodoControllers : ControllerBase
    {
        public AppDBContext AppDBContext {get;set;}
        public TodoControllers(AppDBContext appDBContext)
        {
            AppDBContext = appDBContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = AppDBContext.Users.Include(u=>u.Posts).ToList();
            return Ok(list);
        }
    }
}