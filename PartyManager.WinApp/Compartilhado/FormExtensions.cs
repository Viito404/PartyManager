namespace PartyManager.WinApp.Compartilhado
{
     public static class FormExtensions
     {
          /// <summary>
          /// Define configurações de um Dialog para o formulário.
          /// </summary>
          /// <param name="form"></param>
          public static void ConfigurarDialog(this Form form)
          {
               form.ShowIcon = false;
               form.ShowInTaskbar = false;
               form.FormBorderStyle = FormBorderStyle.FixedDialog;
               form.StartPosition = FormStartPosition.CenterScreen;
               form.MaximizeBox = false;
               form.MinimizeBox = false;
          }
     }
}
