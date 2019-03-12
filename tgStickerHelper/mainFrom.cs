using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgStickerHelper
{
    public partial class mainFrom : Form
    {
        public mainFrom() // Initialize all the components and print the form in the center.
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void InitalizeOpenFileDialog(string path)
        {
            mainPath.Filter = "INI files|*.ini|TEXT files|*.txt";
            mainPath.Title = "Select the ini or text file!";
            mainPath.InitialDirectory = path;

            picPath.Filter = "PNG files|*.png"; //! add .jpg
            picPath.Title = "Select the image!";
            picPath.InitialDirectory = path;
        }

        public void reader()
        {
            var fileStream = mainPath.OpenFile();

            using (System.IO.StreamReader reader = new StreamReader(fileStream)) // reading and streaming the contents of the file.
            {
                richTextBox.Text = reader.ReadToEnd();
                reader.Close();
                fileStream.Close();
            }
        }

        private void pathFormButton_Click(object sender, EventArgs e)
        {
            using (pathForm path = new pathForm()) // Open another form.
            {
                if (path.ShowDialog() == DialogResult.OK)
                {
                    mainPathLabel.Text = "Path: " + path.pathValue;
                    InitalizeOpenFileDialog(path.pathValue); // Receives value from pathForm.
                }
            }
        }

        private void openTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainPath.ShowDialog() == DialogResult.OK) // It will only continue if you click "open".
                {
                    mainPathLabel.Text = "Path: " + mainPath.FileName; // Update the main path label.
                    textLabel.Text = "Name: " + mainPath.SafeFileName; // Update the name of the file.

                    if (mainPath.FileName.Contains(".ini") || mainPath.FileName.Contains(".txt")) // If the source file is an .ini or .txt file.
                    {
                        string pic = mainPath.FileName.Replace(".ini", ".png");

                        picPath.FileName = pic; // Update the pic path.
                        pictureBox.ImageLocation = pic; // Uploading picture.
                        picPathLabel.Text = picPath.FileName; // Upadte the name of the pic.

                        //if (pictureBox.Equals(null))
                            //MessageBox.Show("There is no picture!");
                    }

                    reader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk.\nOriginal error: " + ex.Message);
            }
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            if (mainPath.FileName.Contains(".ini") || mainPath.FileName.Contains(".txt"))
            {
                richTextBox.SaveFile(mainPath.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("This file was updated!");
            }
            else
            {
                MessageBox.Show("Please select a file!");
            }
        }

        private void newTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog newFile = new SaveFileDialog())
                {
                    newFile.DefaultExt = "*.ini";
                    newFile.Filter = "INI files|*.ini|TEXT files|*.txt";

                    if (newFile.ShowDialog() == DialogResult.OK && newFile.FileName.Length > 0)
                    {
                        richTextBox.SaveFile(newFile.FileName, RichTextBoxStreamType.PlainText);
                        MessageBox.Show("A new file was created!");

                        mainPath.FileName = newFile.FileName;
                        mainPathLabel.Text = "Path: " + newFile.FileName;
                        textLabel.Text = mainPath.SafeFileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: This file was not saved correctly!\nOriginal error: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            textLabel.Text = "Name: ";

            mainPath.FileName = null;
            picPath.FileName = null;

            mainPathLabel.Text = "Empty";
            picPathLabel.Text = "Empty";
        }

        private void updateNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textLabel.Text.Contains(".ini") || textLabel.Text.Contains(".txt")) && textLabel.Text != "") // If there was an old name and if the new value isn't null.
                {
                    newTextBox.Text += ".ini"; // add on.
                    string newName = newName = mainPath.FileName.Replace(mainPath.SafeFileName, newTextBox.Text);

                    System.IO.File.Move(mainPath.FileName, newName);
                    mainPath.FileName = newName;
                    textLabel.Text = "Name: " + mainPath.SafeFileName;
                    mainPathLabel.Text = "Current path: " + mainPath.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: The file is either invalid or the textbox is empty!\nOriginal error: " + ex.Message);
            }
        }

        private void loadPicButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (picPath.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.ImageLocation = picPath.FileName;
                    picPathLabel.Text = picPath.FileName;

                    mainPath.FileName = picPath.FileName.Replace(".png", ".ini");
                    mainPathLabel.Text = "Path: " + mainPath.FileName;
                    textLabel.Text = "Name: " + mainPath.SafeFileName;

                    reader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk.\nOriginal error: " + ex.Message);
            }
        }

        private void loadPic2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (picPath.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.ImageLocation = picPath.FileName;
                    picPathLabel.Text = picPath.FileName;

                    richTextBox.Text = "";
                    mainPath.FileName = "";
                    mainPathLabel.Text = "Empty: ";
                    textLabel.Text = "Name: ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk.\nOriginal error: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.ImageLocation != null)
            {
                string oldS = picPath.SafeFileName;
                string newS = picPath.SafeFileName.Replace(".png", "");
                int newN = Int32.Parse(newS);
                --newN;

                if(newN <= 0)
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    if (newN > 0 && 10 > newN)
                        newS = "00" + newN.ToString() + ".png";
                    else
                        newS = "0" + newN.ToString() + ".png";
                }

                picPath.FileName = picPath.FileName.Replace(oldS, newS);
                pictureBox.ImageLocation = picPath.FileName;
                picPathLabel.Text = picPath.FileName;
            }
            else
            {
                MessageBox.Show("Picture box needs to not be empty!");
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.ImageLocation != null)
            {
                string oldS = picPath.SafeFileName;
                string newS = picPath.SafeFileName.Replace(".png", "");
                int newN = Int32.Parse(newS);
                ++newN;

                if (newN > 0 && 10 > newN)
                    newS = "00" + newN.ToString() + ".png";
                else
                    newS = "0" + newN.ToString() + ".png";

                picPath.FileName = picPath.FileName.Replace(oldS, newS);
                pictureBox.ImageLocation = picPath.FileName;
                picPathLabel.Text = picPath.FileName;
            }
            else
            {
                MessageBox.Show("Picture box needs to not be empty!");
            }
        }
    }
}
