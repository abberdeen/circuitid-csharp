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
    ///  Class for testing ConversationMessagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConversationMessagesApiTests
    {
        private ConversationMessagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationMessagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConversationMessagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ConversationMessagesApi
            //Assert.IsInstanceOf(typeof(ConversationMessagesApi), instance);
        }

        
        /// <summary>
        /// Test CreateConversationMessage
        /// </summary>
        [Test]
        public void CreateConversationMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Conversationmessages conversationmessages = null;
            //var response = instance.CreateConversationMessage(conversationmessages);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test FindConversationMessages
        /// </summary>
        [Test]
        public void FindConversationMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object search = null;
            //Object limit = null;
            //Object skip = null;
            //Object sort = null;
            //Object select = null;
            //Object or = null;
            //Object and = null;
            //var response = instance.FindConversationMessages(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindConversationMessages200Response), response, "response is FindConversationMessages200Response");
        }
        
        /// <summary>
        /// Test GetConversationMessage
        /// </summary>
        [Test]
        public void GetConversationMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.GetConversationMessage(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test PatchConversationMessage
        /// </summary>
        [Test]
        public void PatchConversationMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //Conversationmessages conversationmessages = null;
            //var response = instance.PatchConversationMessage(id, conversationmessages);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveConversationMessage
        /// </summary>
        [Test]
        public void RemoveConversationMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.RemoveConversationMessage(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}
