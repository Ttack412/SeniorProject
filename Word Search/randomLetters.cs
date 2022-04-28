using System;
using System.Collections.Generic;
using System.Text;

namespace Word_Search
{
    class randomLetters
    {
        int formSize;
        //Constructor w/ size parameter
        public randomLetters(int size)
        {
            formSize = size;
        }

        //Given the size, this generator will make size squared amount of ranodm letters
        public List<char> generateLetters()
        {
            //Sets creates random object
            Random rnd = new Random();

            int charactersNeeded = formSize * formSize;
            List<char> wordSearchCharacters = new List<char>();

            //Gets a random number, finds what that number converts to in ASCII value, then adds that letter to the list
            for(int i = 0; i < charactersNeeded; i++)
            {
                int index = rnd.Next(97, 123); //ASCII character codes 97-123
                char randomLowerCase = Convert.ToChar(index); //produces any char a-z
                wordSearchCharacters.Add(randomLowerCase);
            }
            //Returns all characters
         return wordSearchCharacters;
        }

    }
}
