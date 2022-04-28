using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace Word_Search
{
    //Cleaned up output messages byu moving them into a seperate class
    //ALSO using a costume Message Box, to change font size due to the default box being so small
    class messageBoxRespone
    {
        public messageBoxRespone()
        {

        }

        //Handles creation of the Message Box
        public void createMessage(string text, string name)
        {
            //Creates only One button that will be labeled Okay
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Pop-up
            DialogResult result;

            //Using a custom message box to change font size
            FlexibleMessageBox.FONT = new Font("Segoe UI", 12, FontStyle.Regular);

            //Pushes Message box to the screen
            result = FlexibleMessageBox.Show(name, text, buttons);
        }

        //ALL methods below just pass different responses to CREATE MESSAGE
        //Words Search Creation Instruction
        public void getInputInstructions()
        {
            String title = "Input Instructions Box";
            String message = "Step One -> Select a size between 5-15" + "\n" +
                "Step Two -> Enter the size you want in the format be entering it in the text box" + "\n" +
                "Suggestion -> Large word searches often have more words then smaller ones";

            createMessage(title, message);
        }

        //How to play the game
        public void getInstructions()
        {
            String title = "Word Search Instructions Box";
            String message = "Step One -> Select multiple letters while holding the ctrl key" + "\n" +
                "Step Two -> Click the Submit Word btn to check if that word can be found" + "\n" +
                "Step Three -> Once you have found all the words click the Submit btn";

            createMessage(title, message);
        }

        //Outputs a completetion or NON-completion message
        public void getFinalResults(int all, int found)
        {
            String title;
            String message;
            int foundItems = found;
            int allItems = all;

            if (foundItems == allItems)
            {
                title = "Winners POV";
                message = "Congradulations!! You've found every word available!" + "\n"
                    + "Please click the exit btn to close the form OR the reset btn to play again :)";
            }
            else
            {
                title = "Losers POV";
                message = "Looks like you still have some words to find :(";
            }

            createMessage(title, message);
        }

        //Outputs a Zerto Word Warning
        public void getError()
        {
            String title = "Zero Words";
            String message = "Sorry, it looks like no words from the dictionary be found" + "\n" + 
                "Please click the reset button to try again!";

            createMessage(title, message);
        }
    }
}
