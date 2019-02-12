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
    public partial class formExcel : Form
    {
        public formExcel()
        {
            InitializeComponent();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog excel = new OpenFileDialog();
                excel.DefaultExt = "*.ods";
                excel.Filter = "ODS Files|*.ods";

                if (excel.ShowDialog() == DialogResult.OK)
                {
                    DataTable tb = new DataTable();

                    dataGridView.DataSource = excel.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: ");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
