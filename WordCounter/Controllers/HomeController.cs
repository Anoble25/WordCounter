using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create()
    {
      RepeatCounter newInputInfo= new RepeatCounter (Request.Form["sentence"], Request.Form["chosenWord"]);
      int output=RepeatCounter.PerformWordCount(newInputInfo);
      Console.WriteLine(output);
      return View("Index", output);
    }

  }
}
