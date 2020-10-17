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

        public static void saveQuote(Desk deskQuote)
        {

            //find the reletive path to the quotes.json file
            string quotesPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            quotesPath += @"\DataBase\quotes.json";
            
            string quotes = File.ReadAllText(quotesPath);
            JArray quoteList = new JArray();

            if (quotes.Length != 0)
            {
                quoteList = JArray.Parse(quotes);
            }

            //convert deskQuote into a Json String, then convert that into a Json Object
            //I don't like it, but it works \_o_/
            String deskQuoteString = JsonConvert.SerializeObject(deskQuote, Formatting.Indented);
            JObject deskQuoteObject = (JObject)JsonConvert.DeserializeObject(deskQuoteString);

            // add Json object to json array, then turn the Json Arry into a Json String
            quoteList.Add(deskQuoteObject);
            string outputString = JsonConvert.SerializeObject(quoteList, Formatting.Indented);

            // write Json String to file
            File.WriteAllText(quotesPath, outputString);
        }
    }
}