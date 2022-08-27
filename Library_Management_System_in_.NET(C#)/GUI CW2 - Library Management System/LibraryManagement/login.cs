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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }
        class_admin admin = new class_admin();
        home h = new home();
        Form_forgetPassword fp = new Form_forgetPassword();

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                    if (txt_username.Text != "" && txt_pass.Text != "")
                    {
                        if (txt_username.Text == admin.un() && txt_pass.Text == admin.p())
                        {
                            h.Show();
                            this.Hide();
                        }
                        if (txt_username.Text != admin.un() && txt_pass.Text == admin.p())
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please Enter Correct User Name..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (txt_username.Text == admin.un() && txt_pass.Text != admin.p())
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please Enter Correct Password..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Fields are empty. Please enter User Name and Password..!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_clickHere_Click(object sender, EventArgs e)
        {
            fp.Show();
        }
    }
}
