using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoCtrlController : ControllerBase
    {
        // GET: api/<demoCtrlController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2"};
        }


        // GET api/<demoCtrlController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //[HttpPost]
        //public string Post([FromBody] Unit unit)
        //{

        //    return unit.UnitCode + " " + unit.UnitName;
        //}


        // POST api/<demoCtrlController>
        [HttpPost]
        public string Post([FromBody] Unit unit)
        {
            
            return "Send Successfully" ;
        }

        //[HttpPost]
        //public string units([FromBody] Unit unit)
        //{

        //    return "Send Successfully";
        //}


        // PUT api/<demoCtrlController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value )
        {
            
        }

        // DELETE api/<demoCtrlController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
