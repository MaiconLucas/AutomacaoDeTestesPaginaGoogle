using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;

namespace ConcertDesafioPratico
{
    public class Tests
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars {get; private set;}
        private IJavaScriptExecutor js;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void googleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).SendKeys("concert technologies");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.Pass();
        }

        [Test]
        public void googleImLucky()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector("center:nth-child(1) > .RNmpXc")).Click();
        }

        [Test]
        public void googleAbout()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Sobre")).Click();
        }

        [Test]
        public void googleDarkModeTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.CssSelector(".tFYjZe > div:nth-child(1)")).Click();
        }

        [Test]
        public void googlePublicity()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Publicidade")).Click();
        }

        [Test]
        public void googleTerms()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Termos")).Click();
        }

        [Test]
        public void googleSetingsSearches()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.LinkText("Configurações de Pesquisa")).Click();
        }

        [Test]
        public void googleSearchWork()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Como funciona a Pesquisa")).Click();
        }

        [Test]
        public void googleBusiness()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Negócios")).Click();
        }

        [Test]
        public void googleAdvancedSearches()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.LinkText("Pesquisa avançada")).Click();
        }

        [Test]
        public void googleSendFeedback()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.CssSelector(".znKVS > span")).Click();
        }

        [Test]
        public void googleDataSearches()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.LinkText("Seus dados na Pesquisa")).Click();
        }

        [Test]
        public void googleSearchesHistoric()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".ayzqOc")).Click();
            driver.FindElement(By.LinkText("Histórico de pesquisa")).Click();
        }

     
        [Test]
        public void googlePrivacy()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Privacidade")).Click();
        }

        [Test]
        public void googleMenu()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.CssSelector(".gb_0e")).Click();
        }


        [Test]
        public void googleImages()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1051, 674);
            driver.FindElement(By.LinkText("Imagens")).Click();
        }

    }
}
