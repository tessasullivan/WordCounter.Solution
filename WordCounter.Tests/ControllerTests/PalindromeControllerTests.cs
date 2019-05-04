using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Controllers;
using Palindromes;

namespace Palindromes.Tests 
{
    [TestClass]
    public class PalindromeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True () 
        {
            PalindromeController controller = new PalindromeController ();
            ActionResult indexView = controller.Index ();
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
        // [TestMethod]
        // public void New_ReturnsCorrectView_True () 
        // {
        //     PalindromesController controller = new PalindromesController ();
        //     ActionResult indexView = controller.New ();
        //     Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        // }
        [TestMethod]
        public void Create_ReturnsCorrectView_True()
        {
            string phrase = "";
            bool isPalindrome = false;
            PalindromeController controller = new PalindromeController ();
            ActionResult indexView = controller.Create (phrase, isPalindrome);
            Assert.IsInstanceOfType (indexView, typeof (ViewResult));
        }
        // [TestMethod]
        // public void Create_HasCorrectModelType_Palindromes()
        // {
        //     int total=0;
        //     string word = "foo";
        //     string sentence = "bar";
        //     PalindromesController controller = new PalindromesController ();
        //     ViewResult createView = controller.Create(total, word, sentence) as ViewResult;
        //     var result = createView.ViewData.Model;
        //     Assert.IsInstanceOfType(result, typeof(Palindromes));
        // }      
    }
}