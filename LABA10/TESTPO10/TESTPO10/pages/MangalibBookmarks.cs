using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace TESTPO10.pages
{
    class MangalibBookmarks
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]")]
        public IWebElement AllBookmarks { get; set; }
    }
}
