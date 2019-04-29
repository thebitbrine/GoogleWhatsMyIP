using System;
namespace GoogleWhatsMyIP
{
    class Program
    {
        static void Main()
        {
            var Response = new System.Net.WebClient() {Encoding = System.Text.Encoding.UTF8}.DownloadString("https://www.google.am/search?q=whats+my+ip&hl=en");
            var m = new System.Text.RegularExpressions.Regex("((?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))(?![\\d])").Match(Response);
            if (m.Success)
                Console.WriteLine(m.Groups[1].ToString());
        }
    }
}
