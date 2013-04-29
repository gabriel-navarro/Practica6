using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        double p1, p2, p3, sub, iva, total;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = double.Parse(this.Producto1.Text);
            p2 = double.Parse(this.Producto2.Text);
            p3 = double.Parse(this.Producto3.Text);
            sub = p1+p2+p3;
            this.factura.Text = sub.ToString();
            iva = sub * .16;
            this.factura.Text = iva.ToString();
            total = sub+iva;
            this.factura.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.Clear();
            p2.Clear();
            p3.Clear();
            sub.Clear();
            iva.Clear();
            total.Clear();
        }
    }
}
