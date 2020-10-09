using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum DesktopMaterial
{
    Oak = 200,
    Laminate = 100,
    Pine = 50,
    Rosewood = 300,
    Venner = 125
}

namespace MegaDesk_CostaLuiz
{

    class Desk
    {
        // constants to Add Quote
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int DEPH_MIN = 12;
        public const int DEPH_MAX = 48;
        public const int DRAWER_PRICE = 50;
        public const int BASE_DESK_PRICE = 200;
        public const int BASE_SIZE_INCL = 1000;
        public const int DESKTOP_SURFACE_AREA = 1;

        public string costumerName;
        public int widthDesk;
        public int dephDesk;
        public int sizeDesk;
        public int drawers;
        public string rushDays;
        public string material;


        public Desk() {}
        
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public void setCostumerName(string costName)
        {
            costumerName = costName;
        }

        public string getCostumerName()
        {
            return costumerName;
        }

        public void setWidth(string width)
        {
            this.widthDesk = int.Parse(width);
        }

        public void setDeph(string deph)
        {
            this.dephDesk = int.Parse(deph);
        }

        public int getSize()
        {
            this.sizeDesk = this.dephDesk * this.widthDesk;
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

        public void setRush(string rush)
        {
            this.rushDays = rush;
        }

    }
}