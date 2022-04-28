using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Word_Search
{
    //This class moves us form the statring menu, to the correct word search form
    class nextForm
    {
        int formSize;
        List<char> wordSearchCharacters = new List<char>();
        List<String> wordSearchWords = new List<String>();
        
        public nextForm()
        {
            
        }
        
        //To create a wordsearch correctly we need Letters to fill the View, The words they make, and the size
        public nextForm(int size, List<char> Characters, List<String> Words)
        {
            formSize = size;
            wordSearchCharacters = Characters;
            wordSearchWords = Words;
        }

        public void setNextForm()
        {
            //Based on the entered size this switch statement will create the word search of that size
            switch(formSize)
            {
                case 5:
                    Form5 newForm5 = new Form5(wordSearchCharacters, wordSearchWords);
                    newForm5.ShowDialog();
                    break;
                case 6:
                    Form6 newForm6 = new Form6(wordSearchCharacters, wordSearchWords);
                    newForm6.ShowDialog();
                    break;
                case 7:
                    Form7 newForm7 = new Form7(wordSearchCharacters, wordSearchWords);
                    newForm7.ShowDialog();
                    break;
                case 8:
                    Form8 newForm8 = new Form8(wordSearchCharacters, wordSearchWords);
                    newForm8.ShowDialog();
                    break;
                case 9:
                    Form9 newForm9 = new Form9(wordSearchCharacters, wordSearchWords);
                    newForm9.ShowDialog();
                    break;
                case 10:
                    Form10 newForm10 = new Form10(wordSearchCharacters, wordSearchWords);
                    newForm10.ShowDialog();
                    break;
                case 11:
                    Form11 newForm11 = new Form11(wordSearchCharacters, wordSearchWords);
                    newForm11.ShowDialog();
                    break;
                case 12:
                    Form12 newForm12 = new Form12(wordSearchCharacters, wordSearchWords);
                    newForm12.ShowDialog();
                    break;
                case 13:
                    Form13 newForm13 = new Form13(wordSearchCharacters, wordSearchWords);
                    newForm13.ShowDialog();
                    break;
                case 14:
                    Form14 newForm14 = new Form14(wordSearchCharacters, wordSearchWords);
                    newForm14.ShowDialog();
                    break;
                case 15:
                    Form15 newForm15 = new Form15(wordSearchCharacters, wordSearchWords);
                    newForm15.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Please make sure to enter the correct inputs");
                    break;
                }
        }
        
    }
}
