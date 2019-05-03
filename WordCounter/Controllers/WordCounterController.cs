using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult Index() { return View(); }

    [HttpPost("/wordcounter/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/WordCounter/show")]
    public ActionResult Create(string word, string sentence)
    {
        WordCounter wordCounter = new WordCounter(word, sentence);

        return View("Show", wordCounter);
    }
  }
}
