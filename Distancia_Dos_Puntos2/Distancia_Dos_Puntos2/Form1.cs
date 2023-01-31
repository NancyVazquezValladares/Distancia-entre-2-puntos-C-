using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_Dos_Puntos2
{
    public partial class FrmPractica1 : Form
    {
        public FrmPractica1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { 
            Formula clase = new Formula();
            double a = clase.formula(double.Parse(tbX2.Text), double.Parse(tbX1.Text), double.Parse(tbY2.Text), double.Parse(tbY1.Text));
            tbDistamcia.Text = a.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbX1.Text = "";
            tbX2.Text = "";
            tbY1.Text = "";
            tbY2.Text = "";
            tbDistamcia.Text = "";
        }
    }
}
