using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace USSProjeto
{
    public partial class MenuBase : Form
    {
        public MenuBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClicaLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void CadPaci(object sender, EventArgs e)
        {
            this.Hide();
            CadPaci cadpaci = new CadPaci();
            cadpaci.Closed += (s, args) => this.Close();
            cadpaci.Show();
        }

        private void CadPront(object sender, EventArgs e)
        {
            this.Hide();
            CadPront cadpront = new CadPront();
            cadpront.Closed += (s, args) => this.Close();
            cadpront.Show();
        }

        private void ConPront(object sender, EventArgs e)
        {
            this.Hide();
            ConPront conpront = new ConPront();
            conpront.Closed += (s, args) => this.Close();
            conpront.Show();
        }

        private void Logout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
