using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3_testing_binaryjazz.Steps
{
    [Binding]
    public class GenerateGenreTest
    {
        private RestClient client = new RestClient("https://binaryjazz.us/wp-json/genrenator/v1/");
        private RestRequest request;
        private IRestResponse response;

        [When(@"send Generate genre request")]
        public void WhenSendGenerateGenreRequest()
        {
            request = new RestRequest("/genre", Method.GET);
            response = client.Execute(request);
        }
        
        [Then(@"genre is succussfully generated")]
        public void ThenGenreIsSuccussfullyGenerated()
        {
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
