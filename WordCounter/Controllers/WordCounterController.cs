using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class WordCounter : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index() { return View(); }
  }
}
