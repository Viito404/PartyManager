
namespace PartyManager.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome;
        public List<Itens> ListaItens = new List<Itens>();
        public decimal valorTotalItens;

        public Tema()
        {
        }

        public Tema(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
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
