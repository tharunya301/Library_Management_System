using SqlOperations;
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
    public partial class give_book : MetroFramework.Forms.MetroForm
    {
        public give_book()
        {
            InitializeComponent();
        }

        private void give_book_Load(object sender, EventArgs e)
        {
            
        }

        SqlOperation sql = new SqlOperation();
        String deactive = "Deactive";
        give_book gb;

        private void btn_saveGiveBook_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime get_date = Convert.ToDateTime(dp_getDate.Value.ToString("d"));
                DateTime due_date = Convert.ToDateTime(dp_dueDate.Value.ToString("d"));

                if (txt_batch.Text != "" && txt_bookName.Text != "" && txt_bookPrice.Text != "" && txt_mobile.Text != "" && txt_ricitID.Text != "" && txt_studentID.Text != "" && txt_studentName.Text != "")
                {
                    if(txt_mobile.Text.All(char.IsDigit) && txt_mobile.Text.Length == 10)
                    {
                        if(txt_studentName.Text.All(char.IsLetter))
                        {
                            if (dp_dueDate.Value.ToString("d") == DateTime.UtcNow.ToString("d"))
                            {
                                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are You Sure This Book Due Date Is Today ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (result == DialogResult.Yes)
                                {
                                    //check again
                                    if(Convert.ToString (sql.select("select status from table_student where id = '"+ txt_studentID.Text +"' ")) == deactive )
                                    {
                                        //invalid position
                                        DialogResult studentValidResult = MetroFramework.MetroMessageBox.Show(this, "Are You Sure Want To Give This Book ? , This Student Not Valid To Get Books Again.. Please Get Payment From This Student..", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                        if (studentValidResult == DialogResult.Yes)
                                        {
                                            sql.insert("insert into table_give values('" + txt_ricitID.Text + "', '" + txt_studentID.Text + "', '" + txt_studentName.Text + "', '" + txt_batch.Text + "', '" + txt_mobile.Text + "' , '" + txt_bookName.Text + "' , '" + txt_bookPrice.Text + "' ,'" + get_date + "' , '" + due_date + "')");
                                            MetroFramework.MetroMessageBox.Show(this, "Receipt Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            gb.Show();
                                        }
                                    }
                                    else
                                    {
                                        //valid position
                                        sql.insert("insert into table_give values('" + txt_ricitID.Text + "', '" + txt_studentID.Text + "', '" + txt_studentName.Text + "', '" + txt_batch.Text + "', '" + txt_mobile.Text + "' , '" + txt_bookName.Text + "' , '" + txt_bookPrice.Text + "' ,'" + get_date + "' , '" + due_date + "')");
                                        MetroFramework.MetroMessageBox.Show(this, "Receipt Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    
                                }
                                else if (result == DialogResult.No)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Select Correct Due Date Again..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                //date no same
                                if (Convert.ToString(sql.select("select status from table_student where id = '" + txt_studentID.Text + "' ")) != deactive)
                                {
                                    //valid position
                                    sql.insert("insert into table_give values('" + txt_ricitID.Text + "', '" + txt_studentID.Text + "', '" + txt_studentName.Text + "', '" + txt_batch.Text + "', '" + txt_mobile.Text + "' , '" + txt_bookName.Text + "' , '" + txt_bookPrice.Text + "' ,'" + get_date + "' , '" + due_date + "')");
                                    MetroFramework.MetroMessageBox.Show(this, "Receipt Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    //invalid position
                                    DialogResult studentValidResult = MetroFramework.MetroMessageBox.Show(this, "Are You Sure Want To Give This Book ? , This Student Not Valid To Get Books Again.. Please Get Payment From This Student..", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (studentValidResult == DialogResult.Yes)
                                    {
                                        sql.insert("insert into table_give values('" + txt_ricitID.Text + "', '" + txt_studentID.Text + "', '" + txt_studentName.Text + "', '" + txt_batch.Text + "', '" + txt_mobile.Text + "' , '" + txt_bookName.Text + "' , '" + txt_bookPrice.Text + "' ,'" + get_date + "' , '" + due_date + "')");
                                        MetroFramework.MetroMessageBox.Show(this, "Receipt Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
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
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_studentID_TextChanged(object sender, EventArgs e)
        {
            //chech again
            try
            {
                txt_studentName.Text = sql.select("select name from table_student where Id like '%"+ txt_studentID.Text +"%'").ToString();
                txt_mobile.Text = Convert.ToString(sql.select("select mobile from table_student where Id like '%" + txt_studentID.Text + "%'"));
                txt_batch.Text = Convert.ToString(sql.select("select batch from table_student where Id like '%" + txt_studentID.Text + "%'"));
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
