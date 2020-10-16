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
        private string[,] priceRush = new string[3, 3];

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
                        this.rushCost = int.Parse(this.priceRush[0, 0]);
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = int.Parse(this.priceRush[0, 1]);
                    if (sizeDesk > 2000)
                        this.rushCost = int.Parse(this.priceRush[0, 2]);
                    break;
                
                case "5 Days":
                    if (sizeDesk < 1000)
                        this.rushCost = int.Parse(this.priceRush[1, 0]);
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = int.Parse(this.priceRush[1, 1]);
                    if (sizeDesk > 2000)
                        this.rushCost = int.Parse(this.priceRush[1, 2]);
                    break;
            
                case "7 Days":
                    if (sizeDesk < 1000)
                        this.rushCost = int.Parse(this.priceRush[2, 0]);
                    if (sizeDesk >= 1000 && sizeDesk <= 2000)
                        this.rushCost = int.Parse(this.priceRush[2, 1]);
                    if (sizeDesk > 2000)
                        this.rushCost = int.Parse(this.priceRush[2, 2]);
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

        /***********************************************
         * Created by: Luiz Manoel
         * In 2020/10/16 01:24
         * ********************************************/
        
        // Create a GetRushOrder method within the DeskQuote class to handle the population of a member variable that holds a two dimension array that encases the logic in a try catch block
        // Read in the rush order price list from this file: rushOrderPrices.txt
        public void GetRushOrder()
        {
            try
            {
                //Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
                string startupPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

                // read the values into a single dimension array and then use nested loops to populate a two dimensional array with three rows and three columns.
                string[] lines = File.ReadAllLines(startupPath + @"\MegaDesk 1.0\MegaDesk 1.0\DataBase\rushOrderPrices.txt").ToArray();

                for (int x = 0; x < lines.Length; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        this.priceRush[0, y] = lines[x];
                        x++;
                    }

                    for (int y = 0; y < 3; y++)
                    {
                        this.priceRush[1, y] = lines[x];
                        x++;
                    }

                    for (int y = 0; y < 3; y++)
                    {
                        this.priceRush[2, y] = lines[x];
                        x++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error happened:" + e.Message);
            }
        }

    }
}
