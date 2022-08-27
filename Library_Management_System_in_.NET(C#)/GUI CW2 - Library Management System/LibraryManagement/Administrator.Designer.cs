namespace LibraryManagement
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.tile_changeUser = new MetroFramework.Controls.MetroTile();
            this.tile_forget = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tile_changeUser
            // 
            this.tile_changeUser.ActiveControl = null;
            this.tile_changeUser.Location = new System.Drawing.Point(47, 85);
            this.tile_changeUser.Name = "tile_changeUser";
            this.tile_changeUser.Size = new System.Drawing.Size(235, 275);
            this.tile_changeUser.TabIndex = 0;
            this.tile_changeUser.Text = "Change User Details";
            this.tile_changeUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tile_changeUser.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_changeUser.TileImage")));
            this.tile_changeUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_changeUser.UseSelectable = true;
            this.tile_changeUser.UseTileImage = true;
            this.tile_changeUser.Click += new System.EventHandler(this.tile_changeUser_Click);
            // 
            // tile_forget
            // 
            this.tile_forget.ActiveControl = null;
            this.tile_forget.Location = new System.Drawing.Point(448, 85);
            this.tile_forget.Name = "tile_forget";
            this.tile_forget.Size = new System.Drawing.Size(235, 275);
            this.tile_forget.TabIndex = 1;
            this.tile_forget.Text = "Change Forget Password Destails";
            this.tile_forget.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tile_forget.TileImage = ((System.Drawing.Image)(resources.GetObject("tile_forget.TileImage")));
            this.tile_forget.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_forget.UseSelectable = true;
            this.tile_forget.UseTileImage = true;
            this.tile_forget.Click += new System.EventHandler(this.tile_forget_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tile_forget);
            this.Controls.Add(this.tile_changeUser);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tile_changeUser;
        private MetroFramework.Controls.MetroTile tile_forget;
    }
}