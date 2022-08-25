namespace WinFormsOrdenacao
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
            this.textBox_qtdNumeros = new System.Windows.Forms.TextBox();
            this.button_gerarNumeros = new System.Windows.Forms.Button();
            this.textBox_listarNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantos números desejas gerar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_qtdNumeros
            // 
            this.textBox_qtdNumeros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_qtdNumeros.Location = new System.Drawing.Point(196, 6);
            this.textBox_qtdNumeros.Name = "textBox_qtdNumeros";
            this.textBox_qtdNumeros.Size = new System.Drawing.Size(124, 23);
            this.textBox_qtdNumeros.TabIndex = 1;
            // 
            // button_gerarNumeros
            // 
            this.button_gerarNumeros.Location = new System.Drawing.Point(12, 36);
            this.button_gerarNumeros.Name = "button_gerarNumeros";
            this.button_gerarNumeros.Size = new System.Drawing.Size(75, 23);
            this.button_gerarNumeros.TabIndex = 2;
            this.button_gerarNumeros.Text = "Gerar";
            this.button_gerarNumeros.UseVisualStyleBackColor = true;
            this.button_gerarNumeros.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_listarNumeros
            // 
            this.textBox_listarNumeros.BackColor = System.Drawing.Color.White;
            this.textBox_listarNumeros.Location = new System.Drawing.Point(12, 74);
            this.textBox_listarNumeros.Multiline = true;
            this.textBox_listarNumeros.Name = "textBox_listarNumeros";
            this.textBox_listarNumeros.ReadOnly = true;
            this.textBox_listarNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listarNumeros.Size = new System.Drawing.Size(308, 87);
            this.textBox_listarNumeros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 307);
            this.Controls.Add(this.textBox_listarNumeros);
            this.Controls.Add(this.button_gerarNumeros);
            this.Controls.Add(this.textBox_qtdNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Metodos ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_qtdNumeros;
        private Button button_gerarNumeros;
        private TextBox textBox_listarNumeros;
    }
}