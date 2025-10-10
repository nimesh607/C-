namespace CRUDDemo
{
    partial class Form2
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
            label1 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnNew = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSaveDb = new Button();
            btnSearch = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 49);
            label1.TabIndex = 1;
            label1.Text = "Employee Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 23);
            textBox4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 223);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 15;
            label5.Text = "Salary:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 57);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 168);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 11;
            label4.Text = "Job:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "Ename:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 57);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 9;
            label2.Text = "Eno:";
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(12, 252);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(86, 41);
            btnFirst.TabIndex = 17;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(104, 252);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 41);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(288, 252);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(78, 41);
            btnLast.TabIndex = 19;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(196, 252);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 41);
            btnNext.TabIndex = 20;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 299);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 41);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(102, 299);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 41);
            btnInsert.TabIndex = 22;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(196, 299);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 41);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(288, 299);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 41);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveDb
            // 
            btnSaveDb.Location = new Point(12, 346);
            btnSaveDb.Name = "btnSaveDb";
            btnSaveDb.Size = new Size(176, 33);
            btnSaveDb.TabIndex = 25;
            btnSaveDb.Text = "Save to Database";
            btnSaveDb.UseVisualStyleBackColor = true;
            btnSaveDb.Click += btnSaveDb_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(194, 342);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 41);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(286, 342);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 40);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 390);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(btnSaveDb);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnNew);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnNext;
        private Button btnNew;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSaveDb;
        private Button btnSearch;
        private Button btnClose;
    }
}