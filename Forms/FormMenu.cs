using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBasquete.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuCadastrarJogador_Click(object sender, EventArgs e)
        {
            new FormJogador().Show();
        }

        private void menuCadastrarJogo_Click(object sender, EventArgs e)
        {
            new FormJogo().Show();
        }

        private void menuConsultarJogo_Click(object sender, EventArgs e)
        {
            new FormListaJogos().Show();
        }

        private void MenuConsultarJogador_Click(object sender, EventArgs e)
        {
            var form = new FormListaJogador();
               form.Show();
        }
    }
}
