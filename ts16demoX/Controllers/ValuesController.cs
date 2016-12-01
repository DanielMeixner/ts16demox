using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace ts16demoX.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly IHostingEnvironment hostingEnvironment;

        public ValuesController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

            
            //string webRootPath = hostingEnvironment.WebRootPath;
            //var lines = System.IO.File.ReadAllLines(webRootPath + @"/quotes.txt");
            //return lines;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";

            //string webRootPath = hostingEnvironment.WebRootPath;
            //var lines = System.IO.File.ReadAllLines(webRootPath + @"/quotes.txt");
            //return new Quote() { Author = "unknown", QuoteText = lines[id] };

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
