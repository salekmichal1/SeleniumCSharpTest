// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
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

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethodOne()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

            // zamykanie okna z plikami cookie, dostostoawnie do nowego fb
            IWebElement closeCookie = driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _al66 _4jy3 _4jy1 selected _51sy']"));
            closeCookie.Click();
            System.Threading.Thread.Sleep(1000);

            // otwierania modala z rejstracją cookie, dostostoawnie do nowego fb
            IWebElement createAccountBtn = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            createAccountBtn.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement monthDropList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("2");
        }

        [Test, Category("Regression Testing")]
        public void TestMethodTwo()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethodThree()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
    }
}
