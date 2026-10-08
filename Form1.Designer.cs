namespace Pizza_Aplication
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
            components = new System.ComponentModel.Container();
            Label label2;
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            label1 = new Label();
            ok_button = new Button();
            chk1 = new CheckBox();
            chk2 = new CheckBox();
            chk3 = new CheckBox();
            label3 = new Label();
            radioB1 = new RadioButton();
            radioB2 = new RadioButton();
            radioB3 = new RadioButton();
            label4 = new Label();
            radioB4 = new RadioButton();
            radioB5 = new RadioButton();
            radiob6 = new RadioButton();
            radioB7 = new RadioButton();
            label5 = new Label();
            radioB10 = new RadioButton();
            radioB9 = new RadioButton();
            radioB8 = new RadioButton();
            Button_Reset = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            txtform1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(225, 18);
            label2.Name = "label2";
            label2.Size = new Size(423, 46);
            label2.TabIndex = 1;
            label2.Text = "PIZZA AYSHE MENU";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Image = Properties.Resources.pizza_icon_26;
            label1.Location = new Point(-222, -11);
            label1.Name = "label1";
            label1.Size = new Size(471, 479);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ok_button
            // 
            ok_button.Location = new Point(255, 378);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(141, 53);
            ok_button.TabIndex = 2;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += ok_button_Click;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(16, 26);
            chk1.Name = "chk1";
            chk1.Size = new Size(115, 24);
            chk1.TabIndex = 3;
            chk1.Text = "Extra_cheese";
            chk1.UseVisualStyleBackColor = true;
            chk1.CheckedChanged += chk1_CheckedChanged;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(16, 56);
            chk2.Name = "chk2";
            chk2.Size = new Size(108, 24);
            chk2.TabIndex = 4;
            chk2.Text = "Mushrooms";
            chk2.UseVisualStyleBackColor = true;
            chk2.CheckedChanged += chk2_CheckedChanged;
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(16, 82);
            chk3.Name = "chk3";
            chk3.Size = new Size(71, 24);
            chk3.TabIndex = 5;
            chk3.Text = "Onion";
            chk3.UseVisualStyleBackColor = true;
            chk3.CheckedChanged += chk3_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(0, -7);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 6;
            label3.Text = "EXTRA";
            // 
            // radioB1
            // 
            radioB1.AutoSize = true;
            radioB1.Location = new Point(14, 35);
            radioB1.Name = "radioB1";
            radioB1.Size = new Size(75, 24);
            radioB1.TabIndex = 7;
            radioB1.TabStop = true;
            radioB1.Text = "SMALL";
            radioB1.UseVisualStyleBackColor = true;
            radioB1.CheckedChanged += radioB1_CheckedChanged;
            // 
            // radioB2
            // 
            radioB2.AutoSize = true;
            radioB2.Location = new Point(14, 65);
            radioB2.Name = "radioB2";
            radioB2.Size = new Size(85, 24);
            radioB2.TabIndex = 8;
            radioB2.TabStop = true;
            radioB2.Text = "Medium";
            radioB2.UseVisualStyleBackColor = true;
            radioB2.CheckedChanged += radioB2_CheckedChanged;
            // 
            // radioB3
            // 
            radioB3.AutoSize = true;
            radioB3.Location = new Point(14, 95);
            radioB3.Name = "radioB3";
            radioB3.Size = new Size(67, 24);
            radioB3.TabIndex = 9;
            radioB3.TabStop = true;
            radioB3.Text = "Large";
            radioB3.UseVisualStyleBackColor = true;
            radioB3.CheckedChanged += radioB3_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(267, 227);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 10;
            label4.Text = "SIZE";
            // 
            // radioB4
            // 
            radioB4.Font = new Font("Segoe UI", 9F);
            radioB4.Location = new Point(7, 26);
            radioB4.Name = "radioB4";
            radioB4.Size = new Size(138, 50);
            radioB4.TabIndex = 11;
            radioB4.TabStop = true;
            radioB4.Text = "Margherita";
            radioB4.UseVisualStyleBackColor = true;
            radioB4.CheckedChanged += radioB4_CheckedChanged;
            // 
            // radioB5
            // 
            radioB5.AutoSize = true;
            radioB5.Font = new Font("Segoe UI", 9F);
            radioB5.Location = new Point(7, 68);
            radioB5.Name = "radioB5";
            radioB5.Size = new Size(138, 24);
            radioB5.TabIndex = 9;
            radioB5.TabStop = true;
            radioB5.Text = "Quattro stagioni";
            radioB5.UseVisualStyleBackColor = true;
            radioB5.CheckedChanged += radioB5_CheckedChanged;
            // 
            // radiob6
            // 
            radiob6.AutoSize = true;
            radiob6.Font = new Font("Segoe UI", 9F);
            radiob6.Location = new Point(7, 94);
            radiob6.Name = "radiob6";
            radiob6.Size = new Size(103, 24);
            radiob6.TabIndex = 13;
            radiob6.TabStop = true;
            radiob6.Text = " pepperoni";
            radiob6.UseVisualStyleBackColor = true;
            radiob6.CheckedChanged += radiob6_CheckedChanged;
            // 
            // radioB7
            // 
            radioB7.AutoSize = true;
            radioB7.Font = new Font("Segoe UI", 9F);
            radioB7.Location = new Point(6, 124);
            radioB7.Name = "radioB7";
            radioB7.Size = new Size(74, 24);
            radioB7.TabIndex = 14;
            radioB7.TabStop = true;
            radioB7.Text = "Classic";
            radioB7.UseVisualStyleBackColor = true;
            radioB7.CheckedChanged += radioB7_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(473, 64);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 15;
            label5.Text = "DRINK";
            // 
            // radioB10
            // 
            radioB10.AutoSize = true;
            radioB10.Location = new Point(11, 85);
            radioB10.Name = "radioB10";
            radioB10.Size = new Size(69, 24);
            radioB10.TabIndex = 18;
            radioB10.TabStop = true;
            radioB10.Text = "Water";
            radioB10.UseVisualStyleBackColor = true;
            radioB10.CheckedChanged += radioB10_CheckedChanged;
            // 
            // radioB9
            // 
            radioB9.AutoSize = true;
            radioB9.Location = new Point(11, 55);
            radioB9.Name = "radioB9";
            radioB9.Size = new Size(64, 24);
            radioB9.TabIndex = 17;
            radioB9.TabStop = true;
            radioB9.Text = "Soda";
            radioB9.UseVisualStyleBackColor = true;
            radioB9.CheckedChanged += radioB9_CheckedChanged;
            // 
            // radioB8
            // 
            radioB8.AutoSize = true;
            radioB8.Location = new Point(11, 25);
            radioB8.Name = "radioB8";
            radioB8.Size = new Size(60, 24);
            radioB8.TabIndex = 16;
            radioB8.TabStop = true;
            radioB8.Text = "Cola";
            radioB8.UseVisualStyleBackColor = true;
            radioB8.CheckedChanged += radioB8_CheckedChanged;
            // 
            // Button_Reset
            // 
            Button_Reset.Location = new Point(430, 378);
            Button_Reset.Name = "Button_Reset";
            Button_Reset.Size = new Size(141, 53);
            Button_Reset.TabIndex = 19;
            Button_Reset.Text = "RESET";
            Button_Reset.UseVisualStyleBackColor = true;
            Button_Reset.Click += Button_Reset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioB7);
            groupBox1.Controls.Add(radiob6);
            groupBox1.Controls.Add(radioB5);
            groupBox1.Controls.Add(radioB4);
            groupBox1.Location = new Point(260, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 154);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(0, 2);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 24;
            label6.Text = "PIZZA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioB10);
            groupBox2.Controls.Add(radioB9);
            groupBox2.Controls.Add(radioB8);
            groupBox2.Location = new Point(473, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(132, 147);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioB3);
            groupBox3.Controls.Add(radioB2);
            groupBox3.Controls.Add(radioB1);
            groupBox3.Location = new Point(260, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(120, 124);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(chk3);
            groupBox4.Controls.Add(chk2);
            groupBox4.Controls.Add(chk1);
            groupBox4.Location = new Point(473, 234);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(132, 121);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // txtform1
            // 
            txtform1.Location = new Point(648, 200);
            txtform1.Name = "txtform1";
            txtform1.Size = new Size(125, 27);
            txtform1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(630, 471);
            Controls.Add(txtform1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Button_Reset);
            Controls.Add(label1);
            Controls.Add(ok_button);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private Label label1;
        private Label label2;
        private Button ok_button;
        private CheckBox chk1;
        private CheckBox chk2;
        private CheckBox chk3;
        private Label label3;
        private RadioButton radioB1;
        private RadioButton radioB2;
        private RadioButton radioB3;
        private Label label4;
        private RadioButton radioB4;
        private RadioButton radioB5;
        private RadioButton radiob6;
        private RadioButton radioB7;
        private Label label5;
        private RadioButton radioB10;
        private RadioButton radioB9;
        private RadioButton radioB8;
        private Button Button_Reset;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private TextBox txtform1;
    }
}
