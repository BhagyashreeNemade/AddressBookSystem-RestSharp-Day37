using AddressBookSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
namespace MSTestForRestApiOperations
{
    [TestClass]
    public class TestRestOperations
    {
        RestClient client;

        [TestInitialize]
        public void Setup()
        {
            client = new RestClient("http://localhost:4000");
        }

        /// <summary>
        /// UC1
        /// Tests the retrieving data function using get operation.
        /// </summary>
        [TestMethod]
        public void TestRetrievingDataUsingGetOperation()
        {
            RestRequest request = new RestRequest("/contacts", Method.GET);
            IRestResponse response = client.Execute(request);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            List<ContactInfo> dataResponse = JsonConvert.DeserializeObject<List<ContactInfo>>(response.Content);
            Assert.AreEqual(3, dataResponse.Count);
        }
    }
}