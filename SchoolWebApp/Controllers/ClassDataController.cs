using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolWebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ClassDataController : Controller
    {
        private SchoolDbContext ctx = new SchoolDbContext();
        // GET: api/values
        public IActionResult Get()
        {
            var classess = ctx.Classes.AsEnumerable();
            return Ok(classess);
        }

    }
}
