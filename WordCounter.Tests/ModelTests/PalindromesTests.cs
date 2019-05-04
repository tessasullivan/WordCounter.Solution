using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void IsPalindromeTest_SingleChar_True()
    {
    // any necessary logic to prep for test; instantiating new classes, etc
        string phrase="A";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(true, testPalindrome.IsPalindromeTest());
    }

    [TestMethod]
    public void IsPalindromeTest_WordIsPalindromeTestEvenNumberOfChars_True()
    {
        string phrase="noon";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(true, testPalindrome.IsPalindromeTest());
    }
    [TestMethod]
    public void IsPalindromeTest_WordIsPalindromeTestOddNumberOfChars_True()
    {
        string phrase = "madam";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(true, testPalindrome.IsPalindromeTest());
    }
    [TestMethod]
    public void IsPalindromeTest_NumberIsPalindromeTest_True()
    {
        string phrase = "4554";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(true, testPalindrome.IsPalindromeTest());
    }
    [TestMethod]
    public void IsPalindromeTest_WordIsPalindromeTest_False()
    {
        string phrase = "jump";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(false, testPalindrome.IsPalindromeTest());
    }
  }
}