using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form_horarios : Form
    {
        public Form_horarios()
        {
            InitializeComponent();
        }
        acciones c = new acciones();
        private void btn_salirH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrarH_Click(object sender, EventArgs e)
        {
            dgv_horas.DataSource = c.MostrarHorarios();
        }

        private void btn_insertarH_Click(object sender, EventArgs e)
        {
            c.insertar_horario(TimeSpan.Parse(txt_hora.Text));
            dgv_horas.DataSource = c.MostrarHorarios();
        }

        private void btn_actualiarH_Click(object sender, EventArgs e)
        {
            c.actualizar_horario(int.Parse(txt_idhora.Text), TimeSpan.Parse(txt_hora.Text));
                dgv_horas.DataSource = c.MostrarHorarios();
        }

        private void btn_limpiarH_Click(object sender, EventArgs e)
        {
            txt_idhora.Text = "";
            txt_hora.Text = "";
        }

        private void dgv_horas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idhora.Text = dgv_horas.CurrentRow.Cells[0].Value.ToString();
            txt_hora.Text = dgv_horas.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
