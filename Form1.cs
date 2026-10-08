using System.Web;

namespace Pizza_Aplication
{

    public partial class Form1 : Form
    {

        public TextBox tBox1;
        public static Form1 Instance { get; private set; }
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            tBox1= txtform1;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            UpdatetotalPriceform2(totalPrice);

        }


        enum pizzaEnum { Margherita, Quattro_stagioni, Pepperoni, Classic };
        enum toppingsEnum { Extra_cheese, Mushrooms, Olives, Pineapple, Ham, Bacon, Onion, Peppers };

        enum sizepizzaEnum { Small, Medium, Large };


        public static string x;
        public static string y = "";
        public static string z;
        public static string u;
        public void ok_button_Click(object sender, EventArgs e)
        {

            UpdatetotalPriceform2(totalPrice);
            Form1.ActiveForm.Hide();
            Form2 f2 = new Form2();

            f2.Show();
            
            
        }

        public void UpdateOrderSummary()
        {
            pizzachoice();
            Sizepizza();
            topping();
            drinkchoice();
        }

        public void Button_Reset_Click(object sender, EventArgs e)
        {
            radioB4.Checked = false;
            radioB5.Checked = false;
            radiob6.Checked = false;
            radioB7.Checked = false;
            radioB1.Checked = false;
            radioB2.Checked = false;
            radioB3.Checked = false;
            radioB8.Checked = false;
            radioB9.Checked = false;
            radioB10.Checked = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;

        }



        public static int totalPrice = 0;
        public int ToppingsPricetotal = 0;
        public int PizzaPricetotal = 0;
        public int DrinkPricetotal = 0;
        public int SizePricetotal = 0;

        public int TopPrice()
        {
            if (chk2.Checked)
            {
                ToppingsPricetotal += 10; // Add price for Mushrooms
            }

            if (chk3.Checked)
            {
                ToppingsPricetotal += 10;
            }

            if (chk1.Checked)
            {
                ToppingsPricetotal += 20;
            }
            return ToppingsPricetotal;
        }
        public int PizzaPrice()
        {

            if (radioB4.Checked)
            {
                PizzaPricetotal += 100;

            }
             if (radioB5.Checked)
            {
                PizzaPricetotal += 150;
            }
             if (radiob6.Checked)
            {
                PizzaPricetotal += 200;
            }
             if (radioB7.Checked)
            {
                PizzaPricetotal += 100;
            }
   
            return PizzaPricetotal;
        }
        public int DrinkPrice()
        {
            if (radioB8.Checked)
            {
                DrinkPricetotal += 80;
            }
            if (radioB9.Checked)
            {
                DrinkPricetotal += 50;
            }
            if (radioB10.Checked)
            {
                DrinkPricetotal += 20;
            }
            return DrinkPricetotal;
        }

        public int SizePrice()
        {

            if (radioB1.Checked )
            {
                SizePricetotal += 100;
            }
            if (radioB2.Checked)
            {
                SizePricetotal += 150;
            }
            if (radioB3.Checked)
            {
                SizePricetotal += 200;
            }
            return SizePricetotal;

        }
  
        public int UpdatetotalPriceform2(int totalprice)
        {

            totalprice = PizzaPricetotal+SizePricetotal + DrinkPricetotal  + ToppingsPricetotal;
            txtform1.Text = totalprice.ToString();
            return totalprice;
        }
        public void topping()
        {

            if (chk1.Checked == true)
            {
                y = "Extra Cheese";
                TopPrice();
            }

            if (chk2.Checked == true)
            {
                y += ", Mushrooms";
                TopPrice();
            }

            if (chk3.Checked == true)
            {
                y += ", onione";
                TopPrice();
            }
            if (y.StartsWith(","))
            {
                y = y.Substring(1, y.Length - 1).Trim();
            }

            if (y == " ")
                y = "No Toppings";

        }
        public void pizzachoice()
        {
            if (radioB4.Checked == true)
            {
                PizzaPrice();
                x = "Margherita";
            }
            if (radioB5.Checked == true)
            {
                PizzaPrice();
                x = "Quattro stagioni";
            }
            if (radiob6.Checked)
            {
                PizzaPrice();
                x = " pepperoni";
            }
            if (radioB7.Checked == true)
            {
                PizzaPrice();
                x = " Classica";
            }
        }
        public void Sizepizza()
        {
            if (radioB1.Checked == true)
            {
                SizePrice();
                z = "Small";
            }
            if (radioB2.Checked == true)
            {
               SizePrice();
                z = "Medium";
            }
            if (radioB3.Checked == true)
            {
                SizePrice();
                z = "Large";
            }
        }
        public void drinkchoice()
        {
            if (radioB8.Checked == true)
            {
                DrinkPrice();
                u += "Coca Cola";
            }
            if (radioB9.Checked == true)
            {
                DrinkPrice();
                u += "Soda";
            }
            if (radioB10.Checked == true)
            {
                DrinkPrice();
                u += "Water";
            }
        }

        public string callinfoPI(string a)
        {
            a = x;
            return a;
        }
        public string callinfoSI(string a)
        {
            a = z;
            return a;
        }
        public string callinfodr(string a)
        {
            a = u;
            return a;
        }
        public string callinfoto(string a)
        {
            a = y;
            return a;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioB4_CheckedChanged(object sender, EventArgs e)
        {
            pizzachoice();
        }

        private void radioB5_CheckedChanged(object sender, EventArgs e)
        {
            pizzachoice();
        }

        private void radiob6_CheckedChanged(object sender, EventArgs e)
        {
            pizzachoice();
        }

        private void radioB7_CheckedChanged(object sender, EventArgs e)
        {
            pizzachoice();
        }

        private void radioB1_CheckedChanged(object sender, EventArgs e)
        {
            Sizepizza();
        }

        private void radioB2_CheckedChanged(object sender, EventArgs e)
        {
            Sizepizza();

        }

        private void radioB3_CheckedChanged(object sender, EventArgs e)
        {
            Sizepizza();

        }

        private void radioB8_CheckedChanged(object sender, EventArgs e)
        {
            drinkchoice();
        }

        private void radioB9_CheckedChanged(object sender, EventArgs e)
        {
            drinkchoice();
        }

        private void radioB10_CheckedChanged(object sender, EventArgs e)
        {
            drinkchoice();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            topping();
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            topping();

        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            topping();

        }

  
    }
}

