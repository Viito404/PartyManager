using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.Dados.Arquivo.ModuloCliente
{
     public class RepositorioClienteArquivo : RepositorioArquivoBase<Cliente>, IRepositorioCliente
     {
          public RepositorioClienteArquivo(ContextoDados contexto) : base(contexto)
          {
          }

          protected override List<Cliente> ObterRegistros()
          {
               return contextoDados.clientes;
          }
     }
}
