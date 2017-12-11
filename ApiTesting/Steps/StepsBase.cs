using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace ApiTesting.Steps
{
    [Binding]
    public class StepsBase
    {
        protected static RestClient Client;
        protected static RestRequest Request;
        protected static IRestResponse Response;

        protected readonly Uri BaseUri = new Uri("https://reqres.in/api/users/");

        public StepsBase()
        {
            Client = new RestClient(BaseUri);
        }
    }
}