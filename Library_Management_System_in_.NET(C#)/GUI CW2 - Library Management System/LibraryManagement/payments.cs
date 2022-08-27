using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlOperations;

namespace LibraryManagement
{
    public partial class payments : MetroFramework.Forms.MetroForm
    {
        public payments()
        {
            InitializeComponent();
        }

        payments p;
        SqlOperation sql = new SqlOperation();

        private void btn_saveGiveBook_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime get_date = Convert.ToDateTime(dp_getDate.Value.ToString("d"));
                DateTime due_date = Convert.ToDateTime(dp_dueDate.Value.ToString("d"));

                if (txt_batch.Text != "" && txt_bookName.Text != "" && txt_bookPrice.Text != "" && txt_mobile.Text != "" && txt_ricitID.Text != "" && txt_studentID.Text != "" && txt_studentName.Text != "" && txt_amount.Text != "")
                {
                    if (txt_mobile.Text.All(char.IsDigit) && txt_mobile.Text.Length == 10)
                    {
                        if (txt_studentName.Text.All(char.IsLetter))
                        {
                            sql.insert("insert into table_payments values('" + txt_ricitID.Text + "', '" + txt_studentID.Text + "', '" + txt_studentName.Text + "', '" + txt_batch.Text + "', '" + txt_mobile.Text + "' , '"+ txt_bookID.Text +"', '" + txt_bookName.Text + "' , '" + txt_bookPrice.Text + "' ,'" + get_date + "' , '" + due_date + "' , '" + txt_amount.Text + "')");
                            MetroFramework.MetroMessageBox.Show(this, "Payment Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please enter valid Member Name ..! The Member Name Can't Be Letters..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter valid Mobile Number..! The mobile Number Want Start With 0 and Length Must 10 Digits..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
