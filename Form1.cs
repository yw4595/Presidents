using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/**
 * Author: Yanzhi Wang
 * Purpose: This class represents the main form for the Presidents program. It displays a list of US presidents
 *          and allows the user to select and view information about each president.
 * Restrictions: None
 */

namespace Presidents
{
    public partial class presidentsForm : Form
    {

        /**

Purpose: Initializes the main form of the Presidents application and registers an event handler for the Load event.
*/
        public presidentsForm()
        {
            InitializeComponent();
            //presidentwikiWebBrowser.Scroll += presidentwikiWebBrowser_Scroll;
            this.Load += presidentsForm_Load;
           

        }




        /**

Purpose: Closes the main form of the Presidents application.
*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //Purpose: Initialize the form and set some initial values for the form elements.
        private void presidentsForm_Load(object sender, EventArgs e)
        {
            
            // Set the ProgressBar value to 75
            progressBar.Value = 75;
            franklindrooseveltTextBox.Text = "0";
            williamjclintonTextBox.Text = "0";
            jamesbuchananTextBox.Text = "0";
            franklinpierceTextBox.Text = "0";
            barackobamaTextBox.Text = "0";
            johnfkennedyTextBox.Text = "0";
            martinvanburenTextBox.Text = "0";
            benjaminharrisonTextBox.Text = "0";
            georgewbushTextBox.Text = "0";
            williammckinleyTextBox.Text = "0";
            ronaldreaganTextBox.Text = "0";
            dwightdeisenhowerTextBox.Text = "0";
            theodorerooseveltTextBox.Text = "0";
            thomasjeffersonTextBox.Text = "0";
            georgewashingtonTextBox.Text = "0";
            johnadamsTextBox.Text = "0";

        }






        //Purpose: Show all the presidents' information.
        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            franklindrooseveltRadioButton.Visible = true;
            williamjclintonRadioButton.Visible = true;
            jamesbuchananRadioButton.Visible = true;
            franklinpierceRadioButton.Visible = true;
            barackobamaRadioButton.Visible = true;
            johnfkennedyRadioButton.Visible = true;
            martinvanburenRadioButton.Visible = true;

            benjaminharrisonRadioButton.Visible = true;
            georgebushRadioButton.Visible = true;
            williammckinleyRadioButton.Visible = true;
            ronaldreaganRadioButton.Visible = true;
            dwightdeisenhowerRadioButton.Visible = true;
            theodorerooseveltRadioButton.Visible = true;
            thomasjeffersonRadioButton.Visible = true;
            georgewashingtonRadioButton.Visible = true;
            johnadamsRadioButton.Visible = true;

        }

        //Purpose: Show only the information of Democrat presidents.

        private void democratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            franklindrooseveltRadioButton.Visible = true;
            williamjclintonRadioButton.Visible = true;
            jamesbuchananRadioButton.Visible = true;
            franklinpierceRadioButton.Visible = true;
            barackobamaRadioButton.Visible = true;
            johnfkennedyRadioButton.Visible = true;
            martinvanburenRadioButton.Visible = true;

            benjaminharrisonRadioButton.Visible = false;
            georgebushRadioButton.Visible = false;
            williammckinleyRadioButton.Visible = false;
            ronaldreaganRadioButton.Visible = false;
            dwightdeisenhowerRadioButton.Visible = false;
            theodorerooseveltRadioButton.Visible = false;
            thomasjeffersonRadioButton.Visible = false;
            georgewashingtonRadioButton.Visible = false;
            johnadamsRadioButton.Visible = false;
        }

        //Purpose: Show only the information of Republican presidents.
        private void republicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            franklindrooseveltRadioButton.Visible = false;
            williamjclintonRadioButton.Visible = false;
            jamesbuchananRadioButton.Visible = false;
            franklinpierceRadioButton.Visible = false;
            barackobamaRadioButton.Visible = false;
            johnfkennedyRadioButton.Visible = false;
            martinvanburenRadioButton.Visible = false;

            benjaminharrisonRadioButton.Visible = true;
            georgebushRadioButton.Visible = true;
            williammckinleyRadioButton.Visible = true;
            ronaldreaganRadioButton.Visible = true;
            dwightdeisenhowerRadioButton.Visible = true;
            theodorerooseveltRadioButton.Visible = true;
            thomasjeffersonRadioButton.Visible = false;
            georgewashingtonRadioButton.Visible = false;
            johnadamsRadioButton.Visible = false;
        }

        //Purpose: Show only the information of Democrat-Republican presidents.
        private void democratRepublicanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Hide all other presidents
            franklindrooseveltRadioButton.Visible = false;
            williamjclintonRadioButton.Visible = false;
            jamesbuchananRadioButton.Visible = false;
            franklinpierceRadioButton.Visible = false;
            barackobamaRadioButton.Visible = false;
            johnfkennedyRadioButton.Visible = false;
            martinvanburenRadioButton.Visible = false;
            benjaminharrisonRadioButton.Visible = false;
            georgebushRadioButton.Visible = false;
            williammckinleyRadioButton.Visible = false;
            ronaldreaganRadioButton.Visible = false;
            dwightdeisenhowerRadioButton.Visible = false;
            theodorerooseveltRadioButton.Visible = false;
            georgewashingtonRadioButton.Visible = false;
            johnadamsRadioButton.Visible = false;

            // Show presidents who were affiliated with the Democratic-Republican Party
            thomasjeffersonRadioButton.Visible = true;
        }

        private void federalistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set all other radio buttons to not visible
            franklindrooseveltRadioButton.Visible = false;
            williamjclintonRadioButton.Visible = false;
            jamesbuchananRadioButton.Visible = false;
            franklinpierceRadioButton.Visible = false;
            barackobamaRadioButton.Visible = false;
            johnfkennedyRadioButton.Visible = false;
            martinvanburenRadioButton.Visible = false;

            benjaminharrisonRadioButton.Visible = false;
            georgebushRadioButton.Visible = false;
            williammckinleyRadioButton.Visible = false;
            ronaldreaganRadioButton.Visible = false;
            dwightdeisenhowerRadioButton.Visible = false;
            theodorerooseveltRadioButton.Visible = false;
            thomasjeffersonRadioButton.Visible = false;

            // Set federalist presidents to visible
            georgewashingtonRadioButton.Visible = true;
            johnadamsRadioButton.Visible = true;
        }






        // This method is triggered when the georgewashingtonRadioButton is checked
        private void georgewashingtonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the georgewashingtonRadioButton is checked, load the image of George Washington and set the PictureBox to zoom mode
            if (georgewashingtonRadioButton.Checked)
            {
                pictureBox.Image = Image.FromFile(@"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\GeorgeWashington.jpeg");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // If the georgewashingtonRadioButton is checked, navigate to George Washington's Wikipedia page in the WebBrowser control
            if (georgewashingtonRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            }
            // If the benjaminharrisonRadioButton is checked, navigate to Benjamin Harrison's Wikipedia page in the WebBrowser control
            if (benjaminharrisonRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            }
        }

        // This method is called when the text in the "Benjamin Harrison" text box changes
        private void benjaminharrisonTextBox_TextChanged(object sender, EventArgs e)
        {
            // Attempt to parse the text in the text box as an integer
            int number;
            if (int.TryParse(benjaminharrisonTextBox.Text, out number))
            {
                // If the parsed integer is equal to 23, clear any error messages associated with the text box
                if (number == 23)
                {
                    errorProvider.SetError(benjaminharrisonTextBox, "");
                }
                // Otherwise, set an error message indicating that the number is incorrect
                else
                {
                    errorProvider.SetError(benjaminharrisonTextBox, "That is the wrong number");
                }
            }
            // If the text cannot be parsed as an integer, clear any error messages associated with the text box
            else
            {
                errorProvider.SetError(benjaminharrisonTextBox, "");
            }
        }





        // This method is triggered when the benjaminharrisonRadioButton is checked
        private void benjaminharrisonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the benjaminharrisonRadioButton is checked, load the image of Benjamin Harrison and set the PictureBox to stretch mode
            if (benjaminharrisonRadioButton.Checked)
            {
                pictureBox.Image = Image.FromFile(@"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\BenjaminHarrison.jpeg");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // If the benjaminharrisonRadioButton is checked, navigate to Benjamin Harrison's Wikipedia page in the WebBrowser control
            if (benjaminharrisonRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            }
        }
        private void franklindrooseveltRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the Franklin D. Roosevelt radio button is checked, update the image and navigate to the corresponding Wikipedia page
            if (franklindrooseveltRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\FranklinDRoosevelt.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
            }
        }

        private void williamjclintonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the Bill Clinton radio button is checked, update the image and navigate to the corresponding Wikipedia page
            if (williamjclintonRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\WilliamJClinton.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Bill_Clinton");
            }
        }

        private void barackobamaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the Barack Obama radio button is checked, update the image and navigate to the corresponding Wikipedia page
            if (barackobamaRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\BarackObama.png";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
            }
        }

        /**

This method is called when the 'William McKinley' radio button is checked.
It sets the image location and size mode of the picture box to display the image of William McKinley.
It also navigates the web browser to the Wikipedia page of William McKinley.
*/
        private void williammckinleyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (williammckinleyRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\WilliamMcKinley.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (williammckinleyRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            }
        }
        /**

This method is called when the 'Thomas Jefferson' radio button is checked.
It sets the image location and size mode of the picture box to display the image of Thomas Jefferson.
It also navigates the web browser to the Wikipedia page of Thomas Jefferson.
*/
        private void thomasjeffersonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (thomasjeffersonRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\ThomasJefferson.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (thomasjeffersonRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            }
        }

        /**

This method is called when the 'Theodore Roosevelt' radio button is checked.
It sets the image location and size mode of the picture box to display the image of Theodore Roosevelt.
It also navigates the web browser to the Wikipedia page of Theodore Roosevelt.
*/
        private void theodorerooseveltRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (theodorerooseveltRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\TheodoreRoosevelt.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (theodorerooseveltRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            }
        }
        private void ronaldreaganRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "Ronald Reagan" radio button is checked
            if (ronaldreaganRadioButton.Checked)
            {
                // Set the image location to the path of Ronald Reagan's image
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\RonaldReagan.jpeg";
                // Set the picture box's size mode to stretch the image to fit
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // Check if the "Ronald Reagan" radio button is checked
            if (ronaldreaganRadioButton.Checked)
            {
                // Navigate to Ronald Reagan's Wikipedia page
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
            }
        }

        private void martinvanburenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "Martin Van Buren" radio button is checked
            if (martinvanburenRadioButton.Checked)
            {
                // Set the image location to the path of Martin Van Buren's image
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\MartinVanBuren.jpeg";
                // Set the picture box's size mode to stretch the image to fit
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Navigate to Martin Van Buren's Wikipedia page
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");
            }
        }

        private void johnfkennedyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "John F. Kennedy" radio button is checked
            if (johnfkennedyRadioButton.Checked)
            {
                // Set the image location to the path of John F. Kennedy's image
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\JohnFKennedy.jpeg";
                // Set the picture box's size mode to stretch the image to fit
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            // Check if the "John F. Kennedy" radio button is checked
            if (johnfkennedyRadioButton.Checked)
            {
                // Navigate to John F. Kennedy's Wikipedia page
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F._Kennedy");
            }
        }

        private void johnadamsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "John Adams" radio button is checked
            if (johnadamsRadioButton.Checked)
            {
                // Set the image location to the path of John Adams's image
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\JohnAdams.jpeg";
                // Set the picture box's size mode to stretch the image to fit
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void jamesbuchananRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "James Buchanan" radio button is checked
            if (jamesbuchananRadioButton.Checked)
            {
                // Set the image location to the path of James Buchanan's image
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\JamesBuchanan.jpeg";
                // Set the picture box's size mode to stretch the image to fit
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                // Navigate to James Buchanan's Wikipedia page
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
            }
        }

  // This method is called when the "George Bush" radio button is checked
private void georgebushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the radio button is checked, set the image location of the picture box to a file path,
            // set the picture box to stretch the image, and navigate to a Wikipedia page about George W. Bush
            if (georgebushRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\GeorgeWBush.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_W._Bush");
            }
        }

        // This method is called when the "Franklin Pierce" radio button is checked
        private void franklinpierceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the radio button is checked, set the image location of the picture box to a file path,
            // set the picture box to stretch the image, and navigate to a Wikipedia page about Franklin Pierce
            if (franklinpierceRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\FranklinPierce.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            }
        }

        // This method is called when the "Dwight D. Eisenhower" radio button is checked
        private void dwightdeisenhowerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If the radio button is checked, set the image location of the picture box to a file path and
            // set the picture box to stretch the image
            if (dwightdeisenhowerRadioButton.Checked)
            {
                pictureBox.ImageLocation = @"C:\Users\Wiz\Desktop\IGME 201\Presidents\Properties\DwightDEisenhower.jpeg";
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            
        // If the radio button is checked, navigate to a Wikipedia page about Dwight D. Eisenhower
if (dwightdeisenhowerRadioButton.Checked)
            {
                presidentwikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
            }
        }

        // This method is called when the mouse pointer hovers over the benjaminharrisonTextBox.
        private void benjaminharrisonTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text box is empty or null.
            if (string.IsNullOrEmpty(benjaminharrisonTextBox.Text))
            {
                // If the text box is empty or null, display a tooltip with the message "Which # President?".
                toolTip.Show("Which # President?", benjaminharrisonTextBox);
            }
        }

        // This method is called when the text in the franklindrooseveltTextBox changes.
        private void franklindrooseveltTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Check if the text in the franklindrooseveltTextBox can be converted to an integer.
            if (int.TryParse(franklindrooseveltTextBox.Text, out number))
            {
                // If the text can be converted to an integer and the value is 32, remove the error message.
                if (number == 32)
                {
                    errorProvider.SetError(franklindrooseveltTextBox, "");
                }
                // If the text can be converted to an integer but the value is not 32, display the error message "That is the wrong number".
                else
                {
                    errorProvider.SetError(franklindrooseveltTextBox, "That is the wrong number");
                }
            }
            // If the text cannot be converted to an integer, remove the error message.
            else
            {
                errorProvider.SetError(franklindrooseveltTextBox, "");
            }
        }

        // This method is called when the mouse pointer hovers over the franklindrooseveltTextBox.
        private void franklindrooseveltTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text box is empty or null.
            if (string.IsNullOrEmpty(franklindrooseveltTextBox.Text))
            {
                // If the text box is empty or null, display a tooltip with the message "Which # President?".
                toolTip.Show("Which # President?", franklindrooseveltTextBox);
            }
        }

        // This method is called when the text in the williamjclintonTextBox changes.
        private void williamjclintonTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Check if the text in the williamjclintonTextBox can be converted to an integer.
            if (int.TryParse(williamjclintonTextBox.Text, out number))
            {
                // If the text can be converted to an integer and the value is 42, remove the error message.
                if (number == 42)
                {
                    errorProvider.SetError(williamjclintonTextBox, "");
                }
                // If the text can be converted to an integer but the value is not 42, display the error message "That is the wrong number".
                else
                {
                    errorProvider.SetError(williamjclintonTextBox, "That is the wrong number");
                }
            }
            // If the text cannot be converted to an integer, remove the error message.
            else
            {
                errorProvider.SetError(williamjclintonTextBox, "");
            }
        }

        private void williamjclintonTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text box is empty or null
            if (string.IsNullOrEmpty(williamjclintonTextBox.Text))
            {
                // Show a tooltip message asking for the president number
                toolTip.Show("Which # President?", williamjclintonTextBox);
            }
        }

        private void barackobamaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Declare a variable to store the parsed number
            int number;

            // Try to parse the text in the text box into an integer
            if (int.TryParse(barackobamaTextBox.Text, out number))
            {
                // Check if the parsed number is equal to 44
                if (number == 44)
                {
                    // If it is, clear any error message
                    errorProvider.SetError(barackobamaTextBox, "");
                }
                else
                {
                    // If it's not, show an error message in the error provider control
                    errorProvider.SetError(barackobamaTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the text cannot be parsed into an integer, clear any error message
                errorProvider.SetError(barackobamaTextBox, "");
            }
        }

        private void barackobamaTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text box is empty or null
            if (string.IsNullOrEmpty(barackobamaTextBox.Text))
            {
                // Show a tooltip message asking for the president number
                toolTip.Show("Which # President?", barackobamaTextBox);
            }
        }

        private void williammckinleyTextBox_TextChanged(object sender, EventArgs e)
        {
            // Declare a variable to store the parsed number
            int number;

            // Try to parse the text in the text box into an integer
            if (int.TryParse(williammckinleyTextBox.Text, out number))
            {
                // Check if the parsed number is equal to 25
                if (number == 25)
                {
                    // If it is, clear any error message
                    errorProvider.SetError(williammckinleyTextBox, "");
                }
                else
                {
                    // If it's not, show an error message in the error provider control
                    errorProvider.SetError(williammckinleyTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the text cannot be parsed into an integer, clear any error message
                errorProvider.SetError(williammckinleyTextBox, "");
            }
        }

        private void williammckinleyTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text box is empty or null
            if (string.IsNullOrEmpty(williammckinleyTextBox.Text))
            {
                // Show a tooltip message asking for the president number
                toolTip.Show("Which # President?", williammckinleyTextBox);
            }
        }

        // This method is called when the text in the thomasjeffersonTextBox is changed.
        private void thomasjeffersonTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the textbox to an integer
            if (int.TryParse(thomasjeffersonTextBox.Text, out number))
            {
                // If the number is correct, remove any error messages
                if (number == 3)
                {
                    errorProvider.SetError(thomasjeffersonTextBox, "");
                }
                // If the number is incorrect, show an error message
                else
                {
                    errorProvider.SetError(thomasjeffersonTextBox, "That is the wrong number");
                }
            }
            // If the textbox is empty or contains non-numeric characters, remove any error messages
            else
            {
                errorProvider.SetError(thomasjeffersonTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the thomasjeffersonTextBox
        private void thomasjeffersonTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the textbox is empty, show a tooltip with a message
            if (string.IsNullOrEmpty(thomasjeffersonTextBox.Text))
            {
                toolTip.Show("Which # President?", thomasjeffersonTextBox);
            }
        }

        // This method is called when the text in the theodorerooseveltTextBox is changed.
        private void theodorerooseveltTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the textbox to an integer
            if (int.TryParse(theodorerooseveltTextBox.Text, out number))
            {
                // If the number is correct, remove any error messages
                if (number == 26)
                {
                    errorProvider.SetError(theodorerooseveltTextBox, "");
                }
                // If the number is incorrect, show an error message
                else
                {
                    errorProvider.SetError(theodorerooseveltTextBox, "That is the wrong number");
                }
            }
            // If the textbox is empty or contains non-numeric characters, remove any error messages
            else
            {
                errorProvider.SetError(theodorerooseveltTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the theodorerooseveltTextBox
        private void theodorerooseveltTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the textbox is empty, show a tooltip with a message
            if (string.IsNullOrEmpty(theodorerooseveltTextBox.Text))
            {
                toolTip.Show("Which # President?", theodorerooseveltTextBox);
            }
        }

        // This method is called when the text in the ronaldreaganTextBox is changed.
        private void ronaldreaganTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the textbox to an integer
            if (int.TryParse(ronaldreaganTextBox.Text, out number))
            {
                // If the number is correct, remove any error messages
                if (number == 40)
                {
                    errorProvider.SetError(ronaldreaganTextBox, "");
                }
                // If the number is incorrect, show an error message
                else
                {
                    errorProvider.SetError(ronaldreaganTextBox, "That is the wrong number");
                }
            }
            // If the textbox is empty or contains non-numeric characters, remove any error messages
            else
            {
                errorProvider.SetError(ronaldreaganTextBox, "");
            }
        }
        // This method is called when the mouse hovers over the ronaldreaganTextBox
        private void ronaldreaganTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text in the ronaldreaganTextBox is null or empty
            if (string.IsNullOrEmpty(ronaldreaganTextBox.Text))
            {
                // If it is, show a tooltip with the message "Which # President?" near the ronaldreaganTextBox
                toolTip.Show("Which # President?", ronaldreaganTextBox);
            }
        }

        // This method is called when the text in the martinvanburenTextBox is changed
        private void martinvanburenTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the martinvanburenTextBox as an integer
            if (int.TryParse(martinvanburenTextBox.Text, out number))
            {
                // If the parse is successful, check if the number is equal to 8 (which is the correct number for Martin Van Buren)
                if (number == 8)
                {
                    // If it is, clear any error message from the errorProvider for the martinvanburenTextBox
                    errorProvider.SetError(martinvanburenTextBox, "");
                }
                else
                {
                    // If it is not, set an error message for the martinvanburenTextBox using the errorProvider
                    errorProvider.SetError(martinvanburenTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the parse is not successful, clear any error message from the errorProvider for the martinvanburenTextBox
                errorProvider.SetError(martinvanburenTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the martinvanburenTextBox
        private void martinvanburenTextBox_MouseHover(object sender, EventArgs e)
        {
            // Check if the text in the martinvanburenTextBox is null or empty
            if (string.IsNullOrEmpty(martinvanburenTextBox.Text))
            {
                // If it is, show a tooltip with the message "Which # President?" near the martinvanburenTextBox
                toolTip.Show("Which # President?", martinvanburenTextBox);
            }
        }

        // This method is called when the text in the johnfkennedyTextBox is changed
        private void johnfkennedyTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the johnfkennedyTextBox as an integer
            if (int.TryParse(johnfkennedyTextBox.Text, out number))
            {
                // If the parse is successful, check if the number is equal to 35 (which is the correct number for John F. Kennedy)
                if (number == 35)
                {
                    // If it is, clear any error message from the errorProvider for the johnfkennedyTextBox
                    errorProvider.SetError(johnfkennedyTextBox, "");
                }
                else
                {
                    // If it is not, set an error message for the johnfkennedyTextBox using the errorProvider
                    errorProvider.SetError(johnfkennedyTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the parse is not successful, clear any error message from the errorProvider for the johnfkennedyTextBox
                errorProvider.SetError(johnfkennedyTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the johnfkennedyTextBox.
        // If the text in the johnfkennedyTextBox is null or empty, a tooltip is displayed 
        // with the message "Which # President?".
        private void johnfkennedyTextBox_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(johnfkennedyTextBox.Text))
            {
                toolTip.Show("Which # President?", johnfkennedyTextBox);
            }
        }

        // This method is called when the text in the johnadamsTextBox is changed.
        // If the text in the johnadamsTextBox can be parsed into an integer and the number is 2,
        // no error is shown.
        // Otherwise, an error message "That is the wrong number" is shown using the errorProvider.
        private void johnadamsTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(johnadamsTextBox.Text, out number))
            {
                if (number == 2)
                {
                    errorProvider.SetError(johnadamsTextBox, "");
                }
                else
                {
                    errorProvider.SetError(johnadamsTextBox, "That is the wrong number");
                }
            }
            else
            {
                errorProvider.SetError(johnadamsTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the johnadamsTextBox.
        // If the text in the johnadamsTextBox is null or empty, a tooltip is displayed 
        // with the message "Which # President?".
        private void johnadamsTextBox_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(johnadamsTextBox.Text))
            {
                toolTip.Show("Which # President?", johnadamsTextBox);
            }
        }

        // This method is called when the text in the James Buchanan text box is changed
        private void jamesbuchananTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the James Buchanan text box as an integer
            if (int.TryParse(jamesbuchananTextBox.Text, out number))
            {
                // If the parsed number is 15 (the correct number for James Buchanan), clear the error provider
                if (number == 15)
                {
                    errorProvider.SetError(jamesbuchananTextBox, "");
                }
                // Otherwise, show an error message in the error provider
                else
                {
                    errorProvider.SetError(jamesbuchananTextBox, "That is the wrong number");
                }
            }
            // If the text in the James Buchanan text box cannot be parsed as an integer, clear the error provider
            else
            {
                errorProvider.SetError(jamesbuchananTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the James Buchanan text box
        private void jamesbuchananTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the James Buchanan text box is empty or null, show a tooltip asking for the correct number
            if (string.IsNullOrEmpty(jamesbuchananTextBox.Text))
            {
                toolTip.Show("Which # President?", jamesbuchananTextBox);
            }
        }

        // This method is called when the text in the George W. Bush text box is changed
        private void georgewbushTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // Try to parse the text in the George W. Bush text box as an integer
            if (int.TryParse(georgewbushTextBox.Text, out number))
            {
                // If the parsed number is 43 (the correct number for George W. Bush), clear the error provider
                if (number == 43)
                {
                    errorProvider.SetError(georgewbushTextBox, "");
                }
                // Otherwise, show an error message in the error provider
                else
                {
                    errorProvider.SetError(georgewbushTextBox, "That is the wrong number");
                }
            }
            // If the text in the George W. Bush text box cannot be parsed as an integer, clear the error provider
            else
            {
                errorProvider.SetError(georgewbushTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the George W. Bush text box
        private void georgewbushTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the George W. Bush text box is empty or null, show a tooltip asking for the correct number
            if (string.IsNullOrEmpty(georgewbushTextBox.Text))
            {
                toolTip.Show("Which # President?", georgewbushTextBox);
            }
        }


        // This method is called when the text in the "George Washington" text box is changed.
        private void georgewashingtonTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // If the text in the box can be parsed into an integer, check if it is equal to 1.
            if (int.TryParse(georgewashingtonTextBox.Text, out number))
            {
                if (number == 1)
                {
                    // If the number is correct, clear the error message.
                    errorProvider.SetError(georgewashingtonTextBox, "");
                }
                else
                {
                    // If the number is incorrect, set the error message to inform the user.
                    errorProvider.SetError(georgewashingtonTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the text cannot be parsed into an integer, clear the error message.
                errorProvider.SetError(georgewashingtonTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the "George Washington" text box.
        private void georgewashingtonTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the text box is empty, show a tooltip with a prompt for the user.
            if (string.IsNullOrEmpty(georgewashingtonTextBox.Text))
            {
                toolTip.Show("Which # President?", georgewashingtonTextBox);
            }
        }

        // This method is called when the text in the "Franklin Pierce" text box is changed.
        private void franklinpierceTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            // If the text in the box can be parsed into an integer, check if it is equal to 14.
            if (int.TryParse(franklinpierceTextBox.Text, out number))
            {
                if (number == 14)
                {
                    // If the number is correct, clear the error message.
                    errorProvider.SetError(franklinpierceTextBox, "");
                }
                else
                {
                    // If the number is incorrect, set the error message to inform the user.
                    errorProvider.SetError(franklinpierceTextBox, "That is the wrong number");
                }
            }
            else
            {
                // If the text cannot be parsed into an integer, clear the error message.
                errorProvider.SetError(franklinpierceTextBox, "");
            }
        }

        // This method is called when the mouse hovers over the "Franklin Pierce" text box.
        private void franklinpierceTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the text box is empty, show a tooltip with a prompt for the user.
            if (string.IsNullOrEmpty(franklinpierceTextBox.Text))
            {
                toolTip.Show("Which # President?", franklinpierceTextBox);
            }
        }

        private void dwightdeisenhowerTextBox_TextChanged(object sender, EventArgs e)
        {
            // Declare a variable to hold the parsed integer value
            int number;

            // Try to parse the text in the textbox as an integer
            if (int.TryParse(dwightdeisenhowerTextBox.Text, out number))
            {
                // If the parsed value is correct, clear the error message
                if (number == 34)
                {
                    errorProvider.SetError(dwightdeisenhowerTextBox, "");
                }
                // If the parsed value is incorrect, display an error message
                else
                {
                    errorProvider.SetError(dwightdeisenhowerTextBox, "That is the wrong number");
                }
            }
            // If the text in the textbox cannot be parsed as an integer, clear the error message
            else
            {
                errorProvider.SetError(dwightdeisenhowerTextBox, "");
            }
        }

        private void dwightdeisenhowerTextBox_MouseHover(object sender, EventArgs e)
        {
            // If the textbox is empty, display a tooltip message
            if (string.IsNullOrEmpty(dwightdeisenhowerTextBox.Text))
            {
                toolTip.Show("Which # President?", dwightdeisenhowerTextBox);
            }
        }








    }
}
