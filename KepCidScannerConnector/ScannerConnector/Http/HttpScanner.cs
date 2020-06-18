using ScannerConnector.Http.Xml;
using ScannerConnector.Http.Xml.Response;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ScannerConnector
{
    class HttpScanner
    {

        private const string ProcessCommandsPath = @"/WSIQueryService/ProcessCommandsViaGet";

        public string Url { get; set; }
        public int port { get; set; }

        HttpClient httpClient;

        private ScannerApiXmlParser xmlParser = new ScannerApiXmlParser();

        public HttpScanner(string url)
        {
            this.Url = url;

            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Url)
            };
        }


        public OrderInterface GetStatus()
        {
            HttpResponseMessage response = httpClient.GetAsync(ProcessCommandsPath).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

            OrderInterface result = xmlParser.GetOrderResult(responseBody);
            return result;
        }


    }
}
