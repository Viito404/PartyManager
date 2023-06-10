namespace PartyManager.WinApp.ModuloCliente
{
     partial class TabelaClienteControl
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               tabelaCliente = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)tabelaCliente).BeginInit();
               SuspendLayout();
               // 
               // tabelaCliente
               // 
               tabelaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               tabelaCliente.Dock = DockStyle.Fill;
               tabelaCliente.Location = new Point(0, 0);
               tabelaCliente.Name = "tabelaCliente";
               tabelaCliente.RowTemplate.Height = 25;
               tabelaCliente.Size = new Size(439, 367);
               tabelaCliente.TabIndex = 0;
               // 
               // TabelaClienteControl
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               Controls.Add(tabelaCliente);
               Name = "TabelaClienteControl";
               Size = new Size(439, 367);
               ((System.ComponentModel.ISupportInitialize)tabelaCliente).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView tabelaCliente;
     }
}
