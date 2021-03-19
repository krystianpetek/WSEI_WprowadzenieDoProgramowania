using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelWiek_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            labelKomunikat1.Text = "Witaj, " + textBoxImie.Text + " " + textBoxNazwisko.Text;
            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if (wiek <= 0)
            {
                labelKomunikat2.Text = "Błędnie wprowadzone dane";
            }
            else if (wiek < 67)
            {
                wiek = 67 - wiek;
                labelKomunikat2.Text = ($"do emerytury zostało Ci {wiek} lat");
            }
            else
            {
                labelKomunikat2.Text = "jesteś emerytem";
            }
        }
    }
}
