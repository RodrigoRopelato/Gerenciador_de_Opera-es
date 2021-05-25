using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muito_Dinheiro
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_NovaOperação_Click(object sender, EventArgs e)
        {
            CadastroOperacao operacao = new CadastroOperacao();
            operacao.Show();
            
        }

        private void btn_Relatório_Click(object sender, EventArgs e)
        {

        }
    }
}
