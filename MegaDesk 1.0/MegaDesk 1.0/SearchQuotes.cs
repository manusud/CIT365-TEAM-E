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
            // Test code to read Json and insert to ListView
            StreamReader r = new StreamReader("file.json");
            string json = r.ReadToEnd();
            dynamic array = JsonConvert.DeserializeObject(json); // necessary include 
            foreach (var item in array)
            {
                if (item.material = QuoteMaterial.Text)
                {
                    Console.WriteLine("{0} {1}", item.temp, item.vcc);
                    string[] row = { "Luiz Manoel Augusto Costa", "2020-10-23", "42", "56", "449", "100.23" };
                    var listViewItem = new ListViewItem(row);
                    listQuoteByMaterial.Items.Add(listViewItem);
                }
            }
        }

        private void closeForm(object sender, FormClosedEventArgs e)
        {
            formMainMenu.Show();
        }
    }
}
