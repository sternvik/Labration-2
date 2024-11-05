using LogicLayer;
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
    public partial class AdminForm : Form
    {
        private InMemoryDatabase inMemoryDatabase;
        public AdminForm(InMemoryDatabase database)
        {
            InitializeComponent();
            inMemoryDatabase = database;
        }

        private void btnLäggTillFordon_Click(object sender, EventArgs e)
        {

        }

        private void btnUppdateraFordon_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBortFordon_Click(object sender, EventArgs e)
        {

        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
