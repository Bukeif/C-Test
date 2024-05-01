namespace Form2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmi, height, weight;
            height = Convert.ToDouble(txtHeight.Text);
            weight = Convert.ToDouble(txtWeight.Text);
            height /= 100.0;
            bmi = calBMI(height, weight);
            printBMI(bmi);

        }

        public double calBMI(double height, double weight)
        {
            double bmi;
            bmi = weight / (height * height);
            return bmi;
        }

        void printBMI(double bmi)
        {
            LBLOutput.Text = "BMI ­È = " + bmi.ToString();
        }


    }
}
