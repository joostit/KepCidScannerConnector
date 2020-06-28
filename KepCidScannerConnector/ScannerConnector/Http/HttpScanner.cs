using ScannerConnector.Http.Xml;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ScannerConnector
{
    class HttpScanner
    {

        private const string HttpGetCommandsPath = @"/WSIQueryService/ProcessCommandsViaGet";
        private const string HttpPostCommandspath = @"WSIQueryService/ProcessCommandsViaPost";
        public string Url { get; set; }
        public int port { get; set; }

        private HttpClient httpClient;

        private ScannerResponseParser responseParser = new ScannerResponseParser();

        private ScannerCommandParser commandParser = new ScannerCommandParser();

        public HttpScanner(string url)
        {
            this.Url = url;

            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Url)
            };
        }


        public Http.Xml.Response.OrderInterface GetStatus()
        {
            HttpResponseMessage response = httpClient.GetAsync(HttpGetCommandsPath).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

            Http.Xml.Response.OrderInterface result = responseParser.GetOrderResult(responseBody);
            return result;
        }


        public List<string> GetShapeList()
        {
            List<string> retVal = new List<string>();

            string content = "inputString=" + commandParser.GetShapeListCommand();

            HttpContent body = new StringContent(content);

            HttpResponseMessage response = httpClient.PostAsync(HttpPostCommandspath, body).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;

            Http.Xml.Response.OrderInterface result = responseParser.GetOrderResult(responseBody);

            if(result.ResultList.Items.Length != 1)
            {
                throw new ProtocolViolationException($"Expected to find exactly one result in the response ResultList. Found {result.ResultList.Items.Length}");
            }

            foreach (var shape in result.ResultList.Items[0].ShapeList)
            {
                retVal.Add(shape.Name);
            }

            return retVal;
        }


    }
}
