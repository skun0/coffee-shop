namespace CoffeeShop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Espresso - $1.50", "Cappuccino - $2.50", "Latte - $3.00", "Americano - $2.00", "Mocha - $3.50", "Macchiato - $2.75", "Tea - $1.75", "Hot Chocolate - $3.00", "Cornetto - $1.80", "Muffin - $2.20", "Bagel - $2.50", "Brownie - $2.00", "Scone - $2.50", "Smoothie - $3.50", "Iced Coffee - $3.00", "Frappuccino - $4.00", "Chocolate Croissant - $2.20", "Pain au Chocolat - $2.50", "Cheesecake Slice - $3.00" });
            comboBox1.Location = new Point(170, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 39);
            label1.Name = "label1";
            label1.Size = new Size(212, 51);
            label1.TabIndex = 1;
            label1.Text = "WELCOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 100);
            label2.Name = "label2";
            label2.Size = new Size(313, 30);
            label2.TabIndex = 2;
            label2.Text = "Choose your product to order!";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(182, 177);
            button1.Name = "button1";
            button1.Size = new Size(99, 27);
            button1.TabIndex = 4;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 126, 83);
            ClientSize = new Size(485, 506);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Coffee Shop";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}