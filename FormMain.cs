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

namespace AppBasquete
{
    public partial class FormMain : Form
    {
        public bool ValidarCampos
        {
            get
            {
                if (!int.TryParse(txtPlacar.Text, out int placar))
                {
                    MessageBox.Show("O placar deve ser um número válido");
                    txtPlacar.Focus();
                    return false;
                }
                if (!int.TryParse(txtMinPontos.Text, out int minimo))
                {
                    MessageBox.Show("O mínimo de pontos deve ser um número válido");
                    txtMinPontos.Focus();
                    return false;
                }
                if (!int.TryParse(txtMaxPontos.Text, out int maximo))
                {
                    MessageBox.Show("O máximo de pontos deve ser um número válido");
                    txtMaxPontos.Focus();
                    return false;
                }
                if (!int.TryParse(txtQuebraMax.Text, out int quebraMaximo))
                {
                    MessageBox.Show("A quebra de recorde máximo deve ser um número válido");
                    txtQuebraMax.Focus();
                    return false;
                }
                if (!int.TryParse(txtQuebraMin.Text, out int Quebraminimo))
                {
                    MessageBox.Show("O quebra de recorde mínimo deve ser um número válido");
                    txtQuebraMin.Focus();
                    return false;
                }                
                return true;
            }
        }
        public FormMain()
        {

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
                    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                var context = new AppDBContext();
                var jogo = new Jogo();
                jogo.Placar = int.Parse(txtPlacar.Text);
                jogo.MinimoTemporada = int.Parse(txtMinPontos.Text);
                jogo.MaximoTemporada = int.Parse(txtMaxPontos.Text);
                jogo.QuebraRecordeMaximo = int.Parse(txtQuebraMax.Text);
                jogo.QuebraRecordeMinimo = int.Parse(txtQuebraMin.Text);
                context.Jogos.Add(jogo);
                if (context.SaveChanges() > 0 )

                {
                    txtNumero.Text = jogo.Id.ToString();
                    MessageBox.Show("Gravado com sucesso!");
                }                
            }          

        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            var form = new FormJogos();
            form.Show();
        }
    }
}
