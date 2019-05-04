using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Palindromes;

namespace Palindromes.Controllers
{
  public class PalindromeController : Controller
  {
    [HttpGet("/Palindrome")]
    public ActionResult Index() { return View(); }

    [HttpPost("/Palindrome/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/Palindrome/show")]
    public ActionResult Create(string phrase, bool isPalindrome)
    {
        Palindrome testPalindrome = new Palindrome(phrase, isPalindrome);
        testPalindrome.IsPalindromeTest();
        return View("Show", testPalindrome);
    }
  }
}
