using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LambdaApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
