using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas_final.controller
{
    class ControllExpresiones
    {
        public DataTable Data { get; set; }
        int row;
        string[] fila;
        //memorias 
        string memoriaS;
        int memoriaI;
        int memoriaU;
        int finalA;
        int finalB;
        
        public ControllExpresiones()
        {
            row = 0;
        }

        public void Crear_tabla(string exprecion, List<string> lista)
        {
            Data = new DataTable();
            Crear_Columnas(lista);
            Llenar_Tabla(exprecion);
            Nombrar();

        }
        private void Crear_Columnas(List<string> lista)
        {
            fila = new string[lista.Count];

            DataColumn columna = new DataColumn();
            columna.ColumnName = "nombre";
            Data.Columns.Add(columna);
            columna = new DataColumn();
            columna.ColumnName = "λ";
            Data.Columns.Add(columna);
            foreach (string s in lista)
            {
                columna = new DataColumn();
                columna.ColumnName = s;
                Data.Columns.Add(columna);
            }

        }
        private void Llenar_Tabla(string expresion)
        {
            Data.Rows.Add(fila); 
            foreach (char s in expresion)
            {
               
                if (char.IsLetter(s) && s.ToString() != "U")
                {
                    // agregar transicion lambda
                    Data.Rows[row]["λ"] = string.Format(" {0}  {1}", Data.Rows[row]["λ"], row +1);
                    row++;
                    Data.Rows.Add(fila);
                    // agregar transicion
                    Data.Rows[row][s.ToString()] = Convert.ToString(row + 1);
                    memoriaS = s.ToString();
                    memoriaI = row;
                    row++;
                    Data.Rows.Add(fila);
                    
                }
                else if (s == Convert.ToChar("*"))
                {
                    if (char.IsLetter(memoriaS[0]))
                    {
                        // agregar Kleen
                        Data.Rows[memoriaI][memoriaS] = memoriaI;
                        Data.Rows[memoriaI]["λ"] = string.Format(" {0}  {1}" , Data.Rows[memoriaI]["λ"], memoriaI + 1);

                    }
                    else
                    {
                        Data.Rows[row]["λ"] = string.Format(" {0}  {1}", Data.Rows[row]["λ"], memoriaU);

                    }
                    
                }
                else if (s == Convert.ToChar("("))
                {   
                    //agregamos lambda
                    Data.Rows[row]["λ"] = string.Format("{0} _ {1}",Data.Rows[row]["λ"], row + 1);
                    row++;
                    Data.Rows.Add(fila);
                    // agregar memoria de division
                    memoriaU = row;
                    Data.Rows[row]["λ"] = Convert.ToString(row + 1);
                    row++;
                    Data.Rows.Add(fila);
                }
                else if (s == Convert.ToChar("U"))
                {
                    finalA = memoriaI;
                    Data.Rows[memoriaU]["λ"]  = string.Format(" {0} - {1} ", memoriaU+1 , row+1);
                    row++;
                    Data.Rows.Add(fila);

                }
                else if (s == Convert.ToChar(")"))
                {
                    finalB = memoriaI;
                    memoriaS = ")";
                   
                    row++;
                    Data.Rows.Add(fila);
                    
                    // ambos finales se unen 
                    Data.Rows[finalA + 1]["λ"] = row;
                    Data.Rows[finalB + 1]["λ"] = row;
                    
                    Data.Rows.Add(fila);
                    
                }
            }
        }
        private void Nombrar()
        {
            for(int n = 0; n < Data.Rows.Count; n++)
            {
                Data.Rows[n]["nombre"] = string.Format(" Q {0} ", n);
            }
        }
    }
}
