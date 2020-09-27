using AppBasquete.Data;
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
    public partial class FormJogos : Form
    {
        public FormJogos()
        {
            InitializeComponent();
        }

        private void FormJogos_Load(object sender, EventArgs e)
        {
            var contexto = new AppDBContext();
            dataJogos.DataSource = contexto.Jogos.ToList();
        }
    }
}
