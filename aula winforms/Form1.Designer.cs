namespace aula_winforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_qtdDados = new System.Windows.Forms.TextBox();
            this.button_gerar = new System.Windows.Forms.Button();
            this.button_abrirArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_dados = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_aplicar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox_algoritmo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_direita = new System.Windows.Forms.Panel();
            this.textBox_console = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_direita.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de dados:";
            // 
            // textBox_qtdDados
            // 
            this.textBox_qtdDados.Location = new System.Drawing.Point(132, 5);
            this.textBox_qtdDados.Name = "textBox_qtdDados";
            this.textBox_qtdDados.Size = new System.Drawing.Size(132, 23);
            this.textBox_qtdDados.TabIndex = 1;
            // 
            // button_gerar
            // 
            this.button_gerar.Location = new System.Drawing.Point(3, 3);
            this.button_gerar.Name = "button_gerar";
            this.button_gerar.Size = new System.Drawing.Size(123, 23);
            this.button_gerar.TabIndex = 2;
            this.button_gerar.Text = "Gerar";
            this.button_gerar.UseVisualStyleBackColor = true;
            this.button_gerar.Click += new System.EventHandler(this.button_gerar_Click);
            // 
            // button_abrirArquivo
            // 
            this.button_abrirArquivo.Location = new System.Drawing.Point(132, 3);
            this.button_abrirArquivo.Name = "button_abrirArquivo";
            this.button_abrirArquivo.Size = new System.Drawing.Size(132, 23);
            this.button_abrirArquivo.TabIndex = 2;
            this.button_abrirArquivo.Text = "Abrir arquivo";
            this.button_abrirArquivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 75);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_gerar);
            this.panel3.Controls.Add(this.button_abrirArquivo);
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 30);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_qtdDados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 32);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dados:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_dados);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 345);
            this.panel4.TabIndex = 5;
            // 
            // textBox_dados
            // 
            this.textBox_dados.Location = new System.Drawing.Point(6, 28);
            this.textBox_dados.Multiline = true;
            this.textBox_dados.Name = "textBox_dados";
            this.textBox_dados.ReadOnly = true;
            this.textBox_dados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_dados.Size = new System.Drawing.Size(261, 305);
            this.textBox_dados.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 75);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_aplicar);
            this.panel6.Location = new System.Drawing.Point(3, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 30);
            this.panel6.TabIndex = 4;
            // 
            // button_aplicar
            // 
            this.button_aplicar.Location = new System.Drawing.Point(3, 3);
            this.button_aplicar.Name = "button_aplicar";
            this.button_aplicar.Size = new System.Drawing.Size(317, 23);
            this.button_aplicar.TabIndex = 2;
            this.button_aplicar.Text = "Aplicar";
            this.button_aplicar.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox_algoritmo);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 32);
            this.panel7.TabIndex = 3;
            // 
            // textBox_algoritmo
            // 
            this.textBox_algoritmo.Location = new System.Drawing.Point(148, 5);
            this.textBox_algoritmo.Name = "textBox_algoritmo";
            this.textBox_algoritmo.Size = new System.Drawing.Size(172, 23);
            this.textBox_algoritmo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Algoritmo de ordenação:";
            // 
            // panel_direita
            // 
            this.panel_direita.Controls.Add(this.textBox_console);
            this.panel_direita.Controls.Add(this.label4);
            this.panel_direita.Controls.Add(this.panel5);
            this.panel_direita.Enabled = false;
            this.panel_direita.Location = new System.Drawing.Point(291, 12);
            this.panel_direita.Name = "panel_direita";
            this.panel_direita.Size = new System.Drawing.Size(332, 426);
            this.panel_direita.TabIndex = 6;
            // 
            // textBox_console
            // 
            this.textBox_console.Location = new System.Drawing.Point(6, 109);
            this.textBox_console.Multiline = true;
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.ReadOnly = true;
            this.textBox_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_console.Size = new System.Drawing.Size(317, 305);
            this.textBox_console.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Console:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.panel_direita);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenação 2ª chave";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_direita.ResumeLayout(false);
            this.panel_direita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox_qtdDados;
        private Button button_gerar;
        private Button button_abrirArquivo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private TextBox textBox_dados;
        private Panel panel5;
        private Panel panel6;
        private Button button_aplicar;
        private Panel panel7;
        private TextBox textBox_algoritmo;
        private Label label3;
        private Panel panel_direita;
        private Label label4;
        private TextBox textBox_console;
    }
}