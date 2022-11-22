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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Cine
{
    public partial class Form_peliculas : Form
    {
        public Form_peliculas()
        {
            InitializeComponent();
        }
        acciones a = new acciones();
        private void btn_salirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrarP_Click(object sender, EventArgs e)
        {
            dgv_pelis.DataSource = a.MostrarPeliculas();
        }

        private void btn_insertarP_Click(object sender, EventArgs e)
        {
            a.insertar_pelicula(txt_tituloP.Text, txt_duracionP.Text, txt_generoP.Text, txt_caliP.Text);
            dgv_pelis.DataSource = a.MostrarPeliculas();
        }

        private void btn_eliminarP_Click(object sender, EventArgs e)
        {
            a.eliminar_pelicula(int.Parse(txt_idP.Text));
            dgv_pelis.DataSource = a.MostrarPeliculas();
        }

        private void btn_actualiarP_Click(object sender, EventArgs e)
        {
            a.actualizar_pelicula(int.Parse(txt_idP.Text), txt_tituloP.Text, txt_duracionP.Text, txt_generoP.Text, txt_caliP.Text);
            dgv_pelis.DataSource = a.MostrarPeliculas();
        }

        private void btn_limpiarP_Click(object sender, EventArgs e)
        {
            txt_idP.Text = "";
            txt_tituloP.Text = "";
            txt_generoP.Text = "";
            txt_caliP.Text = "";
            txt_duracionP.Text = "";
        }

        private void dgv_pelis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idP.Text = dgv_pelis.CurrentRow.Cells[0].Value.ToString();
            txt_tituloP.Text = dgv_pelis.CurrentRow.Cells[1].Value.ToString();
            txt_duracionP.Text = dgv_pelis.CurrentRow.Cells[2].Value.ToString();
            txt_generoP.Text = dgv_pelis.CurrentRow.Cells[3].Value.ToString();
            txt_caliP.Text = dgv_pelis.CurrentRow.Cells[4].Value.ToString();

        }

        private void Form_peliculas_Load(object sender, EventArgs e)
        {
            if(!File.Exists("pelis.txt"))
{
                StreamWriter bloc = new StreamWriter("pelis.txt");
               bloc.Close();
            }
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            GuardarNotas();
        }
        private void GuardarNotas()
        {
            StreamWriter bloc = new StreamWriter("pelis.txt", true);
            bloc.WriteLine(txt_idP.Text);
            bloc.WriteLine(txt_tituloP.Text);
            bloc.WriteLine(txt_generoP.Text);
            bloc.WriteLine(txt_duracionP.Text);
            bloc.WriteLine(txt_caliP.Text);
            bloc.Close();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dgv_pelis.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                // save.Filter = "PDF (*.pdf |*.pdf)";
                save.Filter = "PDF|.pdf  ";
                save.FileName = "PelisPDF";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Vas bien" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgv_pelis.Columns.Count);
                            pTable.DefaultCell.Padding = 5;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in dgv_pelis.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach(DataGridViewRow viewRow in dgv_pelis.Rows)
                            {
                                foreach(DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Informacion exportada", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fallo la exportacion ", ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vacio", "Info");

            }
        }
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumn = 0;
            foreach (DataGridViewColumn columna in dgv_pelis.Columns)
            {
                indicecolumn++;

                exportarexcel.Cells[1, indicecolumn] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in dgv_pelis.Rows)
            {
                indicefila++;
                indicecolumn = 0;

                foreach (DataGridViewColumn columna in dgv_pelis.Columns)
                {
                    indicecolumn++;
                    exportarexcel.Cells[indicefila + 1, indicecolumn] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }
        private void btn_excel_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgv_pelis);
        }
      
    }
}
