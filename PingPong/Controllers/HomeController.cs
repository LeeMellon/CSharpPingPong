using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPongs.Models;
using System;

namespace PingPongs.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<string> output = new List<string>{};
        return View("Index", output);
      }

      [HttpPost("/setRange")]
      public ActionResult RangeSetter()
      {
        int UserRange = Convert.ToInt32(Request.Form["userNumber"]);
        PingPong newPong = new PingPong();
        newPong.SetRange(UserRange);
        List<string> output = newPong.IsDiv(newPong.GetRange());
        return View("Index", output);

      }
    }
}
