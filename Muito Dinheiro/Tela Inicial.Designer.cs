
namespace Muito_Dinheiro
{
    partial class TelaInicial
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
            this.Label_GerenciadoOperações = new System.Windows.Forms.Label();
            this.btn_NovaOperação = new System.Windows.Forms.Button();
            this.btn_Relatório = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_GerenciadoOperações
            // 
            this.Label_GerenciadoOperações.AutoSize = true;
            this.Label_GerenciadoOperações.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_GerenciadoOperações.Location = new System.Drawing.Point(52, 43);
            this.Label_GerenciadoOperações.Name = "Label_GerenciadoOperações";
            this.Label_GerenciadoOperações.Size = new System.Drawing.Size(342, 37);
            this.Label_GerenciadoOperações.TabIndex = 0;
            this.Label_GerenciadoOperações.Text = "Gerenciador De Operações";
            // 
            // btn_NovaOperação
            // 
            this.btn_NovaOperação.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NovaOperação.Location = new System.Drawing.Point(102, 132);
            this.btn_NovaOperação.Name = "btn_NovaOperação";
            this.btn_NovaOperação.Size = new System.Drawing.Size(225, 55);
            this.btn_NovaOperação.TabIndex = 1;
            this.btn_NovaOperação.Text = "Nova Operação";
            this.btn_NovaOperação.UseVisualStyleBackColor = true;
            this.btn_NovaOperação.Click += new System.EventHandler(this.btn_NovaOperação_Click);
            // 
            // btn_Relatório
            // 
            this.btn_Relatório.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Relatório.Location = new System.Drawing.Point(102, 232);
            this.btn_Relatório.Name = "btn_Relatório";
            this.btn_Relatório.Size = new System.Drawing.Size(225, 55);
            this.btn_Relatório.TabIndex = 3;
            this.btn_Relatório.Text = "Relatório";
            this.btn_Relatório.UseVisualStyleBackColor = true;
            this.btn_Relatório.Click += new System.EventHandler(this.btn_Relatório_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 372);
            this.Controls.Add(this.btn_Relatório);
            this.Controls.Add(this.btn_NovaOperação);
            this.Controls.Add(this.Label_GerenciadoOperações);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa de Câmbio Muito Dinheiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_GerenciadoOperações;
        private System.Windows.Forms.Button btn_NovaOperação;
        private System.Windows.Forms.Button btn_Relatório;
    }
}

