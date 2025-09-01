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
            txtName.Location = new Point(180, 66);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 0;
            txtName.KeyPress += txtName_KeyPress;
            txtName.Leave += txtName_Leave;
            txtName.Validating += txtName_Validating;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(180, 115);
            txtPwd.Margin = new Padding(3, 2, 3, 2);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(220, 23);
            txtPwd.TabIndex = 1;
            txtPwd.KeyPress += txtPwd_KeyPress;
            txtPwd.Validating += txtName_Validating;
            // 
            // mtbDob
            // 
            mtbDob.Location = new Point(180, 199);
            mtbDob.Margin = new Padding(3, 2, 3, 2);
            mtbDob.Mask = "00/00/0000";
            mtbDob.Name = "mtbDob";
            mtbDob.Size = new Size(220, 23);
            mtbDob.TabIndex = 3;
            mtbDob.ValidatingType = typeof(DateTime);
            mtbDob.Validating += mtbDob_Validating;
            // 
            // txtCPwd
            // 
            txtCPwd.Location = new Point(180, 157);
            txtCPwd.Margin = new Padding(3, 2, 3, 2);
            txtCPwd.Name = "txtCPwd";
            txtCPwd.PasswordChar = '*';
            txtCPwd.Size = new Size(220, 23);
            txtCPwd.TabIndex = 2;
            txtCPwd.Validating += txtName_Validating;
            // 
            // mtbMobile
            // 
            mtbMobile.Location = new Point(180, 241);
            mtbMobile.Margin = new Padding(3, 2, 3, 2);
            mtbMobile.Name = "mtbMobile";
            mtbMobile.Size = new Size(220, 23);
            mtbMobile.TabIndex = 4;
            mtbMobile.KeyPress += mtbMobile_KeyPress;
            mtbMobile.Validating += mtbMobile_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 283);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(180, 325);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Both;
            txtAddress.Size = new Size(220, 79);
            txtAddress.TabIndex = 6;
            txtAddress.WordWrap = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(24, 71);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "UserName";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(24, 200);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(75, 15);
            lblDOB.TabIndex = 13;
            lblDOB.Text = "Date Of Birth";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-172, -40);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label2";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(24, 157);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(77, 15);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Confirm Pass";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-168, -40);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 9;
            label7.Text = "label2";
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(24, 242);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(44, 15);
            lblMobileNumber.TabIndex = 14;
            lblMobileNumber.Text = "Mobile";
            // 
            // lblEmaild
            // 
            lblEmaild.AutoSize = true;
            lblEmaild.Location = new Point(24, 285);
            lblEmaild.Name = "lblEmaild";
            lblEmaild.Size = new Size(49, 15);
            lblEmaild.TabIndex = 15;
            lblEmaild.Text = "Email Id";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(24, 328);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(32, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 45);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Registration Form";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 422);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(129, 422);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.CausesValidation = false;
            btnClose.Location = new Point(269, 422);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 452);
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
            Margin = new Padding(3, 2, 3, 2);
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
