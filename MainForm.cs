using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RecibosEngePas.UserControls;

namespace RecibosEngePas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlClients uc = new UserControlClients();
            uc.Parent = panelUserControl;
            uc.Dock = DockStyle.Fill;
            uc.Visible = true;
        }
    }
}
