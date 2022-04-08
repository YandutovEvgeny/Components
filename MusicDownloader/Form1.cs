using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowInList(List<string> list)
        {
            listBox1.Items.Clear();
            foreach (string item in list)
            {
                listBox1.Items.Add(item);
            }
        }
        BooksFromSite booksFromSite;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string site = SiteToString.GetSite("https://tululu.org/search/?q=" + textBox1.Text);
                booksFromSite = new BooksFromSite();
                booksFromSite.Refresh(site);
                ShowInList(booksFromSite.Names);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(index !=-1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текст|*.txt";
                if(saveFileDialog.ShowDialog()==DialogResult.OK)
                {
                    string url = "https://tululu.org/" + "txt.php?id=" + 
                        booksFromSite.URLs[index].Remove(0,1);
                    WebClient client = new WebClient();
                    client.DownloadFile(url, saveFileDialog.FileName);
                }
            }
        }
    }
}
