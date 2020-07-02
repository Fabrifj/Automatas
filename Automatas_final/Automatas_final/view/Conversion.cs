using Automatas_final.view;
using System;
using System.Collections;
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
    public partial class Conversion : Form
    {

        private DataTable tabla_Inicial;

        private List<string> estados_Automata;
        private List<string> transiciones;

        private List<string> verificados;

        private string nombre_Columna;

        private bool afn;

        private string delta = "Δ";
        private string lambda = "λ";
        private string phi = "Φ";
        public Conversion()
        {
            InitializeComponent();
            tabla_Inicial = new DataTable();
        }
        private void Conversion_Load(object sender, EventArgs e)
        {
            verificados = new List<string>();

            estados_Automata = new List<string>();
            transiciones = new List<string>();

            nombre_Columna = "";

            DataColumn estados = new DataColumn();
            estados.ColumnName = delta;
            tabla_Inicial.Columns.Add(estados);

            dgDatosEntrada.DataSource = tabla_Inicial;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAgregarColumna_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
            nombre_Columna = entrada.Nombre_Columna;

            if (nombre_Columna != "")
            {
                DataColumn columna = new DataColumn();
                columna.ColumnName = nombre_Columna;
                tabla_Inicial.Columns.Add(columna);
                dgDatosEntrada.DataSource = tabla_Inicial;
            }
            else MessageBox.Show("La columna debe tener un valor de entrada", "Error", MessageBoxButtons.OK);
        }

        private void completar_Transiciones()
        {
            string[] estados_Separados;
            bool todos_Verificados = false;
            int cont = 0;


            while (!todos_Verificados)
            {
                if (transiciones[cont].Contains(",") && !verificados.Contains(transiciones[cont]))
                {
                    estados_Separados = separar_Estados(transiciones[cont]);
                    actualizar_Estados(estados_Separados, cont);
                    estados_Automata.Add(transiciones[cont]);
                }

                verificados.Add(transiciones[cont]);

                cont++;

                if (cont == transiciones.Count) todos_Verificados = true;
            }
        }

        private void btn_Lambda_Click(object sender, EventArgs e)
        {
            dgDatosEntrada.CurrentCell.Value = lambda;
        }

        private void btn_Vacio_Click(object sender, EventArgs e)
        {
            dgDatosEntrada.CurrentCell.Value = phi;
        }
        private string[] separar_Estados(string estados)
        {
            string[] separados = estados.Split(Convert.ToChar(","));

            return separados;
        }
        private void actualizar_Estados(string[] conjunto_Estados, int index)
        {
            int cont;
            string transicion;
            string e;

            DataRow nuevo_Estado = tabla_Inicial.NewRow();

            for (int i = 1; i < tabla_Inicial.Columns.Count; i++)
            {
                transicion = "";

                for (int j = 0; j < conjunto_Estados.Length; j++)
                {
                    cont = 0;

                    while (estados_Automata[cont] != conjunto_Estados[j])
                        cont++;

                    e = tabla_Inicial.Rows[cont][i].ToString();
                    if (!transicion.Contains(e) && e != phi)
                        transicion = agregar(transicion, tabla_Inicial.Rows[cont][i].ToString());
                }

                if (transicion == "") transicion = phi;

                nuevo_Estado[i] = transicion;
                transiciones.Add(transicion);
            }

            nuevo_Estado[0] = transiciones[index];
            tabla_Inicial.Rows.Add(nuevo_Estado);
        }

        private string agregar(string principal, string a)
        {
            if (principal != "")
                principal += "," + a;
            else principal = a;

            return principal;
        }
        private void agregar_Estados()
        {
            for (int i = 0; i < tabla_Inicial.Rows.Count; i++)
            {
                string estado = tabla_Inicial.Rows[i][0].ToString();
                estados_Automata.Add(estado);
            }
        }

        private void agregar_Transiciones()
        {
            string transicion;

            for (int i = 0; i < tabla_Inicial.Rows.Count; i++)
            {
                for (int j = 1; j < tabla_Inicial.Columns.Count; j++)
                {
                    transicion = tabla_Inicial.Rows[i][j].ToString();
                    transiciones.Add(transicion);
                }
            }
        }


        //----ALGORITMO AFN-λ --------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------

        public void cambiar_Notacion()
        {
            string[] lambda_Clausura;
            int index = tabla_Inicial.Columns.Count - 2;
            for (int i = 0; i < estados_Automata.Count; i++)
            {
                if (transiciones[index].Contains(","))
                    lambda_Clausura = separar_Estados(transiciones[index]);
                else
                {
                    lambda_Clausura = new string[] { transiciones[index] };
                }
                nuevas_Transiciones(lambda_Clausura, i, index);

                index += tabla_Inicial.Columns.Count - 1;
            }
        }

        private void nuevas_Transiciones(string[] clausura, int index_Estado, int lambda_C)
        {
            string transicion;
            string cla;
            string e;

            int cont;

            for (int i = 1; i < tabla_Inicial.Columns.Count - 1; i++)
            {
                e = "";
                transicion = "";

                for (int j = 0; j < clausura.Length; j++)
                {
                    cont = 0;

                    while (estados_Automata[cont] != clausura[j])
                        cont++;

                    e = tabla_Inicial.Rows[cont][i].ToString();

                    cont = 0;

                    if (e != phi)
                    {
                        while (estados_Automata[cont] != e && cont < estados_Automata.Count)
                            cont++;

                        cla = transiciones[cont * (tabla_Inicial.Columns.Count - 1) + (tabla_Inicial.Columns.Count - 2)];

                        if (!transicion.Contains(cla))
                            transicion = agregar(transicion, cla);
                    }

                }

                if (transicion == "") transicion = phi;

                verificados.Add(transicion);
            }
        }

        private void actualizar_Transiciones()
        {
            int cont = 0;

            for (int i = 0; i < tabla_Inicial.Rows.Count; i++)
            {
                for (int j = 1; j < tabla_Inicial.Columns.Count - 1; j++)
                {
                    tabla_Inicial.Rows[i][j] = verificados[cont];
                    cont++;
                }
            }
        }



    }
}
