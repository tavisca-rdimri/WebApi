using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/greet")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        static List<string> strings=new List<string>()
        {
            "Value1","Value2"
        };
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //[HttpGet]
        //public <string> public Get()
        //{

        //}
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            if(id=="Hi"||id=="hi"||id=="HI")
            return "Hello";
            if (id == "hello"||id=="Hello")
                return "Hi";
            return ":(";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
