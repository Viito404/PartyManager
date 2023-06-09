using System.Text.Json;
using System.Text.Json.Serialization;

namespace PartyManager.Dados.Arquivo.Compartilhado
{
     public class ContextoDados
     {
          private const string CAMINHO_ARQUIVO = "Compartilhado\\PartyManager.json";

          /*
          Implementar listas das entidades
          */

          public ContextoDados()
          {
               /*
               Instanciar listas das entidades
               */
          }

          public ContextoDados(bool carregarDados) : this()
          {
               if (carregarDados)
                    CarregarArquivoJson();
          }

          public void GravarArquivoJson()
          {
               JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

               string registrosJson = JsonSerializer.Serialize(this, configuracoes);

               File.WriteAllText(CAMINHO_ARQUIVO, registrosJson);
          }

          private void CarregarArquivoJson()
          {
               JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

               if (File.Exists(CAMINHO_ARQUIVO))
               {
                    string registrosJson = File.ReadAllText(CAMINHO_ARQUIVO);

                    if (registrosJson.Length > 0)
                    {
                         ContextoDados dadosJson = JsonSerializer.Deserialize<ContextoDados>(registrosJson, configuracoes);

                         /*
                         Fazer listas receberem os dados de "dadosJson" 
                         */
                    }
               }
          }

          private static JsonSerializerOptions ConfigurarSerializadorJson()
          {
               JsonSerializerOptions configuracoes = new JsonSerializerOptions();
               configuracoes.IncludeFields = true;
               configuracoes.WriteIndented = true;
               configuracoes.ReferenceHandler = ReferenceHandler.Preserve;

               return configuracoes;
          }
     }
}
