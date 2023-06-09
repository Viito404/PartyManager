namespace PartyManager.Dados.Arquivo.Compartilhado
{
     public abstract class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
     {
          protected ContextoDados contextoDados;
          private int contador;

          public RepositorioArquivoBase(ContextoDados contexto)
          {
               contextoDados = contexto;
               AtualizarContador();
          }

          /// <summary>
          /// Retorna todos os registros de um tipo específico.
          /// </summary>
          /// <returns>Uma lista protegida com todos os registros de um mesmo tipo.</returns>
          protected abstract List<TEntidade> ObterRegistros();

          /// <summary>
          /// Verifica se há registros, e se houver, atribui a variável "contador" a maior id existente desses registros. 
          /// </summary>
          private void AtualizarContador()
          {
               if (ObterRegistros().Count > 0)
                    contador = ObterRegistros().Max(x => x.id);
          }

          /// <summary>
          /// Insere um novo objeto em uma lista, gravando as modificações em um arquivo Json e aumentando a variável "contador".
          /// </summary>
          /// <param name="novoRegistro"></param>
          public void Inserir(TEntidade novoRegistro)
          {
               List<TEntidade> registros = ObterRegistros();

               contador++;
               novoRegistro.id = contador;
               registros.Add(novoRegistro);

               contextoDados.GravarArquivoJson();
          }

          /// <summary>
          /// Procura pelo atributo "id" um objeto antigo de uma lista, e sobreescreve o novo objeto gravando as modificações em um arquivo Json.
          /// </summary>
          /// <param name="novoRegistro"></param>
          public void Editar(int id, TEntidade registroAtualizado)
          {
               TEntidade registroSelecionado = SelecionarPorId(id);

               registroSelecionado.AtualizarRegistros(registroAtualizado);

               contextoDados.GravarArquivoJson();
          }

          /// <summary>
          /// Remove um objeto de uma lista, gravando as modificações em um arquivo Json.
          /// </summary>
          /// <param name="novoRegistro"></param>
          public void Deletar(TEntidade registroSelecionado)
          {
               List<TEntidade> registros = ObterRegistros();

               registros.Remove(registroSelecionado);

               contextoDados.GravarArquivoJson();
          }

          /// <summary>
          /// Procura um objeto de uma lista pelo atributo "id".
          /// </summary>
          /// <param name="id"></param>
          /// <returns></returns>
          private TEntidade SelecionarPorId(int id)
          {
               List<TEntidade> registros = ObterRegistros();

               return registros.FirstOrDefault(x => x.id == id);
          }

          /// <summary>
          /// Retorna registros de um tipo específico.
          /// </summary>
          /// <returns>Uma lista pública com todos os registros de um mesmo tipo.</returns>
          public List<TEntidade> SelecionarTodos()
          {
               return ObterRegistros();
          }
     }
}