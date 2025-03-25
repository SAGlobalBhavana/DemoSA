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
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            
            driver.Close();
        }
       

    }
}
