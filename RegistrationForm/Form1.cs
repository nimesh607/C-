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
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancel the event to prevent focus loss
            }
            /*  else if (txtName.Text.Length < 3)
              {
                  MessageBox.Show("Name must be at least 3 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  e.Cancel = true; // Cancel the event to prevent focus loss
              }*/
        }
    } 
}
