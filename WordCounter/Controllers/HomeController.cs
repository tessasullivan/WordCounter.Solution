using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }
  }
}
