namespace Metodos_ordenacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_limpa_metodo = new System.Windows.Forms.Button();
            this.comboBox_metodos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_metodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_direita = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_testar = new System.Windows.Forms.Button();
            this.textBox_qtd_valores = new System.Windows.Forms.TextBox();
            this.button_limpa_qtd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_comportamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_direita.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_limpa_metodo);
            this.panel1.Controls.Add(this.comboBox_metodos);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 40);
            this.panel1.TabIndex = 0;
            // 
            // button_limpa_metodo
            // 
            this.button_limpa_metodo.Location = new System.Drawing.Point(239, 4);
            this.button_limpa_metodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_limpa_metodo.Name = "button_limpa_metodo";
            this.button_limpa_metodo.Size = new System.Drawing.Size(86, 32);
            this.button_limpa_metodo.TabIndex = 1;
            this.button_limpa_metodo.Text = "Limpa";
            this.button_limpa_metodo.UseVisualStyleBackColor = true;
            this.button_limpa_metodo.Click += new System.EventHandler(this.button_limpa_metodo_Click);
            // 
            // comboBox_metodos
            // 
            this.comboBox_metodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_metodos.FormattingEnabled = true;
            this.comboBox_metodos.Items.AddRange(new object[] {
            "--Escolha um método--",
            "Agitação",
            "Bolha",
            "Heap",
            "Inserção",
            "Merge",
            "Pente",
            "Quick",
            "Seleção",
            "Shell"});
            this.comboBox_metodos.Location = new System.Drawing.Point(3, 4);
            this.comboBox_metodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_metodos.Name = "comboBox_metodos";
            this.comboBox_metodos.Size = new System.Drawing.Size(228, 28);
            this.comboBox_metodos.Sorted = true;
            this.comboBox_metodos.TabIndex = 0;
            this.comboBox_metodos.SelectedIndexChanged += new System.EventHandler(this.comboBox_metodos_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_metodo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 476);
            this.panel2.TabIndex = 1;
            // 
            // textBox_metodo
            // 
            this.textBox_metodo.Location = new System.Drawing.Point(3, 33);
            this.textBox_metodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_metodo.Multiline = true;
            this.textBox_metodo.Name = "textBox_metodo";
            this.textBox_metodo.ReadOnly = true;
            this.textBox_metodo.Size = new System.Drawing.Size(321, 437);
            this.textBox_metodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 539);
            this.panel3.TabIndex = 1;
            // 
            // panel_direita
            // 
            this.panel_direita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_direita.Controls.Add(this.panel5);
            this.panel_direita.Controls.Add(this.panel6);
            this.panel_direita.Enabled = false;
            this.panel_direita.Location = new System.Drawing.Point(357, 16);
            this.panel_direita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_direita.Name = "panel_direita";
            this.panel_direita.Size = new System.Drawing.Size(336, 539);
            this.panel_direita.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_testar);
            this.panel5.Controls.Add(this.textBox_qtd_valores);
            this.panel5.Controls.Add(this.button_limpa_qtd);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 40);
            this.panel5.TabIndex = 0;
            // 
            // button_testar
            // 
            this.button_testar.Enabled = false;
            this.button_testar.Location = new System.Drawing.Point(152, 4);
            this.button_testar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_testar.Name = "button_testar";
            this.button_testar.Size = new System.Drawing.Size(86, 32);
            this.button_testar.TabIndex = 3;
            this.button_testar.Text = "Testar";
            this.button_testar.UseVisualStyleBackColor = true;
            this.button_testar.Click += new System.EventHandler(this.button_testar_Click);
            // 
            // textBox_qtd_valores
            // 
            this.textBox_qtd_valores.Location = new System.Drawing.Point(3, 4);
            this.textBox_qtd_valores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_qtd_valores.Name = "textBox_qtd_valores";
            this.textBox_qtd_valores.PlaceholderText = "Quantidade de valores";
            this.textBox_qtd_valores.Size = new System.Drawing.Size(141, 27);
            this.textBox_qtd_valores.TabIndex = 2;
            this.textBox_qtd_valores.TextChanged += new System.EventHandler(this.textBox_qtd_valores_TextChanged);
            // 
            // button_limpa_qtd
            // 
            this.button_limpa_qtd.Location = new System.Drawing.Point(239, 4);
            this.button_limpa_qtd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_limpa_qtd.Name = "button_limpa_qtd";
            this.button_limpa_qtd.Size = new System.Drawing.Size(86, 32);
            this.button_limpa_qtd.TabIndex = 1;
            this.button_limpa_qtd.Text = "Limpa";
            this.button_limpa_qtd.UseVisualStyleBackColor = true;
            this.button_limpa_qtd.Click += new System.EventHandler(this.button_limpa_qtd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_comportamento);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 52);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 476);
            this.panel6.TabIndex = 1;
            // 
            // textBox_comportamento
            // 
            this.textBox_comportamento.Location = new System.Drawing.Point(3, 33);
            this.textBox_comportamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_comportamento.Multiline = true;
            this.textBox_comportamento.Name = "textBox_comportamento";
            this.textBox_comportamento.ReadOnly = true;
            this.textBox_comportamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_comportamento.Size = new System.Drawing.Size(321, 437);
            this.textBox_comportamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comportamento: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 572);
            this.Controls.Add(this.panel_direita);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de ordenação";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_direita.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox_metodos;
        private Button button_limpa_metodo;
        private Panel panel2;
        private Panel panel3;
        private Panel panel_direita;
        private Panel panel5;
        private TextBox textBox_qtd_valores;
        private Button button_limpa_qtd;
        private Panel panel6;
        private Label label1;
        private Button button_testar;
        private TextBox textBox_metodo;
        private TextBox textBox_comportamento;
        private Label label2;
    }
}