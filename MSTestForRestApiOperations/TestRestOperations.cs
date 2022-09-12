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
        /// UC25
        /// Tests the delete data using delete operation.
        /// </summary>
        [TestMethod]
        public void TestDeleteDataUsingDeleteOperation()
        {
            //Arrange
            RestRequest request = new RestRequest("contacts/11", Method.DELETE);
            //Act
            IRestResponse response = client.Execute(request);
            //Assert
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }
    }
}