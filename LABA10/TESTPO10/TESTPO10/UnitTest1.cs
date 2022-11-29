using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using TESTPO10.pages;
namespace TESTPO10
{
    public class Tests
    {
        IWebDriver ChromeBrowser;

        [SetUp]
        public void Setup()
        {
            ChromeBrowser = new OpenQA.Selenium.Chrome.ChromeDriver();
            ChromeBrowser.Manage().Window.Maximize();
            ChromeBrowser.Navigate().GoToUrl("https://mangalib.me/");     
            
        }

        [Test]
        public void Test1()
        {
            MangalibMain mangalibMain = new MangalibMain();
            PageFactory.InitElements(ChromeBrowser, mangalibMain);
            mangalibMain.Catalog.Click();
            mangalibMain.CatalogAll.Click();
        }
        [Test]
        public void Test2()
        {
            MangalibMain mangalibMain = new MangalibMain();        
            MangalibLogin mangalibLogin = new MangalibLogin();
            MangalibBookmarks mangalibBookmarks = new MangalibBookmarks();
            PageFactory.InitElements(ChromeBrowser, mangalibMain);
            mangalibMain.LoginButton.Click();

            PageFactory.InitElements(ChromeBrowser, mangalibLogin);

            mangalibLogin.LoginInput.Click();
            mangalibLogin.LoginInput.SendKeys("shulyak.1975@bk.ru");

            mangalibLogin.PasswordInput.Click();
            mangalibLogin.PasswordInput.SendKeys("123452");
            mangalibLogin.ButtonEnter.Click();

            PageFactory.InitElements(ChromeBrowser, mangalibMain);
            mangalibMain.IconProfile.Click();
            mangalibMain.MyBookmarks.Click();
            Thread.Sleep(1000);
            PageFactory.InitElements(ChromeBrowser, mangalibBookmarks);
            mangalibBookmarks.AllBookmarks.Click();

        }
    }
}