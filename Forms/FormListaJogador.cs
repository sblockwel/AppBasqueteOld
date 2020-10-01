using AppBasquete.Data;
using AppBasquete.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Forms
{
    public partial class FormListaJogador : Form
    {
        public FormListaJogador()
        {
            InitializeComponent();
        }

        private void dataListaJogadores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataListaJogadores.CurrentRow.DataBoundItem != null)
            {
                var jogador = (Jogador)dataListaJogadores.CurrentRow.DataBoundItem;
                var form = new FormJogador(jogador);
                form.Show();
            }
        }

        private void FormListaJogador_Load(object sender, EventArgs e)
        {
            var contexto = new AppDBContext();
            dataListaJogadores.DataSource = contexto.Jogadores.ToList();
        }

        private void dataListaJogadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = ((DateTime)e.Value).ToShortDateString();
            }
        }
    }
}
