using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests1
{
    [TestFixture]
    public class SeleniumCSharpTest
    {
        [Test]
        [Author("Michal", "mic@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void TestOne(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch(Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\michal\\source\\repos\\NUnit.Tests1\\NUnit.Tests1\\Screenshot\\Screen.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            return list;
        }

        //[Test]
        //[Author("Michal", "mic@gmail.com")]
        //[Description("Facebook login verify")]
        //public void TestTwo()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";

        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}
    }
}
