using System;
using System.Windows.Forms;

namespace Encryption.Tool
{
    public partial class FrmEncryptionTool : Form
    {
        public FrmEncryptionTool()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtKey, "Enter 8 character long value.");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                btnApply.Enabled = false;
                var result = string.Empty;
                if (!string.IsNullOrEmpty(txtInput.Text))
                {
                    if (!string.IsNullOrEmpty(txtKey.Text))
                    {
                        StringEncryption.EncryptionKey = txtKey.Text.Trim();
                    }

                    var inputValue = txtInput.Text.Trim();

                    if (rbQueryString.Checked)
                    {
                        if (rbEncrypt.Checked)
                        {
                            result = StringEncryption.Encrypt(inputValue);
                        }
                        else
                        {
                            result = StringEncryption.Decrypt(inputValue);
                        }
                    }
                    //else
                    //{
                    //    if (rbEncrypt.Checked)
                    //    {
                    //        result = StringEncryption.GenerateHashWithSalt(inputValue);
                    //    }
                    //    else
                    //    {
                    //        result = StringEncryption.DecryptHashWithSalt(inputValue);
                    //    }
                    //}
                }
                txtResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnApply.Enabled = true;
            }
        }

        private void EncryptWithKey(bool value)
        {
            if(value)
            {
                label3.Text = "Key:";
            }
            else
            {
                label3.Text = "Salt:";
            }
        }

        private void rbQueryString_CheckedChanged(object sender, EventArgs e)
        {
            EncryptWithKey(rbQueryString.Checked);
        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            EncryptWithKey(rbQueryString.Checked);
        }


    }
}
