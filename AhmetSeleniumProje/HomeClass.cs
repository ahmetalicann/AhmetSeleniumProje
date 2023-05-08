using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

    }
}
