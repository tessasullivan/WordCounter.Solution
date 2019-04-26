using System;

namespace WordCounter
{
    public class WordCounter
    {
        private string _word;
        private string _sentence;
        public WordCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string GetWord()
        {
            return _word;
        }
        public void SetWord(string newWord)
        {
            _word = newWord;
        }
        public string GetSentence()
        {
            return _sentence;
        }
        public void SetSentence(string newSentence)
        {
            _sentence = newSentence;
        }
    }
}