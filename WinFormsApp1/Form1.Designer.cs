namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_slide = new Panel();
            button_dashboard = new Button();
            button_score = new Button();
            label_totalFemaleStd = new Label();
            label_totalMaleStd = new Label();
            button_std = new Button();
            panel_logo = new Panel();
            pictureBox2 = new PictureBox();
            label_welcome = new Label();
            label2 = new Label();
            label_totalStd = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel_slide.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.MidnightBlue;
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(label_totalFemaleStd);
            panel_slide.Controls.Add(label_totalMaleStd);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Controls.Add(label_totalStd);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(170, 753);
            panel_slide.TabIndex = 0;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.RoyalBlue;
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 275);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(170, 48);
            button_dashboard.TabIndex = 6;
            button_dashboard.Text = "Trang chủ";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_score
            // 
            button_score.BackColor = Color.RoyalBlue;
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 227);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(170, 48);
            button_score.TabIndex = 4;
            button_score.Text = "Điểm";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = false;
            button_score.Click += button_score_Click;
            // 
            // label_totalFemaleStd
            // 
            label_totalFemaleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalFemaleStd.AutoSize = true;
            label_totalFemaleStd.ForeColor = Color.White;
            label_totalFemaleStd.Location = new Point(78, 531);
            label_totalFemaleStd.Name = "label_totalFemaleStd";
            label_totalFemaleStd.Size = new Size(40, 20);
            label_totalFemaleStd.TabIndex = 2;
            label_totalFemaleStd.Text = "Nữ : ";
            // 
            // label_totalMaleStd
            // 
            label_totalMaleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalMaleStd.AutoSize = true;
            label_totalMaleStd.ForeColor = Color.White;
            label_totalMaleStd.Location = new Point(6, 531);
            label_totalMaleStd.Name = "label_totalMaleStd";
            label_totalMaleStd.Size = new Size(52, 20);
            label_totalMaleStd.TabIndex = 3;
            label_totalMaleStd.Text = "Nam : ";
            // 
            // button_std
            // 
            button_std.BackColor = Color.RoyalBlue;
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 179);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(170, 48);
            button_std.TabIndex = 1;
            button_std.Text = "Học sinh";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = false;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.RoyalBlue;
            panel_logo.Controls.Add(pictureBox2);
            panel_logo.Controls.Add(label_welcome);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(170, 179);
            panel_logo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.Location = new Point(37, 46);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(96, 28);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Welcome";
            label_welcome.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 46);
            label2.TabIndex = 1;
            label2.Text = "HCMUT";
            label2.UseWaitCursor = true;
            // 
            // label_totalStd
            // 
            label_totalStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalStd.AutoSize = true;
            label_totalStd.ForeColor = Color.White;
            label_totalStd.Location = new Point(6, 501);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(112, 20);
            label_totalStd.TabIndex = 1;
            label_totalStd.Text = "Tổng học sinh : ";
            label_totalStd.Click += label_totalStd_Click;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(170, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1447, 753);
            panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(1447, 753);
            panel_cover.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 656);
            panel3.Name = "panel3";
            panel3.Size = new Size(1447, 97);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label_role);
            panel2.Controls.Add(label_user);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1447, 89);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1367, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.ForeColor = Color.White;
            label_role.Location = new Point(118, 49);
            label_role.Name = "label_role";
            label_role.Size = new Size(53, 20);
            label_role.TabIndex = 3;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(118, 17);
            label_user.Name = "label_user";
            label_user.Size = new Size(38, 20);
            label_user.TabIndex = 2;
            label_user.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 49);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "Role: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 68);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(30, 21);
            label10.Name = "label10";
            label10.Size = new Size(373, 25);
            label10.TabIndex = 1;
            label10.Text = "Ho Chi Minh City University of Technology";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1617, 753);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            ForeColor = SystemColors.ControlLight;
            MinimumSize = new Size(1500, 800);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý học sinh";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_slide.PerformLayout();
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Panel panel_logo;
        private Button button_std;
        private Button button_score;
        private Button button_dashboard;
        private Label label2;
        private Label label_welcome;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label_totalStd;
        private Label label_role;
        private Label label_user;
        private Label label_totalMaleStd;
        private Label label_totalFemaleStd;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
    }
}
