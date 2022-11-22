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
    public partial class Form_sala : Form
    {
        public Form_sala()
        {
            InitializeComponent();
        }
        acciones b = new acciones();
        private void btn_salirS_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_mostrarS_Click(object sender, EventArgs e)
        {
            dgv_sala.DataSource = b.MostrarSala();
        }

        private void btn_insertarS_Click(object sender, EventArgs e)
        {
            b.insertar_sala(txt_nom.Text, txt_des.Text);
            dgv_sala.DataSource = b.MostrarSala();
        }

        private void btn_actualiarS_Click(object sender, EventArgs e)
        {
            b.actualizar_sala(int.Parse(txt_idSala.Text), txt_nom.Text, txt_des.Text);
            dgv_sala.DataSource = b.MostrarSala();
        }

        private void btn_limpiarS_Click(object sender, EventArgs e)
        {
            txt_idSala.Text = "";
            txt_nom.Text = "";
            txt_des.Text = "";
        }

        private void dgv_sala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idSala.Text = dgv_sala.CurrentRow.Cells[0].Value.ToString();
            txt_nom.Text = dgv_sala.CurrentRow.Cells[1].Value.ToString();
            txt_des.Text = dgv_sala.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
