using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_CostaLuiz
{
    class QuotesModel
    {

        public static void whyWontThisWork()
        {
            //Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
            string startupPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

            // read the values into a single dimension array and then use nested loops to populate a two dimensional array with three rows and three columns.
            string quotes = File.ReadAllText(startupPath + @"\MegaDesk 1.0\MegaDesk 1.0\DataBase\quotes.json");
        }

        public static void saveQuote(DeskQuote deskQuote)
        {

            //Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
            string quotesPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            quotesPath += @"\MegaDesk 1.0\MegaDesk 1.0\DataBase\quotes.json";
            string quotes = File.ReadAllText(quotesPath);

            if (quotes.Length == 0)
            {
                string outputString = JsonConvert.SerializeObject(deskQuote, Formatting.Indented);
                File.WriteAllText(quotesPath, outputString);
            }
            else
            {
                //List<DeskQuote> quoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                //List.AddRange()

                JArray quoteList = JArray.Parse(quotes);

                quoteList.Add(deskQuote);
                string outputString = JsonConvert.SerializeObject(quoteList, Formatting.Indented);
                File.WriteAllText(quotesPath, outputString);
            }
        }
        
    }
}