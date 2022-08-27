namespace LibraryManagement
{
    partial class book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book));
            this.menuStrip_manageBooks = new System.Windows.Forms.MenuStrip();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_viewBooks = new MetroFramework.Controls.MetroPanel();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_bookPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_publishedYear = new MetroFramework.Controls.MetroTextBox();
            this.txt_publisherName = new MetroFramework.Controls.MetroTextBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnl_addBook = new MetroFramework.Controls.MetroPanel();
            this.txt_addDescription = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_addBookID = new MetroFramework.Controls.MetroTextBox();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.txt_addBookQty = new MetroFramework.Controls.MetroTextBox();
            this.txt_addBookPrice = new MetroFramework.Controls.MetroTextBox();
            this.txt_addPublishedYear = new MetroFramework.Controls.MetroTextBox();
            this.txt_addPublisherName = new MetroFramework.Controls.MetroTextBox();
            this.txt_addBookName = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip_manageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_viewBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnl_addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_manageBooks
            // 
            this.menuStrip_manageBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripMenuItem,
            this.addNewBookToolStripMenuItem});
            this.menuStrip_manageBooks.Location = new System.Drawing.Point(20, 60);
            this.menuStrip_manageBooks.Name = "menuStrip_manageBooks";
            this.menuStrip_manageBooks.Size = new System.Drawing.Size(848, 24);
            this.menuStrip_manageBooks.TabIndex = 0;
            this.menuStrip_manageBooks.Text = "menuStrip1";
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(701, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_viewBooks
            // 
            this.pnl_viewBooks.Controls.Add(this.txt_description);
            this.pnl_viewBooks.Controls.Add(this.btn_delete);
            this.pnl_viewBooks.Controls.Add(this.btn_update);
            this.pnl_viewBooks.Controls.Add(this.txt_qty);
            this.pnl_viewBooks.Controls.Add(this.txt_bookPrice);
            this.pnl_viewBooks.Controls.Add(this.txt_publishedYear);
            this.pnl_viewBooks.Controls.Add(this.txt_publisherName);
            this.pnl_viewBooks.Controls.Add(this.txt_name);
            this.pnl_viewBooks.Controls.Add(this.dataGridView);
            this.pnl_viewBooks.HorizontalScrollbarBarColor = true;
            this.pnl_viewBooks.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_viewBooks.HorizontalScrollbarSize = 10;
            this.pnl_viewBooks.Location = new System.Drawing.Point(23, 87);
            this.pnl_viewBooks.Name = "pnl_viewBooks";
            this.pnl_viewBooks.Size = new System.Drawing.Size(856, 423);
            this.pnl_viewBooks.TabIndex = 16;
            this.pnl_viewBooks.VerticalScrollbarBarColor = true;
            this.pnl_viewBooks.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_viewBooks.VerticalScrollbarSize = 10;
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(285, 3);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PromptText = "Description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(279, 23);
            this.txt_description.TabIndex = 11;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMark = "Description";
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(713, 66);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(569, 66);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(138, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(569, 35);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.PromptText = "Quantity";
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(279, 23);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMark = "Quantity";
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_bookPrice
            // 
            // 
            // 
            // 
            this.txt_bookPrice.CustomButton.Image = null;
            this.txt_bookPrice.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_bookPrice.CustomButton.Name = "";
            this.txt_bookPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_bookPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_bookPrice.CustomButton.TabIndex = 1;
            this.txt_bookPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_bookPrice.CustomButton.UseSelectable = true;
            this.txt_bookPrice.CustomButton.Visible = false;
            this.txt_bookPrice.Lines = new string[0];
            this.txt_bookPrice.Location = new System.Drawing.Point(285, 35);
            this.txt_bookPrice.MaxLength = 32767;
            this.txt_bookPrice.Name = "txt_bookPrice";
            this.txt_bookPrice.PasswordChar = '\0';
            this.txt_bookPrice.PromptText = "Book Price";
            this.txt_bookPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bookPrice.SelectedText = "";
            this.txt_bookPrice.SelectionLength = 0;
            this.txt_bookPrice.SelectionStart = 0;
            this.txt_bookPrice.ShortcutsEnabled = true;
            this.txt_bookPrice.Size = new System.Drawing.Size(279, 23);
            this.txt_bookPrice.TabIndex = 6;
            this.txt_bookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bookPrice.UseSelectable = true;
            this.txt_bookPrice.WaterMark = "Book Price";
            this.txt_bookPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_bookPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_publishedYear
            // 
            // 
            // 
            // 
            this.txt_publishedYear.CustomButton.Image = null;
            this.txt_publishedYear.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_publishedYear.CustomButton.Name = "";
            this.txt_publishedYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_publishedYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_publishedYear.CustomButton.TabIndex = 1;
            this.txt_publishedYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_publishedYear.CustomButton.UseSelectable = true;
            this.txt_publishedYear.CustomButton.Visible = false;
            this.txt_publishedYear.Lines = new string[0];
            this.txt_publishedYear.Location = new System.Drawing.Point(3, 35);
            this.txt_publishedYear.MaxLength = 32767;
            this.txt_publishedYear.Name = "txt_publishedYear";
            this.txt_publishedYear.PasswordChar = '\0';
            this.txt_publishedYear.PromptText = "Published Year";
            this.txt_publishedYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_publishedYear.SelectedText = "";
            this.txt_publishedYear.SelectionLength = 0;
            this.txt_publishedYear.SelectionStart = 0;
            this.txt_publishedYear.ShortcutsEnabled = true;
            this.txt_publishedYear.Size = new System.Drawing.Size(279, 23);
            this.txt_publishedYear.TabIndex = 5;
            this.txt_publishedYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_publishedYear.UseSelectable = true;
            this.txt_publishedYear.WaterMark = "Published Year";
            this.txt_publishedYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_publishedYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_publisherName
            // 
            // 
            // 
            // 
            this.txt_publisherName.CustomButton.Image = null;
            this.txt_publisherName.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_publisherName.CustomButton.Name = "";
            this.txt_publisherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_publisherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_publisherName.CustomButton.TabIndex = 1;
            this.txt_publisherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_publisherName.CustomButton.UseSelectable = true;
            this.txt_publisherName.CustomButton.Visible = false;
            this.txt_publisherName.Lines = new string[0];
            this.txt_publisherName.Location = new System.Drawing.Point(569, 3);
            this.txt_publisherName.MaxLength = 32767;
            this.txt_publisherName.Name = "txt_publisherName";
            this.txt_publisherName.PasswordChar = '\0';
            this.txt_publisherName.PromptText = "Publisher Name";
            this.txt_publisherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_publisherName.SelectedText = "";
            this.txt_publisherName.SelectionLength = 0;
            this.txt_publisherName.SelectionStart = 0;
            this.txt_publisherName.ShortcutsEnabled = true;
            this.txt_publisherName.Size = new System.Drawing.Size(279, 23);
            this.txt_publisherName.TabIndex = 4;
            this.txt_publisherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_publisherName.UseSelectable = true;
            this.txt_publisherName.WaterMark = "Publisher Name";
            this.txt_publisherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_publisherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(3, 3);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PromptText = "Book Name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(279, 23);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMark = "Book Name";
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(846, 317);
            this.dataGridView.TabIndex = 2;
            // 
            // pnl_addBook
            // 
            this.pnl_addBook.Controls.Add(this.txt_addDescription);
            this.pnl_addBook.Controls.Add(this.pictureBox1);
            this.pnl_addBook.Controls.Add(this.txt_addBookID);
            this.pnl_addBook.Controls.Add(this.btn_add);
            this.pnl_addBook.Controls.Add(this.txt_addBookQty);
            this.pnl_addBook.Controls.Add(this.txt_addBookPrice);
            this.pnl_addBook.Controls.Add(this.txt_addPublishedYear);
            this.pnl_addBook.Controls.Add(this.txt_addPublisherName);
            this.pnl_addBook.Controls.Add(this.txt_addBookName);
            this.pnl_addBook.HorizontalScrollbarBarColor = true;
            this.pnl_addBook.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_addBook.HorizontalScrollbarSize = 10;
            this.pnl_addBook.Location = new System.Drawing.Point(23, 87);
            this.pnl_addBook.Name = "pnl_addBook";
            this.pnl_addBook.Size = new System.Drawing.Size(856, 423);
            this.pnl_addBook.TabIndex = 18;
            this.pnl_addBook.VerticalScrollbarBarColor = true;
            this.pnl_addBook.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_addBook.VerticalScrollbarSize = 10;
            // 
            // txt_addDescription
            // 
            // 
            // 
            // 
            this.txt_addDescription.CustomButton.Image = null;
            this.txt_addDescription.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addDescription.CustomButton.Name = "";
            this.txt_addDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addDescription.CustomButton.TabIndex = 1;
            this.txt_addDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addDescription.CustomButton.UseSelectable = true;
            this.txt_addDescription.CustomButton.Visible = false;
            this.txt_addDescription.Lines = new string[0];
            this.txt_addDescription.Location = new System.Drawing.Point(192, 120);
            this.txt_addDescription.MaxLength = 32767;
            this.txt_addDescription.Name = "txt_addDescription";
            this.txt_addDescription.PasswordChar = '\0';
            this.txt_addDescription.PromptText = "Description";
            this.txt_addDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addDescription.SelectedText = "";
            this.txt_addDescription.SelectionLength = 0;
            this.txt_addDescription.SelectionStart = 0;
            this.txt_addDescription.ShortcutsEnabled = true;
            this.txt_addDescription.Size = new System.Drawing.Size(448, 23);
            this.txt_addDescription.TabIndex = 15;
            this.txt_addDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addDescription.UseSelectable = true;
            this.txt_addDescription.WaterMark = "Description";
            this.txt_addDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txt_addBookID
            // 
            // 
            // 
            // 
            this.txt_addBookID.CustomButton.Image = null;
            this.txt_addBookID.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addBookID.CustomButton.Name = "";
            this.txt_addBookID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addBookID.CustomButton.TabIndex = 1;
            this.txt_addBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addBookID.CustomButton.UseSelectable = true;
            this.txt_addBookID.CustomButton.Visible = false;
            this.txt_addBookID.Lines = new string[0];
            this.txt_addBookID.Location = new System.Drawing.Point(192, 20);
            this.txt_addBookID.MaxLength = 32767;
            this.txt_addBookID.Name = "txt_addBookID";
            this.txt_addBookID.PasswordChar = '\0';
            this.txt_addBookID.PromptText = "Book ID";
            this.txt_addBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addBookID.SelectedText = "";
            this.txt_addBookID.SelectionLength = 0;
            this.txt_addBookID.SelectionStart = 0;
            this.txt_addBookID.ShortcutsEnabled = true;
            this.txt_addBookID.Size = new System.Drawing.Size(448, 23);
            this.txt_addBookID.TabIndex = 10;
            this.txt_addBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBookID.UseSelectable = true;
            this.txt_addBookID.WaterMark = "Book ID";
            this.txt_addBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(192, 376);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(448, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "SAVE";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_addBookQty
            // 
            // 
            // 
            // 
            this.txt_addBookQty.CustomButton.Image = null;
            this.txt_addBookQty.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addBookQty.CustomButton.Name = "";
            this.txt_addBookQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addBookQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addBookQty.CustomButton.TabIndex = 1;
            this.txt_addBookQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addBookQty.CustomButton.UseSelectable = true;
            this.txt_addBookQty.CustomButton.Visible = false;
            this.txt_addBookQty.Lines = new string[0];
            this.txt_addBookQty.Location = new System.Drawing.Point(192, 320);
            this.txt_addBookQty.MaxLength = 32767;
            this.txt_addBookQty.Name = "txt_addBookQty";
            this.txt_addBookQty.PasswordChar = '\0';
            this.txt_addBookQty.PromptText = "Quantity";
            this.txt_addBookQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addBookQty.SelectedText = "";
            this.txt_addBookQty.SelectionLength = 0;
            this.txt_addBookQty.SelectionStart = 0;
            this.txt_addBookQty.ShortcutsEnabled = true;
            this.txt_addBookQty.Size = new System.Drawing.Size(448, 23);
            this.txt_addBookQty.TabIndex = 7;
            this.txt_addBookQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBookQty.UseSelectable = true;
            this.txt_addBookQty.WaterMark = "Quantity";
            this.txt_addBookQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addBookQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_addBookPrice
            // 
            // 
            // 
            // 
            this.txt_addBookPrice.CustomButton.Image = null;
            this.txt_addBookPrice.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addBookPrice.CustomButton.Name = "";
            this.txt_addBookPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addBookPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addBookPrice.CustomButton.TabIndex = 1;
            this.txt_addBookPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addBookPrice.CustomButton.UseSelectable = true;
            this.txt_addBookPrice.CustomButton.Visible = false;
            this.txt_addBookPrice.Lines = new string[0];
            this.txt_addBookPrice.Location = new System.Drawing.Point(192, 270);
            this.txt_addBookPrice.MaxLength = 32767;
            this.txt_addBookPrice.Name = "txt_addBookPrice";
            this.txt_addBookPrice.PasswordChar = '\0';
            this.txt_addBookPrice.PromptText = "Book Price";
            this.txt_addBookPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addBookPrice.SelectedText = "";
            this.txt_addBookPrice.SelectionLength = 0;
            this.txt_addBookPrice.SelectionStart = 0;
            this.txt_addBookPrice.ShortcutsEnabled = true;
            this.txt_addBookPrice.Size = new System.Drawing.Size(448, 23);
            this.txt_addBookPrice.TabIndex = 6;
            this.txt_addBookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBookPrice.UseSelectable = true;
            this.txt_addBookPrice.WaterMark = "Book Price";
            this.txt_addBookPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addBookPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_addPublishedYear
            // 
            // 
            // 
            // 
            this.txt_addPublishedYear.CustomButton.Image = null;
            this.txt_addPublishedYear.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addPublishedYear.CustomButton.Name = "";
            this.txt_addPublishedYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addPublishedYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addPublishedYear.CustomButton.TabIndex = 1;
            this.txt_addPublishedYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addPublishedYear.CustomButton.UseSelectable = true;
            this.txt_addPublishedYear.CustomButton.Visible = false;
            this.txt_addPublishedYear.Lines = new string[0];
            this.txt_addPublishedYear.Location = new System.Drawing.Point(192, 220);
            this.txt_addPublishedYear.MaxLength = 32767;
            this.txt_addPublishedYear.Name = "txt_addPublishedYear";
            this.txt_addPublishedYear.PasswordChar = '\0';
            this.txt_addPublishedYear.PromptText = "Published Year";
            this.txt_addPublishedYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addPublishedYear.SelectedText = "";
            this.txt_addPublishedYear.SelectionLength = 0;
            this.txt_addPublishedYear.SelectionStart = 0;
            this.txt_addPublishedYear.ShortcutsEnabled = true;
            this.txt_addPublishedYear.Size = new System.Drawing.Size(448, 23);
            this.txt_addPublishedYear.TabIndex = 5;
            this.txt_addPublishedYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addPublishedYear.UseSelectable = true;
            this.txt_addPublishedYear.WaterMark = "Published Year";
            this.txt_addPublishedYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addPublishedYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_addPublisherName
            // 
            // 
            // 
            // 
            this.txt_addPublisherName.CustomButton.Image = null;
            this.txt_addPublisherName.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addPublisherName.CustomButton.Name = "";
            this.txt_addPublisherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addPublisherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addPublisherName.CustomButton.TabIndex = 1;
            this.txt_addPublisherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addPublisherName.CustomButton.UseSelectable = true;
            this.txt_addPublisherName.CustomButton.Visible = false;
            this.txt_addPublisherName.Lines = new string[0];
            this.txt_addPublisherName.Location = new System.Drawing.Point(192, 170);
            this.txt_addPublisherName.MaxLength = 32767;
            this.txt_addPublisherName.Name = "txt_addPublisherName";
            this.txt_addPublisherName.PasswordChar = '\0';
            this.txt_addPublisherName.PromptText = "Publisher Name";
            this.txt_addPublisherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addPublisherName.SelectedText = "";
            this.txt_addPublisherName.SelectionLength = 0;
            this.txt_addPublisherName.SelectionStart = 0;
            this.txt_addPublisherName.ShortcutsEnabled = true;
            this.txt_addPublisherName.Size = new System.Drawing.Size(448, 23);
            this.txt_addPublisherName.TabIndex = 4;
            this.txt_addPublisherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addPublisherName.UseSelectable = true;
            this.txt_addPublisherName.WaterMark = "Publisher Name";
            this.txt_addPublisherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addPublisherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_addBookName
            // 
            // 
            // 
            // 
            this.txt_addBookName.CustomButton.Image = null;
            this.txt_addBookName.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txt_addBookName.CustomButton.Name = "";
            this.txt_addBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_addBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_addBookName.CustomButton.TabIndex = 1;
            this.txt_addBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_addBookName.CustomButton.UseSelectable = true;
            this.txt_addBookName.CustomButton.Visible = false;
            this.txt_addBookName.Lines = new string[0];
            this.txt_addBookName.Location = new System.Drawing.Point(192, 70);
            this.txt_addBookName.MaxLength = 32767;
            this.txt_addBookName.Name = "txt_addBookName";
            this.txt_addBookName.PasswordChar = '\0';
            this.txt_addBookName.PromptText = "Book Name";
            this.txt_addBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_addBookName.SelectedText = "";
            this.txt_addBookName.SelectionLength = 0;
            this.txt_addBookName.SelectionStart = 0;
            this.txt_addBookName.ShortcutsEnabled = true;
            this.txt_addBookName.Size = new System.Drawing.Size(448, 23);
            this.txt_addBookName.TabIndex = 3;
            this.txt_addBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBookName.UseSelectable = true;
            this.txt_addBookName.WaterMark = "Book Name";
            this.txt_addBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_addBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 520);
            this.Controls.Add(this.pnl_addBook);
            this.Controls.Add(this.pnl_viewBooks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip_manageBooks);
            this.MainMenuStrip = this.menuStrip_manageBooks;
            this.Name = "book";
            this.Text = "Manage Books";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.book_Load);
            this.menuStrip_manageBooks.ResumeLayout(false);
            this.menuStrip_manageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_viewBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnl_addBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_manageBooks;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel pnl_viewBooks;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroTextBox txt_bookPrice;
        private MetroFramework.Controls.MetroTextBox txt_publishedYear;
        private MetroFramework.Controls.MetroTextBox txt_publisherName;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroPanel pnl_addBook;
        private MetroFramework.Controls.MetroTextBox txt_addDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_addBookID;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroTextBox txt_addBookQty;
        private MetroFramework.Controls.MetroTextBox txt_addBookPrice;
        private MetroFramework.Controls.MetroTextBox txt_addPublishedYear;
        private MetroFramework.Controls.MetroTextBox txt_addPublisherName;
        private MetroFramework.Controls.MetroTextBox txt_addBookName;
        private MetroFramework.Controls.MetroTextBox txt_description;
    }
}