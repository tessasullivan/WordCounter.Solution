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

        // public string RemoveSomePunctuation(string wordToClean)
        // // Remove beginning or ending punctuation
        // // Since we can't use regular expressions, I cheat here in a different way by removing all punctuation except apostrophe
        // {
        //     char[] splitWord = wordToClean.ToCharArray();
        //     string cleanedWord = "";
        //     foreach (char letter in splitWord)
        //     {
        //         if (char.IsLetter(letter) || letter == '\'')
        //         {
        //             cleanedWord += letter.ToString();
        //         }
        //         else
        //         {
        //             continue;
        //         }
        //     }
        //     return cleanedWord;
        // }
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
        public int CountWordOccurrences()
        {
            string word = GetWord();
            string[] splitSentence = SplitSentence();
            int counter = 0;
            foreach (string wordToTest in splitSentence)
            {
                if (CompareWords(wordToTest))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}