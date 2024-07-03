using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathsController : ControllerBase
    {
        [HttpGet]
        [Route("multiply-numbers")]
        public int MultiplyNumbers(int numberOne, int numberTwo)
        {
            var numbers = numberOne * numberTwo;
            return numbers;
        }

        [HttpGet]
        [Route("add-numbers")]
        public int AddNumbers(int numberOne, int numberTwo)
        {
            var numbers = numberOne + numberTwo;
            return numbers;
        }

    }
}
