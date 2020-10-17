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

        public static void SaveQuote(DeskQuote deskQuote)
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

        public static List<Desk> LoadQuotes()
        {
            List<Desk> quotesList = new List<Desk>();

            //find the reletive path to the quotes.json file
            string quotesPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            quotesPath += @"\DataBase\quotes.json";
            string quotes = File.ReadAllText(quotesPath);

            if (quotes.Length == 0)
            {
                return null;
            }

            JArray quoteArray = JArray.Parse(quotes);

            foreach (JObject quote in quoteArray)
            {
                // convert each object in the json file to a string, then a Json Object, then a Desk
                String quoteString = JsonConvert.SerializeObject(quote, Formatting.Indented);
                Desk desk = JsonConvert.DeserializeObject<Desk>(quoteString);
                quotesList.Add(desk);
            }

            return quotesList;
        }
    }
}