using Guna.UI2.WinForms;
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
            panel1 = new Panel();
            textBox_manaStdID = new TextBox();
            button_manaStdSearch = new Button();
            textBox_manaStdSearch = new TextBox();
            label_manaStd = new Label();
            button_upload = new Button();
            label_manaStdAddress = new Label();
            radioButton_manaStdFemale = new RadioButton();
            radioButton_manaStdMale = new RadioButton();
            label_manaStdGender = new Label();
            label_manaStdBirthDate = new Label();
            guna2DataGridView_manaStd = new Guna2DataGridView();
            textBox_Name = new TextBox();
            label_Name = new Label();
            textBox_DoB = new TextBox();
            button_update = new Button();
            button_delete = new Button();
            button_manaStdClear = new Button();
            button_addStd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            comboBox_nation = new ComboBox();
            combobox_city = new ComboBox();
            combobox_district = new ComboBox();
            combobox_ward = new ComboBox();
            textbox_street = new TextBox();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(textBox_manaStdID);
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
            // textBox_manaStdID
            // 
            textBox_manaStdID.Location = new Point(1134, 15);
            textBox_manaStdID.Name = "textBox_manaStdID";
            textBox_manaStdID.Size = new Size(125, 27);
            textBox_manaStdID.TabIndex = 92;
            textBox_manaStdID.Visible = false;
            // 
            // button_manaStdSearch
            // 
            button_manaStdSearch.Anchor = AnchorStyles.Top;
            button_manaStdSearch.BackColor = Color.MidnightBlue;
            button_manaStdSearch.FlatStyle = FlatStyle.Flat;
            button_manaStdSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaStdSearch.ForeColor = Color.WhiteSmoke;
            button_manaStdSearch.Location = new Point(850, 13);
            button_manaStdSearch.Name = "button_manaStdSearch";
            button_manaStdSearch.Size = new Size(125, 38);
            button_manaStdSearch.TabIndex = 25;
            button_manaStdSearch.Text = "Tìm kiếm";
            button_manaStdSearch.UseVisualStyleBackColor = false;
            // 
            // textBox_manaStdSearch
            // 
            textBox_manaStdSearch.Anchor = AnchorStyles.Top;
            textBox_manaStdSearch.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_manaStdSearch.Location = new Point(357, 19);
            textBox_manaStdSearch.Name = "textBox_manaStdSearch";
            textBox_manaStdSearch.Size = new Size(435, 25);
            textBox_manaStdSearch.TabIndex = 4;
            // 
            // label_manaStd
            // 
            label_manaStd.AutoSize = true;
            label_manaStd.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStd.Location = new Point(28, 15);
            label_manaStd.Name = "label_manaStd";
            label_manaStd.Size = new Size(262, 38);
            label_manaStd.TabIndex = 0;
            label_manaStd.Text = "Quản lý học sinh";
            // 
            // button_upload
            // 
            button_upload.Location = new Point(0, 0);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(75, 23);
            button_upload.TabIndex = 76;
            // 
            // label_manaStdAddress
            // 
            label_manaStdAddress.Anchor = AnchorStyles.Bottom;
            label_manaStdAddress.AutoSize = true;
            label_manaStdAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStdAddress.ForeColor = SystemColors.Highlight;
            label_manaStdAddress.Location = new Point(74, 492);
            label_manaStdAddress.Name = "label_manaStdAddress";
            label_manaStdAddress.Size = new Size(85, 23);
            label_manaStdAddress.TabIndex = 60;
            label_manaStdAddress.Text = "Địa chỉ : ";
            // 
            // radioButton_manaStdFemale
            // 
            radioButton_manaStdFemale.Anchor = AnchorStyles.Bottom;
            radioButton_manaStdFemale.AutoSize = true;
            radioButton_manaStdFemale.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_manaStdFemale.ForeColor = SystemColors.Highlight;
            radioButton_manaStdFemale.Location = new Point(866, 392);
            radioButton_manaStdFemale.Name = "radioButton_manaStdFemale";
            radioButton_manaStdFemale.Size = new Size(56, 26);
            radioButton_manaStdFemale.TabIndex = 9;
            radioButton_manaStdFemale.Text = "Nữ";
            radioButton_manaStdFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton_manaStdMale
            // 
            radioButton_manaStdMale.Anchor = AnchorStyles.Bottom;
            radioButton_manaStdMale.AutoSize = true;
            radioButton_manaStdMale.Checked = true;
            radioButton_manaStdMale.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_manaStdMale.ForeColor = SystemColors.Highlight;
            radioButton_manaStdMale.Location = new Point(792, 392);
            radioButton_manaStdMale.Name = "radioButton_manaStdMale";
            radioButton_manaStdMale.Size = new Size(68, 26);
            radioButton_manaStdMale.TabIndex = 8;
            radioButton_manaStdMale.TabStop = true;
            radioButton_manaStdMale.Text = "Nam";
            radioButton_manaStdMale.UseVisualStyleBackColor = true;
            // 
            // label_manaStdGender
            // 
            label_manaStdGender.Anchor = AnchorStyles.Bottom;
            label_manaStdGender.AutoSize = true;
            label_manaStdGender.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStdGender.ForeColor = SystemColors.Highlight;
            label_manaStdGender.Location = new Point(684, 394);
            label_manaStdGender.Name = "label_manaStdGender";
            label_manaStdGender.Size = new Size(102, 23);
            label_manaStdGender.TabIndex = 57;
            label_manaStdGender.Text = "Giới tính : ";
            // 
            // label_manaStdBirthDate
            // 
            label_manaStdBirthDate.Anchor = AnchorStyles.Bottom;
            label_manaStdBirthDate.AutoSize = true;
            label_manaStdBirthDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStdBirthDate.ForeColor = SystemColors.Highlight;
            label_manaStdBirthDate.Location = new Point(50, 441);
            label_manaStdBirthDate.Name = "label_manaStdBirthDate";
            label_manaStdBirthDate.Size = new Size(109, 23);
            label_manaStdBirthDate.TabIndex = 55;
            label_manaStdBirthDate.Text = "Ngày sinh : ";
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
            guna2DataGridView_manaStd.TabStop = false;
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
            guna2DataGridView_manaStd.CellContentClick += guna2DataGridView_manaStd_CellContentClick;
            guna2DataGridView_manaStd.Click += guna2DataGridView_manaStd_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Bottom;
            textBox_Name.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Name.Location = new Point(165, 393);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.PlaceholderText = "Nguyễn Văn A";
            textBox_Name.Size = new Size(429, 25);
            textBox_Name.TabIndex = 1;
            // 
            // label_Name
            // 
            label_Name.Anchor = AnchorStyles.Bottom;
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Name.ForeColor = SystemColors.Highlight;
            label_Name.Location = new Point(51, 394);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(108, 23);
            label_Name.TabIndex = 50;
            label_Name.Text = "Họ và tên : ";
            // 
            // textBox_DoB
            // 
            textBox_DoB.Anchor = AnchorStyles.Bottom;
            textBox_DoB.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_DoB.Location = new Point(165, 440);
            textBox_DoB.Name = "textBox_DoB";
            textBox_DoB.PlaceholderText = "dd/mm/yyyy";
            textBox_DoB.Size = new Size(429, 25);
            textBox_DoB.TabIndex = 2;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.MidnightBlue;
            button_update.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(1125, 505);
            button_update.Name = "button_update";
            button_update.Size = new Size(125, 38);
            button_update.TabIndex = 11;
            button_update.Text = "Cập nhật";
            button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.MidnightBlue;
            button_delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(1125, 553);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 38);
            button_delete.TabIndex = 12;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            // 
            // button_manaStdClear
            // 
            button_manaStdClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_manaStdClear.BackColor = Color.MidnightBlue;
            button_manaStdClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaStdClear.ForeColor = Color.White;
            button_manaStdClear.Location = new Point(12, 553);
            button_manaStdClear.Name = "button_manaStdClear";
            button_manaStdClear.Size = new Size(125, 38);
            button_manaStdClear.TabIndex = 67;
            button_manaStdClear.Text = "Dọn";
            button_manaStdClear.UseVisualStyleBackColor = false;
            button_manaStdClear.Click += button_manaStdClear_Click;
            // 
            // button_addStd
            // 
            button_addStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addStd.BackColor = Color.MidnightBlue;
            button_addStd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addStd.ForeColor = Color.White;
            button_addStd.Location = new Point(1125, 459);
            button_addStd.Name = "button_addStd";
            button_addStd.Size = new Size(125, 38);
            button_addStd.TabIndex = 10;
            button_addStd.Text = "Thêm";
            button_addStd.UseVisualStyleBackColor = false;
            button_addStd.Click += button_addStd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(165, 505);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 83;
            label1.Text = "Quốc tịch";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(338, 505);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 84;
            label2.Text = "Tỉnh/Thành phố";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(511, 505);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 85;
            label3.Text = "Quận/Huyện";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(682, 505);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 86;
            label4.Text = "Phường/Xã";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            guna2HtmlLabel1.ForeColor = Color.Red;
            guna2HtmlLabel1.Location = new Point(846, 567);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(273, 22);
            guna2HtmlLabel1.TabIndex = 87;
            guna2HtmlLabel1.Text = "* Nhấn vào học sinh để cập nhật hoặc xóa\r\n\r\n";
            // 
            // comboBox_nation
            // 
            comboBox_nation.Anchor = AnchorStyles.Bottom;
            comboBox_nation.FormattingEnabled = true;
            comboBox_nation.Location = new Point(165, 533);
            comboBox_nation.Name = "comboBox_nation";
            comboBox_nation.Size = new Size(151, 28);
            comboBox_nation.TabIndex = 88;
            // 
            // combobox_city
            // 
            combobox_city.Anchor = AnchorStyles.Bottom;
            combobox_city.FormattingEnabled = true;
            combobox_city.Location = new Point(338, 533);
            combobox_city.Name = "combobox_city";
            combobox_city.Size = new Size(151, 28);
            combobox_city.TabIndex = 89;
            // 
            // combobox_district
            // 
            combobox_district.Anchor = AnchorStyles.Bottom;
            combobox_district.FormattingEnabled = true;
            combobox_district.Location = new Point(511, 533);
            combobox_district.Name = "combobox_district";
            combobox_district.Size = new Size(151, 28);
            combobox_district.TabIndex = 90;
            // 
            // combobox_ward
            // 
            combobox_ward.Anchor = AnchorStyles.Bottom;
            combobox_ward.FormattingEnabled = true;
            combobox_ward.Location = new Point(682, 533);
            combobox_ward.Name = "combobox_ward";
            combobox_ward.Size = new Size(151, 28);
            combobox_ward.TabIndex = 91;
            // 
            // textbox_street
            // 
            textbox_street.Anchor = AnchorStyles.Bottom;
            textbox_street.Location = new Point(866, 534);
            textbox_street.Name = "textbox_street";
            textbox_street.PlaceholderText = "Đường phố";
            textbox_street.Size = new Size(151, 27);
            textbox_street.TabIndex = 92;
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 603);
            Controls.Add(textbox_street);
            Controls.Add(combobox_ward);
            Controls.Add(combobox_district);
            Controls.Add(combobox_city);
            Controls.Add(comboBox_nation);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_delete);
            Controls.Add(button_addStd);
            Controls.Add(button_update);
            Controls.Add(textBox_DoB);
            Controls.Add(button_manaStdClear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_upload);
            Controls.Add(label_manaStdAddress);
            Controls.Add(radioButton_manaStdFemale);
            Controls.Add(radioButton_manaStdMale);
            Controls.Add(label_manaStdGender);
            Controls.Add(label_manaStdBirthDate);
            Controls.Add(guna2DataGridView_manaStd);
            Controls.Add(textBox_Name);
            Controls.Add(label_Name);
            Controls.Add(button1);
            Controls.Add(textBox_email);
            Controls.Add(label9);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            MinimumSize = new Size(1200, 650);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            Click += ManageStudentForm_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button button_manaStdSearch;
        private TextBox textBox_manaStdSearch;
        private Label label_manaStd;
        private Button button_upload;
        private Label label_manaStdAddress;
        private RadioButton radioButton_manaStdFemale;
        private RadioButton radioButton_manaStdMale;
        private Label label_manaStdGender;
        private Label label_manaStdBirthDate;
        private TextBox textBox_manaStdLname;
        private Label label_manaStdLname;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_manaStd;
        private TextBox textBox_Name;
        private Label label_Name;
        private TextBox textBox_DoB;
        private Button button_update;
        private Button button_delete;
        private Button button_manaStdClear;
        private Button button_addStd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private ComboBox comboBox_nation;
        private ComboBox combobox_city;
        private ComboBox combobox_district;
        private ComboBox combobox_ward;
        private TextBox textBox_manaStdID;
        private TextBox textbox_street;
    }
}