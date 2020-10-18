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


            /*string startupPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

            StreamReader r = new StreamReader(startupPath + @"\MegaDesk 1.0\MegaDesk 1.0\DataBase\quotes.json");
            string json = r.ReadToEnd();
            dynamic array = JsonConvert.DeserializeObject(json); 
            foreach (var item in array)
            {
                if (item.desk.material = QuoteMaterial.Text) // test to insert only 
                {
                    string[] row = { item.customerName, "2020-10-23", "42", "56", "449", "100.23" };
                    var listViewItem = new ListViewItem(row);
                    listQuoteByMaterial.Items.Add(listViewItem);
                }
            } */

        }

        private void closeForm(object sender, FormClosedEventArgs e)
        {
            formMainMenu.Show();
        }
    }
}
