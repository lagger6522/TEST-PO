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
    public class GettingListOfMangaWithSpecificTagsTest
    {
        [Test]
        public void GettingListOfMangaWithSpecificTags()
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
            mangalibCatalogPage.Tags.Click();
            Thread.Sleep(2000);
            mangalibCatalogPage.TagsOfMonstergirl.Click();
            mangalibCatalogPage.СhooseTags.Click();
            closeBrowser.CloseBrows();
        }
    }
}
