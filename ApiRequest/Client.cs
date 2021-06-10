using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRequest.Models;

namespace ApiRequest
{
    public class Client
    {
        private static RestClient client;

        static Client()
        {
            client = new RestClient(Routes.Base) { };
        }


        public static IRestResponse Post(string url, GetTokenForRegister token)
        {
            var request = new RestRequest(Routes.Base + url, Method.POST);

            request.AddHeader("Accept", "*/*");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Connection", "keep-alive");
            request.AddJsonBody(token);
            var response = client.Execute(request);
            return response;
        }

        public static IRestResponse Get(string url)
        {
            var request = new RestRequest(Routes.Base + url, Method.GET);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);

            return response;
        }
    }
}
