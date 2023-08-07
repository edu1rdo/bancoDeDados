using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTI17T
{
    public partial class atualizar : Form
    {
        public atualizar()
        {
            InitializeComponent();
            atu
        }

        private void atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.atualizar(Convert.ToUInt64(cpf.Text), "pessoa", "nome", nome.Text); //atualizo o nome
            atu.atualizar(Convert.ToUInt64(cpf.Text), "pessoa", "telefone", telefone.Text);
            atu.atualizar(Convert.ToUInt64(cpf.Text), "pessoa", "cidade", cidade.Text);
            atu.atualizar(Convert.ToUInt64(cpf.Text), "pessoa", "uf", UF.Text);
            MessageBox.Show("dados atualizados com sucesso");

        }//fim do botao atualizar

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do cpf

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do nomee

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do tel

        private void cidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da cidade

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do uf
    }//fim da classe
}//fim do projeto
