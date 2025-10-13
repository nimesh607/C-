namespace CRUDUsingStoredProcedures
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            
            tbSalary = new TextBox();
            lblSalary = new Label();
            tbJob = new TextBox();
            lblJob = new Label();
            tbEno = new TextBox();
            lblEno = new Label();
            tbEname = new TextBox();
            lblEname = new Label();
            lblTitle = new Label();
            btnClear = new Button();
            btnSelect = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            btnloadImage = new Button();
            btnClearImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(107, 181);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(254, 35);
            tbSalary.TabIndex = 2;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(17, 184);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(68, 30);
            lblSalary.TabIndex = 18;
            lblSalary.Text = "Salary";
            // 
            // tbJob
            // 
            tbJob.Location = new Point(107, 140);
            tbJob.Name = "tbJob";
            tbJob.Size = new Size(254, 35);
            tbJob.TabIndex = 1;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(17, 145);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(45, 30);
            lblJob.TabIndex = 16;
            lblJob.Text = "Job";
            // 
            // tbEno
            // 
            tbEno.Enabled = false;
            tbEno.Location = new Point(107, 58);
            tbEno.Name = "tbEno";
            tbEno.Size = new Size(254, 35);
            tbEno.TabIndex = 11;
            // 
            // lblEno
            // 
            lblEno.AutoSize = true;
            lblEno.Location = new Point(14, 58);
            lblEno.Name = "lblEno";
            lblEno.Size = new Size(48, 30);
            lblEno.TabIndex = 14;
            lblEno.Text = "Eno";
            // 
            // tbEname
            // 
            tbEname.Location = new Point(107, 99);
            tbEname.Name = "tbEname";
            tbEname.Size = new Size(254, 35);
            tbEname.TabIndex = 0;
            // 
            // lblEname
            // 
            lblEname.AutoSize = true;
            lblEname.Location = new Point(14, 106);
            lblEname.Name = "lblEname";
            lblEname.Size = new Size(76, 30);
            lblEname.TabIndex = 12;
            lblEname.Text = "Ename";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 255, 192);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(684, 43);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Employee Details";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(131, 232);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(17, 232);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(108, 43);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(245, 232);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(98, 43);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(131, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 43);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(17, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 43);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(245, 281);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 43);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnloadImage
            // 
            btnloadImage.Location = new Point(367, 281);
            btnloadImage.Name = "btnloadImage";
            btnloadImage.Size = new Size(305, 43);
            btnloadImage.TabIndex = 3;
            btnloadImage.Text = "Load Image";
            btnloadImage.UseVisualStyleBackColor = true;
            btnloadImage.Click += btnloadImage_Click;
            // 
            // btnClearImage
            // 
            btnClearImage.BackgroundImage = (Image)resources.GetObject("btnClearImage.BackgroundImage");
            btnClearImage.BackgroundImageLayout = ImageLayout.Center;
            btnClearImage.Location = new Point(625, 59);
            btnClearImage.Name = "btnClearImage";
            btnClearImage.Size = new Size(47, 50);
            btnClearImage.TabIndex = 10;
            btnClearImage.UseVisualStyleBackColor = true;
            btnClearImage.Click += btnClearImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(367, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 335);
            Controls.Add(btnClearImage);
            Controls.Add(btnloadImage);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnClear);
            Controls.Add(btnSelect);
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
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSalary;
        private Label lblSalary;
        private TextBox tbJob;
        private Label lblJob;
        private TextBox tbEno;
        private Label lblEno;
        private TextBox tbEname;
        private Label lblEname;
        private Label lblTitle;
        private Button btnClear;
        private Button btnSelect;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnloadImage;
        private Button btnClearImage;
        private OpenFileDialog openFileDialog1;
    }
}