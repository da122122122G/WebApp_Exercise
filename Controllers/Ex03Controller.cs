using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Exercise.Controllers;
/// <summary>
/// 演習-03 ルーティング属性を利用するコントローラを実装する
/// </summary>
[Route("Exercise03")]
public class Ex03Controller : Controller
{
    [HttpGet("Morning")]
    public IActionResult Goodmorning()
    {
        return Content("おはようございます。");
    }

    [HttpGet("Evening")]
    public IActionResult Goodevening()
    {
        return Content("こんばんは。");
    }

    [HttpGet("Lunch")]
    public IActionResult Hello()
    {
        return Content("こんにちは。");
    }

    [HttpGet("night")]
    public IActionResult GoodNight()
    {
        return Content("おやすみ");
    }
}