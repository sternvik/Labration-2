using LogicLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGUI
{
    public partial class AnvändareForm : Form
    {
        private InMemoryDatabase inMemoryDatabase;
        public AnvändareForm(InMemoryDatabase database)
        {
            InitializeComponent();
            inMemoryDatabase = database;
        }

        private void btnHyraFordon_Click(object sender, EventArgs e)
        {

        }

        private void btnAvslutaHyra_Click(object sender, EventArgs e)
        {

        }

        private void btnRapporteraFordon_Click(object sender, EventArgs e)
        {

        }

        private void btnVisaHyreshistorik_Click(object sender, EventArgs e)
        {

        }

        private void btnLäggTillBetalningsmetod_Click(object sender, EventArgs e)
        {

        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
