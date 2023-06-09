namespace PartyManager.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
          public int id;

          /// <summary>
          /// Sobreescreve os registros de um objeto para outro.
          /// </summary>
          /// <param name="registroAtualizado"></param>
          public abstract void AtualizarRegistros(TEntidade registroAtualizado);


          /// <summary>
          /// Verifica se há erros e conflitos nas regras de negócio.
          /// </summary>
          /// <returns>Uma lista com os erros encontrados.</returns>
          public abstract string[] ValidarErros();
    }
}