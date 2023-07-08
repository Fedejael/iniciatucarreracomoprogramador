using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        public string titulo;
        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        private void Calcular()
        {
            double total = 0;
            string detalle = "";
            if(rbTallaS.Checked == true)
            {
                total += 50;
                detalle += "Casaca Talle S $50 \r\n";
            }
            if (rbTallaM.Checked == true)
            {
                total += 100;
                detalle += "Casaca Talle M $100 \r\n";
            }
            if (rbTallaL.Checked == true)
            {
                total += 200;
                detalle += "Casaca Talle L $200 \r\n";
            }
            if (rbBlanco.Checked==true)
            {
                total += 10;
                detalle += "Color blanco \r\n";
            }
            if (rbRojo.Checked == true)
            {
                total += 20;
                detalle += "Color rojo \r\n";
            }
            detalle += "El total a pagar es de " + total + "\r\n";
            txtdetalle.Text = detalle;

        }
    }
}
