
namespace PartyManager.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome;
        public List<Item> ListaItens = new List<Item>();
        public decimal valorTotalItens;

        public Tema()
        {
        }

        public Tema(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void AtribuirItensTema(List<Item> itens)
        {
            ListaItens.Clear();
            ListaItens.AddRange(itens);
        }

        public override void AtualizarRegistros(Tema registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }

        public override string[] ValidarErros()
        {
            List<string> ErrosTema = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ErrosTema.Add("O nome é obrigatório");

            return ErrosTema.ToArray();
        }
    }
}
