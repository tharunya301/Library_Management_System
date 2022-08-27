namespace LibraryManagement
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.tile_book = new MetroFramework.Controls.MetroTile();
            this.tile_student = new MetroFramework.Controls.MetroTile();
            this.tile_assign = new MetroFramework.Controls.MetroTile();
            this.tile_administrator = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_book
            // 
            this.tile_book.ActiveControl = null;
            this.tile_book.Location = new System.Drawing.Point(23, 77);
            this.tile_book.Name = "tile_book";
            this.tile_book.Size = new System.Drawing.Size(216, 158);
            this.tile_book.Style = MetroFramework.MetroColorStyle.Blue;
            this.tile_book.TabIndex = 0;
            this.tile_book.Text = "MANAGE BOOK";
            this.tile_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tile_book.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_book.TileImage")));
            this.tile_book.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_book.UseSelectable = true;
            this.tile_book.UseTileImage = true;
            this.tile_book.Click += new System.EventHandler(this.tile_book_Click);
            // 
            // tile_student
            // 
            this.tile_student.ActiveControl = null;
            this.tile_student.Location = new System.Drawing.Point(271, 77);
            this.tile_student.Name = "tile_student";
            this.tile_student.Size = new System.Drawing.Size(216, 158);
            this.tile_student.Style = MetroFramework.MetroColorStyle.Blue;
            this.tile_student.TabIndex = 1;
            this.tile_student.Text = "MANAGE STUDENTS";
            this.tile_student.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tile_student.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_student.TileImage")));
            this.tile_student.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_student.UseSelectable = true;
            this.tile_student.UseTileImage = true;
            this.tile_student.Click += new System.EventHandler(this.tile_student_Click);
            // 
            // tile_assign
            // 
            this.tile_assign.ActiveControl = null;
            this.tile_assign.Location = new System.Drawing.Point(517, 77);
            this.tile_assign.Name = "tile_assign";
            this.tile_assign.Size = new System.Drawing.Size(216, 158);
            this.tile_assign.Style = MetroFramework.MetroColorStyle.Blue;
            this.tile_assign.TabIndex = 2;
            this.tile_assign.Text = "GIVE";
            this.tile_assign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tile_assign.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_assign.TileImage")));
            this.tile_assign.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_assign.UseSelectable = true;
            this.tile_assign.UseTileImage = true;
            this.tile_assign.Click += new System.EventHandler(this.tile_assign_Click);
            // 
            // tile_administrator
            // 
            this.tile_administrator.ActiveControl = null;
            this.tile_administrator.Location = new System.Drawing.Point(23, 263);
            this.tile_administrator.Name = "tile_administrator";
            this.tile_administrator.Size = new System.Drawing.Size(216, 158);
            this.tile_administrator.Style = MetroFramework.MetroColorStyle.Blue;
            this.tile_administrator.TabIndex = 3;
            this.tile_administrator.Text = "ADMINISTRATOR";
            this.tile_administrator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tile_administrator.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_administrator.TileImage")));
            this.tile_administrator.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_administrator.UseSelectable = true;
            this.tile_administrator.UseTileImage = true;
            this.tile_administrator.Click += new System.EventHandler(this.tile_administrator_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(271, 263);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(216, 158);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "PAYMENTS";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(769, 475);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tile_administrator);
            this.Controls.Add(this.tile_assign);
            this.Controls.Add(this.tile_student);
            this.Controls.Add(this.tile_book);
            this.Name = "home";
            this.Text = "Home";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_book;
        private MetroFramework.Controls.MetroTile tile_student;
        private MetroFramework.Controls.MetroTile tile_assign;
        private MetroFramework.Controls.MetroTile tile_administrator;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}