namespace StudentManagement
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.stripStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMajor = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.stripInsertMark = new System.Windows.Forms.ToolStripMenuItem();
            this.stripViewMark = new System.Windows.Forms.ToolStripMenuItem();
            this.stripStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripSystem,
            this.stripFunction,
            this.stripSupport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripSystem
            // 
            this.stripSystem.Name = "stripSystem";
            this.stripSystem.Size = new System.Drawing.Size(69, 20);
            this.stripSystem.Text = "Hệ thống";
            // 
            // stripFunction
            // 
            this.stripFunction.Name = "stripFunction";
            this.stripFunction.Size = new System.Drawing.Size(77, 20);
            this.stripFunction.Text = "Chức năng";
            // 
            // stripSupport
            // 
            this.stripSupport.Name = "stripSupport";
            this.stripSupport.Size = new System.Drawing.Size(54, 20);
            this.stripSupport.Text = "Hỗ Trợ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStudent,
            this.stripMajor,
            this.stripSubject,
            this.stripInsertMark,
            this.stripViewMark,
            this.stripStatistical});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(946, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // stripStudent
            // 
            this.stripStudent.Name = "stripStudent";
            this.stripStudent.Size = new System.Drawing.Size(67, 20);
            this.stripStudent.Text = "Sinh viên";
            this.stripStudent.Click += new System.EventHandler(this.stripStudent_Click);
            // 
            // stripMajor
            // 
            this.stripMajor.Name = "stripMajor";
            this.stripMajor.Size = new System.Drawing.Size(46, 20);
            this.stripMajor.Text = "Khoa";
            // 
            // stripSubject
            // 
            this.stripSubject.Name = "stripSubject";
            this.stripSubject.Size = new System.Drawing.Size(67, 20);
            this.stripSubject.Text = "Môn học";
            // 
            // stripInsertMark
            // 
            this.stripInsertMark.Name = "stripInsertMark";
            this.stripInsertMark.Size = new System.Drawing.Size(78, 20);
            this.stripInsertMark.Text = "Nhập điểm";
            this.stripInsertMark.Click += new System.EventHandler(this.stripInsertMark_Click);
            // 
            // stripViewMark
            // 
            this.stripViewMark.Name = "stripViewMark";
            this.stripViewMark.Size = new System.Drawing.Size(73, 20);
            this.stripViewMark.Text = "Xem điểm";
            this.stripViewMark.Click += new System.EventHandler(this.stripViewMark_Click);
            // 
            // stripStatistical
            // 
            this.stripStatistical.Name = "stripStatistical";
            this.stripStatistical.Size = new System.Drawing.Size(97, 20);
            this.stripStatistical.Text = "Thống kê khoa";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 615);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripSystem;
        private System.Windows.Forms.ToolStripMenuItem stripFunction;
        private System.Windows.Forms.ToolStripMenuItem stripSupport;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stripStudent;
        private System.Windows.Forms.ToolStripMenuItem stripMajor;
        private System.Windows.Forms.ToolStripMenuItem stripSubject;
        private System.Windows.Forms.ToolStripMenuItem stripInsertMark;
        private System.Windows.Forms.ToolStripMenuItem stripViewMark;
        private System.Windows.Forms.ToolStripMenuItem stripStatistical;
    }
}