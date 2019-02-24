using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramStickersHelper
{
    public partial class pathForm : Form
    {
        public pathForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sValue = pathTextBox.Text;
            mainForm log = new mainForm(sValue);
            this.Close();
        }
    }
}
