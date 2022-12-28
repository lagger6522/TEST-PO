using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Pages;
using TESTPOLAST.Steps;
using TESTPOLAST.Utils;

namespace TESTPOLAST.AllTestsMangalib
{
    public class MangaOfAgeСategoryTest
    {
        [Test]
        public void MangaOfAgeСategory() 
        {

            CommonConditional commonConditional = new CommonConditional();
            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            CloseBrowser closeBrowser = new CloseBrowser();
            commonConditional.Setup();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.Catalog.Click();
            mangalibMainPage.CatalogAll.Click();
            MangalibCatalogPage mangalibCatalogPage = new MangalibCatalogPage();
            PageFactory.InitElements(commonConditional.driver, mangalibCatalogPage);
            mangalibCatalogPage.AgeRating18Plus.Click();
            mangalibCatalogPage.ShowCatalog.Click();

            closeBrowser.CloseBrows();

        }
    }
}
