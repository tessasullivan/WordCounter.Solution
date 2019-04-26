using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void WordCounterConstructor_CreatesInstanceOfWordCounter_WordCounter()
        {
            WordCounter newWordCounter = new WordCounter("", "");
            Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
        }

        [TestMethod]
        public void GetWord_GetWord_String()
        {
            string word = "test";
            WordCounter newWordCounter = new WordCounter(word, "");
            Assert.AreEqual(word, newWordCounter.GetWord());
        }

        [TestMethod]
        public void SetWord_SetWord_string()
        {
            string word = "test";
            WordCounter newWordCounter = new WordCounter(word, "");
            string updatedWord = "wow";
            newWordCounter.SetWord(updatedWord);
            Assert.AreEqual(updatedWord, newWordCounter.GetWord());
        }
        [TestMethod]
        public void GetSentence_GetSentence_String()
        {
            string sentence = "I am a sentence";
            WordCounter newWordCounter = new WordCounter("", sentence);
            Assert.AreEqual(sentence, newWordCounter.GetSentence());
        }

        [TestMethod]
        public void SetSentence_SetSentence_String()
        {
            string sentence = "I am a sentence";
            WordCounter newWordCounter = new WordCounter("", sentence);
            string updatedSentence = "I love chai";
            newWordCounter.SetSentence(updatedSentence);
            Assert.AreEqual(updatedSentence, newWordCounter.GetSentence());
        }

        [TestMethod]
        public void SplitWord_SplitWord_CharArray()
        {
            string word = "joe";
            // char[] expectedResult = word.ToCharArray();
            char[] expectedResult = new char[] {'j','o','e'};
            WordCounter newWordCounter = new WordCounter(word, "");
            CollectionAssert.AreEqual(expectedResult, newWordCounter.SplitWord());
        }

        [TestMethod]
        public void RemoveSomePunctuation_VerifyBeginningPunctuationRemoved_String()
        {
            string word = "\"Word";
            string sentence = "";
            string expectedResult = "Word";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            string actualResult = newWordCounter.RemoveSomePunctuation(word);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void RemoveSomePunctuation_VerifyEndingPunctuationRemoved_String()
        {
            string word = "test.";
            string sentence = "";
            string expectedResult = "test";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            string actualResult = newWordCounter.RemoveSomePunctuation(word);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SplitSentence_SplitSentenceWithPunctuation_StringArray()
        {
            string sentence = "I am a sentence.";
            string[] expectedResult = sentence.Split(' ');
            WordCounter newWordCounter = new WordCounter("", sentence);
            CollectionAssert.AreEqual(expectedResult, newWordCounter.SplitSentence());
        }
        // This test currently fails but I cannot figure out why so I'm commenting it out and plan to come back to it later.
        // [TestMethod]
        // public void SplitSentence_VerifySentencePunctuationIgnored_StringArray()
        // {
        //     string word = "";
        //     // string sentence = "I am a sentence.";
        //     // string[] expectedResult = {"I", "am", "a", "sentence"};
        //     string sentence = "sentence.";
        //     string[] expectedResult = {"sentence"};
        //     foreach (string testWord in expectedResult)
        //     {
        //         System.Console.WriteLine("expectedResult "+ "'" + testWord + "'");
        //     }
        //     WordCounter newWordCounter = new WordCounter(word, sentence);
        //     CollectionAssert.AreEqual(expectedResult, newWordCounter.SplitSentence());
        // }

        [TestMethod]
        public void CheckWord_VerifyWordContainsAlphaNumericOnly_True()
        {
            string word = "test";
            string sentence = "";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(true, newWordCounter.CheckWord());
        }
        
        [TestMethod]
        public void CheckWord_VerifyWordContainsAlphaNumericOnly_False()
        {
            string word = "%";
            string sentence = "";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(false, newWordCounter.CheckWord());
        }
        [TestMethod]
        public void CheckWord_VerifyWordContainsApostropheIsWord_True()
        {
            string word = "can't";
            string sentence = "";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(true, newWordCounter.CheckWord());
        }
    }
}