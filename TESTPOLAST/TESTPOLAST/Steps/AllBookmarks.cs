using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Pages;
using TESTPOLAST.Utils;

namespace TESTPOLAST.Steps
{
    public class AllBookmarks
    {
        public void AllBookmarksStep()
        {
            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            CommonConditional commonConditional = new CommonConditional();
            MangalibMyBookmarksPage mangalibBookmarksPage = new MangalibMyBookmarksPage();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.IconProfile.Click();
            mangalibMainPage.MyBookmarks.Click();
            PageFactory.InitElements(commonConditional.driver, mangalibBookmarksPage);
            mangalibBookmarksPage.AllBookmarks.Click();
        }

    }
}
