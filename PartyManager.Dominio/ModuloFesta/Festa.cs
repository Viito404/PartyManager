using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManager.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public string Endereco { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Festa()
        {

        }

        public Festa(int id, Cliente cliente, Tema tema, string endereco, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino)
        {
            this.id = id;
            Cliente = cliente;
            Tema = tema;
            Endereco = endereco;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public override void AtualizarRegistros(Festa registroAtualizado)
        {
            Cliente = registroAtualizado.Cliente;
            Tema = registroAtualizado.Tema;
            Endereco = registroAtualizado.Endereco;
            Data = registroAtualizado.Data;
            HoraInicio = registroAtualizado.HoraInicio;
            HoraTermino = registroAtualizado.HoraTermino;
        }

        public override string[] ValidarErros()
        {
            List<string> errosFesta = new List<string>();

            if (Cliente == null) 
            {
                errosFesta.Add("Campo \"Cliente\" é obrigatório!");
            }
            if (Tema == null)
            {
                errosFesta.Add("Campo \"Tema\" é obrigatório!");
            }

            if (string.IsNullOrEmpty(Endereco))
                errosFesta.Add("Campo \"Endereço\" é obrigatório!");

            if (Data < DateTime.Now)
            {
                errosFesta.Add("Campo \"Data\" não pode ser anterior a data atual!");
            }
            if (HoraTermino <= HoraInicio)
            {
                errosFesta.Add("Campo \"Hora Término\" deve ser superior ao horário de início!");
            }

            return errosFesta.ToArray();
        }
    }
}
