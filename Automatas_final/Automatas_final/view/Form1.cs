using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_final
{
    public partial class Form1 : Form
    {
        Expresiones expresiones = new Expresiones();
        Gramatica gramatica = new  Gramatica();
        Conversion conversion = new Conversion();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExpresiones_Click(object sender, EventArgs e)
        {
            expresiones.ShowDialog();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            conversion.ShowDialog();
        }

        private void btnGramatica_Click(object sender, EventArgs e)
        {
            gramatica.ShowDialog();
        }
    }
}
