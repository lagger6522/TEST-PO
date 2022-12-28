using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTPOLAST.Pages
{
    public class MangalibCatalogPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div[1]/div/div[1]")]
        public IWebElement Ganre { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[3]/div[3]/div[2]/div/div[2]")]
        public IWebElement GanreOfComedy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div[1]/div/div[2]")]
        public IWebElement Tags { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[2]/div[3]/div[4]/div/div[58]/span[2]")]                                         
        public IWebElement TagsOfMonstergirl { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[2]/div[3]/div[4]/div/div[58]/span[2]")]
        public IWebElement СhooseOfComedy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[2]/div[4]")]
        public IWebElement СhooseTags { get; set; } 

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div[1]/div/div[6]/div[2]/div[3]")]
        public IWebElement AgeRating18Plus { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[2]/div[1]/div[2]/button[2]")]
        public IWebElement ShowCatalog { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-page']/div/div/div[1]/div[1]/div/div/button/span")]
        public IWebElement SortCatalog { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='tippy-5']/div/div/div/label[4]/span[2]")]
        public IWebElement SortCatalogByDate { get; set; }

        




    }
}
