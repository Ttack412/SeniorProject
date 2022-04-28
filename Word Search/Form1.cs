using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Word_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Sends the program onto the next form
        private void continueBtn_Click(object sender, EventArgs e)
        {
            //Gets the value in the text box
            string input = matrixSizeText.Text;

            //A few Input tests
            //Checks to see if nothing was entered
            if(input != "X")
            {
                //With some  manipulating we have the number we need
                int formSize = Int32.Parse(input);

                //Checks to see is the size is valid
                if (formSize >= 5 && formSize <= 15)
                {
                    //Genreates random letters, using the randomLetters object, and stores them into a char array
                    randomLetters randomCharacters = new randomLetters(formSize);
                    List<char> newCharacters = randomCharacters.generateLetters();

                    //Generates random words, using the randomWords object, and stores them into a string array
                    randomWords myRandomWords = new randomWords(formSize, newCharacters);
                    List<String> newWords = myRandomWords.findWords();

                    //Passes both arrays into the following form
                    nextForm nextForm = new nextForm(formSize, newCharacters, newWords);
                    this.Hide();
                    nextForm.setNextForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid size using the correct format that is within the limit :)");
                }
                
            }
            else
            {
                MessageBox.Show("Please follow the instructions and enter the input correctly :)");
            }
            
        }

        //Gets Input instructions
        private void button1_Click(object sender, EventArgs e)
        {
            messageBoxRespone myMessage = new messageBoxRespone();
            myMessage.getInputInstructions();
        }
    }
}
