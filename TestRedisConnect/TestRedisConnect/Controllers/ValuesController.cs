using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestRedisConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("redis")]
        public ActionResult<string> TestRedisConnectionApi()
        {
            try
            {
                var conn = StackExchange.Redis.ConnectionMultiplexer.Connect("10.31.202.17:6379");
                var db = conn.GetDatabase();
                return "redis connection success ";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"redis connection fail error:{ex.Message}");
                return "redis connection fail";
            }

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
