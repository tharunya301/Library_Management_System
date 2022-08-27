namespace LibraryManagement
{
    partial class payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payments));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dp_dueDate = new MetroFramework.Controls.MetroDateTime();
            this.dp_getDate = new MetroFramework.Controls.MetroDateTime();
            this.btn_saveGiveBook = new MetroFramework.Controls.MetroButton();
            this.txt_bookID = new MetroFramework.Controls.MetroTextBox();
            this.txt_bookPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_bookName = new MetroFramework.Controls.MetroTextBox();
            this.txt_mobile = new MetroFramework.Controls.MetroTextBox();
            this.txt_batch = new MetroFramework.Controls.MetroTextBox();
            this.txt_studentName = new MetroFramework.Controls.MetroTextBox();
            this.txt_studentID = new MetroFramework.Controls.MetroTextBox();
            this.txt_ricitID = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_amount = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.dp_dueDate);
            this.groupBox1.Controls.Add(this.dp_getDate);
            this.groupBox1.Controls.Add(this.btn_saveGiveBook);
            this.groupBox1.Controls.Add(this.txt_bookID);
            this.groupBox1.Controls.Add(this.txt_bookPrice);
            this.groupBox1.Controls.Add(this.txt_bookName);
            this.groupBox1.Controls.Add(this.txt_mobile);
            this.groupBox1.Controls.Add(this.txt_batch);
            this.groupBox1.Controls.Add(this.txt_studentName);
            this.groupBox1.Controls.Add(this.txt_studentID);
            this.groupBox1.Controls.Add(this.txt_ricitID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Ricit";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(433, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Due Date:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(433, 166);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Get Date:";
            // 
            // dp_dueDate
            // 
            this.dp_dueDate.Location = new System.Drawing.Point(502, 225);
            this.dp_dueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dp_dueDate.Name = "dp_dueDate";
            this.dp_dueDate.Size = new System.Drawing.Size(233, 29);
            this.dp_dueDate.TabIndex = 23;
            // 
            // dp_getDate
            // 
            this.dp_getDate.Location = new System.Drawing.Point(502, 159);
            this.dp_getDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dp_getDate.Name = "dp_getDate";
            this.dp_getDate.Size = new System.Drawing.Size(233, 29);
            this.dp_getDate.TabIndex = 22;
            // 
            // btn_saveGiveBook
            // 
            this.btn_saveGiveBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saveGiveBook.BackgroundImage")));
            this.btn_saveGiveBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveGiveBook.Location = new System.Drawing.Point(433, 361);
            this.btn_saveGiveBook.Name = "btn_saveGiveBook";
            this.btn_saveGiveBook.Size = new System.Drawing.Size(302, 23);
            this.btn_saveGiveBook.TabIndex = 21;
            this.btn_saveGiveBook.Text = "Save Data";
            this.btn_saveGiveBook.UseSelectable = true;
            this.btn_saveGiveBook.Click += new System.EventHandler(this.btn_saveGiveBook_Click);
            // 
            // txt_bookID
            // 
            // 
            // 
            // 
            this.txt_bookID.CustomButton.Image = null;
            this.txt_bookID.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_bookID.CustomButton.Name = "";
            this.txt_bookID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bookID.CustomButton.TabIndex = 1;
            this.txt_bookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bookID.CustomButton.UseSelectable = true;
            this.txt_bookID.CustomButton.Visible = false;
            this.txt_bookID.Lines = new string[0];
            this.txt_bookID.Location = new System.Drawing.Point(6, 361);
            this.txt_bookID.MaxLength = 32767;
            this.txt_bookID.Name = "txt_bookID";
            this.txt_bookID.PasswordChar = '\0';
            this.txt_bookID.PromptText = "Book ID";
            this.txt_bookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bookID.SelectedText = "";
            this.txt_bookID.SelectionLength = 0;
            this.txt_bookID.SelectionStart = 0;
            this.txt_bookID.ShortcutsEnabled = true;
            this.txt_bookID.Size = new System.Drawing.Size(302, 23);
            this.txt_bookID.TabIndex = 20;
            this.txt_bookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bookID.UseSelectable = true;
            this.txt_bookID.WaterMark = "Book ID";
            this.txt_bookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_bookPrice
            // 
            // 
            // 
            // 
            this.txt_bookPrice.CustomButton.Image = null;
            this.txt_bookPrice.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_bookPrice.CustomButton.Name = "";
            this.txt_bookPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bookPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bookPrice.CustomButton.TabIndex = 1;
            this.txt_bookPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bookPrice.CustomButton.UseSelectable = true;
            this.txt_bookPrice.CustomButton.Visible = false;
            this.txt_bookPrice.Lines = new string[0];
            this.txt_bookPrice.Location = new System.Drawing.Point(433, 96);
            this.txt_bookPrice.MaxLength = 32767;
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.PasswordChar = '\0';
            this.txt_bookPrice.PromptText = "Book Price";
            this.txt_bookPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bookPrice.SelectedText = "";
            this.txt_bookPrice.SelectionLength = 0;
            this.txt_bookPrice.SelectionStart = 0;
            this.txt_bookPrice.ShortcutsEnabled = true;
            this.txt_bookPrice.Size = new System.Drawing.Size(302, 23);
            this.txt_bookPrice.TabIndex = 17;
            this.txt_bookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bookPrice.UseSelectable = true;
            this.txt_bookPrice.WaterMark = "Book Price";
            this.txt_bookPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bookPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_bookName
            // 
            // 
            // 
            // 
            this.txt_bookName.CustomButton.Image = null;
            this.txt_bookName.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_bookName.CustomButton.Name = "";
            this.txt_bookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bookName.CustomButton.TabIndex = 1;
            this.txt_bookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bookName.CustomButton.UseSelectable = true;
            this.txt_bookName.CustomButton.Visible = false;
            this.txt_bookName.Lines = new string[0];
            this.txt_bookName.Location = new System.Drawing.Point(433, 21);
            this.txt_bookName.MaxLength = 32767;
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.PasswordChar = '\0';
            this.txt_bookName.PromptText = "Book Name";
            this.txt_bookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bookName.SelectedText = "";
            this.txt_bookName.SelectionLength = 0;
            this.txt_bookName.SelectionStart = 0;
            this.txt_bookName.ShortcutsEnabled = true;
            this.txt_bookName.Size = new System.Drawing.Size(302, 23);
            this.txt_bookName.TabIndex = 16;
            this.txt_bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bookName.UseSelectable = true;
            this.txt_bookName.WaterMark = "Book Name";
            this.txt_bookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_mobile
            // 
            // 
            // 
            // 
            this.txt_mobile.CustomButton.Image = null;
            this.txt_mobile.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_mobile.CustomButton.Name = "";
            this.txt_mobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mobile.CustomButton.TabIndex = 1;
            this.txt_mobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mobile.CustomButton.UseSelectable = true;
            this.txt_mobile.CustomButton.Visible = false;
            this.txt_mobile.Lines = new string[0];
            this.txt_mobile.Location = new System.Drawing.Point(6, 293);
            this.txt_mobile.MaxLength = 32767;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.PasswordChar = '\0';
            this.txt_mobile.PromptText = "Mobile";
            this.txt_mobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mobile.SelectedText = "";
            this.txt_mobile.SelectionLength = 0;
            this.txt_mobile.SelectionStart = 0;
            this.txt_mobile.ShortcutsEnabled = true;
            this.txt_mobile.Size = new System.Drawing.Size(302, 23);
            this.txt_mobile.TabIndex = 15;
            this.txt_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mobile.UseSelectable = true;
            this.txt_mobile.WaterMark = "Mobile";
            this.txt_mobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_batch
            // 
            // 
            // 
            // 
            this.txt_batch.CustomButton.Image = null;
            this.txt_batch.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_batch.CustomButton.Name = "";
            this.txt_batch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_batch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_batch.CustomButton.TabIndex = 1;
            this.txt_batch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_batch.CustomButton.UseSelectable = true;
            this.txt_batch.CustomButton.Visible = false;
            this.txt_batch.Lines = new string[0];
            this.txt_batch.Location = new System.Drawing.Point(11, 225);
            this.txt_batch.MaxLength = 32767;
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.PasswordChar = '\0';
            this.txt_batch.PromptText = "Batch";
            this.txt_batch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_batch.SelectedText = "";
            this.txt_batch.SelectionLength = 0;
            this.txt_batch.SelectionStart = 0;
            this.txt_batch.ShortcutsEnabled = true;
            this.txt_batch.Size = new System.Drawing.Size(302, 23);
            this.txt_batch.TabIndex = 14;
            this.txt_batch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_batch.UseSelectable = true;
            this.txt_batch.WaterMark = "Batch";
            this.txt_batch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_batch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_studentName
            // 
            // 
            // 
            // 
            this.txt_studentName.CustomButton.Image = null;
            this.txt_studentName.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_studentName.CustomButton.Name = "";
            this.txt_studentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_studentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_studentName.CustomButton.TabIndex = 1;
            this.txt_studentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_studentName.CustomButton.UseSelectable = true;
            this.txt_studentName.CustomButton.Visible = false;
            this.txt_studentName.Lines = new string[0];
            this.txt_studentName.Location = new System.Drawing.Point(11, 157);
            this.txt_studentName.MaxLength = 32767;
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.PasswordChar = '\0';
            this.txt_studentName.PromptText = "Student Name";
            this.txt_studentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_studentName.SelectedText = "";
            this.txt_studentName.SelectionLength = 0;
            this.txt_studentName.SelectionStart = 0;
            this.txt_studentName.ShortcutsEnabled = true;
            this.txt_studentName.Size = new System.Drawing.Size(302, 23);
            this.txt_studentName.TabIndex = 13;
            this.txt_studentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_studentName.UseSelectable = true;
            this.txt_studentName.WaterMark = "Student Name";
            this.txt_studentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_studentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_studentID
            // 
            // 
            // 
            // 
            this.txt_studentID.CustomButton.Image = null;
            this.txt_studentID.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_studentID.CustomButton.Name = "";
            this.txt_studentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_studentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_studentID.CustomButton.TabIndex = 1;
            this.txt_studentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_studentID.CustomButton.UseSelectable = true;
            this.txt_studentID.CustomButton.Visible = false;
            this.txt_studentID.Lines = new string[0];
            this.txt_studentID.Location = new System.Drawing.Point(11, 89);
            this.txt_studentID.MaxLength = 32767;
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.PasswordChar = '\0';
            this.txt_studentID.PromptText = "Student ID";
            this.txt_studentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_studentID.SelectedText = "";
            this.txt_studentID.SelectionLength = 0;
            this.txt_studentID.SelectionStart = 0;
            this.txt_studentID.ShortcutsEnabled = true;
            this.txt_studentID.Size = new System.Drawing.Size(302, 23);
            this.txt_studentID.TabIndex = 12;
            this.txt_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_studentID.UseSelectable = true;
            this.txt_studentID.WaterMark = "Student ID";
            this.txt_studentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_studentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ricitID
            // 
            // 
            // 
            // 
            this.txt_ricitID.CustomButton.Image = null;
            this.txt_ricitID.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_ricitID.CustomButton.Name = "";
            this.txt_ricitID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ricitID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ricitID.CustomButton.TabIndex = 1;
            this.txt_ricitID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ricitID.CustomButton.UseSelectable = true;
            this.txt_ricitID.CustomButton.Visible = false;
            this.txt_ricitID.Lines = new string[0];
            this.txt_ricitID.Location = new System.Drawing.Point(11, 21);
            this.txt_ricitID.MaxLength = 32767;
            this.txt_ricitID.Name = "txt_ricitID";
            this.txt_ricitID.PasswordChar = '\0';
            this.txt_ricitID.PromptText = "Ricit ID";
            this.txt_ricitID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ricitID.SelectedText = "";
            this.txt_ricitID.SelectionLength = 0;
            this.txt_ricitID.SelectionStart = 0;
            this.txt_ricitID.ShortcutsEnabled = true;
            this.txt_ricitID.Size = new System.Drawing.Size(302, 23);
            this.txt_ricitID.TabIndex = 11;
            this.txt_ricitID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ricitID.UseSelectable = true;
            this.txt_ricitID.WaterMark = "Ricit ID";
            this.txt_ricitID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ricitID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txt_amount
            // 
            // 
            // 
            // 
            this.txt_amount.CustomButton.Image = null;
            this.txt_amount.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txt_amount.CustomButton.Name = "";
            this.txt_amount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_amount.CustomButton.TabIndex = 1;
            this.txt_amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_amount.CustomButton.UseSelectable = true;
            this.txt_amount.CustomButton.Visible = false;
            this.txt_amount.Lines = new string[0];
            this.txt_amount.Location = new System.Drawing.Point(433, 293);
            this.txt_amount.MaxLength = 32767;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PasswordChar = '\0';
            this.txt_amount.PromptText = "Payed Amount";
            this.txt_amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_amount.SelectedText = "";
            this.txt_amount.SelectionLength = 0;
            this.txt_amount.SelectionStart = 0;
            this.txt_amount.ShortcutsEnabled = true;
            this.txt_amount.Size = new System.Drawing.Size(302, 23);
            this.txt_amount.TabIndex = 26;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_amount.UseSelectable = true;
            this.txt_amount.WaterMark = "Payed Amount";
            this.txt_amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "payments";
            this.Text = "Payments";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dp_dueDate;
        private MetroFramework.Controls.MetroDateTime dp_getDate;
        private MetroFramework.Controls.MetroButton btn_saveGiveBook;
        private MetroFramework.Controls.MetroTextBox txt_bookID;
        private MetroFramework.Controls.MetroTextBox txt_bookPrice;
        private MetroFramework.Controls.MetroTextBox txt_bookName;
        private MetroFramework.Controls.MetroTextBox txt_mobile;
        private MetroFramework.Controls.MetroTextBox txt_batch;
        private MetroFramework.Controls.MetroTextBox txt_studentName;
        private MetroFramework.Controls.MetroTextBox txt_studentID;
        private MetroFramework.Controls.MetroTextBox txt_ricitID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_amount;
    }
}