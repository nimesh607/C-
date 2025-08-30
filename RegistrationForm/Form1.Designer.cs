namespace RegistrationForm
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
            txtName = new TextBox();
            txtPwd = new TextBox();
            mtbDob = new MaskedTextBox();
            txtCPwd = new TextBox();
            mtbMobile = new MaskedTextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblUserName = new Label();
            lblDOB = new Label();
            lblPassword = new Label();
            label5 = new Label();
            lblConfirmPassword = new Label();
            label7 = new Label();
            lblMobileNumber = new Label();
            lblEmaild = new Label();
            lblAddress = new Label();
            lblTitle = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(206, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 27);
            txtName.TabIndex = 0;
            txtName.Leave += txtName_Leave;
            txtName.Validating += txtName_Validating;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(206, 153);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(251, 27);
            txtPwd.TabIndex = 1;
            txtPwd.Validating += txtName_Validating;
            // 
            // mtbDob
            // 
            mtbDob.Location = new Point(206, 265);
            mtbDob.Mask = "00/00/0000";
            mtbDob.Name = "mtbDob";
            mtbDob.Size = new Size(251, 27);
            mtbDob.TabIndex = 3;
            mtbDob.ValidatingType = typeof(DateTime);
            mtbDob.Validating += mtbDob_Validating;
            // 
            // txtCPwd
            // 
            txtCPwd.Location = new Point(206, 209);
            txtCPwd.Name = "txtCPwd";
            txtCPwd.PasswordChar = '*';
            txtCPwd.Size = new Size(251, 27);
            txtCPwd.TabIndex = 2;
            txtCPwd.Validating += txtName_Validating;
            // 
            // mtbMobile
            // 
            mtbMobile.Location = new Point(206, 321);
            mtbMobile.Mask = " ";
            mtbMobile.Name = "mtbMobile";
            mtbMobile.Size = new Size(251, 27);
            mtbMobile.TabIndex = 4;
            mtbMobile.KeyPress += mtbMobile_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 377);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(206, 433);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Both;
            txtAddress.Size = new Size(251, 104);
            txtAddress.TabIndex = 6;
            txtAddress.WordWrap = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(27, 95);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(78, 20);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "UserName";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(27, 266);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(96, 20);
            lblDOB.TabIndex = 13;
            lblDOB.Text = "Date Of Birth";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-196, -54);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "label2";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(27, 209);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(93, 20);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Confirm Pass";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-192, -54);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "label2";
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(27, 323);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(56, 20);
            lblMobileNumber.TabIndex = 14;
            lblMobileNumber.Text = "Mobile";
            // 
            // lblEmaild
            // 
            lblEmaild.AutoSize = true;
            lblEmaild.Location = new Point(27, 380);
            lblEmaild.Name = "lblEmaild";
            lblEmaild.Size = new Size(63, 20);
            lblEmaild.TabIndex = 15;
            lblEmaild.Text = "Email Id";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(27, 437);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(37, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 56);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Registration Form";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 562);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(147, 562);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(307, 562);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 603);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblAddress);
            Controls.Add(lblEmaild);
            Controls.Add(lblMobileNumber);
            Controls.Add(lblDOB);
            Controls.Add(lblUserName);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(mtbMobile);
            Controls.Add(txtCPwd);
            Controls.Add(mtbDob);
            Controls.Add(txtPwd);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPwd;
        private MaskedTextBox mtbDob;
        private TextBox txtCPwd;
        private MaskedTextBox mtbMobile;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblUserName;
        private Label lblDOB;
        private Label lblPassword;
        private Label label5;
        private Label lblConfirmPassword;
        private Label label7;
        private Label lblMobileNumber;
        private Label lblEmaild;
        private Label lblAddress;
        private Label lblTitle;
        private Button btnSave;
        private Button btnClear;
        private Button btnClose;
    }
}
