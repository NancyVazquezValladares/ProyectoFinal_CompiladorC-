using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Compilador_C
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            DGWLog.DataSource = Conexion.Query("select Nombre as Usuario,Nombre_Lenguaje as Lenguaje,Fecha,Archivo from Log,Usuario,Lenguaje where Usuario.id_Usuario = Log.id_Usuario and Log.id_Lenguaje = Lenguaje.id_Lenguaje");
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            string query = "select Nombre as Usuario,Nombre_Lenguaje as Lenguaje,Fecha,Archivo from Log,Usuario,Lenguaje where Usuario.id_Usuario = Log.id_Usuario and Log.id_Lenguaje = Lenguaje.id_Lenguaje";
            Conexion con = new Conexion();
            if (UsuarioCheck.Checked) query += " and Usuario.Nombre='" + UsuarioText.Text + "'";
            if (LenguajeCheck.Checked) query += " and Lenguaje.Nombre_Lenguaje='" + LenguajeText.Text + "'";
            if (FechaCheck.Checked)
            {
                query += " and Fecha between @fecha1 and @fecha2";
                DGWLog.DataSource = Conexion.Query(query,FechaInicio.Value,FechaFin.Value);
                return;
            }
            DGWLog.DataSource = Conexion.Query(query);
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.Filter = "Text Files (*.txt)|*.txt";
                exportar.ShowDialog();
                StreamWriter sw = new StreamWriter(exportar.FileName);
                foreach (DataGridViewRow linea in DGWLog.Rows)
                {
                    sw.WriteLine(linea.Cells[0].Value + " " + linea.Cells[1].Value + " " + linea.Cells[2].Value + " " + linea.Cells[3].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void Csv_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.DefaultExt = "csv";
                exportar.Filter = "CSV Files (*.csv)|*.csv";
                exportar.ShowDialog();
                StreamWriter sw = new StreamWriter(exportar.FileName);
                foreach (DataGridViewRow linea in DGWLog.Rows)
                {
                    sw.WriteLine(linea.Cells[0].Value + "," + linea.Cells[1].Value + "," + linea.Cells[2].Value + "," + linea.Cells[3].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.Filter = "Excel (*.xls)|*.xls";
                if (exportar.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    for (int i = 0; i < DGWLog.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGWLog.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = DGWLog.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(exportar.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void DGWLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
