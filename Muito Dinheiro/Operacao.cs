using System;
using System.Collections.Generic;
using System.Text;

namespace Muito_Dinheiro
{
    class Operacao
    {


        public string Nome { get; set; }
        public double ValorOriginal { get; set; }
        public string MoedaOrigem { get; set; }
        public string MoedaDestino { get; set; }
        public DateTime DataOperacao { get; set; }
        public double ValorConvertido { get; set; }
        public double TaxaOperacao { get; set; }



        public Operacao(string nome, string moedaOrigem, string moedaDestino, DateTime dataoperacao, double valorOriginal)
        {
            Nome = nome;
            MoedaOrigem = moedaOrigem;
            MoedaDestino = moedaDestino;
            DataOperacao = dataoperacao;
            ValorOriginal = valorOriginal;
        }

        public void ConverterValor(double valor, string moedaOrigem, string moedaDestino)
        {

            int origem = VerificarMoeda(moedaOrigem);
            int destino = VerificarMoeda(moedaDestino);

            //matriz moedas

            //     real|dolar|libra|euro
            //real ____|_____|_____|____
            //dolar____|_____|_____|____
            //libra____|_____|_____|____
            //euro ____|_____|_____|____
            double[,] moedas = { { 1.0000, 0.1897, 0.1339, 0.1562 }, { 5.2707, 1.0000, 0.7087, 0.8233 }, { 7.4670, 1.4110, 1.0000, 1.1684 }, { 6.4017, 1.2145, 0.8607, 1.0000 } };
            double valorConvertido = moedas[origem, destino] * valor;
            double taxaOperacao = valorConvertido * 0.1;
            valorConvertido -= taxaOperacao;

            TaxaOperacao = taxaOperacao;
            ValorConvertido = valorConvertido;

        }

        private int VerificarMoeda(string moedaOrigem)
        {
            int num = 0;

            if (moedaOrigem == "BRL (Real)")
                num = 0;
            else if (moedaOrigem == "USD (US Dólar)")
                num = 1;
            else if (moedaOrigem == "GBP (Libra Esterlina)")
                num = 2;
            else if (moedaOrigem == "EUR (Euro)")
                num = 3;

            return num;
        }

        public override string ToString()
        {
            return DataOperacao.ToString()
                +" - "
                + Nome
                 + " - "
                + ValorOriginal.ToString("F2")
                 + " "
                + MoedaOrigem
                 + " - "
                + ValorConvertido.ToString("F2")
                 + " "
                + MoedaDestino;
        }
    }
}
