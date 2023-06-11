
namespace PartyManager.Dominio.ModuloTema
{
    public class Itens : EntidadeBase<Itens>
    {
        public string nome;
        public decimal valor;


        public override void AtualizarRegistros(Itens registroAtualizado)
        {
            nome = registroAtualizado.nome;
            valor = registroAtualizado.valor;
        }

        public override string[] ValidarErros()
        {
            List<string> ErrosItens = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ErrosItens.Add("O campo nome é obrigatório");

            if (valor < 0)
                ErrosItens.Add("O valor tem que ser ZERO ou MAIOR QUE ZERO");


            return ErrosItens.ToArray();
        }
    }
}
