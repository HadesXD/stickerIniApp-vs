using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelegramStickersHelper
{
    public partial class mainForm : Form
    {
        public mainForm() // initial constructor used by mainForm.
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public mainForm(string sValue)
        {
            InitializeComponent();
            MessageBox.Show(sValue);
            mainPath.Text = "Current path is: " + sValue;
        }

        public void InitalizeOpenFileDialog()
        {
            textFile.Filter = "INI files|*.ini";
            textFile.Title = "Select the ini file";
            textFile.InitialDirectory = @"D:\Stickers\Nowandlater\SFW\";

            picFile.Filter = "PNG files|*.png";
            picFile.Title = "Select the picture";
            picFile.InitialDirectory = @"D:\Stickers\Nowandlater\SFW\";
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            pathForm log = new pathForm();
            log.ShowDialog();
        }

        private void openTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textFile.ShowDialog() == DialogResult.OK) //it will only continue if you click "open"
                {
                    labelOldText.Text = "Current name: " + textFile.SafeFileName;
                    mainPath.Text = "Current path: " + textFile.FileName;
                    String pic = textFile.FileName.Substring(0, textFile.FileName.Length - 4);
                    pictureBox.ImageLocation = pic + ".png";
                    picFile.FileName = pic + ".png";
                    labelPicPath.Text = picFile.FileName;

                    var fileStream = textFile.OpenFile();

                    using (System.IO.StreamReader reader = new StreamReader(fileStream))
                    {
                        richTextBox.Text = reader.ReadToEnd();
                        reader.Close();
                        fileStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void loadPicButton_Click(object sender, EventArgs e)
        {

            try
            { 
                if (picFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = picFile.FileName;
                labelPicPath.Text = picFile.FileName;
                textFile.FileName = "";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            if (textFile.FileName != null)
            {
                richTextBox.SaveFile(textFile.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("This .ini file was updated!");
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.ini";
            save.Filter = "INI Files|*.ini";

            if (save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
            {
                richTextBox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                mainPath.Text = textFile.FileName;
                labelOldText.Text = textFile.SafeFileName;
                labelNewText.Text = "New name: ";
            }
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            if (newTextBox.Text != "" && textFile.FileName != "textFile")
            {
                newTextBox.Text += ".ini";
                String newFile = textFile.InitialDirectory + newTextBox.Text;
                System.IO.File.Move(textFile.FileName, newFile);
                labelOldText.Text = "Old name: " + textFile.SafeFileName;
                textFile.FileName = newFile;
                mainPath.Text = "Current path: " + textFile.FileName;
                labelNewText.Text = "Current name: " + textFile.SafeFileName;
            }
            else
            {
                MessageBox.Show("Work nigga");
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            /*DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = loadedImage.Height;
                        pb.Width = loadedImage.Width;
                        pb.Image = loadedImage;
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }*/
        }

        private void nextPicButton_Click(object sender, EventArgs e)
        {
            string newS = picFile.SafeFileName.Substring(0, picFile.SafeFileName.Length - 4);
            picFile.FileName = picFile.FileName.Substring(0, picFile.FileName.Length - 7);
            int newPath = Int32.Parse(newS);
            newPath += 1;
            if (newPath < 10)
            {
                labelNewText.Text = "00" + newPath.ToString() + ".png";
                picFile.FileName += "00" + newPath.ToString() + ".png";
                pictureBox.ImageLocation = picFile.FileName;
                labelPicPath.Text = picFile.FileName;
                string temp = picFile.FileName.Substring(0, picFile.FileName.Length - 4);
                textFile.FileName = temp + ".ini";
                mainPath.Text = textFile.FileName;
                picIni();

            }
            else
            {
                labelNewText.Text = "0" + newPath.ToString() + ".png";
                picFile.FileName += "0" + newPath.ToString() + ".png";
                pictureBox.ImageLocation = picFile.FileName;
                labelPicPath.Text = picFile.FileName;
                string temp = picFile.FileName.Substring(0, picFile.FileName.Length - 4);
                textFile.FileName = temp + ".ini";
                mainPath.Text = textFile.FileName;
                picIni();
            }

        }

        public void picIni()
        {
            var fileStream = textFile.OpenFile();

            using (System.IO.StreamReader reader = new StreamReader(fileStream))
            {
                richTextBox.Text = reader.ReadToEnd();
                reader.Close();
                fileStream.Close();
            }
        }
    }
}
