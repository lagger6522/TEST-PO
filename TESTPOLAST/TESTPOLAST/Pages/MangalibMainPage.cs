using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.model;

namespace TESTPOLAST.Pages
{
    public class MangalibMainPage
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

        [FindsBy(How = How.XPath, Using = "//*[@id='search-link']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[1]/input")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[1]/div[1]")]
        public IWebElement Searching { get; set; }
                                            
        [FindsBy(How = How.XPath, Using = "//*[@id='site_type']/body/div[1]/div/div/div[3]")]
        public IWebElement ResultSearchingClick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[1]/div/section[1]/div/a")]
        public IWebElement AllNews { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div[2]/div[7]/h2/a")]
        public IWebElement TransferTitle { get; set; }

    }
}
