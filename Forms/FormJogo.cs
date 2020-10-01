using AppBasquete.Data;
using AppBasquete.Extensions;
using AppBasquete.Models;
using System;
using System.Windows.Forms;

namespace AppBasquete.Forms
{
    public partial class FormJogo : Form
    {

        Jogo jogo;
        public FormJogo(Jogo jogo = null)
        {
            InitializeComponent();
            this.jogo = jogo;
        }
        public bool ValidarCampos
        {
            get
            {
                if (!int.TryParse(txtPlacar.Text, out int placar))
                {
                    MessageBox.Show("O placar deve ser um número válido!");
                    txtPlacar.Focus();
                    return false;
                }
                if (!int.TryParse(txtMinPontos.Text, out int minimo))
                {
                    MessageBox.Show("O mínimo de pontos deve ser um número válido!");
                    txtMinPontos.Focus();
                    return false;
                }
                if (!int.TryParse(txtMaxPontos.Text, out int maximo))
                {
                    MessageBox.Show("O máximo de pontos deve ser um número válido!");
                    txtMaxPontos.Focus();
                    return false;
                }
                if (!int.TryParse(txtQuebraMax.Text, out int quebraMaximo))
                {
                    MessageBox.Show("A quebra de recorde máximo deve ser um número válido!");
                    txtQuebraMax.Focus();
                    return false;
                }
                if (!int.TryParse(txtQuebraMin.Text, out int Quebraminimo))
                {
                    MessageBox.Show("O quebra de recorde mínimo deve ser um número válido!");
                    txtQuebraMin.Focus();
                    return false;
                }
                return true;
            }
        }

        void CarregarDados()
        {
            if (jogo == null)
            {
                jogo = new Jogo();
            }
            txtNumero.Text = jogo.Id > 0 ? jogo.Id.ToString() : "Novo";
            txtPlacar.Text = jogo.Placar.ToString();
            txtMinPontos.Text = jogo.MinimoTemporada.ToString();
            txtMaxPontos.Text = jogo.MaximoTemporada.ToString();
            txtQuebraMin.Text = jogo.QuebraRecordeMinimo.ToString();
            txtQuebraMax.Text = jogo.QuebraRecordeMaximo.ToString();

        }

        void CarregarJogo()
        {
            jogo.Placar = txtPlacar.Text.ToInt();
            jogo.MinimoTemporada = txtMinPontos.Text.ToInt();
            jogo.MaximoTemporada = txtMaxPontos.Text.ToInt();
            jogo.QuebraRecordeMinimo = txtQuebraMin.Text.ToInt();
            jogo.QuebraRecordeMaximo = txtQuebraMax.Text.ToInt();
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                var contexto = new AppDBContext();
                CarregarJogo();
                if (jogo.Id == 0)
                    contexto.Jogos.Add(jogo);
                else
                    contexto.Jogos.Update(jogo);
                if (contexto.SaveChanges() > 0)
                {
                    CarregarDados();
                    MessageBox.Show("Gravado com sucesso!");
                }
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            var form = new FormListaJogos();
            form.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            jogo = null;
            CarregarDados();
        }
    }
}
