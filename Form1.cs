using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_Teste
{
    public partial class fmTeste : Form
    {
        int index = 0;
        public fmTeste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //missclick
        }

        private void btImp1_DragOver(object sender, DragEventArgs e)
        {
            //eu desisto
        }

        private void btCls_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            tbDesc.Text = "";
            cbCategoria.SelectedIndex = -1;
            nudImp.Value = 1;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Nota[] notas = new Nota[200];

            if (btAdd.Text == "Adicionar")
            {
                foreach (Nota i in notas)
                {
                    if(notas[index].Nome == tbNome.Text || notas[index].Desc == tbDesc.Text)
                    {
                        MessageBox.Show("Nota duplicada", "Já existe uma nota semelhante no sistema. Deseja adicionar mesmo assim?");
                    }
                }

                notas[index] = new Nota(tbNome.Text, Convert.ToString(cbCategoria.SelectedItem), Convert.ToInt32(nudImp.Value), tbDesc.Text);

            }
        }
    }
}
