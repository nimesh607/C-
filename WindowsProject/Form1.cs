namespace WindowsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,Welcome to first form of GUI Programming");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on the form!");
        }
    }
}
