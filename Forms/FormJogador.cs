using AppBasquete.Models;
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
    public partial class FormJogador : Form
    {
        Jogador jogador;
        public FormJogador(Jogador jogador = null)
        {
            InitializeComponent();
            if (jogador == null)
            {
                jogador = new Jogador();               
            }
            this.jogador = jogador;
            CarregarDados();
        }

        void CarregarDados()
        {
            txtIdJogador.Text = jogador.Id > 0 ? jogador.Id.ToString() : "Novo";
        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOutro.Visible = comboSexo.SelectedIndex == 2;
            lblOutro.Visible = comboSexo.SelectedIndex == 2;
        }

        private void FormJogador_Load(object sender, EventArgs e)
        {

        }
    }
}
