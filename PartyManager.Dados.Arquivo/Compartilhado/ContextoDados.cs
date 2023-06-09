﻿using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PartyManager.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string CAMINHO_ARQUIVO = "Compartilhado\\PartyManager.json";

        public List<Cliente> clientes;

        public List<Tema> temas;
        public List<Festa> festas;

        /*
        Implementar listas das entidades
        */

        public ContextoDados()
        {
            clientes = new List<Cliente>();
            temas = new List<Tema>();
            festas = new List<Festa>();

            /*
            Instanciar listas das entidades
            */
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarArquivoJson();
        }

        /// <summary>
        /// Grava os registros do tipo string, em um arquivo Json.
        /// </summary>
        public void GravarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            string registrosJson = JsonSerializer.Serialize(this, configuracoes);

            File.WriteAllText(CAMINHO_ARQUIVO, registrosJson);
        }

        /// <summary>
        /// Pegar os registros de um arquivo Json e atribui para dentro das listas.
        /// </summary>
        private void CarregarArquivoJson()
        {
            JsonSerializerOptions configuracoes = ConfigurarSerializadorJson();

            if (File.Exists(CAMINHO_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(CAMINHO_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados dadosJson = JsonSerializer.Deserialize<ContextoDados>(registrosJson, configuracoes);

                    clientes = dadosJson.clientes;
                    temas = dadosJson.temas;
                    festas = dadosJson.festas;
                    /*
                    Fazer listas receberem os dados de "dadosJson" 
                    */
                }
            }
        }

        /// <summary>
        /// Configura algumas opções do serializador Json. 
        /// </summary>
        /// <returns>Retorna uma classe com as opções definidas.</returns>
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
