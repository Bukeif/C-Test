namespace Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            close = new PictureBox();
            groupBox1 = new GroupBox();
            chkEggCake = new CheckBox();
            chkBurgerWithEgg = new CheckBox();
            chkSandwich = new CheckBox();
            chkBurger = new CheckBox();
            groupBox2 = new GroupBox();
            rdbLarge = new RadioButton();
            rdbSmall = new RadioButton();
            chkFries = new CheckBox();
            chkDrink = new CheckBox();
            rdbMilkTea = new RadioButton();
            rdbCoffee = new RadioButton();
            rdbBlackTea = new RadioButton();
            groupBox3 = new GroupBox();
            button1 = new Button();
            LBLOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.Image = (Image)resources.GetObject("close.Image");
            close.Location = new Point(719, 12);
            close.Name = "close";
            close.Size = new Size(42, 37);
            close.SizeMode = PictureBoxSizeMode.StretchImage;
            close.TabIndex = 0;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEggCake);
            groupBox1.Controls.Add(chkBurgerWithEgg);
            groupBox1.Controls.Add(chkSandwich);
            groupBox1.Controls.Add(chkBurger);
            groupBox1.Location = new Point(36, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(230, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "主餐";
            // 
            // chkEggCake
            // 
            chkEggCake.AutoSize = true;
            chkEggCake.Location = new Point(12, 163);
            chkEggCake.Name = "chkEggCake";
            chkEggCake.Size = new Size(77, 19);
            chkEggCake.TabIndex = 3;
            chkEggCake.Text = "蛋餅  $25";
            chkEggCake.UseVisualStyleBackColor = true;
            // 
            // chkBurgerWithEgg
            // 
            chkBurgerWithEgg.AutoSize = true;
            chkBurgerWithEgg.Location = new Point(12, 122);
            chkBurgerWithEgg.Name = "chkBurgerWithEgg";
            chkBurgerWithEgg.Size = new Size(101, 19);
            chkBurgerWithEgg.TabIndex = 2;
            chkBurgerWithEgg.Text = "漢堡加蛋  $40";
            chkBurgerWithEgg.UseVisualStyleBackColor = true;
            // 
            // chkSandwich
            // 
            chkSandwich.AutoSize = true;
            chkSandwich.Location = new Point(12, 87);
            chkSandwich.Name = "chkSandwich";
            chkSandwich.Size = new Size(89, 19);
            chkSandwich.TabIndex = 1;
            chkSandwich.Text = "三明治  $30";
            chkSandwich.UseVisualStyleBackColor = true;
            // 
            // chkBurger
            // 
            chkBurger.AutoSize = true;
            chkBurger.Checked = true;
            chkBurger.CheckState = CheckState.Checked;
            chkBurger.Location = new Point(12, 44);
            chkBurger.Name = "chkBurger";
            chkBurger.Size = new Size(77, 19);
            chkBurger.TabIndex = 0;
            chkBurger.Text = "漢堡  $35";
            chkBurger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbLarge);
            groupBox2.Controls.Add(rdbSmall);
            groupBox2.Controls.Add(chkFries);
            groupBox2.Location = new Point(338, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 81);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // rdbLarge
            // 
            rdbLarge.AutoSize = true;
            rdbLarge.Location = new Point(168, 44);
            rdbLarge.Name = "rdbLarge";
            rdbLarge.Size = new Size(76, 19);
            rdbLarge.TabIndex = 2;
            rdbLarge.Text = "大薯  $35";
            rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbSmall
            // 
            rdbSmall.AutoSize = true;
            rdbSmall.Checked = true;
            rdbSmall.Location = new Point(15, 43);
            rdbSmall.Name = "rdbSmall";
            rdbSmall.Size = new Size(76, 19);
            rdbSmall.TabIndex = 1;
            rdbSmall.TabStop = true;
            rdbSmall.Text = "小薯  $35";
            rdbSmall.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Location = new Point(15, 0);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(50, 19);
            chkFries.TabIndex = 0;
            chkFries.Text = "薯條";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // chkDrink
            // 
            chkDrink.AutoSize = true;
            chkDrink.Location = new Point(14, 0);
            chkDrink.Name = "chkDrink";
            chkDrink.Size = new Size(77, 19);
            chkDrink.TabIndex = 3;
            chkDrink.Text = "飲料  $20";
            chkDrink.UseVisualStyleBackColor = true;
            // 
            // rdbMilkTea
            // 
            rdbMilkTea.AutoSize = true;
            rdbMilkTea.Checked = true;
            rdbMilkTea.Location = new Point(14, 35);
            rdbMilkTea.Name = "rdbMilkTea";
            rdbMilkTea.Size = new Size(78, 19);
            rdbMilkTea.TabIndex = 4;
            rdbMilkTea.TabStop = true;
            rdbMilkTea.Text = "奶茶  +$5";
            rdbMilkTea.UseVisualStyleBackColor = true;
            // 
            // rdbCoffee
            // 
            rdbCoffee.AutoSize = true;
            rdbCoffee.Location = new Point(14, 67);
            rdbCoffee.Name = "rdbCoffee";
            rdbCoffee.Size = new Size(85, 19);
            rdbCoffee.TabIndex = 5;
            rdbCoffee.Text = "咖啡  +$10";
            rdbCoffee.UseVisualStyleBackColor = true;
            // 
            // rdbBlackTea
            // 
            rdbBlackTea.AutoSize = true;
            rdbBlackTea.Location = new Point(15, 102);
            rdbBlackTea.Name = "rdbBlackTea";
            rdbBlackTea.Size = new Size(49, 19);
            rdbBlackTea.TabIndex = 6;
            rdbBlackTea.Text = "紅茶";
            rdbBlackTea.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkDrink);
            groupBox3.Controls.Add(rdbBlackTea);
            groupBox3.Controls.Add(rdbMilkTea);
            groupBox3.Controls.Add(rdbCoffee);
            groupBox3.Location = new Point(338, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(201, 145);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(36, 360);
            button1.Name = "button1";
            button1.Size = new Size(134, 48);
            button1.TabIndex = 8;
            button1.Text = "點餐";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LBLOutput
            // 
            LBLOutput.BackColor = Color.Black;
            LBLOutput.Font = new Font("微軟正黑體", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            LBLOutput.ForeColor = SystemColors.ButtonFace;
            LBLOutput.Location = new Point(338, 360);
            LBLOutput.Name = "LBLOutput";
            LBLOutput.Size = new Size(342, 48);
            LBLOutput.TabIndex = 9;
            LBLOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(773, 454);
            Controls.Add(LBLOutput);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "猜數字遊戲";
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox close;
        private GroupBox groupBox1;
        private CheckBox chkEggCake;
        private CheckBox chkBurgerWithEgg;
        private CheckBox chkSandwich;
        private CheckBox chkBurger;
        private GroupBox groupBox2;
        private RadioButton rdbSmall;
        private CheckBox chkFries;
        private RadioButton rdbLarge;
        private CheckBox chkDrink;
        private RadioButton rdbMilkTea;
        private RadioButton rdbCoffee;
        private RadioButton rdbBlackTea;
        private GroupBox groupBox3;
        private Button button1;
        private Label LBLOutput;
    }
}
