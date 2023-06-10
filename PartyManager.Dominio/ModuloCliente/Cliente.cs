using System.Text.Json.Serialization;

namespace PartyManager.Dominio.ModuloCliente
{
     public class Cliente : EntidadeBase<Cliente>
     {
          public string nome { get; set;}
          public string telefone;

          public Cliente()
          {

          }

          public Cliente(string nome, string telefone)
          {
               this.nome = nome;
               this.telefone = telefone;
          }

          public override void AtualizarRegistros(Cliente registroAtualizado)
          {
               nome = registroAtualizado.nome;
               telefone = registroAtualizado.telefone;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrEmpty(nome))
                    erros.Add("Campo \"Nome\" está vazio!");

               if (telefone == "(  )     -")
                    erros.Add("Campo \"Telefone\" está vazio!");

               return erros.ToArray();
          }
     }
}
