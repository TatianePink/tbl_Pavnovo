namespace sistema
{
    partial class fmr_Cliente2
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
            btn_Salvar = new Button();
            GridCliente = new DataGridView();
            btn_AlterarCliente = new Button();
            btn_ExcluirCliente = new Button();
            btn_CancelarCliente = new Button();
            btn_NovoCliente = new Button();
            txt_Cliente2 = new TextBox();
            txt_cliente = new Label();
            ((System.ComponentModel.ISupportInitialize)GridCliente).BeginInit();
            SuspendLayout();
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(559, 72);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(94, 29);
            btn_Salvar.TabIndex = 10;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // GridCliente
            // 
            GridCliente.AllowUserToAddRows = false;
            GridCliente.AllowUserToDeleteRows = false;
            GridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCliente.Location = new Point(102, 149);
            GridCliente.Name = "GridCliente";
            GridCliente.ReadOnly = true;
            GridCliente.RowHeadersWidth = 51;
            GridCliente.Size = new Size(572, 254);
            GridCliente.TabIndex = 29;
            // 
            // btn_AlterarCliente
            // 
            btn_AlterarCliente.Location = new Point(192, 72);
            btn_AlterarCliente.Name = "btn_AlterarCliente";
            btn_AlterarCliente.Size = new Size(94, 29);
            btn_AlterarCliente.TabIndex = 28;
            btn_AlterarCliente.Text = "Alterar";
            btn_AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirCliente
            // 
            btn_ExcluirCliente.Location = new Point(304, 72);
            btn_ExcluirCliente.Name = "btn_ExcluirCliente";
            btn_ExcluirCliente.Size = new Size(94, 29);
            btn_ExcluirCliente.TabIndex = 27;
            btn_ExcluirCliente.Text = "Excluir";
            btn_ExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarCliente
            // 
            btn_CancelarCliente.Location = new Point(419, 72);
            btn_CancelarCliente.Name = "btn_CancelarCliente";
            btn_CancelarCliente.Size = new Size(94, 29);
            btn_CancelarCliente.TabIndex = 26;
            btn_CancelarCliente.Text = "Cancelar";
            btn_CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_NovoCliente
            // 
            btn_NovoCliente.Location = new Point(72, 72);
            btn_NovoCliente.Name = "btn_NovoCliente";
            btn_NovoCliente.Size = new Size(94, 29);
            btn_NovoCliente.TabIndex = 25;
            btn_NovoCliente.Text = "Novo";
            btn_NovoCliente.UseVisualStyleBackColor = true;
            // 
            // txt_Cliente2
            // 
            txt_Cliente2.Location = new Point(152, 29);
            txt_Cliente2.Name = "txt_Cliente2";
            txt_Cliente2.Size = new Size(125, 27);
            txt_Cliente2.TabIndex = 24;
            // 
            // txt_cliente
            // 
            txt_cliente.AutoSize = true;
            txt_cliente.Location = new Point(72, 32);
            txt_cliente.Name = "txt_cliente";
            txt_cliente.Size = new Size(53, 20);
            txt_cliente.TabIndex = 23;
            txt_cliente.Text = "cliente";
            // 
            // fmr_Cliente2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridCliente);
            Controls.Add(btn_AlterarCliente);
            Controls.Add(btn_ExcluirCliente);
            Controls.Add(btn_CancelarCliente);
            Controls.Add(btn_NovoCliente);
            Controls.Add(txt_Cliente2);
            Controls.Add(txt_cliente);
            Controls.Add(btn_Salvar);
            Name = "fmr_Cliente2";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)GridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar;
        private DataGridView GridCliente;
        private Button btn_AlterarCliente;
        private Button btn_ExcluirCliente;
        private Button btn_CancelarCliente;
        private Button btn_NovoCliente;
        private TextBox txt_Cliente2;
        private Label txt_cliente;
    }
}
