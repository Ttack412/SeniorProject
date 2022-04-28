using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Word_Search
{
    //Collects all words that can be created by the random characters
    class randomWords
    {
        int formSize;
        List<char> wordSearchCharacters = new List<char>();

        //Constructor needs a form size AND the character list
        public randomWords(int size, List<char> Characters)
        {
            formSize = size;
            wordSearchCharacters = Characters;
        }

        //Finds returns a list of all possible words
        public List<String> findWords()
        {
            //Holds all strings that can be formed through the combination of characters
            List<String> potentialWords = new List<String>();

            //Holds all real words found from the comparision of Potential Words and Dictionary Words
            List<String> completeWords = new List<String>();

            //Gets the total number of characters in the form
            int numberOfCharacters = formSize * formSize;

            //Tracks the position of the character on the word search form
            int left = 0;
            int right = formSize - 1;
            int top = 0;
            int bottom = formSize - 1;

            //counter to make sure we stay within the bounds of left, right, bottom, and center
            int count = 0;

            //tracks characters within the ROW, provides us with a point to reset to a new row
            int countTwo = 0;

            //tracks the index of the value of the character within the potential words list
            int indexTracker = 0;
     
            //Cycles throught every character and collects all possible strings they create based on typical word search rules
            for (int i = 0; i < numberOfCharacters; i++)
            {
                //RIGHT
                while (count <= right)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[count + i].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //BOTTOM
                while (count <= bottom)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i + (formSize * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //LEFT
                while (count <= left)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i - count].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //TOP
                while (count <= top)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i - (formSize * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //TOP-RIGHT DIAG
                while (count <= top && count <= right)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i - ((formSize - 1) * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //BOTTOM-RIGHT DIAG
                while (count <= bottom && count <= right)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i + ((formSize + 1) * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //BOTTOM-LEFT DIAG
                while (count <= bottom && count <= left)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i + ((formSize - 1) * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                }
                count = 0;

                //TOP-LEFT DIAG
                while (count <= top && count <= left)
                {
                    if (count == 0)
                    {
                        potentialWords.Add(wordSearchCharacters[i].ToString());
                        indexTracker++;
                        count++;
                    }
                    else
                    {
                        potentialWords.Add(potentialWords[indexTracker - 1] + wordSearchCharacters[i - ((formSize + 1) * count)].ToString());
                        indexTracker++;
                        count++;
                    }
                } 
                count = 0;


                //SETTING CODE POSITION TO MATCH I's POSITION

                //When we start a row Right is MAXED and Left is 0, so the next index would be 1 to the left
                //And we need to adjust our values to match 
                right--;
                left++;
                countTwo++;

                //Count Two tells us if we are at the end of the row, so if we are at the end of the row we need to reset
                if(countTwo == formSize)
                {
                    //Changes Left, Right, and CounterTwo to initial values
                    left = 0;
                    right = formSize - 1;
                    countTwo = 0;
                    
                    //Adjusts variables to begin in the row below
                    top++;
                    bottom--;
                    
                }

            }

            //Removes all duplicates
            potentialWords = potentialWords.Distinct().ToList();

            //Scanner to read in the dictionalry
            StreamReader scanner = new StreamReader("realFinal.txt");
            string line;

            //Reads in all words form the dictionary and places them into a list
            while((line = scanner.ReadLine()) != null)
            {
                for (int i = 0; i < potentialWords.Count; i++)
                {
                    if (potentialWords[i].Equals(line))
                    {
                        completeWords.Add(potentialWords[i]);
                    }
                    
                }
            }
            scanner.Close();

            //Doubles checks for duplicates and returns the list
            return completeWords.Distinct().ToList();
        }

    }
}
