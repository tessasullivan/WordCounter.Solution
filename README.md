# Word Counter

#### A program that counts words in a sentence, based on the word the user enters.

#### By **Tessa Sullivan**

## Description
The program will take a word and a sentence from a user and output how frequently the word appears in the sentence.



### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| User does not enter anything for word | User hits enter when prompted for word | Output: User prompted to enter word|
| User does not enter anything for sentence | User hits enter when prompted for sentence | Output: User prompted to enter sentence|
| Words which only contain non-alphanumeric characters are rejected| Input: % | Output: User prompted to enter word|
| Sentences which contain words with only non-alphanumeric characters are accepted but the said words will be discounted| Input: word: cat, sentence: I wanted a sandwich which costs $4| Output: cat: 0|
| Single word entered for both word and sentence | User enters 'a' for both word and sentence| Output: a: 1|
| Word does not occur in sentence | Input: word: cat, sentence: I walked the dog this morning|Output: cat: 0|
| Word occurs 1 time in sentence | Input: word: dog, sentence: I walked the dog this morning|Output: dog: 1 |
| Word occurs 3 times in sentence | Input: coffee, sentence: I went to Starbucks coffee and got tea instead of coffee because I don't like coffee | Output: coffee: 3|
| Case is ignored | Input: word: coffee, sentence: I went to Starbucks Coffee this morning | Output: coffee: 1|
| Words which contain apostrophe are treated as words | Input: word: can't, sentence: I can't wait to see you | Output: can't: 1|
| Words which contain an apostrophe are considered different from words without|Input: word: cant, sentence, I can't believe you can cant | Output: cant: 1 |



## Setup/Installation Requirements

Currently does not include Program.cs so it cannot be run directly from the command line.  Tests can be run by doing the following:
1. Install .Net 2.2 
    * Go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and download the appropriate installer for your OS.
2. cd to repo directory
3. On the command line, run:
    * dotnet test LeetSpeak.Tests

## Known Issues
* No known issues at this time.

## Technologies Used

* C#

## Support and contact details

_Contact Tessa Sullivan @ tessa.sullivan@gmail.com_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_Tessa Sullivan_**