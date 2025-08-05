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
            txtPassword.Enabled = txtConfirmPassword.Enabled = true;
            txtName.Focus(); // Set focus back to the Name textbox
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure of closing the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//dialog result is returned from the message box
            if (dr == DialogResult.Yes)
                this.Close();
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
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancel the event to prevent focus loss
                return;
            }
            if (tb.Name == "txtName")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Password should be at least  8 to 16 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Cancel the event to prevent focus loss
                    return;
                }
            }
            if (tb.Name == "txtConfirmPassword")
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    DialogResult dr = MessageBox.Show("Password and Confirm Password do not match!\n\n Do you remember the password", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txtConfirmPassword.Clear();
                        txtConfirmPassword.Focus();
                    }
                    else
                    {
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtPassword.Focus();

                    }
                    return;
                }
                txtPassword.Enabled = txtConfirmPassword.Enabled = false; // Disable password fields after validation
            }
        }

        private void txtDob_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            MessageBox.Show("Length:" + txtDob.Text.Replace("/", "").Trim().Length);
            if (txtDob.Text.Replace("/", "").Trim().Length == 0)
            {
                MessageBox.Show("Date of Birth cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                bool status = DateTime.TryParseExact(txtDob.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt);
                if (status)
                {
                    MessageBox.Show(dt.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Date Format! Please enter in dd/MM/yyyy format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
