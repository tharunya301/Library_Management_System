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
    public partial class Administrator : MetroFramework.Forms.MetroForm
    {
        public Administrator()
        {
            InitializeComponent();
        }

        SubForm_ChangeUser cu = new SubForm_ChangeUser();
        SubForm_changeForget cf = new SubForm_changeForget();
        
        private void tile_changeUser_Click(object sender, EventArgs e)
        {
            cu.Show();
        }

        private void tile_forget_Click(object sender, EventArgs e)
        {
            cf.Show();
        }
    }
}
