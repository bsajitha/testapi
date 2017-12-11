using System.Net;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using ApiTesting.Steps;

namespace ApiTesting
{
    [Binding]
    public class SearchAPISteps : StepsBase
    {

    [Given(@"I search for user id (.*)")]
        public void GivenISearchForUserId(string searchTerm)
        {
            getRequest(searchTerm);
        }

    [Then(@"I will receive an (.*) response")]
        public void ThenIWillReceiveAnOKResponse(HttpStatusCode statusCode)
        {
            Assert.That(Response.StatusCode, Is.EqualTo(statusCode));
        }

    private static void getRequest(string searchTerm)
    {
            Request = new RestRequest(Method.GET)
            {
                Resource = searchTerm
            };

    }

    [When(@"(?i)the response is received")]
    public void WhenIGetTheResponseBackFromApi()
    {
        Response = Client.Execute<dynamic>(Request);
    }
}
}
