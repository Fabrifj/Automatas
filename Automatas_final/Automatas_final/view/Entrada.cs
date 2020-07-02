using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_final.view
{
    public partial class Entrada : Form
    {
        private string nombre_Columna;
        private string lambda = "λ";
        public Entrada()
        {
            InitializeComponent();
        }

        public string Nombre_Columna { get => nombre_Columna; }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            nombre_Columna = txt_Nombre.Text;
            if (nombre_Columna == "")
            {
                DialogResult res = MessageBox.Show("Nombre no ingresado", "Error", MessageBoxButtons.OKCancel);

                if (res == DialogResult.Cancel)
                    this.Close();
            }
            else this.Close();
        }

        private void btn_Lambda_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = lambda;
        }
    }
}
