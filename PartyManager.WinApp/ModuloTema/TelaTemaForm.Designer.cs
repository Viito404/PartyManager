namespace PartyManager.WinApp.ModuloTema
{
    partial class TelaTemaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            btnCancelar = new Button();
            tboxNome = new TextBox();
            label2 = new Label();
            tboxId = new TextBox();
            label1 = new Label();
            clbItens = new CheckedListBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(368, 412);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 60);
            btnCadastrar.TabIndex = 24;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(461, 412);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 60);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tboxNome
            // 
            tboxNome.Anchor = AnchorStyles.None;
            tboxNome.Location = new Point(168, 121);
            tboxNome.Margin = new Padding(3, 4, 3, 4);
            tboxNome.Name = "tboxNome";
            tboxNome.Size = new Size(286, 27);
            tboxNome.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 125);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 27;
            label2.Text = "Nome";
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(268, 55);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 26;
            tboxId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 59);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 25;
            label1.Text = "Nº";
            // 
            // clbItens
            // 
            clbItens.FormattingEnabled = true;
            clbItens.Location = new Point(119, 165);
            clbItens.Name = "clbItens";
            clbItens.Size = new Size(335, 224);
            clbItens.TabIndex = 29;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 485);
            Controls.Add(clbItens);
            Controls.Add(tboxNome);
            Controls.Add(label2);
            Controls.Add(tboxId);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private TextBox tboxNome;
        private Label label2;
        private TextBox tboxId;
        private Label label1;
        private CheckedListBox clbItens;
    }
}