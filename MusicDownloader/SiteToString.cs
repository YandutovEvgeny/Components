using System.Net;
using System.IO;

namespace MusicDownloader
{
    static class SiteToString
    {
        public static string GetSite(string URL)
        {
            WebRequest webRequest = WebRequest.Create(URL); //Формируем запрос к серверу
            WebResponse webResponse = webRequest.GetResponse(); //Получаем ответ

            Stream stream = webResponse.GetResponseStream();    //Сервер показывает нам сайт, HTML в поток
            StreamReader streamReader = new StreamReader(stream); //Расшифровываем полученный поток
            string result = streamReader.ReadToEnd();
            return result;
        }
    }
}
