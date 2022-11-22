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
    public partial class Form_cartelera : Form
    {
        public Form_cartelera()
        {
            InitializeComponent();
        }
        acciones d = new acciones();
        private void btn_salirS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrarC_Click(object sender, EventArgs e)
        {
            dgv_carte.DataSource = d.MostrarCartelera();
        }

        private void btn_insertarC_Click(object sender, EventArgs e)
        {
            d.insertar_cartelera(int.Parse(txt_idSala.Text), int.Parse(txt_idHoras.Text), int.Parse(txt_idPel.Text));
            dgv_carte.DataSource = d.MostrarCartelera();
        }

        private void btn_limpiarC_Click(object sender, EventArgs e)
        {
            txt_idCart.Text = "";
            txt_idHoras.Text = "";
            txt_idPel.Text = "";
            txt_idSala.Text = "";

        }

        private void dgv_carte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idCart.Text = dgv_carte.CurrentRow.Cells[0].Value.ToString();
            txt_idSala.Text = dgv_carte.CurrentRow.Cells[1].Value.ToString();
            txt_idHoras.Text = dgv_carte.CurrentRow.Cells[2].Value.ToString();
            txt_idPel.Text = dgv_carte.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
