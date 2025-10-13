namespace CRUDUsingStoredProcedures
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
            lblTitle = new Label();
            lblEname = new Label();
            tbEname = new TextBox();
            tbEno = new TextBox();
            lblEno = new Label();
            tbJob = new TextBox();
            lblJob = new Label();
            tbSalary = new TextBox();
            lblSalary = new Label();
            lblStatus = new Label();
            cbStatus = new CheckBox();
            btnNext = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 255, 192);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Details";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEname
            // 
            lblEname.AutoSize = true;
            lblEname.Location = new Point(12, 100);
            lblEname.Name = "lblEname";
            lblEname.Size = new Size(76, 30);
            lblEname.TabIndex = 1;
            lblEname.Text = "Ename";
            // 
            // tbEname
            // 
            tbEname.Location = new Point(105, 100);
            tbEname.Name = "tbEname";
            tbEname.Size = new Size(254, 35);
            tbEname.TabIndex = 2;
            // 
            // tbEno
            // 
            tbEno.Enabled = false;
            tbEno.Location = new Point(105, 52);
            tbEno.Name = "tbEno";
            tbEno.Size = new Size(254, 35);
            tbEno.TabIndex = 4;
            // 
            // lblEno
            // 
            lblEno.AutoSize = true;
            lblEno.Location = new Point(12, 52);
            lblEno.Name = "lblEno";
            lblEno.Size = new Size(48, 30);
            lblEno.TabIndex = 3;
            lblEno.Text = "Eno";
            // 
            // tbJob
            // 
            tbJob.Location = new Point(105, 158);
            tbJob.Name = "tbJob";
            tbJob.Size = new Size(254, 35);
            tbJob.TabIndex = 6;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(12, 158);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(45, 30);
            lblJob.TabIndex = 5;
            lblJob.Text = "Job";
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(105, 209);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(254, 35);
            tbSalary.TabIndex = 8;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(12, 209);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(68, 30);
            lblSalary.TabIndex = 7;
            lblSalary.Text = "Salary";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 259);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 30);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(105, 259);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(15, 14);
            cbStatus.TabIndex = 10;
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(25, 306);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(108, 43);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(139, 306);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(108, 43);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(btnClose);
            Controls.Add(btnNext);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(tbSalary);
            Controls.Add(lblSalary);
            Controls.Add(tbJob);
            Controls.Add(lblJob);
            Controls.Add(tbEno);
            Controls.Add(lblEno);
            Controls.Add(tbEname);
            Controls.Add(lblEname);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEname;
        private TextBox tbEname;
        private TextBox tbEno;
        private Label lblEno;
        private TextBox tbJob;
        private Label lblJob;
        private TextBox tbSalary;
        private Label lblSalary;
        private Label lblStatus;
        private CheckBox cbStatus;
        private Button btnNext;
        private Button btnClose;
    }
}
