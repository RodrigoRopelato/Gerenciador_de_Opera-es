using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Muito_Dinheiro
{
    public partial class CadastroOperacao : Form
    {
        List<Operacao> listaOp = new List<Operacao>();

        public CadastroOperacao()
        {

            InitializeComponent();

            textBox_valor.Text = "0.00";
            comboBox_origem.Text = "BRL (Real)";
            comboBox_destino.Text = "USD (US Dólar)";
            lab_moeda1.Text = "";
            lab_moeda2.Text = "";
        }

        private void btn_finalOperação_Click(object sender, EventArgs e)
        {
            Operacao op;
           

            string nome = textBox_nome.Text;
            double valorOriginal = double.Parse(textBox_valor.Text);
            string moedaOrigem = comboBox_origem.Text;
            string moedaDestino = comboBox_destino.Text;
            DateTime dataoperacao = DateTime.Now;


            op = new Operacao(nome, moedaOrigem, moedaDestino, dataoperacao, valorOriginal);

            op.ConverterValor(valorOriginal, moedaOrigem, moedaDestino);

            textBox_dataOperaçao.Text = op.DataOperacao.ToString(dataoperacao.ToShortDateString())+ " - " +op.DataOperacao.ToString(dataoperacao.ToShortTimeString());
            textBox_valorConverido.Text = op.ValorConvertido.ToString("F2");
            textBox_taxa.Text = op.TaxaOperacao.ToString("F2");
            lab_moeda1.Text = op.MoedaDestino;
            lab_moeda2.Text = op.MoedaDestino;

            listaOp.Add(op);

            MessageBox.Show("Registro gravado com sucesso!\n"+op,"Registro");
            
        }
    }
}
