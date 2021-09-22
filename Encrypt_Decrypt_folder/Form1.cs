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
using System.Security.AccessControl;

namespace Encrypt_Decrypt_folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                txt_find.Text = fbd.SelectedPath;
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (txt_find.Text == "")
            { 
            MessageBox.Show("First select a folder for encrypt", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_find.Focus();
            }
            else 
            {

                try
                {
                    string folderPosition = txt_find.Text;
                    string userName = Environment.UserName;

                    DirectoryInfo dInfo = new DirectoryInfo(folderPosition);

                    DirectorySecurity dSecurity = dInfo.GetAccessControl();

                    dInfo.SetAccessControl(dSecurity);
                    DirectorySecurity ds = dInfo.GetAccessControl();
                    FileSystemAccessRule fsar = new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsar);
                    dInfo.SetAccessControl(ds);
                    MessageBox.Show("Your folder locked.", "Mission Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (txt_find.Text == "")
            {
                MessageBox.Show("First select a folder for decrypt", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_find.Focus();
            }
            else
            {

                try
                {
                    string folderPosition = txt_find.Text;
                    string userName = Environment.UserName;

                    DirectoryInfo dInfo = new DirectoryInfo(folderPosition);

                    DirectorySecurity dSecurity = dInfo.GetAccessControl();

                    dInfo.SetAccessControl(dSecurity);
                    DirectorySecurity ds = dInfo.GetAccessControl();
                    FileSystemAccessRule fsar = new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsar);
                    dInfo.SetAccessControl(ds);
                    MessageBox.Show("Your folder not locked.", "Mission Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
