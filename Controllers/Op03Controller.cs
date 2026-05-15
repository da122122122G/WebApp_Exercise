using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Exercise.Models;

namespace WebApp_Exercise.Controllers;

[Route("Option03")]
public class Op03Controller : Controller
{
    [HttpPost("Calc")]
    public IActionResult Calc(Op03Form form)
    {
        switch (form.opt)
        {
            case 1:
                var result = form.value1 + form.value2;
                return Content($"{form.value1} + {form.value2} = {result}");
            case 2:
                result = form.value1 - form.value2;
                return Content($"{form.value1} - {form.value2} = {result}");

            case 3:
                result = form.value1 * form.value2;
                return Content($"{form.value1} * {form.value2} = {result}");

            case 4:
                result = form.value1 / form.value2;
                return Content($"{form.value1} / {form.value2} = {result}");

            case 5:
                result = form.value1 % form.value2;
                return Content($"{form.value1} % {form.value2} = {result}");

            default:
                return Content("不明な計算種別です。");
        }
    }
}
