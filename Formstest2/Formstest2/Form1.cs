namespace Formstest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(LBLOutput.Text);
            num = num + 1;
            LBLOutput.Text = num.ToString();
        }

        private void LBLOutput_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LBLOutput.Text = "0";
        }
    }
}
