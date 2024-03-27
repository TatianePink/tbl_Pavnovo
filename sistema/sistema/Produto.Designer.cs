namespace sistema
{
    partial class fmr_Produto
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
            dataGridView1 = new DataGridView();
            btn_AlterarP = new Button();
            btn_ExcluirP = new Button();
            btn_CancelarP = new Button();
            btn_NovoP = new Button();
            txt_Descricao = new TextBox();
            txt_Descriçao = new Label();
            txt_Valor = new Label();
            txt_ValorP = new TextBox();
            txt_Categoria = new TextBox();
            txt_CategoriaP = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 254);
            dataGridView1.TabIndex = 29;
            // 
            // btn_AlterarP
            // 
            btn_AlterarP.Location = new Point(201, 77);
            btn_AlterarP.Name = "btn_AlterarP";
            btn_AlterarP.Size = new Size(94, 29);
            btn_AlterarP.TabIndex = 28;
            btn_AlterarP.Text = "Alterartrar";
            btn_AlterarP.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirP
            // 
            btn_ExcluirP.Location = new Point(312, 77);
            btn_ExcluirP.Name = "btn_ExcluirP";
            btn_ExcluirP.Size = new Size(94, 29);
            btn_ExcluirP.TabIndex = 27;
            btn_ExcluirP.Text = "Excluir";
            btn_ExcluirP.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarP
            // 
            btn_CancelarP.Location = new Point(448, 77);
            btn_CancelarP.Name = "btn_CancelarP";
            btn_CancelarP.Size = new Size(94, 29);
            btn_CancelarP.TabIndex = 26;
            btn_CancelarP.Text = "Cancelar";
            btn_CancelarP.UseVisualStyleBackColor = true;
            // 
            // btn_NovoP
            // 
            btn_NovoP.Location = new Point(80, 77);
            btn_NovoP.Name = "btn_NovoP";
            btn_NovoP.Size = new Size(94, 29);
            btn_NovoP.TabIndex = 25;
            btn_NovoP.Text = "Novo";
            btn_NovoP.UseVisualStyleBackColor = true;
            // 
            // txt_Descricao
            // 
            txt_Descricao.Location = new Point(149, 34);
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.Size = new Size(125, 27);
            txt_Descricao.TabIndex = 24;
            // 
            // txt_Descriçao
            // 
            txt_Descriçao.AutoSize = true;
            txt_Descriçao.Location = new Point(80, 37);
            txt_Descriçao.Name = "txt_Descriçao";
            txt_Descriçao.Size = new Size(74, 20);
            txt_Descriçao.TabIndex = 23;
            txt_Descriçao.Text = "Descriçao";
            // 
            // txt_Valor
            // 
            txt_Valor.AutoSize = true;
            txt_Valor.Location = new Point(294, 37);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(43, 20);
            txt_Valor.TabIndex = 30;
            txt_Valor.Text = "Valor";
            // 
            // txt_ValorP
            // 
            txt_ValorP.Location = new Point(343, 37);
            txt_ValorP.Name = "txt_ValorP";
            txt_ValorP.Size = new Size(125, 27);
            txt_ValorP.TabIndex = 31;
            // 
            // txt_Categoria
            // 
            txt_Categoria.Location = new Point(555, 37);
            txt_Categoria.Name = "txt_Categoria";
            txt_Categoria.Size = new Size(125, 27);
            txt_Categoria.TabIndex = 32;
            // 
            // txt_CategoriaP
            // 
            txt_CategoriaP.AutoSize = true;
            txt_CategoriaP.Location = new Point(474, 37);
            txt_CategoriaP.Name = "txt_CategoriaP";
            txt_CategoriaP.Size = new Size(74, 20);
            txt_CategoriaP.TabIndex = 33;
            txt_CategoriaP.Text = "Categoria";
            // 
            // fmr_Produto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_CategoriaP);
            Controls.Add(txt_Categoria);
            Controls.Add(txt_ValorP);
            Controls.Add(txt_Valor);
            Controls.Add(dataGridView1);
            Controls.Add(btn_AlterarP);
            Controls.Add(btn_ExcluirP);
            Controls.Add(btn_CancelarP);
            Controls.Add(btn_NovoP);
            Controls.Add(txt_Descricao);
            Controls.Add(txt_Descriçao);
            Name = "fmr_Produto";
            Text = "Produto";
            Load += Produto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_AlterarP;
        private Button btn_ExcluirP;
        private Button btn_CancelarP;
        private Button btn_NovoP;
        private TextBox txt_Descricao;
        private Label txt_Descriçao;
        private Label txt_Valor;
        private TextBox txt_ValorP;
        private TextBox txt_Categoria;
        private Label txt_CategoriaP;
    }
}