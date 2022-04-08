using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDownloader
{
    class BooksFromSite
    {
        public List<string> Names;
        public List<string> URLs;

        public BooksFromSite()
        {
            Names = new List<string>();
            URLs = new List<string>();
        }
        public void Refresh(string site)
        {
            Names = new List<string>();
            URLs = new List<string>();
            //indexOF - находит данную строчку в массиве букв, возвращает её индекс
            int index = site.IndexOf("href=\"/b");
            while(index!=-1)    //-1 - это слово, которого нет там где мы ищем
            {
                site = site.Remove(0, index + 7);   //Удаляем всё, что до слэша
                string url = site.Remove(site.IndexOf("/")); //Удаляем всё, что после слэша
                URLs.Add(url);
                
                index = site.IndexOf(">");
                site = site.Remove(0,index+1);
                string name = site.Remove(site.IndexOf("<"));
                Names.Add(name);

                index = site.IndexOf("href=\"/b");
            }
        }
    }
}
