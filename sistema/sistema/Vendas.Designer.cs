namespace sistema
{
    partial class frmVendas
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
            GridVendas = new DataGridView();
            btn_AlterarVen = new Button();
            btn_ExcluirVen = new Button();
            btn_Comfirmar = new Button();
            btn_Adicionar = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            LCliente = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridVendas).BeginInit();
            SuspendLayout();
            // 
            // GridVendas
            // 
            GridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVendas.Location = new Point(313, 122);
            GridVendas.Name = "GridVendas";
            GridVendas.RowHeadersWidth = 51;
            GridVendas.Size = new Size(440, 275);
            GridVendas.TabIndex = 2;
            // 
            // btn_AlterarVen
            // 
            btn_AlterarVen.Location = new Point(432, 52);
            btn_AlterarVen.Name = "btn_AlterarVen";
            btn_AlterarVen.Size = new Size(94, 29);
            btn_AlterarVen.TabIndex = 32;
            btn_AlterarVen.Text = "Alterartrar";
            btn_AlterarVen.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirVen
            // 
            btn_ExcluirVen.Location = new Point(548, 52);
            btn_ExcluirVen.Name = "btn_ExcluirVen";
            btn_ExcluirVen.Size = new Size(94, 29);
            btn_ExcluirVen.TabIndex = 31;
            btn_ExcluirVen.Text = "Excluir";
            btn_ExcluirVen.UseVisualStyleBackColor = true;
            // 
            // btn_Comfirmar
            // 
            btn_Comfirmar.Location = new Point(659, 52);
            btn_Comfirmar.Name = "btn_Comfirmar";
            btn_Comfirmar.Size = new Size(94, 29);
            btn_Comfirmar.TabIndex = 30;
            btn_Comfirmar.Text = "comfirmar";
            btn_Comfirmar.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Location = new Point(313, 52);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(94, 29);
            btn_Adicionar.TabIndex = 29;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(96, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 27);
            textBox1.TabIndex = 34;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(12, 43);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(55, 20);
            LCliente.TabIndex = 35;
            LCliente.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 36;
            label1.Text = "Quantidade";
            // 
            // frmVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LCliente);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btn_AlterarVen);
            Controls.Add(btn_ExcluirVen);
            Controls.Add(btn_Comfirmar);
            Controls.Add(btn_Adicionar);
            Controls.Add(GridVendas);
            Name = "frmVendas";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)GridVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView GridVendas;
        private Button btn_AlterarVen;
        private Button btn_ExcluirVen;
        private Button btn_Comfirmar;
        private Button btn_Adicionar;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label LCliente;
        private Label label1;
    }
}