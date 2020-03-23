using System;
using System.Windows.Forms;

namespace laborator2
{

    public partial class Form1 : Form
    {
        String numar1 = null;
        String numar2= null;
        String semn = null;
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            display();
        }

        // cifre

        private void button0_Click(object sender, EventArgs e)
        {
            Button button9 = (Button)sender;
            if (semn == null)
                numar1 += "0";
            else
                numar2 += "0";
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            if (semn == null)
                numar1 += "1";
            else
                numar2 += "1";
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            if (semn == null)
                numar1 += "2";
            else
                numar2 += "2";
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            if (semn == null)
                numar1 += "3";
            else
                numar2 += "3";
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button4 = (Button)sender;
            if (semn == null)
                numar1 += "4";
            else
                numar2 += "4";
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button5 = (Button)sender;
            if (semn == null)
                numar1 += "5";
            else
                numar2 += "5";
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button6 = (Button)sender;
            if (semn == null)
                numar1 += "6";
            else
                numar2 += "6";
            display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button7 = (Button)sender;
            if (semn == null)
                numar1 += "7";
            else
                numar2 += "7";
            display();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button8 = (Button)sender;
            if (semn == null)
                numar1 += "8";
            else
                numar2 += "8";
            display();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button9 = (Button)sender;
            if (semn == null)
                numar1 += "9";
            else
                numar2 += "9";
            display();
        }


        // Semne

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button buttonPlus = (Button)sender;
            if (validateSign())
                semn = "+";
            display();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Button buttonMin = (Button)sender;
            if (validateSign())
                semn = "-";
            display();
        }

        private void buttonInmultit_Click(object sender, EventArgs e)
        {
            Button buttonInmultit = (Button)sender;
            if (validateSign())
                semn = "*";
            display();
        }

        private void buttonImpartit_Click(object sender, EventArgs e)
        {
            Button buttonImpartit = (Button)sender;
            if (validateSign())
                semn = "/";
            display();
        }


        // altele
        private void buttonPunct_Click(object sender, EventArgs e)
        {
            Button buttonPunct = (Button)sender;
            if (semn == null)
               numar1= addPoint(numar1);
            else 
                numar2 = addPoint(numar2);
            display();
           
        }


        private void buttonStergere_Click(object sender, EventArgs e)
        {
            numar1 = null;
            numar2 = null;
            semn = null;
            this.textBox1.Clear();

        }

        private void buttonNegativ_Click(object sender, EventArgs e)
        {
            if (semn == null)
            {
                numar1= makeNegativ(numar1);
              }
            else
               numar2=  makeNegativ(numar2);
            display();
        }

        // functii
        private bool validateSign()
        {
           if( numar1 !=null && numar2==null)
                 if (numar1.EndsWith("0") || numar1.EndsWith("1") || numar1.EndsWith("2") || numar1.EndsWith("3") || numar1.EndsWith("4") || numar1.EndsWith("5") || numar1.EndsWith("6") || numar1.EndsWith("7") || numar1.EndsWith("8") || numar1.EndsWith("9"))

                return true;
            
            return false;
        }

        private void display()
        {
            this.avertisment.Text = "";
            this.textBox1.Clear();
            this.textBox1.AppendText(numar1 + " " + semn + " " + numar2);
        }

        private String makeNegativ(String numar)
        {
            
            if (numar == null)
            {
                numar = "-";
                return numar;
            }

            if (numar[0].ToString() == "-")
            {
                String temp = "";
                for (int i = 1; i <= numar.Length - 1; i++)
                    temp += numar[i];
                numar = temp;
                return numar;
            }
            else
            {
                numar = "-" + numar;
                return numar;
            }
        }

        private String addPoint(String numar1)
        {
            if (numar1 == null || numar1.Contains("."))
                return numar1;

            if (numar1.EndsWith("0") || numar1.EndsWith("1") || numar1.EndsWith("2") || numar1.EndsWith("3") || numar1.EndsWith("4") || numar1.EndsWith("5") || numar1.EndsWith("6") || numar1.EndsWith("7") || numar1.EndsWith("8") || numar1.EndsWith("9"))
                numar1 += ".";
            return numar1;
        }

        private void war()
        {

            this.avertisment.Text = "Nu se poate imparti la 0";
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            float flt1, flt2;
            float rez = 0;

            if (numar1 == null || numar2 == null || semn == null || numar2 == "-")
                return;

             flt1 = float.Parse(numar1);
             flt2 = float.Parse(numar2);

            switch (semn.ToString()) {
                case "+":
                    rez = flt1 + flt2;
                    break;
                case "-":
                    rez = flt1 - flt2;
                    break;
                case "*":
                    rez = flt1 * flt2;
                    break;
                case "/":
                    if (flt2 == 0.00)
                    {
                        war();
                        return;
                    }
                    rez = flt1 / flt2;
                    break;
            }

            numar1 = rez.ToString();
            numar2 = null;
            semn = null;
            display();



        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    button0_Click(button0, e);
                    break;
                case '1':
                    button1_Click(button1, e);
                    break;
                case '2':
                    button2_Click(button2, e);
                    break;
                case '3':
                    button3_Click(button3, e);
                    break;
                case '4':
                    button4_Click(button4, e);
                    break;
                case '5':
                    button5_Click(button5, e);
                    break;
                case '6':
                    button1_Click(button6, e);
                    break;
                case '7':
                    button7_Click(button7, e);
                    break;
                case '8':
                    button8_Click(button8, e);
                    break;
                case '9':
                    button9_Click(button9, e);
                    break;
                case '=':
                    buttonEgal_Click(buttonEgal, e);
                    break;
                case '*':
                    buttonInmultit_Click(buttonInmultit, e);
                    break;
                case '/':
                    buttonImpartit_Click(buttonImpartit, e);
                    break;
                case '+':
                    buttonPlus_Click(buttonPlus, e);
                    break;
                case '-':
                    buttonMinus_Click(buttonMinus, e);
                    break;
                case '.':
                    buttonPunct_Click(buttonVirgula, e);
                    break;
                case 'm':
                    buttonNegativ_Click(buttonNegativ, e);
                    break;
                case 'd':
                    buttonStergere_Click(buttonStergere, e);
                    break;

                default:
                    break;
            }

        }
    }

}
