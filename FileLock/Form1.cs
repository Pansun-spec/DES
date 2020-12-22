using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace FileLock
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            string inFile = txtFileName.Text;
            string outFile = inFile + ".txt";
            string password = txtPassword.Text;
            FileLock.DESFileClass.EncryptFile(inFile, outFile, password);//Encrypt file
            //delete old file
            File.Delete(inFile);
            txtFileName.Text = string.Empty;
            MessageBox.Show("Encrypt successfully");
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            string inFile = txtFileName.Text;
            string outFile = inFile.Substring(0, inFile.Length - 4);
            string password = txtPassword.Text;
            FileLock.DESFileClass.DecryptFile(inFile, outFile, password);//Decrypt file
            //delete old file
            File.Delete(inFile);
            txtFileName.Text = string.Empty;
            MessageBox.Show("Decrypt successfully");
        }

        
    }
}
