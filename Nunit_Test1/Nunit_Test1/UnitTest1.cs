using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Nunit_Test1
{
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            driver.Url = "https://www.google.com/";            
        }

        [Test]
        public void TestMethod2()
        {
            driver.Url = "https://www.google.com/";
        }
    }
}
