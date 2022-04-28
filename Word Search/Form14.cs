using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Search
{
    public partial class Form14 : Form
    {
        //Lists for all generated characters and words
        List<char> wordSearchCharacters = new List<char>();
        List<String> wordSearchWords = new List<String>();

        //New message box object, used in a few of the methods
        messageBoxRespone myMessage = new messageBoxRespone();

        public Form14()
        {
            InitializeComponent();
        }

        //Contructor that is given the generated char list and generated word list
        public Form14(List<char> characterList, List<String> wordList)
        {
            InitializeComponent();

            //Clears view of any items left during testing
            this.wordSearchView.Items.Clear();

            //Populates lists
            wordSearchCharacters = characterList;
            wordSearchWords = wordList;

        }

        //On form load I call the fill form method below
        private void Form14_Load(object sender, EventArgs e)
        {
            fillForm();

            //Makes it so users can't user the check list box
            checkedListBox.Enabled = false;

            //Zero Word Notice
            if (wordSearchWords.Count == 0)
            {
                noWords();
            }
        }

        //AKA SUBMIT 
        //This button submits the currently selected characters and checks to see if they match a word
        private void button1_Click(object sender, EventArgs e)
        {
            //Collects all indexes of the SELECTED letters in the view
            ListView.SelectedIndexCollection indexes = this.wordSearchView.SelectedIndices;

            //finds the letter that the selected index matches and adds them to a string
            string selection = null;
            foreach (int index in indexes)
            {
                selection = selection + (this.wordSearchView.Items[index].Text);
            }


            //Runs through every possible word and checks to see is if the selected words matches
            for (int i = 0; i < wordSearchWords.Count; i++)
            {
                //compares the characters of the selected word to a real word AND proceeds if it matches
                if (sameChars(wordSearchWords[i], selection))
                {
                    //Goes through all selected letters and BOLDS them
                    foreach (int index in indexes)
                    {
                        this.wordSearchView.Items[index].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    }

                    //Selects the word in the check box
                    checkedListBox.SetItemChecked(i, true);
                }
            }
        }

        //NO W#ORDS message
        public void noWords()
        {
            myMessage.getError();
        }



        //INSTRUCTIONS btn
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            myMessage.getInstructions();
        }

        //COMPLETE btn
        //Calls grabs the completion check from Message Box Items
        private void button2_Click(object sender, EventArgs e)
        {
            myMessage.getFinalResults(wordSearchWords.Count, checkedListBox.CheckedItems.Count);
        }

        //CLOSE PROGRAM
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sends us back to form 1 and allows for a new word search to be played
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Hide();
            newForm1.ShowDialog();
            this.Close();
        }

        //Checks to see if two strings have the same chars, and returns a bool
        private bool sameChars(String firstStr, String secondStr)
        {
            //Reduces strings into Char Arrays
            char[] first = firstStr.ToCharArray();
            char[] second = secondStr.ToCharArray();

            //Sorts both arrays
            Array.Sort(first);
            Array.Sort(second);

            //Returns is they contain the same amount of characters in the same order
            return first.SequenceEqual(second);
        }

        //Fills the empty form at creation
        public void fillForm()
        {
            //Fills View with all the generated characters
            for (int i = 0; i < wordSearchCharacters.Count; i++)
            {
                wordSearchView.Items.Add((wordSearchCharacters[i]).ToString());
            }

            //Fills List Box with all generated words
            for (int i = 0; i < wordSearchWords.Count; i++)
            {
                checkedListBox.Items.Add((wordSearchWords[i]));
            }
        }

    }
}