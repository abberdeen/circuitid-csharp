/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.16
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
    ///  Class for testing MessageCampaignsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MessageCampaignsApiTests
    {
        private MessageCampaignsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessageCampaignsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessageCampaignsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' MessageCampaignsApi
            //Assert.IsInstanceOf(typeof(MessageCampaignsApi), instance);
        }

        
        /// <summary>
        /// Test CreateMessageCampaign
        /// </summary>
        [Test]
        public void CreateMessageCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Messagecampaigns messagecampaigns = null;
            //var response = instance.CreateMessageCampaign(messagecampaigns);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test FindMessageCampaigns
        /// </summary>
        [Test]
        public void FindMessageCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object search = null;
            //Object limit = null;
            //Object skip = null;
            //Object sort = null;
            //Object select = null;
            //Object or = null;
            //Object and = null;
            //var response = instance.FindMessageCampaigns(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindMessageCampaigns200Response), response, "response is FindMessageCampaigns200Response");
        }
        
        /// <summary>
        /// Test GetMessageCampaign
        /// </summary>
        [Test]
        public void GetMessageCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.GetMessageCampaign(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test PatchMessageCampaign
        /// </summary>
        [Test]
        public void PatchMessageCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //Messagecampaigns messagecampaigns = null;
            //var response = instance.PatchMessageCampaign(id, messagecampaigns);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveMessageCampaign
        /// </summary>
        [Test]
        public void RemoveMessageCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.RemoveMessageCampaign(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}
