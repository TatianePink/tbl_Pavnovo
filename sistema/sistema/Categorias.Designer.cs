namespace sistema
{
    partial class frm_Categorias
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
            btn_CadastrarC = new Button();
            btn_ExcluirC = new Button();
            btn_CancelarC = new Button();
            btn_NovoC = new Button();
            txt_Cliente2 = new TextBox();
            txt_categoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 254);
            dataGridView1.TabIndex = 22;
            // 
            // btn_CadastrarC
            // 
            btn_CadastrarC.Location = new Point(152, 77);
            btn_CadastrarC.Name = "btn_CadastrarC";
            btn_CadastrarC.Size = new Size(94, 29);
            btn_CadastrarC.TabIndex = 21;
            btn_CadastrarC.Text = "Cadastrar";
            btn_CadastrarC.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirC
            // 
            btn_ExcluirC.Location = new Point(264, 77);
            btn_ExcluirC.Name = "btn_ExcluirC";
            btn_ExcluirC.Size = new Size(94, 29);
            btn_ExcluirC.TabIndex = 20;
            btn_ExcluirC.Text = "Excluir";
            btn_ExcluirC.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarC
            // 
            btn_CancelarC.Location = new Point(379, 77);
            btn_CancelarC.Name = "btn_CancelarC";
            btn_CancelarC.Size = new Size(94, 29);
            btn_CancelarC.TabIndex = 19;
            btn_CancelarC.Text = "Cancelar";
            btn_CancelarC.UseVisualStyleBackColor = true;
            // 
            // btn_NovoC
            // 
            btn_NovoC.Location = new Point(32, 77);
            btn_NovoC.Name = "btn_NovoC";
            btn_NovoC.Size = new Size(94, 29);
            btn_NovoC.TabIndex = 18;
            btn_NovoC.Text = "Novo";
            btn_NovoC.UseVisualStyleBackColor = true;
            // 
            // txt_Cliente2
            // 
            txt_Cliente2.Location = new Point(112, 34);
            txt_Cliente2.Name = "txt_Cliente2";
            txt_Cliente2.Size = new Size(125, 27);
            txt_Cliente2.TabIndex = 13;
            // 
            // txt_categoria
            // 
            txt_categoria.AutoSize = true;
            txt_categoria.Location = new Point(32, 37);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(74, 20);
            txt_categoria.TabIndex = 12;
            txt_categoria.Text = "Categoria";
            // 
            // frm_Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_CadastrarC);
            Controls.Add(btn_ExcluirC);
            Controls.Add(btn_CancelarC);
            Controls.Add(btn_NovoC);
            Controls.Add(txt_Cliente2);
            Controls.Add(txt_categoria);
            Name = "frm_Categorias";
            Text = " ";
            Load += frm_Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_CadastrarC;
        private Button btn_ExcluirC;
        private Button btn_CancelarC;
        private Button btn_NovoC;
        private TextBox txt_Cliente2;
        private Label txt_categoria;
    }
}