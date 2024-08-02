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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox_email = new TextBox();
            label9 = new Label();
            button_clear = new Button();
            button_add = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            lb_class_name = new Label();
            label_manaStd = new Label();
            label8 = new Label();
            cmb_class_list = new ComboBox();
            txtb_search_by_name = new TextBox();
            textBox_manaStdID = new TextBox();
            button_upload = new Button();
            radioButton_manaStdFemale = new RadioButton();
            radioButton_manaStdMale = new RadioButton();
            label_manaStdGender = new Label();
            guna2DataGridView_manaStd = new Guna2DataGridView();
            textBox_Name = new TextBox();
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtgrid_class = new DataGridView();
            tb_class_id = new TextBox();
            lb_class_id_sys = new Label();
            bt_add_to_class = new Button();
            btn_delete_from_class = new Button();
            lb_street = new Label();
            button2 = new Button();
            cbb_search_by_level = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            cbb_day = new ComboBox();
            cbb_year = new ComboBox();
            label12 = new Label();
            cbb_month = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaStd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgrid_class).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1209, 789);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 49;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Bottom;
            textBox_email.Location = new Point(259, 771);
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
            label9.Location = new Point(173, 777);
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
            button_clear.Location = new Point(925, 789);
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
            button_add.Location = new Point(766, 789);
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
            panel2.Location = new Point(8, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(1430, 10);
            panel2.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lb_class_name);
            panel1.Controls.Add(label_manaStd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmb_class_list);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 72);
            panel1.TabIndex = 68;
            // 
            // lb_class_name
            // 
            lb_class_name.Anchor = AnchorStyles.Right;
            lb_class_name.AutoSize = true;
            lb_class_name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            lb_class_name.Location = new Point(811, 15);
            lb_class_name.Name = "lb_class_name";
            lb_class_name.Size = new Size(426, 38);
            lb_class_name.TabIndex = 1;
            lb_class_name.Text = "Danh sách học sinh theo lớp";
            // 
            // label_manaStd
            // 
            label_manaStd.AutoSize = true;
            label_manaStd.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaStd.Location = new Point(8, 15);
            label_manaStd.Name = "label_manaStd";
            label_manaStd.Size = new Size(299, 38);
            label_manaStd.TabIndex = 0;
            label_manaStd.Text = "Danh sách học sinh";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(1243, 25);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 95;
            label8.Text = "Chọn lớp : ";
            // 
            // cmb_class_list
            // 
            cmb_class_list.Anchor = AnchorStyles.Right;
            cmb_class_list.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_class_list.FormattingEnabled = true;
            cmb_class_list.Location = new Point(1351, 22);
            cmb_class_list.Name = "cmb_class_list";
            cmb_class_list.Size = new Size(80, 28);
            cmb_class_list.TabIndex = 89;
            cmb_class_list.SelectedIndexChanged += cmb_class_list_SelectedIndexChanged;
            // 
            // txtb_search_by_name
            // 
            txtb_search_by_name.Anchor = AnchorStyles.Bottom;
            txtb_search_by_name.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtb_search_by_name.Location = new Point(683, 571);
            txtb_search_by_name.Name = "txtb_search_by_name";
            txtb_search_by_name.Size = new Size(122, 25);
            txtb_search_by_name.TabIndex = 20;
            txtb_search_by_name.TextChanged += txtb_search_by_name_TextChanged;
            // 
            // textBox_manaStdID
            // 
            textBox_manaStdID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_manaStdID.Location = new Point(1197, 606);
            textBox_manaStdID.Name = "textBox_manaStdID";
            textBox_manaStdID.Size = new Size(80, 27);
            textBox_manaStdID.TabIndex = 92;
            // 
            // button_upload
            // 
            button_upload.Location = new Point(0, 0);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(75, 23);
            button_upload.TabIndex = 76;
            // 
            // radioButton_manaStdFemale
            // 
            radioButton_manaStdFemale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_manaStdFemale.AutoSize = true;
            radioButton_manaStdFemale.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            radioButton_manaStdFemale.ForeColor = Color.Black;
            radioButton_manaStdFemale.Location = new Point(325, 608);
            radioButton_manaStdFemale.Name = "radioButton_manaStdFemale";
            radioButton_manaStdFemale.Size = new Size(57, 27);
            radioButton_manaStdFemale.TabIndex = 9;
            radioButton_manaStdFemale.Text = "Nữ";
            radioButton_manaStdFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton_manaStdMale
            // 
            radioButton_manaStdMale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_manaStdMale.AutoSize = true;
            radioButton_manaStdMale.Checked = true;
            radioButton_manaStdMale.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            radioButton_manaStdMale.ForeColor = Color.Black;
            radioButton_manaStdMale.Location = new Point(325, 575);
            radioButton_manaStdMale.Name = "radioButton_manaStdMale";
            radioButton_manaStdMale.Size = new Size(70, 27);
            radioButton_manaStdMale.TabIndex = 8;
            radioButton_manaStdMale.TabStop = true;
            radioButton_manaStdMale.Text = "Nam";
            radioButton_manaStdMale.UseVisualStyleBackColor = true;
            // 
            // label_manaStdGender
            // 
            label_manaStdGender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_manaStdGender.AutoSize = true;
            label_manaStdGender.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label_manaStdGender.ForeColor = Color.Black;
            label_manaStdGender.Location = new Point(325, 544);
            label_manaStdGender.Name = "label_manaStdGender";
            label_manaStdGender.Size = new Size(102, 23);
            label_manaStdGender.TabIndex = 57;
            label_manaStdGender.Text = "Giới tính : ";
            // 
            // guna2DataGridView_manaStd
            // 
            guna2DataGridView_manaStd.AllowUserToAddRows = false;
            guna2DataGridView_manaStd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            guna2DataGridView_manaStd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView_manaStd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_manaStd.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_manaStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView_manaStd.ColumnHeadersHeight = 24;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_manaStd.DefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView_manaStd.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaStd.Location = new Point(8, 78);
            guna2DataGridView_manaStd.Name = "guna2DataGridView_manaStd";
            guna2DataGridView_manaStd.RowHeadersVisible = false;
            guna2DataGridView_manaStd.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaStd.RowsDefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView_manaStd.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaStd.RowTemplate.Height = 80;
            guna2DataGridView_manaStd.RowTemplate.ReadOnly = true;
            guna2DataGridView_manaStd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_manaStd.Size = new Size(797, 436);
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
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView_manaStd.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_manaStd.ThemeStyle.ReadOnly = false;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaStd.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView_manaStd.CellClick += guna2DataGridView_manaStd_CellClick;
            // 
            // textBox_Name
            // 
            textBox_Name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Name.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Name.Location = new Point(35, 542);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.PlaceholderText = "Họ và tên";
            textBox_Name.Size = new Size(254, 25);
            textBox_Name.TabIndex = 1;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_update.BackColor = Color.MidnightBlue;
            button_update.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(477, 659);
            button_update.Name = "button_update";
            button_update.Size = new Size(125, 38);
            button_update.TabIndex = 9;
            button_update.Text = "Cập nhật";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click_1;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_delete.BackColor = Color.MidnightBlue;
            button_delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(477, 703);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 38);
            button_delete.TabIndex = 10;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click_1;
            // 
            // button_manaStdClear
            // 
            button_manaStdClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_manaStdClear.BackColor = Color.MidnightBlue;
            button_manaStdClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaStdClear.ForeColor = Color.White;
            button_manaStdClear.Location = new Point(477, 536);
            button_manaStdClear.Name = "button_manaStdClear";
            button_manaStdClear.Size = new Size(125, 38);
            button_manaStdClear.TabIndex = 67;
            button_manaStdClear.Text = "Dọn";
            button_manaStdClear.UseVisualStyleBackColor = false;
            button_manaStdClear.Click += button_manaStdClear_Click;
            // 
            // button_addStd
            // 
            button_addStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_addStd.BackColor = Color.MidnightBlue;
            button_addStd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addStd.ForeColor = Color.White;
            button_addStd.Location = new Point(477, 615);
            button_addStd.Name = "button_addStd";
            button_addStd.Size = new Size(125, 38);
            button_addStd.TabIndex = 8;
            button_addStd.Text = "Thêm";
            button_addStd.UseVisualStyleBackColor = false;
            button_addStd.Click += Button_addStd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 633);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 83;
            label1.Text = "Quốc tịch";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(174, 633);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 84;
            label2.Text = "Tỉnh/Thành phố";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 690);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 85;
            label3.Text = "Quận/Huyện";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(174, 690);
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
            guna2HtmlLabel1.Location = new Point(506, 641);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 87;
            guna2HtmlLabel1.Text = null;
            // 
            // comboBox_nation
            // 
            comboBox_nation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_nation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_nation.FormattingEnabled = true;
            comboBox_nation.Location = new Point(35, 653);
            comboBox_nation.Name = "comboBox_nation";
            comboBox_nation.Size = new Size(115, 28);
            comboBox_nation.TabIndex = 3;
            // 
            // combobox_city
            // 
            combobox_city.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            combobox_city.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_city.FormattingEnabled = true;
            combobox_city.Location = new Point(174, 653);
            combobox_city.Name = "combobox_city";
            combobox_city.Size = new Size(115, 28);
            combobox_city.TabIndex = 4;
            // 
            // combobox_district
            // 
            combobox_district.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            combobox_district.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_district.FormattingEnabled = true;
            combobox_district.Location = new Point(35, 710);
            combobox_district.Name = "combobox_district";
            combobox_district.Size = new Size(115, 28);
            combobox_district.TabIndex = 5;
            // 
            // combobox_ward
            // 
            combobox_ward.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            combobox_ward.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_ward.FormattingEnabled = true;
            combobox_ward.Location = new Point(174, 710);
            combobox_ward.Name = "combobox_ward";
            combobox_ward.Size = new Size(115, 28);
            combobox_ward.TabIndex = 6;
            // 
            // textbox_street
            // 
            textbox_street.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textbox_street.Location = new Point(325, 711);
            textbox_street.Name = "textbox_street";
            textbox_street.Size = new Size(115, 27);
            textbox_street.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(620, 702);
            label5.Name = "label5";
            label5.Size = new Size(276, 18);
            label5.TabIndex = 88;
            label5.Text = "* Nhấn vào học sinh để cập nhật hoặc xóa";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(620, 720);
            label6.Name = "label6";
            label6.Size = new Size(430, 18);
            label6.TabIndex = 93;
            label6.Text = "* Chọn học sinh từ danh sách toàn bộ học sinh để thêm vào lớp học";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(999, 608);
            label7.Name = "label7";
            label7.Size = new Size(192, 23);
            label7.TabIndex = 94;
            label7.Text = "ID hệ thống học sinh :";
            // 
            // dtgrid_class
            // 
            dtgrid_class.AllowUserToAddRows = false;
            dtgrid_class.AllowUserToDeleteRows = false;
            dtgrid_class.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtgrid_class.BackgroundColor = Color.White;
            dtgrid_class.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrid_class.Location = new Point(811, 78);
            dtgrid_class.Name = "dtgrid_class";
            dtgrid_class.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dtgrid_class.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtgrid_class.Size = new Size(624, 436);
            dtgrid_class.TabIndex = 96;
            dtgrid_class.CellClick += dtgrid_class_CellClick;
            // 
            // tb_class_id
            // 
            tb_class_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_class_id.Location = new Point(1197, 640);
            tb_class_id.Name = "tb_class_id";
            tb_class_id.Size = new Size(80, 27);
            tb_class_id.TabIndex = 97;
            // 
            // lb_class_id_sys
            // 
            lb_class_id_sys.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb_class_id_sys.AutoSize = true;
            lb_class_id_sys.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lb_class_id_sys.ForeColor = Color.Black;
            lb_class_id_sys.Location = new Point(1040, 640);
            lb_class_id_sys.Name = "lb_class_id_sys";
            lb_class_id_sys.Size = new Size(151, 23);
            lb_class_id_sys.TabIndex = 98;
            lb_class_id_sys.Text = "ID hệ thống lớp :";
            // 
            // bt_add_to_class
            // 
            bt_add_to_class.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_add_to_class.BackColor = Color.MidnightBlue;
            bt_add_to_class.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            bt_add_to_class.ForeColor = Color.White;
            bt_add_to_class.Location = new Point(1297, 588);
            bt_add_to_class.Name = "bt_add_to_class";
            bt_add_to_class.Size = new Size(138, 45);
            bt_add_to_class.TabIndex = 99;
            bt_add_to_class.Text = "Thêm vào lớp";
            bt_add_to_class.UseVisualStyleBackColor = false;
            bt_add_to_class.MouseClick += bt_add_to_class_Click;
            // 
            // btn_delete_from_class
            // 
            btn_delete_from_class.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_from_class.BackColor = Color.MidnightBlue;
            btn_delete_from_class.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_delete_from_class.ForeColor = Color.White;
            btn_delete_from_class.Location = new Point(1297, 641);
            btn_delete_from_class.Name = "btn_delete_from_class";
            btn_delete_from_class.Size = new Size(138, 45);
            btn_delete_from_class.TabIndex = 100;
            btn_delete_from_class.Text = "Xóa khỏi lớp";
            btn_delete_from_class.UseVisualStyleBackColor = false;
            btn_delete_from_class.MouseClick += btn_delete_from_class_Click;
            // 
            // lb_street
            // 
            lb_street.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_street.AutoSize = true;
            lb_street.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            lb_street.ForeColor = Color.Black;
            lb_street.Location = new Point(325, 690);
            lb_street.Name = "lb_street";
            lb_street.Size = new Size(80, 17);
            lb_street.TabIndex = 101;
            lb_street.Text = "Đường phố";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1255, 698);
            button2.Name = "button2";
            button2.Size = new Size(180, 43);
            button2.TabIndex = 102;
            button2.Text = "Môn học và điểm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbb_search_by_level
            // 
            cbb_search_by_level.Anchor = AnchorStyles.Bottom;
            cbb_search_by_level.AutoCompleteCustomSource.AddRange(new string[] { "excellent", "good", "average", "week" });
            cbb_search_by_level.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_search_by_level.FormattingEnabled = true;
            cbb_search_by_level.Items.AddRange(new object[] { "excellent", "good", "average", "weak" });
            cbb_search_by_level.Location = new Point(683, 641);
            cbb_search_by_level.Name = "cbb_search_by_level";
            cbb_search_by_level.Size = new Size(158, 28);
            cbb_search_by_level.TabIndex = 103;
            cbb_search_by_level.SelectedIndexChanged += cbb_search_by_level_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(683, 548);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 104;
            label10.Text = "Tìm theo tên:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(683, 614);
            label11.Name = "label11";
            label11.Size = new Size(158, 23);
            label11.TabIndex = 105;
            label11.Text = "Tìm theo học lực:";
            // 
            // cbb_day
            // 
            cbb_day.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbb_day.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_day.FormattingEnabled = true;
            cbb_day.Location = new Point(35, 598);
            cbb_day.Name = "cbb_day";
            cbb_day.Size = new Size(58, 28);
            cbb_day.TabIndex = 106;
            // 
            // cbb_year
            // 
            cbb_year.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbb_year.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_year.FormattingEnabled = true;
            cbb_year.Location = new Point(199, 598);
            cbb_year.Name = "cbb_year";
            cbb_year.Size = new Size(90, 28);
            cbb_year.TabIndex = 108;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(35, 576);
            label12.Name = "label12";
            label12.Size = new Size(72, 17);
            label12.TabIndex = 109;
            label12.Text = "Ngày sinh";
            // 
            // cbb_month
            // 
            cbb_month.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbb_month.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_month.FormattingEnabled = true;
            cbb_month.Location = new Point(113, 598);
            cbb_month.Name = "cbb_month";
            cbb_month.Size = new Size(58, 28);
            cbb_month.TabIndex = 110;
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 753);
            Controls.Add(cbb_month);
            Controls.Add(label12);
            Controls.Add(cbb_year);
            Controls.Add(cbb_day);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cbb_search_by_level);
            Controls.Add(button2);
            Controls.Add(lb_street);
            Controls.Add(btn_delete_from_class);
            Controls.Add(bt_add_to_class);
            Controls.Add(lb_class_id_sys);
            Controls.Add(tb_class_id);
            Controls.Add(txtb_search_by_name);
            Controls.Add(dtgrid_class);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox_manaStdID);
            Controls.Add(label5);
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
            Controls.Add(button_manaStdClear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_upload);
            Controls.Add(radioButton_manaStdFemale);
            Controls.Add(radioButton_manaStdMale);
            Controls.Add(label_manaStdGender);
            Controls.Add(guna2DataGridView_manaStd);
            Controls.Add(textBox_Name);
            Controls.Add(button1);
            Controls.Add(textBox_email);
            Controls.Add(label9);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            Click += ManageStudentForm_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaStd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgrid_class).EndInit();
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
        private TextBox txtb_search_by_name;
        private Label label_manaStd;
        private Button button_upload;
        private RadioButton radioButton_manaStdFemale;
        private RadioButton radioButton_manaStdMale;
        private Label label_manaStdGender;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_manaStd;
        private TextBox textBox_Name;
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
        private Label label5;
        private ComboBox cmb_class_list;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dtgrid_class;
        private TextBox tb_class_id;
        private Label lb_class_id_sys;
        private Label lb_class_name;
        private Button bt_add_to_class;
        private Button btn_delete_from_class;
        private Label lb_street;
        private Button button2;
        private ComboBox cbb_search_by_level;
        private Label label10;
        private Label label11;
        private ComboBox cbb_day;
        private ComboBox cbb_year;
        private Label label12;
        private ComboBox cbb_month;
    }
}