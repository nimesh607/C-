using System.Text.RegularExpressions;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBoxBase)//TextBox Base is the base class for TextBox and RichTextBox and MaskTextBox
                {
                    TextBoxBase tb = (TextBoxBase)ctrl;
                    tb.Clear();//it is defined in the TextBoxBase class
                }
            }
            txtPwd.Enabled = txtCPwd.Enabled = true;
            txtName.Focus(); // Set focus back to the Name textbox
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure of closing the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//dialog result is returned from the message box
            if (dr == DialogResult.Yes)
            {
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is TextBoxBase)
                    {
                        ctrl.CausesValidation = false;//CausesValidation is common property for all control 
                    }
                    
                }
                txtName.CausesValidation = false;
                this.Close();
            }
            else
                return;

        }

        private void txtName_Leave(object sender, EventArgs e)
        {

        }

        /*
         Event args:
        -Not all events ,but some events are associated with properties.
        -The event args class contains properties that provide additional information about the event.
         -To access the properties of an event ,use the second parameter of your Event Procedure i.e. e in this case which is of type "EventArgs" or a child class of EventArgs.
        -if the Parameter is of type "EventArgs" then you cannot access any properties of the event.whereas if the parameter is of type child class of EventArgs then there are properties that can be accessed.
        -For example, the TextBox.Validating event is associated with the CancelEventArgs class, which has a Cancel property that can be set to true to cancel the event.
        -The Validating event is raised when the control loses focus and is about to be validated.
        -The Validating event is used to validate the input in the control before it loses focus.
         */
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            TextBox tb = (TextBox)sender; // Cast sender to TextBox
            if (tb.Text.Trim().Length == 0)
            {
                MessageBox.Show("you can't leave field to be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancel will not allow the focus to leave the TextBox
                return;

            }
            if (tb.Name != "txtName")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Password should be at least  8 to 16 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Cancel the event to prevent focus loss
                    return;
                }
            }
            if (tb.Name == "txtCPwd")
            {
                if (txtPwd.Text != txtCPwd.Text)
                {
                    DialogResult dr = MessageBox.Show("Password and Confirm Password do not match!\n\n Do you remember the password", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txtCPwd.Clear();
                        txtCPwd.Focus();
                    }
                    else
                    {
                        txtPwd.Clear();
                        txtCPwd.Clear();
                        txtPwd.Focus();

                    }
                    return;
                }
                txtPwd.Enabled = txtCPwd.Enabled = false; // Disable password fields after validation
            }

        }

        private void mtbDob_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!mtbDob.MaskFull && string.IsNullOrWhiteSpace(mtbDob.Text.Replace("/", "").Replace("-", "").Trim()))
            {
                MessageBox.Show("Date of Birth cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            else
            {
                //Try and TryParse will convert string into default datatime form i.e:MM/DD/YYYY .but i am expecting DD/MM/YYYY so for that use TryExact.it takes 5 parameters.
                MessageBox.Show(mtbDob.Text.Replace("/", "").Replace("_", "").Trim());
                bool status = DateTime.TryParseExact(mtbDob.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt);//tryparse will generate output in boolean so i have stored it into bool
                if (status)
                {
                    if (dt > DateTime.Now.AddYears(-18))
                    {
                        MessageBox.Show("You need to attain 18 years to register", "Age Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Date Format! Please enter in dd/MM/yyyy format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }

            }
        }

        private void mtbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Convert.ToInt32(e.KeyChar) != 8)
            {
                MessageBox.Show("Please enter numeric values only.", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;//it will not allow to character inside tb
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Please enter only Alphabets .", "Letters Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back && "!@#$%^&*()-_=+[]{};:,.<>?/|\\`~".IndexOf(e.KeyChar) == -1)
            {
                MessageBox.Show("Please enter only letters or digits.",
                                "Password Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void mtbMobile_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (mtbMobile.Text.Trim().Length > 0)
            {
                Regex rg = new Regex(@"^[6-9]\d{9}$");
                if (!rg.IsMatch(mtbMobile.Text))
                {
                    MessageBox.Show("Invalid Mobile No.Format.", "Mobile No.Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Trim().Length > 0)
            {
                Regex rg = new Regex(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$");

                if (!rg.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email Format.", "Email.Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
