using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3_testing_binaryjazz.Steps
{
    [Binding]
    public class GenerateStoryTest
    {
        private RestClient client = new RestClient("https://binaryjazz.us/wp-json/genrenator/v1/");
        private RestRequest request;
        private IRestResponse response;
        private int id = (new Random()).Next(50);

        [When(@"send Generate story request")]
        public void WhenSendGenerateStoryRequest()
        {
            request = new RestRequest($"/story/{id}", Method.GET);
            response = client.Execute(request);
        }
        
        [Then(@"story is succussfully generated")]
        public void ThenStoryIsSuccussfullyGenerated()
        {
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
