using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using ServiceCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet("[action]")]
        public object Info()
        {
            return Helpers.GetInfo("localhost");
            //return Assembly.GetEntryAssembly()
            //    .GetTypes()
            //    .Where(x => x.IsClass &&  x.Namespace.Contains("Controllers")).ToList();
        }
    }
}
