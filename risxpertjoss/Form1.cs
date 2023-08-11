/***********************************************************/
/*           Programación para mecatrónicos                */
/*  Nombre:    Josnell Tejeda Sicart                       */
/*  Matricula: 2022-1145                                   */
/*  Seccion:   Viernes                                     */
/*  Practica:  Risxpert                                    */
/*  Fecha:     1/8/2023                                    */
/***********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace risxpertjoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int idCounter = 1;
        private void btnSave1_Click(object sender, EventArgs e)
        {
            int rowIndex =
              dtgv1.Rows.Count - 1;



            string Analista = textBoxanalista.Text;
            string BienoActivo = textBoxbien.Text;
            string Riesgo = textBoxries.Text;
            string Daño = textBoxdaño.Text;
            dtgv1.Rows.Add(idCounter, Analista, BienoActivo, Riesgo, Daño);

            idCounter++;

            textBoxanalista.Clear();
            textBoxbien.Clear();
            textBoxries.Clear();
            textBoxdaño.Clear();

        }

        private void textBoxdaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)



                dtgv1.Rows.Remove(dtgv1.CurrentRow);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void btnSave2_Click(object sender, EventArgs e)
        {

            
            string columna2 = dtgv1.Rows[dtgv1.Rows.Count - 1].Cells[2].Value?.ToString();
            string columna3 = dtgv1.Rows[dtgv1.Rows.Count - 1].Cells[3].Value?.ToString();
            string columna4 = dtgv1.Rows[dtgv1.Rows.Count - 1].Cells[4].Value?.ToString();
            

        }



        private void dtgvValores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdtvValores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex >= 3 && e.ColumnIndex <= 8 && !string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
              
                if (!int.TryParse(e.FormattedValue.ToString(), out int numericValue))
                {
                    e.Cancel = true; 
                    MessageBox.Show("Inserte valor numérico.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                if (numericValue < 1 || numericValue > 5)
                {
                    e.Cancel = true; 
                    MessageBox.Show("Inserte valor entre 1 y 5.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvValores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellValores = dtgvValores.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex >= 3)
            {
                if (int.TryParse(cellValores.Value?.ToString(), out int numericValue))
                {
                    switch (numericValue)
                    {
                        case 1:
                            cellValores.Style.BackColor = Color.Blue;
                            break;
                        case 2:
                            cellValores.Style.BackColor = Color.Lime;
                            break;
                        case 3:
                            cellValores.Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            cellValores.Style.BackColor = Color.Orange;
                            break;
                        case 5:
                            cellValores.Style.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void tabControl_Seleted(object sender, TabControlEventArgs e)
        {
            for (int i = 0; i < dtgv1.Rows.Count; i++)
            {

                {
                    UpdateTab2(i);
                    UpdateTab3(i);
                    UpdateTab4(i);
                }

            }

        }
        private void UpdateTab2(int i)
        {
            var dtgvValoresRows = dtgvValores.Rows[i];
            var dtgv1Rows = dtgv1.Rows[i];


            if (dtgvValores.Rows.Count < dtgv1.Rows.Count)
            {
                dtgvValores.Rows.Add();
            }
            dtgvValoresRows.Cells[0].Value = dtgv1Rows.Cells[2].Value;
            dtgvValoresRows.Cells[1].Value = dtgv1Rows.Cells[3].Value;
            dtgvValoresRows.Cells[2].Value = dtgv1Rows.Cells[4].Value;
        }
        private void UpdateTab3(int i)
        {
            var dtgvevaluacionRows = dtgvevaluacion.Rows[i];
            var dtgvValoresRows = dtgvValores.Rows[i];

            int F = Convert.ToInt32(dtgvValoresRows.Cells[4].Value);
            int S = Convert.ToInt32(dtgvValoresRows.Cells[3].Value);
            int P = Convert.ToInt32(dtgvValoresRows.Cells[5].Value);
            int E = Convert.ToInt32(dtgvValoresRows.Cells[8].Value);
            int A = Convert.ToInt32(dtgvValoresRows.Cells[6].Value);
            int V = Convert.ToInt32(dtgvValoresRows.Cells[7].Value);
            int I = F * S;
            int D = P * E;
            int Pb = A * V;
            int C = I + D;
            int ER = Pb * C;

            if (dtgvevaluacion.Rows.Count < dtgvValores.Rows.Count)
            {
                dtgvevaluacion.Rows.Add();
            }

            dtgvevaluacionRows.Cells[0].Value = dtgvValoresRows.Cells[0].Value;
            dtgvevaluacionRows.Cells[1].Value = dtgvValoresRows.Cells[1].Value;
            dtgvevaluacionRows.Cells[2].Value = dtgvValoresRows.Cells[2].Value;
            dtgvevaluacionRows.Cells[3].Value = C;
            dtgvevaluacionRows.Cells[4].Value = Pb;
            dtgvevaluacionRows.Cells[5].Value = ER;
        }

        private void dtgv_evaluacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

            }

        }


        private void UpdateTab4(int i)
        {

            if (dtgvclasificacion.Rows.Count < dtgvevaluacion.Rows.Count)
            {
                dtgvclasificacion.Rows.Add();
            }
            var dtgvClassRows = dtgvclasificacion.Rows[i];
            var dtgvevaluacionRows = dtgvevaluacion.Rows[i];

            dtgvClassRows.Cells[0].Value = dtgvevaluacionRows.Cells[0].Value;
            dtgvClassRows.Cells[1].Value = dtgvevaluacionRows.Cells[1].Value;
            dtgvClassRows.Cells[2].Value = dtgvevaluacionRows.Cells[5].Value;

            DataGridViewCell ERValue = dtgvclasificacion.Rows[i].Cells[2];
            DataGridViewRow ClassRow = dtgvclasificacion.Rows[i];

            if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)
            {
                ClassRow.Cells[3].Value = "Muy Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.  Blue;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
            {
                ClassRow.Cells[3].Value = "Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.Lime;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
            {
                ClassRow.Cells[3].Value = "Normal";
                ClassRow.Cells[3].Style.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
            {
                ClassRow.Cells[3].Value = "Grande";
                ClassRow.Cells[3].Style.BackColor = Color.Orange;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
            {
                ClassRow.Cells[3].Value = "Elevado";
                ClassRow.Cells[3].Style.BackColor = Color.Red;
            }

            dtgvclasificacion.Sort(dtgvclasificacion.Columns[2], ListSortDirection.Descending);
        }



    }       
 
}


   
    
    

