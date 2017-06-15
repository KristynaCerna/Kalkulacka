using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        Double hodnota = 0;
        String funkce = ""; 
        bool funkce_vybrana = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((vysledek.Text == "0")||(funkce_vybrana))
                vysledek.Clear();

            Button klavesa = (Button)sender;
            vysledek.Text = vysledek.Text + klavesa.Text;
        }

        private void funkce_click(object sender, EventArgs e)
        {
            Button klavesa = (Button)sender;
            funkce = klavesa.Text;
            hodnota = Double.Parse(vysledek.Text);
            funkce_vybrana = true; 
        }

        private void ButtonVymazatVse_Click(object sender, EventArgs e)
        {
            vysledek.Text = "0";
        }

        private void buttonSmazatVse_Click(object sender, EventArgs e)
        {
            vysledek.Clear();
            hodnota = 0;
            vysledek.Text = "0";
        }

        private void buttonRovnase_Click(object sender, EventArgs e)
        {
            switch(funkce)
            {
                case "+":
                    vysledek.Text = (hodnota + Double.Parse(vysledek.Text)).ToString();
                    break;

                case "-":
                    vysledek.Text = (hodnota - Double.Parse(vysledek.Text)).ToString();
                    break;

                case "*":
                    vysledek.Text = (hodnota * Double.Parse(vysledek.Text)).ToString();
                    break;

                case "/":
                    vysledek.Text = (hodnota / Double.Parse(vysledek.Text)).ToString();
                    break;
                default:
                    break;
            }
            funkce_vybrana = false;
        }
    }
}
