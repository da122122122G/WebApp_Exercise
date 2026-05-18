using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_Exercise.Models;
using WebApp_Exercise.Controllers;

namespace WebApp_Exercise.Controllers;

[Route("Option04")]
public class Option04Controller : Controller
{
    [HttpGet("Enter")]
    public ActionResult Enter()
    {
        var form = new Op03Form();
        return View(form);
    }

    [HttpPost("Result")]
    public IActionResult Result(Op03Form form)
    {
        if (!ModelState.IsValid)
        {
            return View("Enter", form);
        }
        switch (form.SelectedOpt)
        {
            case 1:
                form.Answer = form.value1 + form.value2;
                break;
            case 2:
                form.Answer = form.value1 - form.value2;
                break;
            case 3:
                form.Answer = form.value1 * form.value2;
                break;
            case 4:
                form.Answer = form.value1 / form.value2;
                break;
            case 5:
                form.Answer = form.value1 % form.value2;
                break;
            default:
                ModelState.AddModelError("Opt", "不明な計算種別です。");
                break;
        }
        return View(form);
    }

    [HttpGet("Back")]
    public IActionResult Back()
    {
        return RedirectToAction("Enter");
    }
}