using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json; // to use json

namespace MegaDesk_CostaLuiz
{
    public partial class SearchQuotes : Form
    {
        private mainMenu formMainMenu = new mainMenu();

        public SearchQuotes()
        {
            InitializeComponent();

            // add itens Surface Materials to combobox
            List<string> listMaterial = ((DesktopMaterial[])Enum.GetValues(typeof(DesktopMaterial))).Select(c => c.ToString()).ToList();
            QuoteMaterial.DataSource = listMaterial;
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            this.Close();
            formMainMenu.Show();
        }

        private void ChangeDeskTopMaterial(object sender, EventArgs e)
        {
            // Read Json and insert to ListView
            listQuoteByMaterial.Items.Clear();
            var quotesList2 = QuotesModel.LoadQuotes();
            foreach (var c in quotesList2)
            {
                var myMaterial = c.desk.material.ToString();

                if (myMaterial == QuoteMaterial.Text) // test to insert only 


                    listQuoteByMaterial.Items.Add(new ListViewItem(new string[] { c.customerName,
                                                                              c.quoteDate,
                                                                              c.desk.widthDesk.ToString(),
                                                                              c.desk.depthDesk.ToString(),
                                                                              c.desk.sizeDesk.ToString(),
                                                                              c.totalCost.ToString()}));
                
            }

        }

        private void closeForm(object sender, FormClosedEventArgs e)
        {
            formMainMenu.Show();
        }
    }
}
