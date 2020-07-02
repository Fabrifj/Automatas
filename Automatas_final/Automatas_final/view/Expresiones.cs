using Automatas_final.controller;
using Automatas_final.view;
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
    public partial class Expresiones : Form
    {
        ExAuto exAuto;
        ControllExpresiones ctrlE = new ControllExpresiones();
        private List<string> alfabeto = new List<string>();
        private string Expresion;
        string[] cadena;
        public Expresiones()
        {
            
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string simbolo = txtAlfabeto.Text;
            if (simbolo.Length>=2)
            {
                MessageBox.Show("Ingrese solo un caracter");
            }else if( char.IsLetter(simbolo[0]))
            {
                foreach (string s in alfabeto){
                    if (simbolo == s)
                    {
                        MessageBox.Show("Simbolo repetido ingrese uno nuevo");
                        return;
                    }
                }
                Console.WriteLine("el simobolo es "+simbolo);
                alfabeto.Add(simbolo);
            }
            else
            {
                MessageBox.Show("Ingrese un caracter alfabetico");
            }
            cbxAlfebeto.DataSource = Conversion();

            
        }
        private string[] Conversion()
        {
            int a = 0;
            cadena = new string[alfabeto.Count];
            foreach ( string s in alfabeto)
            {
                cadena[a] = s;
                a++;
            }

            return cadena;
        }

        private void btnSimbolo_Click(object sender, EventArgs e)
        {
            int index = cbxAlfebeto.SelectedIndex;
            Expresion += alfabeto[index];
            txtExpresion.Text = Expresion;
        }

        private void btnKleen_Click(object sender, EventArgs e)
        {
            Expresion += "*";
            txtExpresion.Text = Expresion;
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            Expresion += "U";
            txtExpresion.Text = Expresion;
        }

        private void btnParenA_Click(object sender, EventArgs e)
        {
            Expresion += "(";
            txtExpresion.Text = Expresion;
        }

        private void btnPareB_Click(object sender, EventArgs e)
        {
            Expresion += ")";
            txtExpresion.Text = Expresion;
        }

        private void btnTransformar_Click(object sender, EventArgs e)
        {
            ctrlE.Crear_tabla(Expresion, alfabeto);
            exAuto = new ExAuto(ctrlE.Data);
            exAuto.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Expresion = Expresion.Substring(0, Expresion.Length - 1);
            txtExpresion.Text = Expresion;
        }
    }
}
