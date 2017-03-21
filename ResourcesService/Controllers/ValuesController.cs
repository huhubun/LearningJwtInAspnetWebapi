using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;
using System.Xml.Serialization;

namespace ResourcesService.Controllers
{
    public class Sample
    {
        public string Code { get; set; }

        public string Name { get; set; }

        [XmlArrayItem("Item")]
        public List<string> Items { get; set; }
    }

    [ApiVersion("1.0")]
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            var sample = new Sample
            {
                Code = "sample_code",
                Name = "sample name",
                Items = new List<string> { "a", "b", "c", "d" }
            };

            return Ok(sample);
        }

        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
