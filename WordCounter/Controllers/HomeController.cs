using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }
  }
}
