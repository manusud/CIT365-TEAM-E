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
    public partial class AddNewQuote : Form
    {

        public string CostName;

        public AddNewQuote()
        {
            InitializeComponent();
            
            // add itens to number of drawers combobox
            for (int i = 0; i <= 7; i++)
            {
                string item = string.Format("{0}", i.ToString());
                QuoteDrawers.Items.Add(item);
            }

            // add itens Surface Materials combobox

            foreach (var item in Enum.GetValues(typeof(DesktopMaterial)))
            {
                QuoteMaterial.Items.Add(item);
            }

            // add itens to Rusch combobox
            QuoteRush.Items.Add("Normal");
            QuoteRush.Items.Add("3 Days");
            QuoteRush.Items.Add("5 Days");
            QuoteRush.Items.Add("7 Days");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.QuoteCostumerName.Text != "" && this.QuoteWidth.Text != "" &&
                this.QuoteDepth.Text != "" && this.QuoteDrawers.Text != "" &&
                this.QuoteMaterial.Text != "" && this.QuoteRush.Text != "")
            {
                quote formQuote = new quote();
                Desk myDesk = new Desk();
                DeskQuote myDeskQuote = new DeskQuote();

                myDesk.setCostumerName(this.QuoteCostumerName.Text);
                myDesk.setWidth(this.QuoteWidth.Text);
                myDesk.setDeph(this.QuoteDepth.Text);
                myDesk.setNumberDrawers(this.QuoteDrawers.Text);
                myDesk.setMaterial(this.QuoteMaterial.Text);
                myDesk.setRush(this.QuoteRush.Text);

                formQuote.lbCostumerName.Text = myDesk.getCostumerName();
                formQuote.lbBasePrice.Text = Desk.BASE_DESK_PRICE.ToString();
                formQuote.lbBaseSizeIn.Text = Desk.BASE_SIZE_INCL.ToString();   
                formQuote.lbCostPerIn.Text = Desk.DESKTOP_SURFACE_AREA.ToString();
                formQuote.lbTotalSize.Text = myDesk.getSize().ToString();

                myDeskQuote.setSizeOverage(myDesk.getSize());
                formQuote.lbSizeOverage.Text = myDeskQuote.getSizeOverage().ToString();
                formQuote.lbSizeCost.Text = myDeskQuote.getSizeCost(myDesk.getSize()).ToString();

                formQuote.lbPriceDrawer.Text = Desk.DRAWER_PRICE.ToString();
                formQuote.lbDrawerCost.Text = myDeskQuote.getDrawersCost(this.QuoteDrawers.Text).ToString();

                formQuote.lbMaterial.Text = this.QuoteMaterial.Text;
                formQuote.lbMaterialCost.Text = myDeskQuote.getCostMaterial(this.QuoteMaterial.Text).ToString();

                formQuote.lbShippingMethod.Text = this.QuoteRush.Text;
                formQuote.lbShippingCost.Text = myDeskQuote.getRushCost(myDesk.getSize(), this.QuoteRush.Text).ToString();

                int totalCost = int.Parse(formQuote.lbSizeCost.Text) + int.Parse(formQuote.lbBasePrice.Text) +
                                int.Parse(formQuote.lbDrawerCost.Text) + int.Parse(formQuote.lbMaterialCost.Text) +
                                int.Parse(formQuote.lbShippingCost.Text);

                formQuote.lbTotalCost.Text = totalCost.ToString();
                formQuote.lbDateTime.Text = myDesk.GetDateTime().ToString();


                this.Close();
                formQuote.Show();

            }
            else
                MessageBox.Show("All fields must be filled!");
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu formMainMenu = new mainMenu();
            this.Close();
            formMainMenu.Show();

        }

        private void ValidadeWidth(object sender, CancelEventArgs e)
        {
            TextBox testWidth = sender as TextBox;
            try
            {               
                if (!testWidth.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Must be a integer number!");
                    e.Cancel = true;
                    return;
                }

                if (int.Parse(testWidth.Text) < Desk.WIDTH_MIN || int.Parse(testWidth.Text) > Desk.WIDTH_MAX)
                {
                    MessageBox.Show("Must be between 24 and 96!");
                    e.Cancel = true;
                    return;
                }
            }
            catch
            {
                if (testWidth.Text is null)
                    MessageBox.Show("The With fiel cannot be null");
            }
        }

        private void ValidateDepth(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                    if (!Char.IsControl(e.KeyChar))
                    {
                        MessageBox.Show("Must be a integer number!");
                        return;
                    } 
            }
        }

        private void ValidadeDeph2(object sender, CancelEventArgs e)
        {
            
            TextBox testWidth = sender as TextBox;

            try
            {

                if (int.Parse(testWidth.Text) < Desk.DEPH_MIN || int.Parse(testWidth.Text) > Desk.DEPH_MAX)
                {
                    MessageBox.Show("Must be between 12 and 48!");
                    e.Cancel = true;
                    return;
                }
            }
            catch
            {
                if (testWidth.Text is null)
                    MessageBox.Show("The With fiel cannot be null");
            }
        }   
    }
}
