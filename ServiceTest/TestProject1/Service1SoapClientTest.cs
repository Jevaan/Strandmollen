using ServiceTest.WebService1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Data;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for Service1SoapClientTest and is intended
    ///to contain all Service1SoapClientTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Service1SoapClientTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for HelloWorld
        ///</summary>
        [TestMethod()]
        public void HelloWorldTest()
        {
            Service1SoapClient target = new Service1SoapClient(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.HelloWorld();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetData
        ///</summary>
        [TestMethod()]
        public void GetDataTest()
        {
            Service1SoapClient target = new Service1SoapClient(); // TODO: Initialize to an appropriate value
            DataSet expected = null; // TODO: Initialize to an appropriate value
            DataSet actual;
            actual = target.GetData();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Service1SoapClient Constructor
        ///</summary>
        [TestMethod()]
        public void Service1SoapClientConstructorTest4()
        {
            string endpointConfigurationName = string.Empty; // TODO: Initialize to an appropriate value
            Service1SoapClient target = new Service1SoapClient(endpointConfigurationName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Service1SoapClient Constructor
        ///</summary>
        [TestMethod()]
        public void Service1SoapClientConstructorTest3()
        {
            Service1SoapClient target = new Service1SoapClient();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Service1SoapClient Constructor
        ///</summary>
        [TestMethod()]
        public void Service1SoapClientConstructorTest2()
        {
            string endpointConfigurationName = string.Empty; // TODO: Initialize to an appropriate value
            string remoteAddress = string.Empty; // TODO: Initialize to an appropriate value
            Service1SoapClient target = new Service1SoapClient(endpointConfigurationName, remoteAddress);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Service1SoapClient Constructor
        ///</summary>
        [TestMethod()]
        public void Service1SoapClientConstructorTest1()
        {
            Binding binding = null; // TODO: Initialize to an appropriate value
            EndpointAddress remoteAddress = null; // TODO: Initialize to an appropriate value
            Service1SoapClient target = new Service1SoapClient(binding, remoteAddress);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Service1SoapClient Constructor
        ///</summary>
        [TestMethod()]
        public void Service1SoapClientConstructorTest()
        {
            string endpointConfigurationName = string.Empty; // TODO: Initialize to an appropriate value
            EndpointAddress remoteAddress = null; // TODO: Initialize to an appropriate value
            Service1SoapClient target = new Service1SoapClient(endpointConfigurationName, remoteAddress);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
