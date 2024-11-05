using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace WinFormGUI
{
    public partial class MainMenuForm : Form
    {
        private InMemoryDatabase inMemoryDatabase;

        public MainMenuForm()
        {
            InitializeComponent();
            inMemoryDatabase = InMemoryDatabase.Instance;
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            var loggaInForm = new LoggaInForm(inMemoryDatabase);
            loggaInForm.ShowDialog();
            this.Hide();
        }

        private void btnSkapaKonto_Click(object sender, EventArgs e)
        {
            var skapaKontoForm = new SkapaKontoForm(inMemoryDatabase);
            skapaKontoForm.ShowDialog();
            this.Hide();
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
