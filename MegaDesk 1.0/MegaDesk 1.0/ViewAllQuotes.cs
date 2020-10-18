using System;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu formMainMenu = new mainMenu();
            this.Close();
            formMainMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var quoteList = new BindingList<DeskQuote>();
            dataGridView1.DataSource = quoteList;
            foreach (var c in quoteList)
            {
                c.customerName.ToString();
                c.desk.material.ToString();
                c.desk.widthDesk.ToString();
                c.desk.depthDesk.ToString();
                c.desk.sizeDesk.ToString();
                c.totalCost.ToString();
        }
        }
    }
}
