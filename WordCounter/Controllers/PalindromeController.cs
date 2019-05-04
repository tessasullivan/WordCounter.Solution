using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Palindromes;

namespace Palindromes.Controllers
{
  public class PalindromesController : Controller
  {
    [HttpGet("/Palindromes")]
    public ActionResult Index() { return View(); }

    [HttpPost("/Palindromes/new")]
    public ActionResult New() { return View(); }

    // [HttpPost("/Palindromes/show")]
    // public ActionResult Create(int total, string word, string sentence)
    // {
    //     Palindromes Palindromes = new Palindromes(total, word, sentence);
    //     Palindromes.CountWordOccurrences();

    //     return View("Show", Palindromes);
    // }
  }
}
