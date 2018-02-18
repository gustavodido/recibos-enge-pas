using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RecibosEngePas;

namespace RecibosEngePas.UserControls
{
    public partial class UserControlClients : UserControl
    {
        public UserControlClients()
        {
            InitializeComponent();
        }

        private void UserControlClients_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
