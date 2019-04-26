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
    }
}