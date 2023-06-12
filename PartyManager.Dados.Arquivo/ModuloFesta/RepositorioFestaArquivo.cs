using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManager.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioArquivoBase<Festa>, IRepositorioFesta
    {
        public RepositorioFestaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDados.festas;
        }
    }
}
