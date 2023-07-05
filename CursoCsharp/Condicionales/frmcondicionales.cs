using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Condicionales
{
    public partial class frmcondicionales : Form
    {
        public frmcondicionales()
        {
            InitializeComponent();
        }
        int numero;
        
        private void btncalcular_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }
        private void Calcular()
        {
            try
            {

                if(numero>=1)
                {
                    lblresultado.Text = " Es un numero positivo";
                }
                else if (numero == 0)
                {
                    lblresultado.Text = " Es un valor 0";
                }
                else
                {
                    lblresultado.Text = " Es un numero negativo";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        private void AsignarValores()
        {
            try
            {
                numero = Convert.ToInt32(txtnumero.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
