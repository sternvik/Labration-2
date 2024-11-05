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
    public partial class LoggaInForm : Form
    {
        private InMemoryDatabase inMemoryDatabase;

        public LoggaInForm(InMemoryDatabase database)
        {
            InitializeComponent();
            inMemoryDatabase = database;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string användarnamn = txtAnvändarnamn.Text;
            string lösenord = txtLösenord.Text;

            Person inloggadPerson = inMemoryDatabase.personlista.Find(p => p.Namn == användarnamn && p.Lösenord == lösenord);

            if (inloggadPerson != null)
            {
                MessageBox.Show($"Inloggad som {inloggadPerson.Namn}. Din roll: {inloggadPerson.Roll}");

                if (inloggadPerson.Roll == "Admin")
                {
                    var adminForm = new AdminForm(inMemoryDatabase);
                    adminForm.Show();
                }
                else
                {
                    var användarForm = new AnvändareForm(inMemoryDatabase);
                    användarForm.Show();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord.");
            }
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
