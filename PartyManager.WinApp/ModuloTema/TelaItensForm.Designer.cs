namespace PartyManager.WinApp.ModuloTema
{
    partial class TelaItensForm
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
            label1 = new Label();
            tboxId = new TextBox();
            label2 = new Label();
            tboxNome = new TextBox();
            txtboxValor = new TextBox();
            label3 = new Label();
            ListBoxItens = new ListBox();
            btnAdicionarItem = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(351, 433);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 60);
            btnCadastrar.TabIndex = 31;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(444, 433);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 60);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 66);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 32;
            label1.Text = "Nº";
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(251, 62);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 33;
            tboxId.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 138);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 34;
            label2.Text = "Nome";
            // 
            // tboxNome
            // 
            tboxNome.Anchor = AnchorStyles.None;
            tboxNome.Location = new Point(112, 135);
            tboxNome.Margin = new Padding(3, 4, 3, 4);
            tboxNome.Name = "tboxNome";
            tboxNome.Size = new Size(378, 27);
            tboxNome.TabIndex = 35;
            // 
            // txtboxValor
            // 
            txtboxValor.Anchor = AnchorStyles.None;
            txtboxValor.Location = new Point(112, 170);
            txtboxValor.Margin = new Padding(3, 4, 3, 4);
            txtboxValor.Name = "txtboxValor";
            txtboxValor.Size = new Size(201, 27);
            txtboxValor.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 173);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 39;
            label3.Text = "Valor";
            // 
            // ListBoxItens
            // 
            ListBoxItens.FormattingEnabled = true;
            ListBoxItens.ItemHeight = 20;
            ListBoxItens.Location = new Point(52, 217);
            ListBoxItens.Name = "ListBoxItens";
            ListBoxItens.Size = new Size(438, 184);
            ListBoxItens.TabIndex = 40;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.None;
            btnAdicionarItem.BackColor = SystemColors.ButtonHighlight;
            btnAdicionarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarItem.Location = new Point(319, 170);
            btnAdicionarItem.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(171, 27);
            btnAdicionarItem.TabIndex = 41;
            btnAdicionarItem.Text = "Adicionar item";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItemTema_Click;
            // 
            // TelaItensForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 506);
            Controls.Add(btnAdicionarItem);
            Controls.Add(ListBoxItens);
            Controls.Add(label3);
            Controls.Add(txtboxValor);
            Controls.Add(tboxNome);
            Controls.Add(label2);
            Controls.Add(tboxId);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Name = "TelaItensForm";
            ShowIcon = false;
            Text = "Cadastro de Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private TextBox tboxId;
        private Label label2;
        private TextBox tboxNome;
        private TextBox txtboxValor;
        private Label label3;
        private ListBox ListBoxItens;
        private Button btnAdicionarItem;
    }
}