using BLL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SeleccionCliente : Form
    {

        private readonly ClienteManager clienteManager;
        public Cliente ClienteSeleccionado;

        public SeleccionCliente()
        {
            InitializeComponent();
            clienteManager = new ClienteManager();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = clienteManager.GetAllClientes();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void onDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteSeleccionado = (Cliente)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            this.Close();
        }
    }
}
