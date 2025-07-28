namespace CourseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int Count = 0;
        private void All_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            rbNormal.Checked = true; // check the Normal radio button when any checkbox is checked.
            CheckBox cb = (CheckBox)sender;//sender is an object(parent) ,i want to use checked property of checkbox(child).so we need to cast it from parent                                to child type than only we can use child property.

            int Amt = int.Parse(txtFees.Text);
            string cbText = cb.Text;
            int start = cbText.IndexOf('(');
            int end = cbText.IndexOf(')');
            string numberPart = cbText.Substring(start + 1, end - start - 1);
            int value = int.Parse(numberPart);

            if (cb.Checked)
            {
                Count += 1;
                Amt += value;
            }
            else
            {
                Count -= 1;
                Amt -= value;

            }
            txtFees.Text = Amt.ToString();
        }

        private void All_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            int Amt = int.Parse(txtFees.Text);
            if (rb.Checked)
            {
                Amt += (Convert.ToInt32(rb.Tag) * Count); // Tag property is used to store additional information about the control.
            }
            else
            {
                {
                    Amt -= (Convert.ToInt32(rb.Tag) * Count); // If the radio button is unchecked, we subtract the value from the total amount.
                }
            }
            txtFees.Text = Amt.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control c in gbCourses.Controls)
            {
                if (c is CheckBox cb)
                {
                    cb.Checked = false;
                } // Uncheck all checkboxes.
                  // ((CheckBox)c).Checked = false; // Uncheck all checkboxes using the Checked property.
            }
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    /*TextBox tb = (TextBox)ctrl;//Control is parent class of all control.and clear method is not available in parent class.so we need to cast it to child type TextBox.
                    tb.Clear(); // Clear all textboxes.*/
                    ((TextBox)ctrl).Clear(); // Clear all textboxes using the Clear method.
                   
                }
            }
            txtFees.Text = "0"; // Reset the fees text box to 0.
            txtName.Focus(); // Set focus to the Name text box.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); // Close the form when the Close button is clicked.
        }
    }
}
