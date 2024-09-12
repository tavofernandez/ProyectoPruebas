using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Pruebas
{
    public partial class frmPruebas : Form
    {
        public frmPruebas()
        {
            InitializeComponent();
        }

        int numero1, numero2, resultado;
        private void button1_Click(object sender, EventArgs e)
        {

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = numero1 + numero2;

            textBox3.Text = resultado.ToString();

        }
    }
}
