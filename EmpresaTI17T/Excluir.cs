using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeLogin;

namespace EmpresaTI17T
{
   
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do cpf

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.excluir(Convert.ToInt64(cpf.Text), Convert"pessoa");
        }
    }
}
