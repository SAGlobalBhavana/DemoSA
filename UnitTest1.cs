using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoSA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Navigate()
        {
            // Initialising the driver
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name=\"email\"]")).SendKeys("BhavanaaR@saglobal.com");
            driver.FindElement(By.XPath("//input[@name=\"pass\"]")).SendKeys("****");
            driver.FindElement(By.XPath("//input[@name=\"Submit\"]")).Click();
            
            // Close the driver
            driver.Close();
        }
    }
}
