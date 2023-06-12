using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloFesta
{
    partial class TabelaFestaControl
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
            tabelaFestas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaFestas).BeginInit();
            SuspendLayout();
            // 
            // tabelaFestas
            // 
            tabelaFestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFestas.Dock = DockStyle.Fill;
            tabelaFestas.Location = new Point(0, 0);
            tabelaFestas.Margin = new Padding(3, 2, 3, 2);
            tabelaFestas.Name = "tabelaFestas";
            tabelaFestas.RowHeadersWidth = 51;
            tabelaFestas.RowTemplate.Height = 29;
            tabelaFestas.Size = new Size(511, 336);
            tabelaFestas.TabIndex = 1;
            // 
            // TabelaFestaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaFestas);
            Name = "TabelaFestaControl";
            Size = new Size(511, 336);
            ((System.ComponentModel.ISupportInitialize)tabelaFestas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaFestas;
    }
}
