using Microsoft.AspNetCore.Mvc;
using System;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        // Operation Sum
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // Operation Subtraction 
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // Operation Multiplication
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
            }

            return BadRequest("Invalid Input");
        }

        // Operation Division
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                if (IsZero(ConvertToDecimal(firstNumber)) || IsZero(ConvertToDecimal(secondNumber)))
                {
                    return BadRequest("Can't divide by Zero");
                }

                var div =ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(div.ToString("F2"));
            }

            return BadRequest("Invalid Input");
        }

        // Operation Avarege
        [HttpGet("ava/{firstNumber}/{secondNumber}")]
        public IActionResult Ava(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var ava = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) /2;
                return Ok(ava.ToString());
            }

            return BadRequest("Invalid Input");
        }

        //Operation Square Root
        [HttpGet("sq/{number}")]
        public IActionResult Sq(string number)
        {
            if (IsNumeric(number))
            {
                if(ConvertToDecimal(number) < 0)
                {
                    return BadRequest("Negative SquareRoot not exist");
                }
                var sq = Math.Sqrt((double)ConvertToDecimal(number));
                return Ok(sq.ToString("F2"));
            }

            return BadRequest("Invalid Input");
        }


        private bool IsZero(decimal number)
        {
            if (number == 0) { return true; }

            return false;
        }

        /// Methods
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;

        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number
                );
            return isNumber;

        }
    }
}
