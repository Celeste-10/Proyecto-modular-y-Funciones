using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monto.Dao;

namespace Monto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio=double.Parse(tbPrecio.Text);
            lblMonto.Text = "Precio: "+precio+" Monto: "+Calculo.CalcularMonto(precio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "Monto: " + Calculo.CalcularMonto(ref precio)+" Precio: "+precio;
        }
    }
}
