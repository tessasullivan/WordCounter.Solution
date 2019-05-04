using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTest : IDisposable
  {
    public void Dispose()
    {
        Palindrome.Clear();
    }
    [TestMethod]
    public void PalindromeConstructor_CreatesInstanceOfPalindrome_Palindrome()
    {
        string phrase = "";
        Palindrome newPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(typeof(Palindrome), newPalindrome.GetType());
    }
    [TestMethod]
    public void GetPhrase_GetPhrase_String()
    {
        string phrase = "this is a phrase";
        Palindrome newPalindrome = new Palindrome(phrase, false);
        Assert.AreEqual(phrase, newPalindrome.GetPhrase());
    }

    [TestMethod]
    public void SetTotal_SetTotal_string()
    {
        string phrase = "this is a phrase";
        Palindrome newPalindrome = new Palindrome(phrase, false);
        string phrase2 = "This is a different phrase";
        newPalindrome.SetPhrase(phrase2);
        Assert.AreEqual(phrase2, newPalindrome.GetPhrase());
    }
    [TestMethod]
    public void GetIsPalindrome_GetIsPalindrome_True()
    {
        string phrase = "this is a phrase";
        bool test = true;
        Palindrome newPalindrome = new Palindrome(phrase, test);
        Assert.AreEqual(true, newPalindrome.GetIsPalindrome());

    }
    [TestMethod]
    public void GetId_GetId_1()
    {
        string phrase = "this is a phrase";
        bool test = true;
        Palindrome newPalindrome = new Palindrome(phrase, test);
        Assert.AreEqual(1, newPalindrome.GetId());
    }
    [TestMethod]
    public void GetIsPalindrome_SingleChar_True()
    {
    // any necessary logic to prep for test; instantiating new classes, etc
        string phrase="A";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        testPalindrome.IsPalindromeTest();
        Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    }

    [TestMethod]
    public void GetIsPalindrome_WordGetIsPalindromeEvenNumberOfChars_True()
    {
        string phrase="noon";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        testPalindrome.IsPalindromeTest();
        Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    }
    [TestMethod]
    public void GetIsPalindrome_WordGetIsPalindromeOddNumberOfChars_True()
    {
        string phrase = "madam";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        testPalindrome.IsPalindromeTest();
        Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    }
    [TestMethod]
    public void GetIsPalindrome_NumberGetIsPalindrome_True()
    {
        string phrase = "4554";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        testPalindrome.IsPalindromeTest();
        Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    }
    [TestMethod]
    public void GetIsPalindrome_WordGetIsPalindrome_False()
    {
        string phrase = "jump";
        Palindrome testPalindrome = new Palindrome(phrase, false);
        testPalindrome.IsPalindromeTest();
        Assert.AreEqual(false, testPalindrome.GetIsPalindrome());
    }
    // [TestMethod]
    // public void GetIsPalindrome_PhraseIsPalindrome_True()
    // {
    //     string phrase = "a but tuba";
    //     Palindrome testPalindrome = new Palindrome(phrase, false);
    //     testPalindrome.IsPalindromeTest();
    //     Assert.AreEqual(true, testPalindrome.GetIsPalindrome());
    // }
  }
}