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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        public string titulo;
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }
    }
}
