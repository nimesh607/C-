namespace CourseForm
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
            label1 = new Label();
            lblTitle = new Label();
            txtName = new TextBox();
            txtFees = new TextBox();
            lblFees = new Label();
            gbCourses = new GroupBox();
            groupBox3 = new GroupBox();
            cbMysql = new CheckBox();
            cbPython = new CheckBox();
            cbMongodb = new CheckBox();
            cbPhp = new CheckBox();
            cbReact = new CheckBox();
            cbOracle = new CheckBox();
            cbAdvJava = new CheckBox();
            cbCoreJava = new CheckBox();
            cbAngular = new CheckBox();
            cbSqlServer = new CheckBox();
            cbAsp = new CheckBox();
            cbCSharp = new CheckBox();
            cbLinux = new CheckBox();
            cbUnix = new CheckBox();
            cbCpp = new CheckBox();
            cbC = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbTrack = new GroupBox();
            rbSuperFast = new RadioButton();
            rbFast = new RadioButton();
            rbNormal = new RadioButton();
            btnReset = new Button();
            btnClose = new Button();
            gbCourses.SuspendLayout();
            gbTrack.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(117, 9);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(777, 56);
            label1.TabIndex = 0;
            label1.Text = "Information Technologies Courses";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 79);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(120, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(370, 42);
            txtName.TabIndex = 2;
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.Location = new Point(779, 90);
            txtFees.Name = "txtFees";
            txtFees.ReadOnly = true;
            txtFees.Size = new Size(191, 42);
            txtFees.TabIndex = 4;
            txtFees.Text = "0";
            txtFees.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(606, 97);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(167, 35);
            lblFees.TabIndex = 3;
            lblFees.Text = "Total Fees: ";
            // 
            // gbCourses
            // 
            gbCourses.BackColor = Color.Wheat;
            gbCourses.Controls.Add(groupBox3);
            gbCourses.Controls.Add(cbMysql);
            gbCourses.Controls.Add(cbPython);
            gbCourses.Controls.Add(cbMongodb);
            gbCourses.Controls.Add(cbPhp);
            gbCourses.Controls.Add(cbReact);
            gbCourses.Controls.Add(cbOracle);
            gbCourses.Controls.Add(cbAdvJava);
            gbCourses.Controls.Add(cbCoreJava);
            gbCourses.Controls.Add(cbAngular);
            gbCourses.Controls.Add(cbSqlServer);
            gbCourses.Controls.Add(cbAsp);
            gbCourses.Controls.Add(cbCSharp);
            gbCourses.Controls.Add(cbLinux);
            gbCourses.Controls.Add(cbUnix);
            gbCourses.Controls.Add(cbCpp);
            gbCourses.Controls.Add(cbC);
            gbCourses.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCourses.Location = new Point(18, 137);
            gbCourses.Name = "gbCourses";
            gbCourses.Size = new Size(952, 187);
            gbCourses.TabIndex = 5;
            gbCourses.TabStop = false;
            gbCourses.Text = "Courses Offered";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(348, 232);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox2";
            // 
            // cbMysql
            // 
            cbMysql.AutoSize = true;
            cbMysql.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMysql.Location = new Point(652, 146);
            cbMysql.Name = "cbMysql";
            cbMysql.Size = new Size(163, 30);
            cbMysql.TabIndex = 15;
            cbMysql.Text = "MySql(3000)";
            cbMysql.UseVisualStyleBackColor = true;
            cbMysql.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbPython
            // 
            cbPython.AutoSize = true;
            cbPython.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPython.Location = new Point(652, 110);
            cbPython.Name = "cbPython";
            cbPython.Size = new Size(171, 30);
            cbPython.TabIndex = 14;
            cbPython.Text = "Python(4000)";
            cbPython.UseVisualStyleBackColor = true;
            cbPython.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbMongodb
            // 
            cbMongodb.AutoSize = true;
            cbMongodb.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMongodb.Location = new Point(652, 74);
            cbMongodb.Name = "cbMongodb";
            cbMongodb.Size = new Size(206, 30);
            cbMongodb.TabIndex = 13;
            cbMongodb.Text = "Mongo Db(2000)";
            cbMongodb.UseVisualStyleBackColor = true;
            cbMongodb.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbPhp
            // 
            cbPhp.AutoSize = true;
            cbPhp.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhp.Location = new Point(652, 38);
            cbPhp.Name = "cbPhp";
            cbPhp.Size = new Size(141, 30);
            cbPhp.TabIndex = 12;
            cbPhp.Text = "Php(4000)";
            cbPhp.UseVisualStyleBackColor = true;
            cbPhp.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbReact
            // 
            cbReact.AutoSize = true;
            cbReact.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbReact.Location = new Point(431, 146);
            cbReact.Name = "cbReact";
            cbReact.Size = new Size(163, 30);
            cbReact.TabIndex = 11;
            cbReact.Text = "React(5000)";
            cbReact.UseVisualStyleBackColor = true;
            cbReact.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbOracle
            // 
            cbOracle.AutoSize = true;
            cbOracle.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOracle.Location = new Point(431, 110);
            cbOracle.Name = "cbOracle";
            cbOracle.Size = new Size(170, 30);
            cbOracle.TabIndex = 10;
            cbOracle.Text = "Oracle(2500)";
            cbOracle.UseVisualStyleBackColor = true;
            cbOracle.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbAdvJava
            // 
            cbAdvJava.AutoSize = true;
            cbAdvJava.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAdvJava.Location = new Point(431, 74);
            cbAdvJava.Name = "cbAdvJava";
            cbAdvJava.Size = new Size(195, 30);
            cbAdvJava.TabIndex = 9;
            cbAdvJava.Text = "Adv Java(4500)";
            cbAdvJava.UseVisualStyleBackColor = true;
            cbAdvJava.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbCoreJava
            // 
            cbCoreJava.AutoSize = true;
            cbCoreJava.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCoreJava.Location = new Point(431, 38);
            cbCoreJava.Name = "cbCoreJava";
            cbCoreJava.Size = new Size(208, 30);
            cbCoreJava.TabIndex = 8;
            cbCoreJava.Text = "Core Java(3500)";
            cbCoreJava.UseVisualStyleBackColor = true;
            cbCoreJava.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbAngular
            // 
            cbAngular.AutoSize = true;
            cbAngular.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAngular.Location = new Point(203, 146);
            cbAngular.Name = "cbAngular";
            cbAngular.Size = new Size(178, 30);
            cbAngular.TabIndex = 7;
            cbAngular.Text = "Angular(5000)";
            cbAngular.UseVisualStyleBackColor = true;
            cbAngular.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbSqlServer
            // 
            cbSqlServer.AutoSize = true;
            cbSqlServer.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSqlServer.Location = new Point(203, 110);
            cbSqlServer.Name = "cbSqlServer";
            cbSqlServer.Size = new Size(221, 30);
            cbSqlServer.TabIndex = 6;
            cbSqlServer.Text = "SQL Server(2000)";
            cbSqlServer.UseVisualStyleBackColor = true;
            cbSqlServer.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbAsp
            // 
            cbAsp.AutoSize = true;
            cbAsp.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAsp.Location = new Point(203, 74);
            cbAsp.Name = "cbAsp";
            cbAsp.Size = new Size(186, 30);
            cbAsp.TabIndex = 5;
            cbAsp.Text = "ASP.Net(4000)";
            cbAsp.UseVisualStyleBackColor = true;
            cbAsp.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbCSharp
            // 
            cbCSharp.AutoSize = true;
            cbCSharp.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCSharp.Location = new Point(203, 38);
            cbCSharp.Name = "cbCSharp";
            cbCSharp.Size = new Size(132, 30);
            cbCSharp.TabIndex = 4;
            cbCSharp.Text = "C#(3000)";
            cbCSharp.UseVisualStyleBackColor = true;
            cbCSharp.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbLinux
            // 
            cbLinux.AutoSize = true;
            cbLinux.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLinux.Location = new Point(6, 146);
            cbLinux.Name = "cbLinux";
            cbLinux.Size = new Size(155, 30);
            cbLinux.TabIndex = 3;
            cbLinux.Text = "Linux(4000)";
            cbLinux.UseVisualStyleBackColor = true;
            cbLinux.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbUnix
            // 
            cbUnix.AutoSize = true;
            cbUnix.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUnix.Location = new Point(6, 110);
            cbUnix.Name = "cbUnix";
            cbUnix.Size = new Size(147, 30);
            cbUnix.TabIndex = 2;
            cbUnix.Text = "Unix(2000)";
            cbUnix.UseVisualStyleBackColor = true;
            cbUnix.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbCpp
            // 
            cbCpp.AutoSize = true;
            cbCpp.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCpp.Location = new Point(6, 74);
            cbCpp.Name = "cbCpp";
            cbCpp.Size = new Size(145, 30);
            cbCpp.TabIndex = 1;
            cbCpp.Text = "C++(2500)";
            cbCpp.UseVisualStyleBackColor = true;
            cbCpp.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // cbC
            // 
            cbC.AutoSize = true;
            cbC.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbC.Location = new Point(6, 38);
            cbC.Name = "cbC";
            cbC.Size = new Size(119, 30);
            cbC.TabIndex = 0;
            cbC.Text = "C(1500)";
            cbC.UseVisualStyleBackColor = true;
            cbC.CheckedChanged += All_Checkbox_CheckedChanged;
            // 
            // gbTrack
            // 
            gbTrack.BackColor = Color.Wheat;
            gbTrack.Controls.Add(rbSuperFast);
            gbTrack.Controls.Add(rbFast);
            gbTrack.Controls.Add(rbNormal);
            gbTrack.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbTrack.Location = new Point(18, 330);
            gbTrack.Name = "gbTrack";
            gbTrack.Size = new Size(952, 111);
            gbTrack.TabIndex = 6;
            gbTrack.TabStop = false;
            gbTrack.Text = "Track";
            // 
            // rbSuperFast
            // 
            rbSuperFast.AutoSize = true;
            rbSuperFast.Location = new Point(682, 50);
            rbSuperFast.Name = "rbSuperFast";
            rbSuperFast.Size = new Size(230, 36);
            rbSuperFast.TabIndex = 2;
            rbSuperFast.Tag = "500";
            rbSuperFast.Text = "SuperFast(500)";
            rbSuperFast.UseVisualStyleBackColor = true;
            rbSuperFast.CheckedChanged += All_RadioButton_CheckedChanged;
            // 
            // rbFast
            // 
            rbFast.AutoSize = true;
            rbFast.Location = new Point(344, 50);
            rbFast.Name = "rbFast";
            rbFast.Size = new Size(155, 36);
            rbFast.TabIndex = 1;
            rbFast.Tag = "100";
            rbFast.Text = "Fast(100)";
            rbFast.UseVisualStyleBackColor = true;
            rbFast.CheckedChanged += All_RadioButton_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Location = new Point(6, 50);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(124, 36);
            rbNormal.TabIndex = 0;
            rbNormal.TabStop = true;
            rbNormal.Tag = "0";
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += All_RadioButton_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(295, 456);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(178, 48);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(479, 456);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(178, 48);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(28F, 56F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 516);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(gbTrack);
            Controls.Add(gbCourses);
            Controls.Add(txtFees);
            Controls.Add(lblFees);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(10, 8, 10, 8);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gbCourses.ResumeLayout(false);
            gbCourses.PerformLayout();
            gbTrack.ResumeLayout(false);
            gbTrack.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtFees;
        private Label lblFees;
        private GroupBox gbCourses;
        private CheckBox cbC;
        private CheckBox cbCpp;
        private CheckBox cbLinux;
        private CheckBox cbUnix;
        private CheckBox cbMysql;
        private CheckBox cbPython;
        private CheckBox cbMongodb;
        private CheckBox cbPhp;
        private CheckBox cbReact;
        private CheckBox cbOracle;
        private CheckBox cbAdvJava;
        private CheckBox cbCoreJava;
        private CheckBox cbAngular;
        private CheckBox cbSqlServer;
        private CheckBox cbAsp;
        private CheckBox cbCSharp;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbTrack;
        private RadioButton rbSuperFast;
        private RadioButton rbFast;
        private RadioButton rbNormal;
        private Button btnReset;
        private Button btnClose;
    }
}
