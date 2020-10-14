using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_CostaLuiz
{
    class DeskQuote : Desk
    {
        private int drawersCost;
        private int materialCost;
        private int rushCost;
        private int myOverage;
        private int sizeCost;

        public DeskQuote()
        {

        }

        public void setSizeOverage(int mySize)
        {
            if (mySize > 1000)
                this.myOverage = mySize - 1000;
            else
                this.myOverage = 0;
        }

        public int getSizeOverage()
        {
            return this.myOverage;
        }

        public int getSizeCost(int mySize)
        {
            if (mySize > 1000)
                this.sizeCost = this.myOverage * DESKTOP_SURFACE_AREA;
            else
                this.sizeCost = 0;
            return this.sizeCost;
        }

        public int getDrawersCost(string myNumberOfDrawers)
        {
            this.drawersCost = int.Parse(myNumberOfDrawers) * DRAWER_PRICE;
            return this.drawersCost;
        }

        public int getCostMaterial(string myMaterial)
        {
            this.materialCost = (int)Enum.Parse(typeof(DesktopMaterial), myMaterial);
            return this.materialCost;
        }
      
        public int getRushCost(int sizeDesk,string rushDays)
        {           
            switch (rushDays)
            {
                case "3 Days":
                    if (sizeDesk < 1000)
                        this.rushCost = 60;
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = 70;
                    if (sizeDesk > 2000)
                        this.rushCost = 80;
                    break;
                
                case "5 Days":
                    if (sizeDesk < 1000)
                        this.rushCost = 40;
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = 50;
                    if (sizeDesk > 2000)
                        this.rushCost = 60;
                    break;
            
                case "7 Days":
                    if (sizeDesk < 1000)
                        this.rushCost = 30;
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = 35;
                    if (sizeDesk > 2000)
                        this.rushCost = 40;
                    break;
                default:
                    this.rushCost = 0;
                    break;
            }
            return this.rushCost;
        }

        internal string getSizeCost(string v)
        {
            throw new NotImplementedException();
        }

        // Read in the rush order price list from this file: rushOrderPrices.txt
        public int GetRushOrder(int sizeDesk, string rushDays)
        {
            //Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
            string startupPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            StreamReader reader = new StreamReader(startupPath + @"\MegaDesk 1.0\Properties\DataBase\rushOrderPrices.txt");
            
            reader.Close();



            return this.rushCost;
        }

    }
}
