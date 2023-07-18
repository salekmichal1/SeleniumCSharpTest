using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Tests1.BaseClass;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using NUnit.Tests1.Utilities;

namespace NUnit.Tests1
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver Driver;

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodOne()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodTwo()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodThree()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodFour()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodFive()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodSix()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodSeven()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodEight()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodNine()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Category("UAT Testing"), Category("ModuleOne")]
        public void TestMethodTen()
        {
            var driver = new BrowserUtility().Init(Driver);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
