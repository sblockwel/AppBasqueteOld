using AppBasquete.Data;
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
    public partial class FormListaJogos : Form
    {
        public FormListaJogos()
        {
            InitializeComponent();
        }

        private void FormListaJogos_Load(object sender, EventArgs e)
        {
            var contexto = new AppDBContext();
            dataJogos.DataSource = contexto.Jogos
                .Join(contexto.Jogadores, jogo => jogo.Jogador,
                jogador => jogador, (jogo, jogador) => new
                {
                    Id = jogo.Id,
                    Placar = jogo.Placar,
                    MinimoTemporada = jogo.MinimoTemporada,
                    MaximoTemporada = jogo.MaximoTemporada,
                    QuebraRecordeMinimo = jogo.QuebraRecordeMinimo,
                    QuebraRecordeMaximo = jogo.QuebraRecordeMaximo,
                    Jogador = jogador.Nome
                }).OrderBy(x => x.Jogador).ThenBy(y => y.Placar).ToList();
            comboPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataJogos.DataSource = null;
            var contexto = new AppDBContext();
            var query = contexto.Jogos
                .Join(contexto.Jogadores, jogo => jogo.Jogador,
                    jogador => jogador, (jogo, jogador) => new
                    {
                        Id = jogo.Id,
                        Placar = jogo.Placar,
                        MinimoTemporada = jogo.MinimoTemporada,
                        MaximoTemporada = jogo.MaximoTemporada,
                        QuebraRecordeMinimo = jogo.QuebraRecordeMinimo,
                        QuebraRecordeMaximo = jogo.QuebraRecordeMaximo,
                        Jogador = jogador.Nome
                    });

            if (comboPesquisa.SelectedIndex == 0)
            {
                query = query.Where(x => x.Jogador.Contains(txtPesquisa.Text));

            }
            else if (comboPesquisa.SelectedIndex == 1)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.Placar == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            else if (comboPesquisa.SelectedIndex == 2)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.MinimoTemporada == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            else if (comboPesquisa.SelectedIndex == 3)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.MaximoTemporada == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            else if (comboPesquisa.SelectedIndex == 4)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.QuebraRecordeMinimo == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            else if (comboPesquisa.SelectedIndex == 5)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.QuebraRecordeMaximo == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            dataJogos.DataSource = query.OrderBy(x => x.Jogador).ThenBy(y => y.Placar).ToList();
        }
    }
}
