using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AhmetSeleniumProje
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait wait;


        [SetUp]
        public void tarayiciAc()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Sayfanın yüklenmesi için(Tüm sayfa yüklenmeden işleme devam etmez)
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
            //Üzerinde işlem yapılacak element
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.trendyol.com");
        }

        [TearDown]
        public void tarayiciKapat()
        {
            driver.Quit();
        }

        //CSS ile seçilen elementin sayfada görünür olmasını bekler
        public void waitCssElement(string elementCss)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(elementCss)));
        }

        //Id ile seçilen elementin sayfada görünür olmasını bekler
        public void waitIdElement(string elementId)
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(elementId)));
        }

        //Xpath ile seçilen elementin sayfada görünür olmasını bekler
        public void waitXpathElement(string elementxPath)
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(elementxPath)));
        }

        //Belirlenen Textin , CSS ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitCssText(string elementCss, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.Id(elementCss), elementText));
        }


        //Belirlenen Textin , Id ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitIdText(string elementId, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.Id(elementId), elementText));
        }

        //Belirlenen Textin , CSS ile seçilen element içerisinde string olarak varolmasını bekler
        public void waitXpathText(string elementXpath, string elementText)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath(elementXpath), elementText));
        }



    }
}
