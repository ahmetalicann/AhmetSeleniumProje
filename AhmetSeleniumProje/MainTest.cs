using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Compatibility;
using NUnit;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace AhmetSeleniumProje
{
    [TestFixture]
    public class MainTest:HomeClass
    {
        [Test]
        public void LoginTest()
        {

            findCSS("div.modal-close");
            findId("onetrust-accept-btn-handler");
            findCSS("div.link.account-user");
            sendId("login-email", "ahmet");
            sendId("login-password-input", "testsifre");
            findXpath("//html/body/div[1]/div[3]/div[3]/div[1]/form/button");
            Thread.Sleep(2000);

        }

        [Test]
        public void HelpinTest()
        {
            findCSS("div.modal-close");
            findId("onetrust-accept-btn-handler");
            findXpath("//div[@id='headerMain']/div/div/ul/li[3]/a");
            Thread.Sleep(2000);
            findCSS("div.layout-wrapper>div:nth-of-type(13)>span");
            Thread.Sleep(2000);
        }

        [Test]
        public void Deneme()
        {
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            ////WebDriverWait Visibility: belirlenen element sayfada görünene kadar belirlenen süre doğrultusunda bekler.
            ////Aynı şekilde bir element silindiğinde yada yok olması gerektiğinde emin olmak için InVisiblity kullanılacak.
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("div.modal-close")));
            ////WebDriverWait Presence: belirlenen element sayfa yüklenmesede Html içerisinde var ise devam eder.
            ////wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("div.modal-close")));
            //findCSS("div.modal-close");
            ////Text komutları: element içerisinde belirtilen Text gelene kadar bekler.
            //wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.Id("onetrust-accept-btn-handler"), "KABUL ET"));
            //findId("onetrust-accept-btn-handler");

            waitCssElement("div.modal-close");
            findCSS("div.modal-close");
            waitIdText("onetrust-accept-btn-handler", "KABUL ET");
            findId("onetrust-accept-btn-handler");


        }
    }
}
