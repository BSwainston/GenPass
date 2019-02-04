//Created by: Bryan Swainston
//Creation Date: 2-3-2019
//Last Modified Date: 2-4-2019
//Version 1.1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenPass
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            lblVersion.Text = "Version 1.1";
            if (chkBoxAll.Checked == false & chkBoxCustom.Checked == false)
            {
                btnGenPass.Enabled = false;
            }
            else
            {
                btnGenPass.Enabled = true;
            }
        }
        private void BtnGenPass_Click(object sender, EventArgs e)
        {
            int length;
            if (int.TryParse(txtBoxLength.Text, out length))
            {
                if (length < 401)
                {
                    if (chkBoxAll.Checked == true)
                    {
                        if (chkBoxSpecial.Checked == true)
                        {
                            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                            int i = 0;

                            StringBuilder res = new StringBuilder();
                            Random rnd = new Random();
                            while (i < length)
                            {
                                res.Append(valid[rnd.Next(valid.Length)]);
                                ++i;
                            }
                            txtBoxGenerator.Text = res.ToString();
                        }
                        else
                        {
                            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&* ";
                            int i = 0;

                            StringBuilder res = new StringBuilder();
                            Random rnd = new Random();
                            while (i < length)
                            {
                                res.Append(valid[rnd.Next(valid.Length)]);
                                ++i;
                            }
                            txtBoxGenerator.Text = res.ToString();
                        }


                    }
                    else if (chkBoxCustom.Checked == true)
                    {
                        string valid = txtBoxCustom.Text;
                        int i = 0;

                        StringBuilder res = new StringBuilder();
                        Random rnd = new Random();
                        while (i < length)
                        {
                            res.Append(valid[rnd.Next(valid.Length)]);
                            ++i;
                        }
                        txtBoxGenerator.Text = res.ToString();
                    }
                    else if (chkBoxAll.Checked == false & chkBoxCustom.Checked == false)
                    {
                        MessageBox.Show("Please choose between using all characters, or a custom list of characters, and check the appropriate box.",
                                        "Error",
                                        MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Numbers over 400 are not permitted.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtBoxLength.Text))
                {
                    MessageBox.Show("Please enter your desired password length.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please enter numbers only in the text box.", "Error", MessageBoxButtons.OK);
                }

            }
        }
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxGenerator.Text))
            {
                MessageBox.Show("Nothing to copy.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Clipboard.SetText(txtBoxGenerator.Text);
                MessageBox.Show("Password Copied to Clipboard.", "Copied", MessageBoxButtons.OK);
            }

        }

        private void ChkBoxCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCustom.Checked == true)
            {
                chkBoxAll.Checked = false;
                grpBoxCustom.Enabled = true;
                chkBoxSpecial.Enabled = false;
                btnGenPass.Enabled = true;
            }
            else
            {
                grpBoxCustom.Enabled = false;
                chkBoxAll.Checked = true;
            }

        }

        private void ChkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAll.Checked == true)
            {
                chkBoxCustom.Checked = false;
                grpBoxCustom.Enabled = false;
                chkBoxSpecial.Enabled = true;
                btnGenPass.Enabled = true;
            }
            else
            {
                chkBoxCustom.Checked = true;
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Using GENPASS!!!"
                            + "\n"
                            + "Please email any suggestions to bryandswainston@gmail.com"
                            + "\n"
                            + ""
                            + "\n"
                            + "Created by: Bryan Swainston"
                            + "\n"
                            + "Creation Date: 2-3-2019"
                            + "\n"
                            + "Last Modified Date: 2-4-2019"
                            + "\n"
                            + "Version 1.1", "About");
        }
    }
}
