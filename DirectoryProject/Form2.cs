using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DirectoryProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ReadLines()
        {
            int i = tbText.Lines.Count();
            tbLineCount.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\Test";
            string path = null;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;

                string TxtFile = File.ReadAllText(path);
                tbText.Text = TxtFile;
            }

            ReadLines();
        }

        private void tbText_Changed(object sender, EventArgs e)
        {
            ReadLines();
        }

        private void button_Delete(object sender, EventArgs e)
        {
            tbText.Clear();
        }

        private void btnSaveAs(object sender, EventArgs e)
        {
            if(btnSave.Text == "Save As")
            {
                lblSave.Visible = true;
                tbSave.Visible = true;
                btnCancel.Visible = true;

                btnSave.Text = "Save";
            }
            else if(btnSave.Text == "Save")
            {
                string path = string.Format(@"D:\Test\" + tbSave.Text + ".txt");
                if (!(File.Exists(path)))
                {
                    File.Create(path);

                    lblSave.Visible = false;
                    tbSave.Visible = false;
                    btnCancel.Visible = false;
                    btnSave.Text = "Save As";
                    tbSave.Clear();
                }
                else
                    MessageBox.Show("This text file already exists. Please try another name.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblSave.Visible = false;
            tbSave.Visible = false;
            btnCancel.Visible = false;
            btnSave.Text = "Save As";
            tbSave.Clear();
        }
    }
}
