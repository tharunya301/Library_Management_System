using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form_forgetPassword : MetroFramework.Forms.MetroForm
    {
        public Form_forgetPassword()
        {
            InitializeComponent();
        }

        class_admin admin = new class_admin();

        private void Form_forgetPassword_Load(object sender, EventArgs e)
        {
            lbl_qs.Text = admin.setQs();
        }

        #region enable_disable
        private void enable_disable()
        {
            //want modify
            if(txt_CurrentPass.Enabled == false && txt_CurrentUserName.Enabled == false && txt_newPass.Enabled == false && txt_newUser.Enabled == false && btn_hide.Enabled == false && btn_show.Enabled == false && button_Hide.Enabled == false && button_Show.Enabled == false && btn_genarate.Enabled == false && btn_change.Enabled == false)
            {
                txt_CurrentPass.Enabled = true;
                txt_CurrentUserName.Enabled = true;
                txt_newPass.Enabled = true;
                txt_newUser.Enabled = true;
                btn_hide.Enabled = true;
                btn_show.Enabled = true;
                button_Hide.Enabled = true;
                button_Show.Enabled = true;
                btn_genarate.Enabled = true;
                btn_change.Enabled = true;
            }
            else
            {
                if(admin.setAns() != txt_ans.Text)
                {
                    txt_CurrentPass.Enabled = false;
                    txt_CurrentUserName.Enabled = false;
                    txt_newPass.Enabled = false;
                    txt_newUser.Enabled = false;
                    btn_hide.Enabled = false;
                    btn_show.Enabled = false;
                    button_Hide.Enabled = false;
                    button_Show.Enabled = false;
                    btn_genarate.Enabled = false;
                    btn_change.Enabled = false;
                }
                
            }
        }

        private void txt_ans_TextChanged(object sender, EventArgs e)
        {
            if(admin.setAns() == txt_ans.Text)
            {
                enable_disable();
                txt_CurrentUserName.Text = admin.un();
                txt_CurrentPass.Text = admin.p();
            }
        }

        #endregion

        #region showHide
        private void button_Show_Click(object sender, EventArgs e)
        {
            if (txt_newPass.PasswordChar == '*')
            {
                button_Hide.BringToFront();
                txt_newPass.PasswordChar = '\0';
            }
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            if (txt_newPass.PasswordChar == '\0')
            {
                button_Show.BringToFront();
                txt_newPass.PasswordChar = '*';

            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_CurrentPass.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                txt_CurrentPass.PasswordChar = '\0';
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_CurrentPass.PasswordChar == '\0')
            {
                btn_show.BringToFront();
                txt_CurrentPass.PasswordChar = '*';
            }
        }
        #endregion

        #region generate
        public void passwordGenarate()
        {
            int length = 8;
            const string validCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

            StringBuilder result = new StringBuilder();
            Random random = new Random();
            while (0 < length--)
            {
                result.Append(validCharacters[random.Next(validCharacters.Length)]);
            }
            txt_newPass.Text = result.ToString();
        }

        private void btn_genarate_Click(object sender, EventArgs e)
        {
            passwordGenarate();
        }
        #endregion

        private void clear()
        {
            txt_ans.Text = "";
            txt_CurrentPass.Text = "";
            txt_CurrentUserName.Text = "";
            txt_newPass.Text = "";
            txt_newUser.Text = "";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_CurrentPass.Text != "" && txt_CurrentUserName.Text != "" && txt_newPass.Text != "" && txt_newUser.Text != "")
                {
                    if (txt_CurrentUserName.Text == admin.un() && txt_CurrentPass.Text == admin.p())
                    {
                        txt_newUser.Text = admin.setUname(txt_newUser.Text);
                        txt_newPass.Text = admin.setPass(txt_newPass.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Data Changed Successfull..Details are Correct", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please Enter Correct User Name and Password...!", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                    }

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Fields are empty. Please fill all the fields..!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
