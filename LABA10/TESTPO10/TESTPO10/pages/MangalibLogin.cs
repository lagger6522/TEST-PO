using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace TESTPO10.pages
{
    class MangalibLogin
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[2]/div/input")]
        public IWebElement LoginInput { get; set; }
                [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[3]/div/input")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[2]/div[1]/form/div[5]/button")]
        public IWebElement ButtonEnter { get; set; }
    }
}
