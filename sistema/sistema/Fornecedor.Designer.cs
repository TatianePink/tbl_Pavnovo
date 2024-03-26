namespace sistema
{
    partial class frm_Fornecedor
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
            GridFornecedor = new DataGridView();
            btn_AlterarF = new Button();
            btn_ExcluirF = new Button();
            btn_CancelarF = new Button();
            btn_NovoF = new Button();
            txt_Fornecedor = new TextBox();
            txt_Fornecedor2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridFornecedor).BeginInit();
            SuspendLayout();
            // 
            // GridFornecedor
            // 
            GridFornecedor.AllowUserToAddRows = false;
            GridFornecedor.AllowUserToDeleteRows = false;
            GridFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFornecedor.Location = new Point(12, 158);
            GridFornecedor.Name = "GridFornecedor";
            GridFornecedor.ReadOnly = true;
            GridFornecedor.RowHeadersWidth = 51;
            GridFornecedor.Size = new Size(572, 254);
            GridFornecedor.TabIndex = 42;
            // 
            // btn_AlterarF
            // 
            btn_AlterarF.Location = new Point(142, 71);
            btn_AlterarF.Name = "btn_AlterarF";
            btn_AlterarF.Size = new Size(94, 29);
            btn_AlterarF.TabIndex = 41;
            btn_AlterarF.Text = "Alterar";
            btn_AlterarF.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirF
            // 
            btn_ExcluirF.Location = new Point(254, 71);
            btn_ExcluirF.Name = "btn_ExcluirF";
            btn_ExcluirF.Size = new Size(94, 29);
            btn_ExcluirF.TabIndex = 40;
            btn_ExcluirF.Text = "Excluir";
            btn_ExcluirF.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarF
            // 
            btn_CancelarF.Location = new Point(369, 71);
            btn_CancelarF.Name = "btn_CancelarF";
            btn_CancelarF.Size = new Size(94, 29);
            btn_CancelarF.TabIndex = 39;
            btn_CancelarF.Text = "Cancelar";
            btn_CancelarF.UseVisualStyleBackColor = true;
            // 
            // btn_NovoF
            // 
            btn_NovoF.Location = new Point(22, 71);
            btn_NovoF.Name = "btn_NovoF";
            btn_NovoF.Size = new Size(94, 29);
            btn_NovoF.TabIndex = 38;
            btn_NovoF.Text = "Novo";
            btn_NovoF.UseVisualStyleBackColor = true;
            // 
            // txt_Fornecedor
            // 
            txt_Fornecedor.Location = new Point(102, 28);
            txt_Fornecedor.Name = "txt_Fornecedor";
            txt_Fornecedor.Size = new Size(125, 27);
            txt_Fornecedor.TabIndex = 37;
            // 
            // txt_Fornecedor2
            // 
            txt_Fornecedor2.AutoSize = true;
            txt_Fornecedor2.Location = new Point(22, 31);
            txt_Fornecedor2.Name = "txt_Fornecedor2";
            txt_Fornecedor2.Size = new Size(84, 20);
            txt_Fornecedor2.TabIndex = 36;
            txt_Fornecedor2.Text = "Fornecedor";
            txt_Fornecedor2.Click += txt_categoria_Click;
            // 
            // frm_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridFornecedor);
            Controls.Add(btn_AlterarF);
            Controls.Add(btn_ExcluirF);
            Controls.Add(btn_CancelarF);
            Controls.Add(btn_NovoF);
            Controls.Add(txt_Fornecedor);
            Controls.Add(txt_Fornecedor2);
            Name = "frm_Fornecedor";
            Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)GridFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridFornecedor;
        private Button btn_AlterarF;
        private Button btn_ExcluirF;
        private Button btn_CancelarF;
        private Button btn_NovoF;
        private TextBox txt_Fornecedor;
        private Label txt_Fornecedor2;
    }
}