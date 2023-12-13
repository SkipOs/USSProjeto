using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USSProjeto
{
    public partial class CadPront : Form
    {
        public CadPront()
        {
            InitializeComponent();
        }

        private void ListaProntuarioPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salvar(object sender, EventArgs e)
        {

        }

        private void Cancelar(object sender, EventArgs e)
        {
            this.Hide();
            MenuBase menu = new MenuBase();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
            this.Dispose();
        }
    }
}
