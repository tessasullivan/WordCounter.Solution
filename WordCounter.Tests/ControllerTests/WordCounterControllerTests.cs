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
            ActionResult indexView = controller.New ();
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
        [TestMethod]
        public void Create_ReturnsCorrectView_True()
        {
            int total=0;
            string word = "foo";
            string sentence = "bar";
            WordCounterController controller = new WordCounterController ();
            ActionResult indexView = controller.Create (total, word, sentence);
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
        [TestMethod]
        public void Create_HasCorrectModelType_WordCounter()
        {
            int total=0;
            string word = "foo";
            string sentence = "bar";
            WordCounterController controller = new WordCounterController ();
            ViewResult createView = controller.Create(total, word, sentence) as ViewResult;
            var result = createView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(WordCounter));
        }      
    }
}