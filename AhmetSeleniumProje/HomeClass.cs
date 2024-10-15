using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AhmetSeleniumProje
{
    public class HomeClass:BaseTest
    {
        public void findId(string elementId)
        {
            driver.FindElement(By.Id(elementId)).Click();
        }

        public void sendId(string elementId, string sendText)
        {
            driver.FindElement(By.Id(elementId)).SendKeys(sendText);
        }
        public void findCSS(string elementCss)
        {
            driver.FindElement(By.CssSelector(elementCss)).Click();
        }
        public void sendCSS(string elementCss, string sendText)
        {
            driver.FindElement(By.CssSelector(elementCss)).SendKeys(sendText);
        }
        public void findXpath(string elementXpath)
        {
            driver.FindElement(By.XPath(elementXpath)).Click();
        }
        public void sendXpath(string elementXpath, string sendText)
        {
            driver.FindElement(By.XPath(elementXpath)).SendKeys(sendText);
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
