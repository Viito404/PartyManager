using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repoTema;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repoTema)
        {
            this.repoTema = repoTema;
        }

        public override string ToolTipInserir => "Inserir Tema";

        public override string ToolTipEditar => "Editar Tema";

        public override string ToolTipDeletar => "Deletar Tema";

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        private Tema ObterClienteSelecionado()
        {
            int id = tabelaTema.ObterIdSelecionado();
            return repoTema.SelecionarPorId(id);
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repoTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastros de Temas";

        }
    }
}
