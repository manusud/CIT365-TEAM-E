using MegaDesk_CostaLuiz;
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
    public partial class mainMenu : Form
    {

        public mainMenu()
        {
            InitializeComponent();
            // To get the current date
            lbMainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // To quit application
            Application.Exit();
        }

        private void btAddNewQuote_Click(object sender, EventArgs e)
        {
            AddNewQuote formAddQuote = new AddNewQuote();
            formAddQuote.Show();
            this.Hide();
        }

        private void btViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes formAllQuotes = new ViewAllQuotes();
            formAllQuotes.Show();
            this.Hide();

        }

        private void btSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes formSearchQuotes = new SearchQuotes();
            formSearchQuotes.Show();
            this.Hide();
            
        }

        private void closeMainForm(object sender, FormClosedEventArgs e)
        {
            // To quit application
            Application.Exit();
        }
    }

}
