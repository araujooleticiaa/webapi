using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiprojeto.Controller
{
    [Route("Categories")]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "rota get";
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetToId(int id)
        {
            return "Get " + id.ToString();
        }

        [HttpPost]
        [Route("")]
        public string Post()
        {
            return "rota post";
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return "rota put";
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "rota delete";
        }

    }
}
