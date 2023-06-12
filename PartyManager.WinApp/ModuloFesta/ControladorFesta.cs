using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;
using PartyManager.WinApp.ModuloCliente;
using PartyManager.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManager.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioFesta repoFesta;
        private TabelaFestaControl tabelaFesta;
        private List<Tema> temas;
        private List<Cliente> clientes;

        public ControladorFesta (IRepositorioFesta repoFesta, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repoFesta = repoFesta;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            
        }
        public override string ToolTipInserir => "Inserir Festa";

        public override string ToolTipEditar => "Editar Festa";

        public override string ToolTipDeletar => "Deletar Festa";

        public override void Deletar()
        {
            Festa festaSeleciado = ObterFestaSelecionado();

            if (festaSeleciado == null)
            {
                MessageBox.Show($"Selecione uma festa primeiro!",
                    "Exclusão de Festas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
        }
        private Festa ObterFestaSelecionado()
        {
            int id = tabelaFesta.ObterIdSelecionado();
            return repoFesta.SelecionarPorId(id);
        }
        public override void Editar()
        {
            TelaFestaForm telaFesta = new TelaFestaForm();
            Festa festaSelecionado = ObterFestaSelecionado();

            if (festaSelecionado == null)
            {
                MessageBox.Show($"Selecione uma Festa primeiro!",
                    "Edição de Festas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }


            telaFesta.ConfigurarTela(festaSelecionado, temas, clientes);

            if (telaFesta.ShowDialog() == DialogResult.OK)
            {
                Festa festaAtualizado = telaFesta.ObterFesta();
                repoFesta.Editar(festaAtualizado.id, festaAtualizado);
            }
            CarregarFestas();
            TelaPrincipalForm.Instancia.AtualizarRodape($"Festa editada com sucesso!", TipoStatusEnum.Sucesso);
        }

        public override void Inserir()
        {
            TelaFestaForm telaFesta = new TelaFestaForm();

            if (telaFesta.ShowDialog() == DialogResult.OK)
            {
                Festa novaFesta = telaFesta.ObterFesta();
                repoFesta.Inserir(novaFesta);
            }

            CarregarFestas();
            TelaPrincipalForm.Instancia.AtualizarRodape($"Festas inserida com sucesso!", TipoStatusEnum.Sucesso);
        }
        private void CarregarFestas()
        {
            temas = repositorioTema.SelecionarTodos();
            clientes = repositorioCliente.SelecionarTodos();
            List<Festa> festas = repoFesta.SelecionarTodos();
            
            tabelaFesta.AtualizarRegistros(festas);
        }
        
        public override UserControl ObterListagem()
        {
            if (tabelaFesta == null)
                tabelaFesta = new TabelaFestaControl();

            CarregarFestas();

            return tabelaFesta;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Festas";
        }
    }
}
