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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        double c;
        double resultado;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Asignardatos();
            Calcular();
        }
        private void Asignardatos()
        {
            try
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }
        private void Calcular()
        {
            try
            {
                resultado = ((c + 5) * (Math.Pow(b, 2) - 3 * a * c) * Math.Pow(a, 2)) / (4 * a);
                lblresultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }
    }
}
