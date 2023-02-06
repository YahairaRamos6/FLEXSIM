using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia3P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            decimal d;
            Punto3d Puntoa = new Punto3d(decimal.Parse(Txt_x1.Text), decimal.Parse(Txt_y1.Text), decimal.Parse(Txt_z1.Text));
            Punto3d Puntob = new Punto3d(decimal.Parse(Txt_x2.Text), decimal.Parse(Txt_y2.Text), decimal.Parse(Txt_z2.Text));
            d = Puntoa.Calcular_Distancia(Puntob);
            Txt_Resultado.Text = d.ToString();
        }
       private void DistanciaP_Load(object sender, EventArgs e)
            {
                Txt_Resultado.Enabled = false;
            }

        private void Btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            Txt_Resultado.Clear();
            Txt_x1.Text = ("");
            Txt_x2.Text = ("");
            Txt_y2.Text = ("");
            Txt_y1.Text = ("");
            Txt_z1.Text = ("");
            Txt_z2.Text = ("");
        }
    }
}
