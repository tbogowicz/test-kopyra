using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application\");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://blog.kopyra.com/";
            driver.FindElement(By.ClassName("age-gate-submit-yes")).Click();
            Assert.Pass();
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}