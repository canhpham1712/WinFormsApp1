namespace WinFormsApp1
{
    partial class LinqTest
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
            dgv_test_std_list = new DataGridView();
            dgv_score = new DataGridView();
            cbb_course_list = new ComboBox();
            tb_course_id = new TextBox();
            tb_std_id = new TextBox();
            tb_std_name = new TextBox();
            bt_add = new Button();
            bt_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_test_std_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_score).BeginInit();
            SuspendLayout();
            // 
            // dgv_test_std_list
            // 
            dgv_test_std_list.AllowUserToAddRows = false;
            dgv_test_std_list.AllowUserToDeleteRows = false;
            dgv_test_std_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_test_std_list.Location = new Point(12, 76);
            dgv_test_std_list.Name = "dgv_test_std_list";
            dgv_test_std_list.RowHeadersWidth = 51;
            dgv_test_std_list.Size = new Size(437, 188);
            dgv_test_std_list.TabIndex = 0;
            dgv_test_std_list.CellClick += dgv_test_std_list_CellClick;
            // 
            // dgv_score
            // 
            dgv_score.AllowUserToAddRows = false;
            dgv_score.AllowUserToDeleteRows = false;
            dgv_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_score.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_score.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_score.Location = new Point(455, 76);
            dgv_score.Name = "dgv_score";
            dgv_score.RowHeadersWidth = 51;
            dgv_score.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_score.Size = new Size(333, 188);
            dgv_score.TabIndex = 1;
            dgv_score.CellEndEdit += dgv_score_CellEndEdit;
            dgv_score.KeyDown += dgv_score_KeyDown;
            // 
            // cbb_course_list
            // 
            cbb_course_list.FormattingEnabled = true;
            cbb_course_list.Location = new Point(517, 28);
            cbb_course_list.Name = "cbb_course_list";
            cbb_course_list.Size = new Size(106, 28);
            cbb_course_list.TabIndex = 2;
            cbb_course_list.SelectedIndexChanged += cbb_course_list_SelectedIndexChanged;
            // 
            // tb_course_id
            // 
            tb_course_id.Location = new Point(671, 29);
            tb_course_id.Name = "tb_course_id";
            tb_course_id.Size = new Size(101, 27);
            tb_course_id.TabIndex = 3;
            // 
            // tb_std_id
            // 
            tb_std_id.Location = new Point(124, 306);
            tb_std_id.Name = "tb_std_id";
            tb_std_id.Size = new Size(125, 27);
            tb_std_id.TabIndex = 4;
            // 
            // tb_std_name
            // 
            tb_std_name.Location = new Point(124, 354);
            tb_std_name.Name = "tb_std_name";
            tb_std_name.Size = new Size(125, 27);
            tb_std_name.TabIndex = 5;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(313, 306);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 29);
            bt_add.TabIndex = 6;
            bt_add.Text = "button1";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(313, 352);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(94, 29);
            bt_delete.TabIndex = 7;
            bt_delete.Text = "delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // LinqTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_delete);
            Controls.Add(bt_add);
            Controls.Add(tb_std_name);
            Controls.Add(tb_std_id);
            Controls.Add(tb_course_id);
            Controls.Add(cbb_course_list);
            Controls.Add(dgv_score);
            Controls.Add(dgv_test_std_list);
            Name = "LinqTest";
            Text = "LinqTest";
            Load += LinqTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_test_std_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_test_std_list;
        private DataGridView dgv_score;
        private ComboBox cbb_course_list;
        private TextBox tb_course_id;
        private TextBox tb_std_id;
        private TextBox tb_std_name;
        private Button bt_add;
        private Button bt_delete;
    }
}