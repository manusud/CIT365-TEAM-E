using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum DesktopMaterial
{    
    Select,
    Oak = 200,
    Laminate = 100,
    Pine = 50,
    Rosewood = 300,
    Veneer = 125
}

namespace MegaDesk_CostaLuiz
{

    class Desk
    {
        // constants to Add Quote
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int depth_MIN = 12;
        public const int depth_MAX = 48;
        public const int DRAWER_PRICE = 50;
        public const int BASE_DESK_PRICE = 200;
        public const int BASE_SIZE_INCL = 1000;
        public const int DESKTOP_SURFACE_AREA = 1;

        //public string customerName;
        public int widthDesk;
        public int depthDesk;
        public int sizeDesk;
        public int drawers;
        //public string rushDays;
        public string material;


        public Desk() {}
        
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        /*public void setcustomerName(string custName)
        {
            customerName = custName;
        }

        public string getcustomerName()
        {
            return customerName;
        }*/

        public void SetWidth(string width)
        {
            this.widthDesk = int.Parse(width);
        }

        public void SetDepth(string depth)
        {
            this.depthDesk = int.Parse(depth);
        }

        public int GetSize()
        {
            this.sizeDesk = this.depthDesk * this.widthDesk;
            return this.sizeDesk;
        }

        public void setNumberDrawers(string numberDrawers)
        {
            this.drawers = int.Parse(numberDrawers);
        }

        public void setMaterial(string strMaterial)
        {
            this.material = strMaterial;
        }

        /*public void setRush(string rush)
        {
            this.rushDays = rush;
        }*/

    }
}