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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TreeNode PopulateTreeView(DirectoryInfo dirInfo)
        {
            var directoryNode = new TreeNode(dirInfo.Name);
            foreach (var subdir in dirInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(PopulateTreeView(subdir));
            }

            foreach (var file in dirInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            var root = new DirectoryInfo(@"D:\RefStudy");
            treeView1.Nodes.Add(PopulateTreeView(root));
        }

        private void btnOpenMain(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
