using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace file_transfer
{

    /// <summary>
    /// Initialization component to our Catalog
    /// </summary>
    public partial class Catalog : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Initialize Components
        /// </summary>
        public Catalog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checked driver info
        /// </summary>
        /// <returns></returns>
        public Tuple<string, string, string> GetDirectory()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 1; i < drives.Length; i++)
            {
                if (drives[i].Name != "E:\\")
                {
                    diskButton1.Text = drives[0].ToString();
                    diskButton2.Text = drives[1].ToString();
                    diskButton3.Text = drives[i].ToString();
                }
            }
            return Tuple.Create(diskButton1.Text, diskButton2.Text, diskButton3.Text);
        }
        private void Catalog_Load(object sender, EventArgs e)
        {
            textBox.Text = "C:\\";
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 1; i < drives.Length; i++)
            {
                if (drives[i].Name != "E:\\")
                {
                    diskButton1.Text = drives[0].ToString();
                    diskButton2.Text = drives[1].ToString();
                    diskButton3.Text = drives[i].ToString();
                }
            }
        }

        /// <summary>
        /// Seaching for Directory
        /// </summary>
        /// <param name="direc"></param>
        /// <returns></returns>
        public string FindDirectory(string direc)
        {
            try
            {
                listBox.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(direc);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo folder in dirs)
                {
                    listBox.Items.Add(folder);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox.Items.Add(file);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot reach directory");
                textBox.Text = "C:\\";
            }

            return direc;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            FindDirectory(textBox.Text);
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox.Text = Path.Combine(textBox.Text, listBox.SelectedItem.ToString());
                if (Path.GetExtension(textBox.Text) == "")
                {
                    listBox.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo folder in dirs)
                    {
                        listBox.Items.Add(folder);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox.Items.Add(file);
                    }
                }

                else
                {
                    Process.Start(textBox.Text.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Can`t open file");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text[textBox.Text.Length - 1] == '\\')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    while (textBox.Text[textBox.Text.Length - 1] != '\\')
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    }
                }
                else if (textBox.Text[textBox.Text.Length - 1] != '\\')
                {
                    while (textBox.Text[textBox.Text.Length - 1] != '\\')
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    }
                }
                listBox.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo folder in dirs)
                {
                    listBox.Items.Add(folder);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox.Items.Add(file);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, first directory");
                textBox.Text = "C:\\";
            }
        }

        private void diskButton1_Click(object sender, EventArgs e)
        {
            var corteg = GetDirectory();
            textBox.Text = corteg.Item1.ToString();
            FindDirectory(textBox.Text);
        }

        private void diskButton2_Click(object sender, EventArgs e)
        {
            var corteg = GetDirectory();
            textBox.Text = corteg.Item2.ToString();
            FindDirectory(textBox.Text);
        }

        private void diskButton3_Click(object sender, EventArgs e)
        {
            var corteg = GetDirectory();
            textBox.Text = corteg.Item3.ToString();
            FindDirectory(textBox.Text);
        }
    }
}
