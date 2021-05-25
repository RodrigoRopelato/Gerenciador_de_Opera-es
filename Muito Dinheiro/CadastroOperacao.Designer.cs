
namespace Muito_Dinheiro
{
    partial class CadastroOperacao
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
            this.label_cadastroOperação = new System.Windows.Forms.Label();
            this.label_nomeCliente = new System.Windows.Forms.Label();
            this.label_moedaOrigem = new System.Windows.Forms.Label();
            this.label_moedaDestino = new System.Windows.Forms.Label();
            this.label_valor = new System.Windows.Forms.Label();
            this.label_resultadoConversão = new System.Windows.Forms.Label();
            this.label_taxa = new System.Windows.Forms.Label();
            this.label_valorConvertido = new System.Windows.Forms.Label();
            this.label_dataOperação = new System.Windows.Forms.Label();
            this.comboBox_origem = new System.Windows.Forms.ComboBox();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.btn_finalOperação = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.textBox_taxa = new System.Windows.Forms.TextBox();
            this.textBox_valorConverido = new System.Windows.Forms.TextBox();
            this.textBox_dataOperaçao = new System.Windows.Forms.TextBox();
            this.lab_moeda1 = new System.Windows.Forms.Label();
            this.lab_moeda2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_cadastroOperação
            // 
            this.label_cadastroOperação.AutoSize = true;
            this.label_cadastroOperação.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cadastroOperação.Location = new System.Drawing.Point(129, 9);
            this.label_cadastroOperação.Name = "label_cadastroOperação";
            this.label_cadastroOperação.Size = new System.Drawing.Size(250, 37);
            this.label_cadastroOperação.TabIndex = 0;
            this.label_cadastroOperação.Text = "Cadastro Operação";
            // 
            // label_nomeCliente
            // 
            this.label_nomeCliente.AutoSize = true;
            this.label_nomeCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nomeCliente.Location = new System.Drawing.Point(28, 84);
            this.label_nomeCliente.Name = "label_nomeCliente";
            this.label_nomeCliente.Size = new System.Drawing.Size(132, 25);
            this.label_nomeCliente.TabIndex = 0;
            this.label_nomeCliente.Text = "Nome Cliente ";
            // 
            // label_moedaOrigem
            // 
            this.label_moedaOrigem.AutoSize = true;
            this.label_moedaOrigem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_moedaOrigem.Location = new System.Drawing.Point(29, 173);
            this.label_moedaOrigem.Name = "label_moedaOrigem";
            this.label_moedaOrigem.Size = new System.Drawing.Size(139, 25);
            this.label_moedaOrigem.TabIndex = 0;
            this.label_moedaOrigem.Text = "Moeda Origem";
            // 
            // label_moedaDestino
            // 
            this.label_moedaDestino.AutoSize = true;
            this.label_moedaDestino.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_moedaDestino.Location = new System.Drawing.Point(290, 173);
            this.label_moedaDestino.Name = "label_moedaDestino";
            this.label_moedaDestino.Size = new System.Drawing.Size(140, 25);
            this.label_moedaDestino.TabIndex = 0;
            this.label_moedaDestino.Text = "Moeda Destino";
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_valor.Location = new System.Drawing.Point(28, 128);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(61, 25);
            this.label_valor.TabIndex = 0;
            this.label_valor.Text = "Valor ";
            // 
            // label_resultadoConversão
            // 
            this.label_resultadoConversão.AutoSize = true;
            this.label_resultadoConversão.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_resultadoConversão.Location = new System.Drawing.Point(129, 256);
            this.label_resultadoConversão.Name = "label_resultadoConversão";
            this.label_resultadoConversão.Size = new System.Drawing.Size(214, 25);
            this.label_resultadoConversão.TabIndex = 0;
            this.label_resultadoConversão.Text = "Resultado da Conversão";
            // 
            // label_taxa
            // 
            this.label_taxa.AutoSize = true;
            this.label_taxa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_taxa.Location = new System.Drawing.Point(28, 294);
            this.label_taxa.Name = "label_taxa";
            this.label_taxa.Size = new System.Drawing.Size(90, 25);
            this.label_taxa.TabIndex = 0;
            this.label_taxa.Text = "Taxa 10%";
            // 
            // label_valorConvertido
            // 
            this.label_valorConvertido.AutoSize = true;
            this.label_valorConvertido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_valorConvertido.Location = new System.Drawing.Point(28, 330);
            this.label_valorConvertido.Name = "label_valorConvertido";
            this.label_valorConvertido.Size = new System.Drawing.Size(154, 25);
            this.label_valorConvertido.TabIndex = 0;
            this.label_valorConvertido.Text = "Valor Convertido";
            // 
            // label_dataOperação
            // 
            this.label_dataOperação.AutoSize = true;
            this.label_dataOperação.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dataOperação.Location = new System.Drawing.Point(28, 367);
            this.label_dataOperação.Name = "label_dataOperação";
            this.label_dataOperação.Size = new System.Drawing.Size(164, 25);
            this.label_dataOperação.TabIndex = 0;
            this.label_dataOperação.Text = "Data da Operação";
            // 
            // comboBox_origem
            // 
            this.comboBox_origem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_origem.FormattingEnabled = true;
            this.comboBox_origem.Items.AddRange(new object[] {
            "BRL (Real)",
            "USD (US Dólar)",
            "GBP (Libra Esterlina)",
            "EUR (Euro)"});
            this.comboBox_origem.Location = new System.Drawing.Point(28, 201);
            this.comboBox_origem.Name = "comboBox_origem";
            this.comboBox_origem.Size = new System.Drawing.Size(163, 28);
            this.comboBox_origem.TabIndex = 3;
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "BRL (Real)",
            "USD (US Dólar)",
            "GBP (Libra Esterlina)",
            "EUR (Euro)"});
            this.comboBox_destino.Location = new System.Drawing.Point(290, 201);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(163, 28);
            this.comboBox_destino.TabIndex = 4;
            // 
            // btn_finalOperação
            // 
            this.btn_finalOperação.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_finalOperação.Location = new System.Drawing.Point(29, 424);
            this.btn_finalOperação.Name = "btn_finalOperação";
            this.btn_finalOperação.Size = new System.Drawing.Size(424, 43);
            this.btn_finalOperação.TabIndex = 5;
            this.btn_finalOperação.Text = "Finalizar Operação";
            this.btn_finalOperação.UseVisualStyleBackColor = true;
            this.btn_finalOperação.Click += new System.EventHandler(this.btn_finalOperação_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_nome.Location = new System.Drawing.Point(166, 82);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(287, 27);
            this.textBox_nome.TabIndex = 1;
            // 
            // textBox_valor
            // 
            this.textBox_valor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_valor.Location = new System.Drawing.Point(95, 126);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(97, 27);
            this.textBox_valor.TabIndex = 2;
            // 
            // textBox_taxa
            // 
            this.textBox_taxa.Enabled = false;
            this.textBox_taxa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_taxa.Location = new System.Drawing.Point(194, 292);
            this.textBox_taxa.Name = "textBox_taxa";
            this.textBox_taxa.Size = new System.Drawing.Size(167, 27);
            this.textBox_taxa.TabIndex = 0;
            // 
            // textBox_valorConverido
            // 
            this.textBox_valorConverido.Enabled = false;
            this.textBox_valorConverido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_valorConverido.Location = new System.Drawing.Point(194, 328);
            this.textBox_valorConverido.Name = "textBox_valorConverido";
            this.textBox_valorConverido.Size = new System.Drawing.Size(167, 27);
            this.textBox_valorConverido.TabIndex = 0;
            // 
            // textBox_dataOperaçao
            // 
            this.textBox_dataOperaçao.Enabled = false;
            this.textBox_dataOperaçao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_dataOperaçao.Location = new System.Drawing.Point(194, 365);
            this.textBox_dataOperaçao.Name = "textBox_dataOperaçao";
            this.textBox_dataOperaçao.Size = new System.Drawing.Size(167, 27);
            this.textBox_dataOperaçao.TabIndex = 0;
            // 
            // lab_moeda1
            // 
            this.lab_moeda1.AutoSize = true;
            this.lab_moeda1.BackColor = System.Drawing.SystemColors.Control;
            this.lab_moeda1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_moeda1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lab_moeda1.Location = new System.Drawing.Point(367, 294);
            this.lab_moeda1.Name = "lab_moeda1";
            this.lab_moeda1.Size = new System.Drawing.Size(81, 19);
            this.lab_moeda1.TabIndex = 0;
            this.lab_moeda1.Text = "USD (Dólar)";
            // 
            // lab_moeda2
            // 
            this.lab_moeda2.AutoSize = true;
            this.lab_moeda2.BackColor = System.Drawing.SystemColors.Control;
            this.lab_moeda2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_moeda2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lab_moeda2.Location = new System.Drawing.Point(367, 333);
            this.lab_moeda2.Name = "lab_moeda2";
            this.lab_moeda2.Size = new System.Drawing.Size(81, 19);
            this.lab_moeda2.TabIndex = 0;
            this.lab_moeda2.Text = "USD (Dólar)";
            // 
            // CadastroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 479);
            this.Controls.Add(this.lab_moeda2);
            this.Controls.Add(this.lab_moeda1);
            this.Controls.Add(this.textBox_dataOperaçao);
            this.Controls.Add(this.textBox_valorConverido);
            this.Controls.Add(this.textBox_taxa);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.btn_finalOperação);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.comboBox_origem);
            this.Controls.Add(this.label_dataOperação);
            this.Controls.Add(this.label_valorConvertido);
            this.Controls.Add(this.label_taxa);
            this.Controls.Add(this.label_resultadoConversão);
            this.Controls.Add(this.label_valor);
            this.Controls.Add(this.label_moedaDestino);
            this.Controls.Add(this.label_moedaOrigem);
            this.Controls.Add(this.label_nomeCliente);
            this.Controls.Add(this.label_cadastroOperação);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroOperacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Operações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cadastroOperação;
        private System.Windows.Forms.Label label_nomeCliente;
        private System.Windows.Forms.Label label_moedaOrigem;
        private System.Windows.Forms.Label label_moedaDestino;
        private System.Windows.Forms.Label label_valor;
        private System.Windows.Forms.Label label_resultadoConversão;
        private System.Windows.Forms.Label label_taxa;
        private System.Windows.Forms.Label label_valorConvertido;
        private System.Windows.Forms.Label label_dataOperação;
        private System.Windows.Forms.ComboBox comboBox_origem;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.Button btn_finalOperação;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.TextBox textBox_taxa;
        private System.Windows.Forms.TextBox textBox_valorConverido;
        private System.Windows.Forms.TextBox textBox_dataOperaçao;
        private System.Windows.Forms.Label lab_moeda1;
        private System.Windows.Forms.Label lab_moeda2;
    }
}