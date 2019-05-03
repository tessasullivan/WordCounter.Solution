using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class WordCounter : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult Index() { return View(); }

    [HttpPost("/WordCounter/new")]
    public ActionResult New() { return View(); }

    // [HttpPost("/wordcounter")]
    // public ActionResult Create()
    // {
    //     return View();
    // }
  }
}
