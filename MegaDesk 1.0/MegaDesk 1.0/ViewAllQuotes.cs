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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            var quoteList = QuotesModel.LoadQuotes();
            foreach (var c in quoteList)
                dataGridView1.Rows.Add(c.customerName,
                                       c.desk.material.ToString(),
                                       c.desk.widthDesk.ToString(),
                                       c.desk.depthDesk.ToString(),
                                       c.desk.sizeDesk.ToString(),
                                       c.totalCost.ToString());                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu formMainMenu = new mainMenu();
            this.Close();
            formMainMenu.Show();
        }

    }
}
