using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace TESTPO10.pages
{
    class MangalibMain
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[2]/div/div[2]/div/div[1]/span")]
        public IWebElement Catalog { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='tippy-2']/div/div/div/a[8]")]
        public IWebElement CatalogAll { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[2]/div/div[3]/a[1]")]
        public IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[2]/div/div[3]/div[3]/img")]
        public IWebElement IconProfile { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='tippy-6']/div/div/div/a[2]")]
        public IWebElement MyBookmarks { get; set; }

    }
}
