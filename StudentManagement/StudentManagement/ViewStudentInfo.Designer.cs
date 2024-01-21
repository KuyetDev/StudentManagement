namespace StudentManagement
{
    partial class ViewStudentInfo
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
            this.cbMajorCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMajorCode
            // 
            this.cbMajorCode.FormattingEnabled = true;
            this.cbMajorCode.Location = new System.Drawing.Point(104, 54);
            this.cbMajorCode.Name = "cbMajorCode";
            this.cbMajorCode.Size = new System.Drawing.Size(290, 23);
            this.cbMajorCode.TabIndex = 0;
            this.cbMajorCode.TextChanged += new System.EventHandler(this.cbMajorCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khoa";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(432, 96);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 32);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(33, 160);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 25;
            this.dgvInfo.Size = new System.Drawing.Size(729, 262);
            this.dgvInfo.TabIndex = 5;
            // 
            // txtMajorName
            // 
            this.txtMajorName.Location = new System.Drawing.Point(104, 113);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.ReadOnly = true;
            this.txtMajorName.Size = new System.Drawing.Size(290, 23);
            this.txtMajorName.TabIndex = 6;
            // 
            // ViewStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMajorCode);
            this.Name = "ViewStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem sinh viên theo khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMajorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.TextBox txtMajorName;
    }
}