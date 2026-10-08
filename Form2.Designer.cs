namespace Pizza_Aplication
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
            label1 = new Label();
            label2 = new Label();
            label3_ = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label_PIZZA = new Label();
            label_SIZE = new Label();
            label_TOPPING = new Label();
            label9 = new Label();
            label_DRINK = new Label();
            button2_Return = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 59);
            label1.TabIndex = 0;
            label1.Text = "Your order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 92);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "SIZE";
            // 
            // label3_
            // 
            label3_.AutoSize = true;
            label3_.Location = new Point(36, 165);
            label3_.Name = "label3_";
            label3_.Size = new Size(68, 20);
            label3_.TabIndex = 2;
            label3_.Text = "TOPPING";
            label3_.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 59);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "PIZZA";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(51, 206);
            label5.Name = "label5";
            label5.Size = new Size(118, 59);
            label5.TabIndex = 4;
            label5.Text = "PRICE";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(51, 255);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(157, 39);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(36, 309);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_PIZZA
            // 
            label_PIZZA.Location = new Point(95, 59);
            label_PIZZA.Name = "label_PIZZA";
            label_PIZZA.Size = new Size(93, 20);
            label_PIZZA.TabIndex = 7;
            label_PIZZA.Click += label6_Click;
            // 
            // label_SIZE
            // 
            label_SIZE.Location = new Point(95, 92);
            label_SIZE.Name = "label_SIZE";
            label_SIZE.Size = new Size(69, 20);
            label_SIZE.TabIndex = 8;
            // 
            // label_TOPPING
            // 
            label_TOPPING.Location = new Point(110, 165);
            label_TOPPING.Name = "label_TOPPING";
            label_TOPPING.Size = new Size(167, 41);
            label_TOPPING.TabIndex = 9;
            // 
            // label9
            // 
            label9.Location = new Point(35, 129);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 10;
            label9.Text = "DRINK";
            // 
            // label_DRINK
            // 
            label_DRINK.Location = new Point(110, 129);
            label_DRINK.Name = "label_DRINK";
            label_DRINK.Size = new Size(69, 20);
            label_DRINK.TabIndex = 11;
            // 
            // button2_Return
            // 
            button2_Return.Location = new Point(158, 309);
            button2_Return.Name = "button2_Return";
            button2_Return.Size = new Size(103, 50);
            button2_Return.TabIndex = 12;
            button2_Return.Text = "Return";
            button2_Return.UseVisualStyleBackColor = true;
            button2_Return.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 394);
            Controls.Add(button2_Return);
            Controls.Add(label_DRINK);
            Controls.Add(label9);
            Controls.Add(label_TOPPING);
            Controls.Add(label_SIZE);
            Controls.Add(label_PIZZA);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3_);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3_;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Label label_PIZZA;
        private Label label_SIZE;
        private Label label_TOPPING;
        private Label label9;
        private Label label_DRINK;
        private Label label3;
        private Label label6;
        private Button button2_Return;
    }
}