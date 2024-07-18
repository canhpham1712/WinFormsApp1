namespace WinFormsApp1
{
    partial class ManageStudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox_email = new TextBox();
            label9 = new Label();
            button_clear = new Button();
            button_add = new Button();
            panel2 = new Panel();
            button_delete = new Button();
            textBox_manaStdEmail = new TextBox();
            label_manaStdEmail = new Label();
            textBox_manaStdID = new TextBox();
            label_manaStdID = new Label();
            panel1 = new Panel();
            button_manaStdSearch = new Button();
            textBox_manaStdSearch = new TextBox();
            label_manaStd = new Label();
            button_manaStdClear = new Button();
            button_update = new Button();
            textBox_manaStdPhone = new TextBox();
            label_manaStdPhone = new Label();
            button_upload = new Button();
            pictureBox_manaStdPhoto = new PictureBox();
            textBox_manaStdAddress = new TextBox();
            label_manaStdAddress = new Label();
            radioButton_manaStdFemale = new RadioButton();
            radioButton_manaStdMale = new RadioButton();
            label_manaStdGender = new Label();
            dateTimePicker_manaStdBirthDate = new DateTimePicker();
            label_manaStdBirthDate = new Label();
            textBox_manaStdLname = new TextBox();
            label_manaStdLname = new Label();
            guna2DataGridView_manaStd = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_manaStdFname = new TextBox();
            label_manaStdFname = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_manaStdPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaStd).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1021, 639);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 49;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Bottom;
            textBox_email.Location = new Point(165, 621);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(427, 27);
            textBox_email.TabIndex = 48;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(79, 627);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 47;
            label9.Text = "Email : ";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(737, 639);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 38);
            button_clear.TabIndex = 43;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.Green;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(578, 639);
            button_add.Name = "button_add";
            button_add.Size = new Size(125, 38);
            button_add.TabIndex = 42;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(8, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 10);
            panel2.TabIndex = 74;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.MidnightBlue;
            button_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(739, 562);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 38);
            button_delete.TabIndex = 73;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // textBox_manaStdEmail
            // 
            textBox_manaStdEmail.Anchor = AnchorStyles.Bottom;
            textBox_manaStdEmail.Location = new Point(202, 544);
            textBox_manaStdEmail.Name = "textBox_manaStdEmail";
            textBox_manaStdEmail.Size = new Size(427, 27);
            textBox_manaStdEmail.TabIndex = 72;
            // 
            // label_manaStdEmail
            // 
            label_manaStdEmail.Anchor = AnchorStyles.Bottom;
            label_manaStdEmail.AutoSize = true;
            label_manaStdEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdEmail.ForeColor = SystemColors.Highlight;
            label_manaStdEmail.Location = new Point(116, 550);
            label_manaStdEmail.Name = "label_manaStdEmail";
            label_manaStdEmail.Size = new Size(80, 23);
            label_manaStdEmail.TabIndex = 71;
            label_manaStdEmail.Text = "Email : ";
            // 
            // textBox_manaStdID
            // 
            textBox_manaStdID.Anchor = AnchorStyles.Bottom;
            textBox_manaStdID.Location = new Point(801, 389);
            textBox_manaStdID.Name = "textBox_manaStdID";
            textBox_manaStdID.Size = new Size(220, 27);
            textBox_manaStdID.TabIndex = 70;
            // 
            // label_manaStdID
            // 
            label_manaStdID.Anchor = AnchorStyles.Bottom;
            label_manaStdID.AutoSize = true;
            label_manaStdID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdID.ForeColor = SystemColors.Highlight;
            label_manaStdID.Location = new Point(647, 394);
            label_manaStdID.Name = "label_manaStdID";
            label_manaStdID.Size = new Size(126, 23);
            label_manaStdID.TabIndex = 69;
            label_manaStdID.Text = "Student ID : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button_manaStdSearch);
            panel1.Controls.Add(textBox_manaStdSearch);
            panel1.Controls.Add(label_manaStd);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 72);
            panel1.TabIndex = 68;
            // 
            // button_manaStdSearch
            // 
            button_manaStdSearch.Anchor = AnchorStyles.Top;
            button_manaStdSearch.BackColor = Color.MidnightBlue;
            button_manaStdSearch.FlatStyle = FlatStyle.Flat;
            button_manaStdSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaStdSearch.ForeColor = Color.WhiteSmoke;
            button_manaStdSearch.Location = new Point(850, 13);
            button_manaStdSearch.Name = "button_manaStdSearch";
            button_manaStdSearch.Size = new Size(125, 38);
            button_manaStdSearch.TabIndex = 25;
            button_manaStdSearch.Text = "Search";
            button_manaStdSearch.UseVisualStyleBackColor = false;
            // 
            // textBox_manaStdSearch
            // 
            textBox_manaStdSearch.Anchor = AnchorStyles.Top;
            textBox_manaStdSearch.Location = new Point(357, 19);
            textBox_manaStdSearch.Name = "textBox_manaStdSearch";
            textBox_manaStdSearch.Size = new Size(435, 27);
            textBox_manaStdSearch.TabIndex = 4;
            // 
            // label_manaStd
            // 
            label_manaStd.AutoSize = true;
            label_manaStd.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStd.Location = new Point(28, 13);
            label_manaStd.Name = "label_manaStd";
            label_manaStd.Size = new Size(288, 40);
            label_manaStd.TabIndex = 0;
            label_manaStd.Text = "Manage Student";
            // 
            // button_manaStdClear
            // 
            button_manaStdClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_manaStdClear.BackColor = Color.MidnightBlue;
            button_manaStdClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaStdClear.ForeColor = Color.White;
            button_manaStdClear.Location = new Point(1058, 562);
            button_manaStdClear.Name = "button_manaStdClear";
            button_manaStdClear.Size = new Size(125, 38);
            button_manaStdClear.TabIndex = 67;
            button_manaStdClear.Text = "Clear";
            button_manaStdClear.UseVisualStyleBackColor = false;
            button_manaStdClear.Click += button_manaStdClear_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.MidnightBlue;
            button_update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(899, 562);
            button_update.Name = "button_update";
            button_update.Size = new Size(125, 38);
            button_update.TabIndex = 66;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            // 
            // textBox_manaStdPhone
            // 
            textBox_manaStdPhone.Anchor = AnchorStyles.Bottom;
            textBox_manaStdPhone.Location = new Point(801, 487);
            textBox_manaStdPhone.Name = "textBox_manaStdPhone";
            textBox_manaStdPhone.Size = new Size(220, 27);
            textBox_manaStdPhone.TabIndex = 65;
            // 
            // label_manaStdPhone
            // 
            label_manaStdPhone.Anchor = AnchorStyles.Bottom;
            label_manaStdPhone.AutoSize = true;
            label_manaStdPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdPhone.ForeColor = SystemColors.Highlight;
            label_manaStdPhone.Location = new Point(684, 492);
            label_manaStdPhone.Name = "label_manaStdPhone";
            label_manaStdPhone.Size = new Size(89, 23);
            label_manaStdPhone.TabIndex = 64;
            label_manaStdPhone.Text = "Phone : ";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.MidnightBlue;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1058, 520);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(125, 38);
            button_upload.TabIndex = 63;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_manaStdPhoto
            // 
            pictureBox_manaStdPhoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_manaStdPhoto.BackColor = Color.Gainsboro;
            pictureBox_manaStdPhoto.Location = new Point(1058, 384);
            pictureBox_manaStdPhoto.Name = "pictureBox_manaStdPhoto";
            pictureBox_manaStdPhoto.Size = new Size(125, 135);
            pictureBox_manaStdPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_manaStdPhoto.TabIndex = 62;
            pictureBox_manaStdPhoto.TabStop = false;
            // 
            // textBox_manaStdAddress
            // 
            textBox_manaStdAddress.Anchor = AnchorStyles.Bottom;
            textBox_manaStdAddress.Location = new Point(202, 484);
            textBox_manaStdAddress.Multiline = true;
            textBox_manaStdAddress.Name = "textBox_manaStdAddress";
            textBox_manaStdAddress.Size = new Size(429, 38);
            textBox_manaStdAddress.TabIndex = 61;
            // 
            // label_manaStdAddress
            // 
            label_manaStdAddress.Anchor = AnchorStyles.Bottom;
            label_manaStdAddress.AutoSize = true;
            label_manaStdAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdAddress.ForeColor = SystemColors.Highlight;
            label_manaStdAddress.Location = new Point(90, 492);
            label_manaStdAddress.Name = "label_manaStdAddress";
            label_manaStdAddress.Size = new Size(106, 23);
            label_manaStdAddress.TabIndex = 60;
            label_manaStdAddress.Text = "Address : ";
            // 
            // radioButton_manaStdFemale
            // 
            radioButton_manaStdFemale.Anchor = AnchorStyles.Bottom;
            radioButton_manaStdFemale.AutoSize = true;
            radioButton_manaStdFemale.ForeColor = SystemColors.Highlight;
            radioButton_manaStdFemale.Location = new Point(916, 442);
            radioButton_manaStdFemale.Name = "radioButton_manaStdFemale";
            radioButton_manaStdFemale.Size = new Size(78, 24);
            radioButton_manaStdFemale.TabIndex = 59;
            radioButton_manaStdFemale.Text = "Female";
            radioButton_manaStdFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton_manaStdMale
            // 
            radioButton_manaStdMale.Anchor = AnchorStyles.Bottom;
            radioButton_manaStdMale.AutoSize = true;
            radioButton_manaStdMale.Checked = true;
            radioButton_manaStdMale.ForeColor = SystemColors.Highlight;
            radioButton_manaStdMale.Location = new Point(801, 444);
            radioButton_manaStdMale.Name = "radioButton_manaStdMale";
            radioButton_manaStdMale.Size = new Size(63, 24);
            radioButton_manaStdMale.TabIndex = 58;
            radioButton_manaStdMale.TabStop = true;
            radioButton_manaStdMale.Text = "Male";
            radioButton_manaStdMale.UseVisualStyleBackColor = true;
            // 
            // label_manaStdGender
            // 
            label_manaStdGender.Anchor = AnchorStyles.Bottom;
            label_manaStdGender.AutoSize = true;
            label_manaStdGender.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdGender.ForeColor = SystemColors.Highlight;
            label_manaStdGender.Location = new Point(671, 441);
            label_manaStdGender.Name = "label_manaStdGender";
            label_manaStdGender.Size = new Size(102, 23);
            label_manaStdGender.TabIndex = 57;
            label_manaStdGender.Text = "Gender : ";
            // 
            // dateTimePicker_manaStdBirthDate
            // 
            dateTimePicker_manaStdBirthDate.Anchor = AnchorStyles.Bottom;
            dateTimePicker_manaStdBirthDate.Location = new Point(202, 436);
            dateTimePicker_manaStdBirthDate.Name = "dateTimePicker_manaStdBirthDate";
            dateTimePicker_manaStdBirthDate.Size = new Size(427, 27);
            dateTimePicker_manaStdBirthDate.TabIndex = 56;
            // 
            // label_manaStdBirthDate
            // 
            label_manaStdBirthDate.Anchor = AnchorStyles.Bottom;
            label_manaStdBirthDate.AutoSize = true;
            label_manaStdBirthDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdBirthDate.ForeColor = SystemColors.Highlight;
            label_manaStdBirthDate.Location = new Point(50, 441);
            label_manaStdBirthDate.Name = "label_manaStdBirthDate";
            label_manaStdBirthDate.Size = new Size(146, 23);
            label_manaStdBirthDate.TabIndex = 55;
            label_manaStdBirthDate.Text = "Date of Birth : ";
            // 
            // textBox_manaStdLname
            // 
            textBox_manaStdLname.Anchor = AnchorStyles.Bottom;
            textBox_manaStdLname.Location = new Point(469, 389);
            textBox_manaStdLname.Name = "textBox_manaStdLname";
            textBox_manaStdLname.Size = new Size(162, 27);
            textBox_manaStdLname.TabIndex = 54;
            // 
            // label_manaStdLname
            // 
            label_manaStdLname.Anchor = AnchorStyles.Bottom;
            label_manaStdLname.AutoSize = true;
            label_manaStdLname.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdLname.ForeColor = SystemColors.Highlight;
            label_manaStdLname.Location = new Point(337, 394);
            label_manaStdLname.Name = "label_manaStdLname";
            label_manaStdLname.Size = new Size(131, 23);
            label_manaStdLname.TabIndex = 53;
            label_manaStdLname.Text = "Last Name : ";
            // 
            // guna2DataGridView_manaStd
            // 
            guna2DataGridView_manaStd.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView_manaStd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView_manaStd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_manaStd.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_manaStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView_manaStd.ColumnHeadersHeight = 24;
            guna2DataGridView_manaStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_manaStd.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView_manaStd.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaStd.Location = new Point(8, 78);
            guna2DataGridView_manaStd.Name = "guna2DataGridView_manaStd";
            guna2DataGridView_manaStd.RowHeadersVisible = false;
            guna2DataGridView_manaStd.RowHeadersWidth = 51;
            guna2DataGridView_manaStd.RowTemplate.Height = 80;
            guna2DataGridView_manaStd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_manaStd.Size = new Size(1242, 286);
            guna2DataGridView_manaStd.TabIndex = 52;
            guna2DataGridView_manaStd.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView_manaStd.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView_manaStd.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView_manaStd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView_manaStd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView_manaStd.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView_manaStd.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_manaStd.ThemeStyle.ReadOnly = false;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // textBox_manaStdFname
            // 
            textBox_manaStdFname.Anchor = AnchorStyles.Bottom;
            textBox_manaStdFname.Location = new Point(202, 389);
            textBox_manaStdFname.Name = "textBox_manaStdFname";
            textBox_manaStdFname.Size = new Size(129, 27);
            textBox_manaStdFname.TabIndex = 51;
            // 
            // label_manaStdFname
            // 
            label_manaStdFname.Anchor = AnchorStyles.Bottom;
            label_manaStdFname.AutoSize = true;
            label_manaStdFname.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_manaStdFname.ForeColor = SystemColors.Highlight;
            label_manaStdFname.Location = new Point(66, 394);
            label_manaStdFname.Name = "label_manaStdFname";
            label_manaStdFname.Size = new Size(130, 23);
            label_manaStdFname.TabIndex = 50;
            label_manaStdFname.Text = "First Name : ";
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 603);
            Controls.Add(panel2);
            Controls.Add(button_delete);
            Controls.Add(textBox_manaStdEmail);
            Controls.Add(label_manaStdEmail);
            Controls.Add(textBox_manaStdID);
            Controls.Add(label_manaStdID);
            Controls.Add(panel1);
            Controls.Add(button_manaStdClear);
            Controls.Add(button_update);
            Controls.Add(textBox_manaStdPhone);
            Controls.Add(label_manaStdPhone);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_manaStdPhoto);
            Controls.Add(textBox_manaStdAddress);
            Controls.Add(label_manaStdAddress);
            Controls.Add(radioButton_manaStdFemale);
            Controls.Add(radioButton_manaStdMale);
            Controls.Add(label_manaStdGender);
            Controls.Add(dateTimePicker_manaStdBirthDate);
            Controls.Add(label_manaStdBirthDate);
            Controls.Add(textBox_manaStdLname);
            Controls.Add(label_manaStdLname);
            Controls.Add(guna2DataGridView_manaStd);
            Controls.Add(textBox_manaStdFname);
            Controls.Add(label_manaStdFname);
            Controls.Add(button1);
            Controls.Add(textBox_email);
            Controls.Add(label9);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            MinimumSize = new Size(1200, 650);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_manaStdPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox_email;
        private Label label9;
        private Button button_clear;
        private Button button_add;
        private Panel panel2;
        private Button button_delete;
        private TextBox textBox_manaStdEmail;
        private Label label_manaStdEmail;
        private TextBox textBox_manaStdID;
        private Label label_manaStdID;
        private Panel panel1;
        private Button button_manaStdSearch;
        private TextBox textBox_manaStdSearch;
        private Label label_manaStd;
        private Button button_manaStdClear;
        private Button button_update;
        private TextBox textBox_manaStdPhone;
        private Label label_manaStdPhone;
        private Button button_upload;
        private PictureBox pictureBox_manaStdPhoto;
        private TextBox textBox_manaStdAddress;
        private Label label_manaStdAddress;
        private RadioButton radioButton_manaStdFemale;
        private RadioButton radioButton_manaStdMale;
        private Label label_manaStdGender;
        private DateTimePicker dateTimePicker_manaStdBirthDate;
        private Label label_manaStdBirthDate;
        private TextBox textBox_manaStdLname;
        private Label label_manaStdLname;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_manaStd;
        private TextBox textBox_manaStdFname;
        private Label label_manaStdFname;
    }
}