using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get(int input)
        {
            string result = string.Empty;

            if (input % 7 == 0)
            {
                result = "C";
            }
            if (input % 9 == 0)
            {
                result = result + "N";
            }

            return new JsonResult(string.IsNullOrEmpty(result) ? input.ToString() : result);
        }
    }
}
