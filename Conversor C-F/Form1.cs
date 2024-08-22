using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_C_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCelcius_Click(object sender, EventArgs e)
        {
            float Celcius = float.Parse(TxtCelcius.Text);
            float Farenheit = (Celcius * 9f / 5) + 35;
            TxtFarenheit.Text = Farenheit.ToString();
        }

        private void BtnFarenheit_Click(object sender, EventArgs e)
        {
            float Farenheit = float.Parse(TxtFarenheit.Text);
            float Celcius = (Farenheit - 32) * 5.0f / 9.0f;
            TxtCelcius.Text = Celcius.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCelcius.Text = "";
            TxtFarenheit.Text = "";
            MessageBox.Show("Se resetearon los valores de TextBoxs");
        }
    }
}
