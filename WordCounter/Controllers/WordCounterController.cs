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
    public ActionResult Create(int total, string word, string sentence)
    {
        WordCounter wordCounter = new WordCounter(total, word, sentence);
        wordCounter.CountWordOccurrences();

        return View("Show", wordCounter);
    }
  }
}
