/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.15
 * Contact: support@circuitid.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.CircuitID.Client;
using Com.CircuitID.Api;
using Com.CircuitID.Models;

namespace Com.CircuitID.Test
{
    /// <summary>
    ///  Class for testing ServersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ServersApiTests
    {
        private ServersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ServersApi
            //Assert.IsInstanceOf(typeof(ServersApi), instance);
        }

        
        /// <summary>
        /// Test CreateServer
        /// </summary>
        [Test]
        public void CreateServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Servers servers = null;
            //var response = instance.CreateServer(servers);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test FindServers
        /// </summary>
        [Test]
        public void FindServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object search = null;
            //Object limit = null;
            //Object skip = null;
            //Object sort = null;
            //Object select = null;
            //Object or = null;
            //Object and = null;
            //var response = instance.FindServers(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindServers200Response), response, "response is FindServers200Response");
        }
        
        /// <summary>
        /// Test GetServer
        /// </summary>
        [Test]
        public void GetServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.GetServer(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test PatchServer
        /// </summary>
        [Test]
        public void PatchServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //Servers servers = null;
            //var response = instance.PatchServer(id, servers);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveServer
        /// </summary>
        [Test]
        public void RemoveServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.RemoveServer(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}