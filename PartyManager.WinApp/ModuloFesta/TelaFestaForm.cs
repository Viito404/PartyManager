using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyManager.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        public TelaFestaForm()
        {
            InitializeComponent();
        }
        public void ConfigurarTela(Festa festa, List<Tema> temas, List<Cliente> clientes)
        {
            tboxId.Text = festa.id.ToString();
            tboxEndereco.Text = festa.Endereco;
            cbBoxTema.DataSource = temas;
            cbBoxTema.ValueMember = "Nome";
            cbBoxTema.SelectedItem = festa.Tema;
            cbBoxCliente.DataSource = clientes;
            cbBoxCliente.ValueMember = "Nome";
            cbBoxCliente.SelectedItem = festa.Cliente;
            dtData.Value = festa.Data;
        }
        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(tboxId.Text);
            string endereco = tboxEndereco.Text;
            

            Festa festa = new Festa();

            if (id > 0)
                festa.id = id;

            return festa;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
