using System.Net;

namespace MyClassLibrary
{
    public class Class1
    {
        public string ScrapeWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
