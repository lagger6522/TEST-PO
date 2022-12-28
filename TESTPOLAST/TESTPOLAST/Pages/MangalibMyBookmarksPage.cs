using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTPOLAST.Pages
{
    public class MangalibMyBookmarksPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]")]
        public IWebElement AllBookmarks { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[2]/div[4]/div[13]/div/div[2]/div[1]/div[1]")]
        public IWebElement TitleOfTheMangaFromList { get; set; }



        //*[@id="main-page"]/div/div/div[2]/div/div[4]/div[30]
        //*[@id="main-page"]/div/div/div[2]/div/div[4]/div[30]/div/div[2]/div[1]/div[1]/a
        //*[@id="main-page"]/div/div/div[2]/div/div[4]/div[30]/div/div[2]/div[1]/div[1]/a/span[1]
        //*[@id="main-page"]/div/div/div[2]/div[2]/div[4]/div[30]/div/div[2]/div[1]/div[1]/a
        //*[@id="main-page"]/div/div/div[2]/div[2]/div[4]/div[13]/div/div[2]/div[1]/div[1]/a
    }
}
