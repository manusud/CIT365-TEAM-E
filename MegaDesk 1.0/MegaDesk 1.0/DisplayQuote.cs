﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_CostaLuiz
{
    public partial class quote : Form
    {
        public quote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu formMainMenu = new mainMenu();
            this.Close();
            formMainMenu.Show();
        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lbMaterial_Click(object sender, EventArgs e)
        {

        }
    }
}
