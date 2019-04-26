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
        public char[] SplitWord()
        {
            return GetWord().ToCharArray();
        }
        public string[] SplitSentence()
        {
            //split the sentence into individual words and 
            string[] splitSentence = _sentence.Split(' ');
            string[] cleanedSentence = new string[splitSentence.Length];
            int i=0;

            foreach (string word in splitSentence)
            {
                string cleanedWord = RemoveSomePunctuation(word);
                // System.Console.WriteLine("index "+ i + " word: " + "'" + cleanedWord + "'");
                cleanedSentence[i] = cleanedWord;
                i++;
            }
            return splitSentence;
        }
        public string RemoveSomePunctuation(string wordToClean)
        // Remove beginning or ending punctuation
        // Since we can't use regular expressions, I cheat here in a different way by removing all punctuation except apostrophe
        {
            char[] splitWord = wordToClean.ToCharArray();
            string cleanedWord = "";
            foreach (char letter in splitWord)
            {
                if (("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz'".Contains(letter)))
                // if ("abcdefghijklmnopqrstuvwxyz'".Contains(letter))

                {
                    cleanedWord += letter.ToString();
                }
                else
                {
                    continue;
                }
            }
            return cleanedWord;
        }

        public bool CheckWord() 
        {
            string wordToTest = GetWord().ToLower();
            char[] charactersToTest = SplitWord();
            foreach (char letter in charactersToTest)
            {
                if ("abcdefghijklmnopqrstuvwxyz'".Contains(letter))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}