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
using LogicLayer;

namespace WinFormGUI
{
    public partial class SkapaKontoForm : Form
    {
        private InMemoryDatabase inMemoryDatabase;

        public SkapaKontoForm(InMemoryDatabase database)
        {
            InitializeComponent();
            inMemoryDatabase = database;
            LoadRoles();
        }

        private void LoadRoles()
        {
            comboBoxRoll.Items.Add("Admin");
            comboBoxRoll.Items.Add("Användare");
            comboBoxRoll.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string namn = txtAnvändarnamn.Text;
            string lösenord = txtLösenord.Text;
            string roll = comboBoxRoll.SelectedItem.ToString();

            if (inMemoryDatabase.personlista.Any(p => p.Namn == namn))
            {
                MessageBox.Show("Användarnamnet är redan taget. Försök med ett annat namn.");
                return;
            }

            int nyttID = inMemoryDatabase.personlista.Count + 1;
            Person nyPerson = new Person(namn, nyttID, lösenord, roll);
            inMemoryDatabase.personlista.Add(nyPerson);

            MessageBox.Show("Konto skapat.");
            this.Close();
        }

        private void btnAvlsuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
