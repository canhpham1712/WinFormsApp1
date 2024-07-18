namespace WinFormsApp1
{
    partial class RegistrationForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            guna2DataGridView_students = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_firstName = new TextBox();
            dataGridViewTextBoxEditingControlBindingSource = new BindingSource(components);
            textBox_lastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            label5 = new Label();
            textBox_address = new TextBox();
            pictureBox_student = new PictureBox();
            button_upload = new Button();
            textBox_phone = new TextBox();
            label6 = new Label();
            button_add = new Button();
            button_clear = new Button();
            panel1 = new Panel();
            button_search = new Button();
            textBox_search = new TextBox();
            label7 = new Label();
            textBox_ID = new TextBox();
            label8 = new Label();
            textBox_email = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_students).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(-15, 391);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 1;
            label1.Text = "First Name : ";
            // 
            // guna2DataGridView_students
            // 
            guna2DataGridView_students.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView_students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView_students.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_students.BackgroundColor = Color.Gainsboro;
            guna2DataGridView_students.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView_students.ColumnHeadersHeight = 24;
            guna2DataGridView_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_students.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView_students.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_students.Location = new Point(12, 78);
            guna2DataGridView_students.Name = "guna2DataGridView_students";
            guna2DataGridView_students.RowHeadersVisible = false;
            guna2DataGridView_students.RowHeadersWidth = 51;
            guna2DataGridView_students.RowTemplate.Height = 80;
            guna2DataGridView_students.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_students.Size = new Size(1158, 277);
            guna2DataGridView_students.TabIndex = 3;
            guna2DataGridView_students.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView_students.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView_students.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView_students.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView_students.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView_students.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView_students.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_students.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView_students.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView_students.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_students.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView_students.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView_students.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_students.ThemeStyle.ReadOnly = false;
            guna2DataGridView_students.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_students.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_students.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_students.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_students.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_students.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_students.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // textBox_firstName
            // 
            textBox_firstName.Anchor = AnchorStyles.Bottom;
            textBox_firstName.DataBindings.Add(new Binding("Tag", dataGridViewTextBoxEditingControlBindingSource, "EditingControlDataGridView", true));
            textBox_firstName.Location = new Point(121, 386);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(129, 32);
            textBox_firstName.TabIndex = 2;
            // 
            // dataGridViewTextBoxEditingControlBindingSource
            // 
            dataGridViewTextBoxEditingControlBindingSource.DataSource = typeof(DataGridViewTextBoxEditingControl);
            // 
            // textBox_lastName
            // 
            textBox_lastName.Anchor = AnchorStyles.Bottom;
            textBox_lastName.Location = new Point(388, 386);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(162, 32);
            textBox_lastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(256, 391);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 4;
            label2.Text = "Last Name : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(-31, 438);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 6;
            label3.Text = "Date of Birth : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom;
            dateTimePicker1.Location = new Point(121, 433);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(427, 32);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(590, 438);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 8;
            label4.Text = "Gender : ";
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.ForeColor = SystemColors.Highlight;
            radioButton_male.Location = new Point(720, 438);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 9;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom;
            radioButton_female.AutoSize = true;
            radioButton_female.ForeColor = SystemColors.Highlight;
            radioButton_female.Location = new Point(835, 436);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(105, 27);
            radioButton_female.TabIndex = 10;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(9, 489);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 11;
            label5.Text = "Address : ";
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Bottom;
            textBox_address.Location = new Point(121, 481);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(429, 38);
            textBox_address.TabIndex = 12;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(972, 381);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(125, 135);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 13;
            pictureBox_student.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.MidnightBlue;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(972, 517);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(125, 38);
            button_upload.TabIndex = 14;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Bottom;
            textBox_phone.Location = new Point(720, 484);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(220, 32);
            textBox_phone.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(603, 489);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 15;
            label6.Text = "Phone : ";
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.MidnightBlue;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(813, 559);
            button_add.Name = "button_add";
            button_add.Size = new Size(125, 38);
            button_add.TabIndex = 17;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.MidnightBlue;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(972, 559);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 38);
            button_clear.TabIndex = 18;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button_search);
            panel1.Controls.Add(textBox_search);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 72);
            panel1.TabIndex = 19;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top;
            button_search.BackColor = Color.MidnightBlue;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.WhiteSmoke;
            button_search.Location = new Point(698, 19);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 38);
            button_search.TabIndex = 25;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top;
            textBox_search.DataBindings.Add(new Binding("Tag", dataGridViewTextBoxEditingControlBindingSource, "EditingControlDataGridView", true));
            textBox_search.Location = new Point(221, 21);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(434, 32);
            textBox_search.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 13);
            label7.Name = "label7";
            label7.Size = new Size(207, 40);
            label7.TabIndex = 0;
            label7.Text = "Registration";
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.Bottom;
            textBox_ID.DataBindings.Add(new Binding("Tag", dataGridViewTextBoxEditingControlBindingSource, "EditingControlDataGridView", true));
            textBox_ID.Location = new Point(720, 386);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(220, 32);
            textBox_ID.TabIndex = 21;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(566, 391);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 20;
            label8.Text = "Student ID : ";
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Bottom;
            textBox_email.DataBindings.Add(new Binding("Tag", dataGridViewTextBoxEditingControlBindingSource, "EditingControlDataGridView", true));
            textBox_email.Location = new Point(121, 541);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(427, 32);
            textBox_email.TabIndex = 23;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(35, 547);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 22;
            label9.Text = "Email : ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(12, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(1158, 16);
            panel2.TabIndex = 25;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 603);
            Controls.Add(panel2);
            Controls.Add(textBox_email);
            Controls.Add(label9);
            Controls.Add(textBox_ID);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(button_clear);
            Controls.Add(button_add);
            Controls.Add(textBox_phone);
            Controls.Add(label6);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_student);
            Controls.Add(textBox_address);
            Controls.Add(label5);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox_lastName);
            Controls.Add(label2);
            Controls.Add(guna2DataGridView_students);
            Controls.Add(textBox_firstName);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 650);
            Name = "RegistrationForm";
            Text = "RegisterForm";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_students).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTextBoxEditingControlBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_students;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private Label label5;
        private TextBox textBox_address;
        private PictureBox pictureBox_student;
        private Button button_upload;
        private TextBox textBox_phone;
        private Label label6;
        private Button button_add;
        private Button button_clear;
        private Panel panel1;
        private Label label7;
        private BindingSource dataGridViewTextBoxEditingControlBindingSource;
        private TextBox textBox_ID;
        private Label label8;
        private TextBox textBox_email;
        private Label label9;
        private TextBox textBox_search;
        private Button button_search;
        private Panel panel2;
    }
}