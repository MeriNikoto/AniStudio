using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AniStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DBStudioContext _context;
        public ValuesController(DBStudioContext context)
        {
            _context = context;
        }

        [HttpGet("JsonData")]
        public JsonResult JsonData()
        {
            var genres = _context.Genres.Include(c => c.Projects).ToList();

            List<object> list = new List<object>();
            list.Add(new[] { "Genre", "Project count" });
            foreach (var c in genres)
            {
                list.Add(new object[] { c.Name, c.Projects.Count() });
            }

            return new JsonResult(list);
        }


        [HttpGet("JsonData1")]
        public JsonResult JsonData1()
        {
            var teams = _context.Teams.Include(c => c.Employees).ToList();

            List<object> list = new List<object>();
            list.Add(new[] { "Teams", "Employees countt" });
            foreach (var c in teams)
            {
                list.Add(new object[] { c.Task, c.Employees.Count() });
            }

            return new JsonResult(list);
        }
    }
}



