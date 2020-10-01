﻿using AppBasquete.Data;
using AppBasquete.Extensions;
using AppBasquete.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Forms
{
    public partial class FormJogador : Form
    {
        Jogador jogador;
        public FormJogador(Jogador jogador = null)
        {
            InitializeComponent();
            this.jogador = jogador;
        }

        public bool ValidarCampos
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("O Nome deve ser preenchido!");
                    txtNome.Focus();
                    return false;
                }
                if (dateTimeDataNasc.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("A data de nascimento não pode ser o dia atual!");
                    dateTimeDataNasc.Focus();
                    return false;
                }
                if (comboSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("O sexo deve ser selecionado!");
                    comboSexo.Focus();
                    return false;
                }
                else if (comboSexo.SelectedIndex == 2 && 
                    (string.IsNullOrEmpty(txtOutro.Text) || string.IsNullOrWhiteSpace(txtOutro.Text)))
                {
                    MessageBox.Show("O campo outro deve ser preenchido!");
                    txtOutro.Focus();
                    return false;
                }
                return true;
            }
        }

        void CarregarDados()
        {
            if (jogador == null)
            {
                jogador = new Jogador();
            }
            txtIdJogador.Text = jogador.Id > 0 ? jogador.Id.ToString() : "Novo";
            txtNome.Text = jogador.Nome;
            if (jogador.DataNasc > DateTime.MinValue && jogador.DataNasc < DateTime.MaxValue)
            {
                dateTimeDataNasc.Value = jogador.DataNasc;
                txtIdade.Text = jogador.Idade.ToString();
            }                       
            string Sexo = string.IsNullOrEmpty(jogador.Sexo) ? "" : jogador.Sexo;
            if (comboSexo.Items.Contains(Sexo))
            {
                comboSexo.SelectedItem = Sexo;
            }
            else if (Sexo != "")
            {
                comboSexo.SelectedIndex = 2;
                txtOutro.Text = Sexo;
            }
            comboTime.Text = jogador.Time;
            comboTecnico.Text = jogador.Tecnico;
            txtCamisa.Text = jogador.NumCamisa;
        }

        void CarregarJogador()
        {
            jogador.Id = txtIdJogador.Text == "Novo" ? 0 : txtIdJogador.Text.ToInt();
            jogador.Nome = txtNome.Text;
            jogador.DataNasc = dateTimeDataNasc.Value;
            string Sexo;
            if (comboSexo.SelectedIndex == 2)
            {
                Sexo = txtOutro.Text;
            }
            else
            {
                Sexo = comboSexo.Text;
            }
            jogador.Sexo = Sexo;
            jogador.Time = comboTime.Text;
            jogador.Tecnico = comboTecnico.Text;
            jogador.NumCamisa = txtCamisa.Text;
        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOutro.Visible = comboSexo.SelectedIndex == 2;
            lblOutro.Visible = comboSexo.SelectedIndex == 2;
        }

        private void FormJogador_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dateTimeDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txtIdade.Text = ((int)(DateTime.Today - dateTimeDataNasc.Value).TotalDays / 365).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            jogador = null;
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                var contexto = new AppDBContext();
                CarregarJogador();
                if (jogador.Id == 0)
                    contexto.Jogadores.Add(jogador);
                else
                    contexto.Jogadores.Update(jogador);
                if (contexto.SaveChanges() > 0)
                {
                    CarregarDados();
                    MessageBox.Show("Gravado com sucesso!");
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (jogador.Id > 0)
            {
                var contexto = new AppDBContext();
                var jogadorObj = contexto.Jogadores.Where(x => x.Id == jogador.Id).FirstOrDefault();
                if (jogadorObj != null)
                {
                    contexto.Remove(jogadorObj);
                    if (contexto.SaveChanges() > 0)
                    {
                        btnLimpar.PerformClick();
                        MessageBox.Show("Registro apagado com sucesso!");
                    }
                }
            }
        }
    }
}
