namespace CleanSlate
{
    public partial class CleanSlate : Form
    {
        public CleanSlate()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CleanSlate_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void CleanSlate_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            // When our user raises the click event on this button
            //Want to show a message box with the user's message
            MessageBox.Show("Your document has been saved", "Save As");
        }
    }
}
