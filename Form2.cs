
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Aplication
{
    public partial class Form2 : Form
    {
        public static Form2 Instance { get; private set; }
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            textBox1.Text = Form1.Instance.tBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "THE PIZZA IS READY!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                //MessageBox.Show("Your order is: ", "Order Confirmation", MessageBoxButtons.OKCancel);

                MessageBox.Show("Thank you for your order!");
                this.Close();



            }

        }
        public string a;
        public string size;
        public string topping;
        public string drink;
        public int totalprice;
        public int totalprice2;
        public void label6_Click(object sender, EventArgs e)
        {



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            label_PIZZA.Text = form1.callinfoPI(a);
            label_SIZE.Text = form1.callinfoSI(size);
            label_TOPPING.Text = form1.callinfoto(topping);
            label_DRINK.Text = form1.callinfodr(drink);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Hide();
            Form1 f = new Form1();
            f.Show();

        }

 
    }
}
