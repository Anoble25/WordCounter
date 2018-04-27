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
      return View("CreateForm");
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
      return View("Index", newInputInfo);
    }
  }
}
