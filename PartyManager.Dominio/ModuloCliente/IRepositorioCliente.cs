﻿namespace PartyManager.Dominio.ModuloCliente
{
     public interface IRepositorioCliente
     {
          void Inserir(Cliente novoCliente);
          void Editar(int id, Cliente cliente);
          void Deletar(Cliente clienteSelecionado);
          List<Cliente> SelecionarTodos();
          Cliente SelecionarPorId(int id);
     }
}
