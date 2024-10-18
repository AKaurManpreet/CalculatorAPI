using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Endpoint to add two decimal numbers
        [HttpGet("sum")]
        public IActionResult AddNumbers([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            var result = number1 + number2;
            return Ok(result);
        }

        // Endpoint to subtract the second decimal from the first
        [HttpGet("difference")]
        public IActionResult SubtractNumbers([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            var result = number1 - number2;
            return Ok(result);
        }

        // Endpoint to multiply two decimal numbers
        [HttpGet("product")]
        public IActionResult MultiplyNumbers([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            var result = number1 * number2;
            return Ok(result);
        }

        // Endpoint to divide the first decimal by the second
        [HttpGet("quotient")]
        public IActionResult DivideNumbers([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            if (number2 == 0) return BadRequest("Division by zero is not allowed.");
            var result = number1 / number2;
            return Ok(result);
        }

        // Endpoint to calculate the remainder of the division
        [HttpGet("remainder")]
        public IActionResult ModuloNumbers([FromQuery] decimal number1, [FromQuery] decimal number2)
        {
            if (number2 == 0) return BadRequest("Division by zero is not allowed.");
            var result = number1 % number2;
            return Ok(result);
        }
    }
}
