namespace LibraryManagement
{
    partial class Form_forgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_forgetPassword));
            this.txt_ans = new MetroFramework.Controls.MetroTextBox();
            this.lbl_qs = new MetroFramework.Controls.MetroLabel();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Hide = new System.Windows.Forms.Button();
            this.btn_genarate = new MetroFramework.Controls.MetroButton();
            this.btn_change = new MetroFramework.Controls.MetroButton();
            this.txt_newPass = new MetroFramework.Controls.MetroTextBox();
            this.txt_newUser = new MetroFramework.Controls.MetroTextBox();
            this.txt_CurrentPass = new MetroFramework.Controls.MetroTextBox();
            this.txt_CurrentUserName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txt_ans
            // 
            // 
            // 
            // 
            this.txt_ans.CustomButton.Image = null;
            this.txt_ans.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txt_ans.CustomButton.Name = "";
            this.txt_ans.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ans.CustomButton.TabIndex = 1;
            this.txt_ans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ans.CustomButton.UseSelectable = true;
            this.txt_ans.CustomButton.Visible = false;
            this.txt_ans.Lines = new string[0];
            this.txt_ans.Location = new System.Drawing.Point(13, 106);
            this.txt_ans.MaxLength = 32767;
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.PasswordChar = '\0';
            this.txt_ans.PromptText = "Answere";
            this.txt_ans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ans.SelectedText = "";
            this.txt_ans.SelectionLength = 0;
            this.txt_ans.SelectionStart = 0;
            this.txt_ans.ShortcutsEnabled = true;
            this.txt_ans.Size = new System.Drawing.Size(372, 23);
            this.txt_ans.TabIndex = 5;
            this.txt_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ans.UseSelectable = true;
            this.txt_ans.WaterMark = "Answere";
            this.txt_ans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ans.TextChanged += new System.EventHandler(this.txt_ans_TextChanged);
            // 
            // lbl_qs
            // 
            this.lbl_qs.AutoSize = true;
            this.lbl_qs.Location = new System.Drawing.Point(13, 73);
            this.lbl_qs.Name = "lbl_qs";
            this.lbl_qs.Size = new System.Drawing.Size(15, 19);
            this.lbl_qs.TabIndex = 4;
            this.lbl_qs.Text = "-";
            // 
            // btn_show
            // 
            this.btn_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_show.BackgroundImage")));
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_show.Enabled = false;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(348, 182);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(37, 25);
            this.btn_show.TabIndex = 29;
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hide.BackgroundImage")));
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hide.Enabled = false;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Location = new System.Drawing.Point(348, 182);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(37, 25);
            this.btn_hide.TabIndex = 30;
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // button_Show
            // 
            this.button_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Show.BackgroundImage")));
            this.button_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Show.Enabled = false;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show.Location = new System.Drawing.Point(348, 267);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(37, 25);
            this.button_Show.TabIndex = 27;
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Hide
            // 
            this.button_Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Hide.BackgroundImage")));
            this.button_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Hide.Enabled = false;
            this.button_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Hide.Location = new System.Drawing.Point(348, 267);
            this.button_Hide.Name = "button_Hide";
            this.button_Hide.Size = new System.Drawing.Size(37, 25);
            this.button_Hide.TabIndex = 28;
            this.button_Hide.UseVisualStyleBackColor = true;
            this.button_Hide.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // btn_genarate
            // 
            this.btn_genarate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_genarate.BackgroundImage")));
            this.btn_genarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_genarate.Enabled = false;
            this.btn_genarate.Location = new System.Drawing.Point(13, 308);
            this.btn_genarate.Name = "btn_genarate";
            this.btn_genarate.Size = new System.Drawing.Size(372, 32);
            this.btn_genarate.TabIndex = 26;
            this.btn_genarate.Text = "Genarate Password";
            this.btn_genarate.UseSelectable = true;
            this.btn_genarate.Click += new System.EventHandler(this.btn_genarate_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_change.BackgroundImage")));
            this.btn_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_change.Enabled = false;
            this.btn_change.Location = new System.Drawing.Point(13, 353);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(372, 32);
            this.btn_change.TabIndex = 25;
            this.btn_change.Text = "Save Changes";
            this.btn_change.UseSelectable = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_newPass
            // 
            // 
            // 
            // 
            this.txt_newPass.CustomButton.Image = null;
            this.txt_newPass.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txt_newPass.CustomButton.Name = "";
            this.txt_newPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newPass.CustomButton.TabIndex = 1;
            this.txt_newPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newPass.CustomButton.UseSelectable = true;
            this.txt_newPass.CustomButton.Visible = false;
            this.txt_newPass.Enabled = false;
            this.txt_newPass.Lines = new string[0];
            this.txt_newPass.Location = new System.Drawing.Point(13, 269);
            this.txt_newPass.MaxLength = 32767;
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '*';
            this.txt_newPass.PromptText = "New Password";
            this.txt_newPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newPass.SelectedText = "";
            this.txt_newPass.SelectionLength = 0;
            this.txt_newPass.SelectionStart = 0;
            this.txt_newPass.ShortcutsEnabled = true;
            this.txt_newPass.Size = new System.Drawing.Size(329, 23);
            this.txt_newPass.TabIndex = 24;
            this.txt_newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_newPass.UseSelectable = true;
            this.txt_newPass.WaterMark = "New Password";
            this.txt_newPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_newUser
            // 
            // 
            // 
            // 
            this.txt_newUser.CustomButton.Image = null;
            this.txt_newUser.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txt_newUser.CustomButton.Name = "";
            this.txt_newUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newUser.CustomButton.TabIndex = 1;
            this.txt_newUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newUser.CustomButton.UseSelectable = true;
            this.txt_newUser.CustomButton.Visible = false;
            this.txt_newUser.Enabled = false;
            this.txt_newUser.Lines = new string[0];
            this.txt_newUser.Location = new System.Drawing.Point(13, 228);
            this.txt_newUser.MaxLength = 32767;
            this.txt_newUser.Name = "txt_newUser";
            this.txt_newUser.PasswordChar = '\0';
            this.txt_newUser.PromptText = "New User Name";
            this.txt_newUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newUser.SelectedText = "";
            this.txt_newUser.SelectionLength = 0;
            this.txt_newUser.SelectionStart = 0;
            this.txt_newUser.ShortcutsEnabled = true;
            this.txt_newUser.Size = new System.Drawing.Size(372, 23);
            this.txt_newUser.TabIndex = 23;
            this.txt_newUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_newUser.UseSelectable = true;
            this.txt_newUser.WaterMark = "New User Name";
            this.txt_newUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_CurrentPass
            // 
            // 
            // 
            // 
            this.txt_CurrentPass.CustomButton.Image = null;
            this.txt_CurrentPass.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txt_CurrentPass.CustomButton.Name = "";
            this.txt_CurrentPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_CurrentPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CurrentPass.CustomButton.TabIndex = 1;
            this.txt_CurrentPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CurrentPass.CustomButton.UseSelectable = true;
            this.txt_CurrentPass.CustomButton.Visible = false;
            this.txt_CurrentPass.Enabled = false;
            this.txt_CurrentPass.Lines = new string[0];
            this.txt_CurrentPass.Location = new System.Drawing.Point(13, 184);
            this.txt_CurrentPass.MaxLength = 32767;
            this.txt_CurrentPass.Name = "txt_CurrentPass";
            this.txt_CurrentPass.PasswordChar = '*';
            this.txt_CurrentPass.PromptText = "Current Password";
            this.txt_CurrentPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CurrentPass.SelectedText = "";
            this.txt_CurrentPass.SelectionLength = 0;
            this.txt_CurrentPass.SelectionStart = 0;
            this.txt_CurrentPass.ShortcutsEnabled = true;
            this.txt_CurrentPass.Size = new System.Drawing.Size(329, 23);
            this.txt_CurrentPass.TabIndex = 22;
            this.txt_CurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CurrentPass.UseSelectable = true;
            this.txt_CurrentPass.WaterMark = "Current Password";
            this.txt_CurrentPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CurrentPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_CurrentUserName
            // 
            // 
            // 
            // 
            this.txt_CurrentUserName.CustomButton.Image = null;
            this.txt_CurrentUserName.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txt_CurrentUserName.CustomButton.Name = "";
            this.txt_CurrentUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_CurrentUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CurrentUserName.CustomButton.TabIndex = 1;
            this.txt_CurrentUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CurrentUserName.CustomButton.UseSelectable = true;
            this.txt_CurrentUserName.CustomButton.Visible = false;
            this.txt_CurrentUserName.Enabled = false;
            this.txt_CurrentUserName.Lines = new string[0];
            this.txt_CurrentUserName.Location = new System.Drawing.Point(13, 143);
            this.txt_CurrentUserName.MaxLength = 32767;
            this.txt_CurrentUserName.Name = "txt_CurrentUserName";
            this.txt_CurrentUserName.PasswordChar = '\0';
            this.txt_CurrentUserName.PromptText = "User Name";
            this.txt_CurrentUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CurrentUserName.SelectedText = "";
            this.txt_CurrentUserName.SelectionLength = 0;
            this.txt_CurrentUserName.SelectionStart = 0;
            this.txt_CurrentUserName.ShortcutsEnabled = true;
            this.txt_CurrentUserName.Size = new System.Drawing.Size(372, 23);
            this.txt_CurrentUserName.TabIndex = 21;
            this.txt_CurrentUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CurrentUserName.UseSelectable = true;
            this.txt_CurrentUserName.WaterMark = "User Name";
            this.txt_CurrentUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CurrentUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form_forgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 419);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_Hide);
            this.Controls.Add(this.btn_genarate);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.txt_newUser);
            this.Controls.Add(this.txt_CurrentPass);
            this.Controls.Add(this.txt_CurrentUserName);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.lbl_qs);
            this.Name = "Form_forgetPassword";
            this.Text = "Forget Your Password..?";
            this.Load += new System.EventHandler(this.Form_forgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_ans;
        private MetroFramework.Controls.MetroLabel lbl_qs;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Hide;
        private MetroFramework.Controls.MetroButton btn_genarate;
        private MetroFramework.Controls.MetroButton btn_change;
        private MetroFramework.Controls.MetroTextBox txt_newPass;
        private MetroFramework.Controls.MetroTextBox txt_newUser;
        private MetroFramework.Controls.MetroTextBox txt_CurrentPass;
        private MetroFramework.Controls.MetroTextBox txt_CurrentUserName;
    }
}