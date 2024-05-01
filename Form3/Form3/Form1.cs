namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalAmount = 0;
            int friesPrice;
            // 大薯/小薯
            if(rdbSmall.Checked )
            {
                friesPrice = 25;
            }
            else
            {
                friesPrice = 35;
            }

            if (chkBurger.Checked)
            { 
                totalAmount += 35;
            }
            if (chkSandwich.Checked)
            {
                totalAmount += 30;
            }
            if (chkBurgerWithEgg.Checked)
            {
                totalAmount += 40;
            }
            if (chkEggCake.Checked)
            {
                totalAmount += 25;
            }
            if (chkFries.Checked)
            { 
                totalAmount += friesPrice;
            }
            if (chkDrink.Checked)
            {
                totalAmount += 20;
                //是否是奶茶
                if(rdbBlackTea.Checked) 
                {
                    totalAmount += 5;
                }
                //是否是咖啡
                if(rdbCoffee.Checked) 
                {
                    totalAmount += 10;
                }
            }
            LBLOutput.Text = "NT $ " + totalAmount;
        }
    }
}
