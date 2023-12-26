using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.WebRequestMethods;

namespace testsite
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [TestCase]
        public void Authorization()
        {
            driver.Url = "https://netology.ru/development";
            IWebElement buttonAuth = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[1]/header/div[1]/div[3]/a")); 
            buttonAuth.Click();
            IWebElement email = driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div[2]/div[2]/div[2]/div/form/div[1]/input"));
            email.SendKeys("matveyloh@mail.ru");
            IWebElement password = driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div[2]/div[2]/div[2]/div/form/div[3]/input"));
            password.SendKeys("123123");
            IWebElement sendButton = driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div[2]/div[2]/div[2]/div/form/button"));
            sendButton.Click();
        }
        [TestCase]
        public void Search()
        {
            driver.Url = "https://netology.ru/development";
            IWebElement search = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[3]/div[2]/div/div[2]/div[2]/form/div/input"));
            search.SendKeys("WEB");
            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[3]/div[2]/div/div[2]/div[2]/form/button"));
            searchButton.Click();
        }
        [TestCase] 
        public void Catalog()
        {
            driver.Url = "https://netology.ru/development";
            IWebElement catalog = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[1]/header/div[1]/div[2]/div/div[1]"));
            catalog.Click();
        }
        [TestCase]
        public void FreeStudy()
        {
            driver.Url = "https://netology.ru/development";
            IWebElement study = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[1]/header/div[1]/div[2]/div/div[2]/a[1]"));
            study.Click();
        }
        [TestCase]
        public void ProfOrientation()
        {
            driver.Url = "https://netology.ru/development";
            IWebElement prof = driver.FindElement(By.XPath("/html/body/div/div[4]/section/div[3]/div/div[4]/div[1]/a"));
            prof.Click();
        }
    }
}