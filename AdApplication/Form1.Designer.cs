
namespace AdApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveAdbtn = new System.Windows.Forms.Button();
            this.infotxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.updateADbtn = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Titlebox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.searchtxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.searchtxt.Location = new System.Drawing.Point(33, 57);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(105, 21);
            this.searchtxt.TabIndex = 3;
            this.searchtxt.Text = "Title";
            this.searchtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchtxt_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(33, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search for ads";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Search_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login to create and update ads";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.textBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBox2.Location = new System.Drawing.Point(265, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 257);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(262, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad information";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(33, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Update_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.deletebtn.Location = new System.Drawing.Point(100, 318);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(1);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(65, 22);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.delete_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(187, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(131, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(127, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username";
            // 
            // pwdtxt
            // 
            this.pwdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.pwdtxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.pwdtxt.Location = new System.Drawing.Point(190, 406);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(171, 21);
            this.pwdtxt.TabIndex = 14;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.usertxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.usertxt.Location = new System.Drawing.Point(190, 379);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(171, 21);
            this.usertxt.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(367, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 21);
            this.button3.TabIndex = 12;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Login_Click);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category.ForeColor = System.Drawing.Color.DarkCyan;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Baby Products",
            "Bikes",
            "Books",
            "Cars",
            "Cellphones",
            "Clothes",
            "Computers",
            "Furniture",
            "Home Decor",
            "Video Games"});
            this.category.Location = new System.Drawing.Point(523, 72);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(106, 22);
            this.category.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(466, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 32;
            this.label7.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(460, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(455, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(488, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.label12.Location = new System.Drawing.Point(520, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 14);
            this.label12.TabIndex = 27;
            this.label12.Text = "Create new ad";
            // 
            // saveAdbtn
            // 
            this.saveAdbtn.BackColor = System.Drawing.Color.Honeydew;
            this.saveAdbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.saveAdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAdbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.saveAdbtn.Location = new System.Drawing.Point(656, 315);
            this.saveAdbtn.Name = "saveAdbtn";
            this.saveAdbtn.Size = new System.Drawing.Size(75, 25);
            this.saveAdbtn.TabIndex = 26;
            this.saveAdbtn.Text = "Save";
            this.saveAdbtn.UseVisualStyleBackColor = false;
            this.saveAdbtn.Click += new System.EventHandler(this.saveAdbtn_Click);
            // 
            // infotxt
            // 
            this.infotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.infotxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.infotxt.Location = new System.Drawing.Point(523, 155);
            this.infotxt.Multiline = true;
            this.infotxt.Name = "infotxt";
            this.infotxt.Size = new System.Drawing.Size(208, 154);
            this.infotxt.TabIndex = 24;
            // 
            // pricetxt
            // 
            this.pricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.pricetxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.pricetxt.Location = new System.Drawing.Point(523, 128);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(208, 21);
            this.pricetxt.TabIndex = 23;
            // 
            // titletxt
            // 
            this.titletxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.titletxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.titletxt.Location = new System.Drawing.Point(523, 101);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(208, 21);
            this.titletxt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(21, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 11);
            this.label2.TabIndex = 35;
            this.label2.Text = "Don\'t have an account?";
            // 
            // register_btn
            // 
            this.register_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.register_btn.BackColor = System.Drawing.Color.Honeydew;
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.register_btn.Location = new System.Drawing.Point(33, 403);
            this.register_btn.Margin = new System.Windows.Forms.Padding(1);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(78, 22);
            this.register_btn.TabIndex = 34;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(460, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "Price (SEK)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkCyan;
            this.label18.Location = new System.Drawing.Point(520, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 14);
            this.label18.TabIndex = 43;
            this.label18.Text = "Create new ad";
            // 
            // updateADbtn
            // 
            this.updateADbtn.BackColor = System.Drawing.Color.Honeydew;
            this.updateADbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.updateADbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateADbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.updateADbtn.Location = new System.Drawing.Point(656, 315);
            this.updateADbtn.Name = "updateADbtn";
            this.updateADbtn.Size = new System.Drawing.Size(75, 25);
            this.updateADbtn.TabIndex = 37;
            this.updateADbtn.Text = "Update ad";
            this.updateADbtn.UseVisualStyleBackColor = false;
            this.updateADbtn.Click += new System.EventHandler(this.UpdateAD_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.usernametxt.ForeColor = System.Drawing.Color.DarkCyan;
            this.usernametxt.Location = new System.Drawing.Point(523, 45);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = true;
            this.usernametxt.Size = new System.Drawing.Size(88, 21);
            this.usernametxt.TabIndex = 49;
            // 
            // SortBox
            // 
            this.SortBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Date",
            "Price"});
            this.SortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.SortBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Items.AddRange(new object[] {
            "Date",
            "Price"});
            this.SortBox.Location = new System.Drawing.Point(177, 318);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(80, 22);
            this.SortBox.TabIndex = 50;
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Leelawadee", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(175, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 11);
            this.label19.TabIndex = 51;
            this.label19.Text = "Sort by...";
            // 
            // Titlebox
            // 
            this.Titlebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.Titlebox.ForeColor = System.Drawing.Color.DarkCyan;
            this.Titlebox.FormattingEnabled = true;
            this.Titlebox.ItemHeight = 14;
            this.Titlebox.Location = new System.Drawing.Point(33, 112);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(224, 200);
            this.Titlebox.TabIndex = 2;
            this.Titlebox.Click += new System.EventHandler(this.Titlebox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkCyan;
            this.label20.Location = new System.Drawing.Point(29, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 23);
            this.label20.TabIndex = 53;
            this.label20.Text = "BUY AND SELL";
            // 
            // logoutbtn
            // 
            this.logoutbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logoutbtn.BackColor = System.Drawing.Color.Honeydew;
            this.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutbtn.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.logoutbtn.Location = new System.Drawing.Point(10, 427);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(1);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(78, 22);
            this.logoutbtn.TabIndex = 54;
            this.logoutbtn.Text = "Log out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Date",
            "Price"});
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(230)))), ((int)(((byte)(192)))));
            this.categoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "All categories",
            "Baby Products",
            "Bikes",
            "Books",
            "Cars",
            "Cellphones",
            "Clothes",
            "Computers",
            "Furniture",
            "Home Decor",
            "Video Games"});
            this.categoryBox.Location = new System.Drawing.Point(142, 57);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(113, 22);
            this.categoryBox.TabIndex = 55;
            this.categoryBox.Text = "All categories";
            this.categoryBox.SelectedValueChanged += new System.EventHandler(this.CategoryBox_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(765, 463);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.updateADbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.saveAdbtn);
            this.Controls.Add(this.infotxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.Titlebox);
            this.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "BUY AND SELL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveAdbtn;
        private System.Windows.Forms.TextBox infotxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button updateADbtn;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox Titlebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}

