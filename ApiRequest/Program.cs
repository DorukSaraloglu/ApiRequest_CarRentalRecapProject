using System;
using ApiRequest.Models;
using Newtonsoft.Json;

namespace ApiRequest
{
    public class Program
    {
        //Önce post işlemi ile register için token alınır.
        static void Main(string[] args)
        {
            //POST
            //var client = Client.Post(Routes.Token, new GetTokenForRegister
            //{
            //    firstName = "d",
            //    lastName = "a",
            //    email = "da@mail.com",
            //    password = "1"
            //});
            //var content = client.Content;
            //Token token = JsonConvert.DeserializeObject<Token>(content);

            //GET
            var client = Client.Get(Routes.Cars);
            var content = client.Content;
            CarList carList = JsonConvert.DeserializeObject<CarList>(content);
            foreach (var car in carList.Data)
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
