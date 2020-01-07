using System;
using Microsoft.AspNetCore.Mvc;

namespace Sprocket.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly string template = "Math, {0}!";

        // api/Math/product
        [HttpGet]
        [ActionName("product")]
        public ActionResult<string> multiply(string number_one = "1", string number_two = "1")
        {
            var math = new Math(int.Parse(number_one), int.Parse(number_two));
            return Ok(String.Format(template, math.Product().ToString()));
        }
    }
}
