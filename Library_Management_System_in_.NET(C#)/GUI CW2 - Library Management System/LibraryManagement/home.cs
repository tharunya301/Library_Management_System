using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LibraryManagement
{
    public partial class home : MetroFramework.Forms.MetroForm
    {
        public home()
        {
            InitializeComponent();
        }

        book b = new book();
        students s = new students();
        give_book gb = new give_book();
        Administrator ad = new Administrator();
        payments p = new payments();

        private void tile_book_Click(object sender, EventArgs e)
        {
            b.Show();
        }

        private void tile_student_Click(object sender, EventArgs e)
        {
            s.Show();
        }

        private void tile_assign_Click(object sender, EventArgs e)
        {
            gb.Show();
        }

        private void tile_administrator_Click(object sender, EventArgs e)
        {
            ad.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            p.Show();
        }
    }
}
