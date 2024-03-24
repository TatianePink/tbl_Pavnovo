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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.buAlterar = new System.Windows.Forms.Button();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buFechar = new System.Windows.Forms.Button();
            this.buConsultar = new System.Windows.Forms.Button();
            this.buIniciar = new System.Windows.Forms.Button();
            this.dgvPessoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(63, 293);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(94, 29);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
          //  this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // buAlterar
            // 
            this.buAlterar.Location = new System.Drawing.Point(654, 124);
            this.buAlterar.Name = "buAlterar";
            this.buAlterar.Size = new System.Drawing.Size(94, 29);
            this.buAlterar.TabIndex = 19;
            this.buAlterar.Text = "Alterar";
            this.buAlterar.UseVisualStyleBackColor = true;
           // this.buAlterar.Click += new System.EventHandler(this.buAlterar_Click);
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(654, 244);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(94, 29);
            this.buExcluir.TabIndex = 18;
            this.buExcluir.Text = "Excluir";
            this.buExcluir.UseVisualStyleBackColor = true;
          //  this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(635, 342);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(144, 51);
            this.buFechar.TabIndex = 17;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
           // this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // buConsultar
            // 
            this.buConsultar.Location = new System.Drawing.Point(654, 186);
            this.buConsultar.Name = "buConsultar";
            this.buConsultar.Size = new System.Drawing.Size(94, 29);
            this.buConsultar.TabIndex = 16;
            this.buConsultar.Text = "Consultar";
            this.buConsultar.UseVisualStyleBackColor = true;
           // this.buConsultar.Click += new System.EventHandler(this.buConsultar_Click);
            // 
            // buIniciar
            // 
            this.buIniciar.Location = new System.Drawing.Point(654, 70);
            this.buIniciar.Name = "buIniciar";
            this.buIniciar.Size = new System.Drawing.Size(94, 29);
            this.buIniciar.TabIndex = 15;
            this.buIniciar.Text = "Incluir";
            this.buIniciar.UseVisualStyleBackColor = true;
          //  this.buIniciar.Click += new System.EventHandler(this.buIniciar_Click);
            // 
            // dgvPessoa
            // 
            this.dgvPessoa.AllowUserToOrderColumns = true;
            this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoa.Location = new System.Drawing.Point(324, 85);
            this.dgvPessoa.MultiSelect = false;
            this.dgvPessoa.Name = "dgvPessoa";
            this.dgvPessoa.ReadOnly = true;
            this.dgvPessoa.RowHeadersWidth = 51;
            this.dgvPessoa.Size = new System.Drawing.Size(300, 188);
            this.dgvPessoa.TabIndex = 20;
            // 
            // fmr_Cliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPessoa);
            this.Controls.Add(this.buAlterar);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buConsultar);
            this.Controls.Add(this.buIniciar);
            this.Controls.Add(this.btn_Salvar);
            this.Name = "fmr_Cliente2";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button buAlterar;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buFechar;
        private System.Windows.Forms.Button buConsultar;
        private System.Windows.Forms.Button buIniciar;
        private System.Windows.Forms.DataGridView dgvPessoa;
    }
}
