namespace Form2
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
            pictureBox1 = new PictureBox();
            btnBMI = new Button();
            txtHeight = new TextBox();
            LBLHeight = new Label();
            LBLWeight = new Label();
            txtWeight = new TextBox();
            LBLOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(724, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(599, 139);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(163, 124);
            btnBMI.TabIndex = 1;
            btnBMI.Text = "計算BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += button1_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(160, 63);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(229, 23);
            txtHeight.TabIndex = 2;
            // 
            // LBLHeight
            // 
            LBLHeight.AutoSize = true;
            LBLHeight.Location = new Point(60, 66);
            LBLHeight.Name = "LBLHeight";
            LBLHeight.Size = new Size(72, 15);
            LBLHeight.TabIndex = 3;
            LBLHeight.Text = "身高(公分) : ";
            LBLHeight.Click += label1_Click;
            // 
            // LBLWeight
            // 
            LBLWeight.AutoSize = true;
            LBLWeight.Location = new Point(60, 166);
            LBLWeight.Name = "LBLWeight";
            LBLWeight.Size = new Size(72, 15);
            LBLWeight.TabIndex = 4;
            LBLWeight.Text = "體重(公斤) : ";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(160, 166);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(229, 23);
            txtWeight.TabIndex = 5;
            // 
            // LBLOutput
            // 
            LBLOutput.BorderStyle = BorderStyle.FixedSingle;
            LBLOutput.Location = new Point(60, 296);
            LBLOutput.Name = "LBLOutput";
            LBLOutput.Size = new Size(466, 50);
            LBLOutput.TabIndex = 6;
            LBLOutput.Text = "   BMI 值 = ";
            LBLOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(LBLOutput);
            Controls.Add(txtWeight);
            Controls.Add(LBLWeight);
            Controls.Add(LBLHeight);
            Controls.Add(txtHeight);
            Controls.Add(btnBMI);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "BMI計算機";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBMI;
        private TextBox txtHeight;
        private Label LBLHeight;
        private Label LBLWeight;
        private TextBox txtWeight;
        private Label LBLOutput;
    }
}
