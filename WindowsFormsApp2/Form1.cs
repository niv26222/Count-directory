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
using CsvHelper;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string dir = textBox1.Text;


            string[] dirs = Directory.GetDirectories(dir, "*", SearchOption.AllDirectories);



            for (int i = 0; i < dirs.Length; i++)
            {

                string lastFolderName = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(dirs[i]));

                if ( dirs[i] != null)
                {

                    txtOutput.Text += "Folder Path is: " + dirs[i] + Environment.NewLine;

                    int countDirectoryTop = Directory.GetDirectories(dirs[i], "*", SearchOption.TopDirectoryOnly).Count();

                    int countDirectoryAll = Directory.GetDirectories(dirs[i], "*", SearchOption.AllDirectories).Count();

                    if (countDirectoryTop > 0)
                    {
                                            
                        txtOutput.Text += "Number of Folders are: " + countDirectoryTop + Environment.NewLine;
                    }

                    if (countDirectoryAll > 0)
                    {
                        txtOutput.Text += "Number of Folders in all path are : " + countDirectoryAll + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    }                   
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.SelectedPath;
                //ofd.SelectedPath = sourceFolder;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
