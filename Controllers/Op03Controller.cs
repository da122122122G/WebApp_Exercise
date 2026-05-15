using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Exercise.Models;

[Route("Option03")]
public class Op03Controller : Controller
{
    [HttpPost("Calc")]
    public IActionResult Calc(Op03Form form)
    {
        if (form.opt == 1)
        {
            var result = form.value1 + form.value2;
            return Content($"{form.value1} + {form.value2} = {result}");
        }
        else if (form.opt == 2)
        {
            var result = form.value1 - form.value2;
            return Content($"{form.value1} - {form.value2} = {result}");
        }
        else if (form.opt == 3)
        {
            var result = form.value1 * form.value2;
            return Content($"{form.value1} * {form.value2} = {result}");
        }
        else if (form.opt == 4)
        {
            var result = form.value1 / form.value2;
            return Content($"{form.value1} / {form.value2} = {result}");
        }
        else if (form.opt == 5)
        {
            var result = form.value1 % form.value2;
            return Content($"{form.value1} % {form.value2} = {result}");
        }
        return Content("不明な計算種別です。");
    }
}
