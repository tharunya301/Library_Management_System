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
    public partial class book : MetroFramework.Forms.MetroForm
    {
        public book()
        {
            InitializeComponent();
        }

        bool MenuSwitch;
        SqlOperation sql = new SqlOperation();
        int ID = 0;

        private void book_Load(object sender, EventArgs e)
        {
            try
            {
                MenuSwitch = true;
                pnl_addBook.Hide();
                dataGridView.DataSource = sql.select("select * from table_book");
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Can't Display Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #region StripMenu
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuSwitch == true)
            {
                pnl_viewBooks.Show();
                pnl_addBook.Hide();
                MenuSwitch = false;
            }
            else if (MenuSwitch == false)
            {
                pnl_viewBooks.Hide();
                pnl_addBook.Hide();
                MenuSwitch = true;
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuSwitch == true)
            {
                pnl_viewBooks.Hide();
                pnl_addBook.Show();
                MenuSwitch = false;
            }
            else if (MenuSwitch == false)
            {
                pnl_viewBooks.Hide();
                pnl_addBook.Hide();
                MenuSwitch = true;
            }
            
        }
        #endregion
        #region insert_update_delete
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_addBookID.Text != "" && txt_addBookName.Text != "" && txt_addBookPrice.Text != "" && txt_addBookQty.Text != "" && txt_addPublishedYear.Text != "" && txt_addPublisherName.Text != "" )
                {
                    if(txt_addPublishedYear.Text.All(char.IsDigit) && txt_addBookQty.Text.All(char.IsDigit))
                    {
                        sql.insert("insert into table_book values('" + txt_addBookID.Text + "', '" + txt_addBookName.Text + "', '" + txt_addDescription.Text + "', '" + txt_addPublisherName.Text + "', '" + txt_addPublishedYear.Text + "' , '"+ txt_addBookPrice.Text +"' , '"+ txt_addBookQty.Text +"')");
                        dataGridView.DataSource = sql.select("select * from table_book");
                        MetroFramework.MetroMessageBox.Show(this, "Book Data Saved Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter valid Years , Prices and Quantities..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_name.Text != "" && txt_bookPrice.Text != "" && txt_qty.Text != "" && txt_publishedYear.Text != "" && txt_publisherName.Text != "" && txt_description.Text != "")
                {
                    if(txt_addPublishedYear.Text.All(char.IsDigit) && txt_addBookPrice.Text.All(char.IsDigit) && txt_addBookQty.Text.All(char.IsDigit))
                    {
                        sql.update("update table_book set name = '" + txt_name.Text + "' ,  description = '" + txt_description.Text + "' , publisher = '" + txt_publisherName.Text + "', publisher_year = '" + txt_publishedYear.Text + "' , price = '" + txt_bookPrice.Text + "' , qty = '" + txt_qty.Text + "'  where book_id = '" + ID + "';");
                        MetroFramework.MetroMessageBox.Show(this, "Book Data Updated Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView.DataSource = sql.select("select * from table_book");
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter valid Years , Prices and Quantities..!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Fields are empty. Please fill all the fields Before Update..!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (ID != 0)
                {
                        sql.delete("delete from table_book where book_id = '" + ID + "' ");
                        MetroFramework.MetroMessageBox.Show(this, "Book Data Deleted Successfully..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Fields are empty. Please fill all the fields Before Delete..!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
