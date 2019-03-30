using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Collections;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0732104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Downloading a file");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Complete");
        }

    }

    class Network
    {
        public static async Task  Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://ibm.com");
            Console.WriteLine(data); 
                }
    }
}

