
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(tboxId.Text);
            string nome = tboxNome.Text;

            // pegar itens selecionado no tema.

            Tema tema = new Tema(id, nome);

            if (id > 0)
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema tema)
        {
            tboxId.Text = tema.id.ToString();
            tboxNome.Text = tema.nome;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.ValidarErros();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

        }
    }
}

