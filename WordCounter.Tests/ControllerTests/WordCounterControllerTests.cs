using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests 
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True () 
        {
            WordCounterController controller = new WordCounterController ();
            ActionResult indexView = controller.Index ();
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
        [TestMethod]
        public void New_ReturnsCorrectView_True () 
        {
            WordCounterController controller = new WordCounterController ();
            ActionResult indexView = controller.Index ();
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
    }
}