using System;

namespace WordCounter
{
    public class WordCounter
    {
        private static int _total;
        private string _word;
        private string _sentence;

        public WordCounter(int total, string word, string sentence)
        {
            _total = total;
            _word = word;
            _sentence = sentence;
        }

        public int GetTotal()
        {
            return _total;
        }
        public void SetTotal(int total)
        {
            _total = total;
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
            //split the sentence into individual words and remove punctuation except apostrophe
            string[] splitSentence = _sentence.Split(' ');
            string[] cleanedSentence = new string[splitSentence.Length];
            int i=0;

            foreach (string word in splitSentence)
            {
                string cleanedWord = RemoveSomePunctuation(word);
                cleanedSentence[i] = cleanedWord;
                i++;
            }
            return cleanedSentence;
        }
        public string RemoveSomePunctuation(string wordToClean)
        {
            // if the first character is not a letter, remove it and return the string, same with last character
            if (! char.IsLetter(wordToClean[0]))
            {
                wordToClean = wordToClean.Remove(0,1);
            }
            else if (!char.IsLetter(wordToClean[wordToClean.Length-1]))
            {
                wordToClean = wordToClean.Remove(wordToClean.Length-1, 1);
            }
            return wordToClean;
        }

        // If the word contains anything but alphabetical or apostrophe characters, reject it
        public bool CheckWord() 
        {
            string wordToTest = GetWord();
            if (wordToTest == "")
            {
                return false;
            }
            else
            {
                char[] charactersToTest = SplitWord();
                foreach (char letter in charactersToTest)
                {
                    if (char.IsLetter(letter) || letter == '\'')

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
        public bool CompareWords(string wordToTest)
        {
            string word = GetWord();
            if (word.ToLower() == wordToTest.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CountWordOccurrences()
        {
            string word = GetWord();
            WordCounter newWordCounter = new WordCounter(0, word, GetSentence());
            string[] splitSentence = SplitSentence();
            int counter = 0;
            foreach (string wordToTest in splitSentence)
            {
                if (CompareWords(wordToTest))
                {
                    counter++;
                }
            }
            System.Console.WriteLine("counter is " + counter);
            newWordCounter.SetTotal(counter);
            System.Console.WriteLine("GetTotal is " + newWordCounter.GetTotal());
        }
    }
}