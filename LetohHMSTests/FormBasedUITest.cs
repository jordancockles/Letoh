﻿using Letoh_HMS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LetohHMSTests
{
    
    
    /// <summary>
    ///This is a test class for FormBasedUITest and is intended
    ///to contain all FormBasedUITest Unit Tests
    ///</summary>
    [TestClass()]
    public class FormBasedUITest
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
        ///A test for LoadLetohData
        ///</summary>
        [TestMethod]
        public void LoadLetohDataTestUnsuccessful()
        {
            LoadFileUnsuccessful lfu = new LoadFileUnsuccessful();        
            FormBasedUI target = new FormBasedUI(null,null,null,null); 
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = lfu.success();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoadLetohDataSuccessful()
        {
            LoadFileSuccess lfs = new LoadFileSuccess();
            FormBasedUI target = new FormBasedUI(null, null, null, null);
            bool expected = true;
            bool actual;
            actual = lfs.success();
            Assert.AreEqual(expected, actual);
        }
    }
}
