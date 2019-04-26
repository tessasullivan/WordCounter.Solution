using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
        public void RemoveSomePunctuation_VerifyWordWithoutPunctuationUnchanged_String()
        {
            string word = "test";
            string sentence = "";
            string expectedResult = "test";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            string actualResult = newWordCounter.RemoveSomePunctuation(word);
            Assert.AreEqual(expectedResult, actualResult);
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
        public void SplitSentence_SplitSentenceWithoutPunctuation_StringArray()
        {
            string word = "test";
            string sentence = "I am a sentence";
            string[] expectedResult = {"I", "am", "a", "sentence"};

            WordCounter newWordCounter = new WordCounter(word, sentence);
            CollectionAssert.AreEqual(expectedResult, newWordCounter.SplitSentence());
        }

        [TestMethod]
        public void SplitSentence_VerifySentencePunctuationIgnored_StringArray()
        {
            string word = "test";
            string sentence = "I am a sentence.";
            string[] expectedResult = {"I", "am", "a", "sentence"};
            WordCounter newWordCounter = new WordCounter(word, sentence);

            string[] actualResult = newWordCounter.SplitSentence();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckWord_VerifyWordContainsAlphabetOnly_True()
        {
            string word = "test";
            string sentence = "";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(true, newWordCounter.CheckWord());
        }

        [TestMethod]
        public void CheckWord_VerifyEmptyString_False()
        {
            string word = "";
            string sentence = "";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(false, newWordCounter.CheckWord());
        }

        [TestMethod]
        public void CheckWord_VerifyWordContainsAlphabetOnly_False()
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

        [TestMethod]
        public void CompareWords_VerifySingleLetterWordMatchesSame_True()
        {
            string word01 = "a";
            string word02 = "a";
            WordCounter newWordCounter = new WordCounter(word01, word02);
            Assert.AreEqual(true, newWordCounter.CompareWords(word02));
        }

        [TestMethod]
        public void CompareWords_VerifyMultipleLetterWordMatchesSame_True()
        {
            string word01 = "and";
            string word02 = "and";
            WordCounter newWordCounter = new WordCounter(word01, word02);
            Assert.AreEqual(true, newWordCounter.CompareWords(word02));
        }

        [TestMethod]
        public void CompareWords_VerifyWordMatchesSameWithDifferentCase_True()
        {
            string word01 = "and";
            string word02 = "And";
            WordCounter newWordCounter = new WordCounter(word01, word02);
            Assert.AreEqual(true, newWordCounter.CompareWords(word02));
        }

        [TestMethod]
        public void CompareWords_VerifyDifferentWordsDoNotMatch_False()
        {
            string word01 = "and";
            string word02 = "but";
            WordCounter newWordCounter = new WordCounter(word01, word02);
            Assert.AreEqual(false, newWordCounter.CompareWords(word02));
        }

        [TestMethod]
        public void CountWordOccurrences_VerifyNoOccurrences_0()
        {
            string word = "foo";
            string sentence = "bar";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(0, newWordCounter.CountWordOccurrences());
        }

        [TestMethod]
        public void CountWordOccurrences_VerifySingleOccurrence_1()
        {
            string word = "foo";
            string sentence = "foo bar";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(1, newWordCounter.CountWordOccurrences());
        }

        [TestMethod]
        public void CountWordOccurrences_VerifyMultipleOccurrences_3()
        {
            string word = "coffee";
            string sentence = "I went to Starbucks coffee and got tea instead of coffee because I don't like coffee";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(3, newWordCounter.CountWordOccurrences());
        }
        [TestMethod]
        public void CountWordOccurrences_VerifyMultipleOccurrencesWithDifferentCase_3()
        {
            string word = "coffee";
            string sentence = "I went to Starbucks Coffee and got tea instead of coffee because I don't like coffee";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(3, newWordCounter.CountWordOccurrences());
        }

        [TestMethod]
        public void CountWordOccurrences_VerifySingleOccurrenceWhenTwoWordsSameExceptApostrophe_1()
        {
            string word = "can't";
            string sentence = "I can't believe you can cant.";
            WordCounter newWordCounter = new WordCounter(word, sentence);
            Assert.AreEqual(1, newWordCounter.CountWordOccurrences());
        }
    }
}