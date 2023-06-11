
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TelaItensForm : Form
    {
        List<Item> ListaItens = new List<Item>();
        public TelaItensForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }      

        public List<Item> ObterListaItens()
        {
            return ListaItens;
        }

        private void btnAdicionarItemTema_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(tboxId.Text);
            string nome = tboxNome.Text;
            decimal valor = Convert.ToDecimal(txtboxValor.Text);

            ListBoxItens.Items.Add($"Item: {nome} - Valor: {valor}");

            tboxNome.Text = "";
            txtboxValor.Text = "";


            Item novoItem = new Item(id, nome, valor);

            string[] erros = novoItem.ValidarErros();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

            ListaItens.Add(novoItem);


        }
    }
}

