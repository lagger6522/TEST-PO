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
    public class GettingListOfMangaSortedByDateOfAdditionTest
    {
        [Test]
        public void GettingListOfMangaSortedByDateOfAddition()
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
            mangalibCatalogPage.SortCatalog.Click();
            mangalibCatalogPage.SortCatalogByDate.Click();
            closeBrowser.CloseBrows();
        }

    }
}
