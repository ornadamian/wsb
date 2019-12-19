using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kwadrat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textobw_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textpole_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBok_TextChanged_TextChanged(object sender, EventArgs e)
        {
            double bok;
            if (double.TryParse(text_bok.Text,out bok) && bok >0)
            {
                textpole.Text = Math.Pow(bok, 2).ToString();
                textobw.Text = (4 * bok).ToString();
                lblkomunikat.Text = String.Empty;
            }
            else
            {
                lblkomunikat.Text = "Wpisz Liczbę dodatnią";
                textpole.Text = String.Empty;
                textobw.Text = String.Empty;
            }

        }

        private void btnwyczysc_Click(object sender, EventArgs e)
        {
            textpole.Text = String.Empty;
            textobw.Text = String.Empty;
            text_bok.Text = String.Empty;
            lblkomunikat.Text = " Wpisz wymiar boku";

        }

        private void btnzamknij_Click(object sender, EventArgs e)
        {
            this.Close(); //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formcolor = new color1();
            formcolor.Show();

        }
    }
}
