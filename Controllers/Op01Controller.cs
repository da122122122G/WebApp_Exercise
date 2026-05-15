using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Exercise.Controllers;

[Route("Option01")]
public class Op01Controller : Controller
{
    [HttpGet("Calc")]
    public IActionResult Calc([FromQuery] int value1, [FromQuery] int value2, [FromQuery] int opt)
    {

        if (opt == 1)
        {
            var result = value1 + value2;
            return Content($"{value1} + {value2} = {result}");
        }

        else if (opt == 2)
        {
            var result = value1 - value2;
            return Content($"{value1} - {value2} = {result}");
        }
        else if (opt == 3)
        {
            var result = value1 * value2;
            return Content($"{value1} * {value2} = {result}");
        }
        else if (opt == 4)
        {
            var result = value1 / value2;
            return Content($"{value1} / {value2} = {result}");
        }
        else if (opt == 5)
        {
            var result = value1 % value2;
            return Content($"{value1} % {value2} = {result}");
        }
        return Content("不明な計算種別です。");
    }
}
