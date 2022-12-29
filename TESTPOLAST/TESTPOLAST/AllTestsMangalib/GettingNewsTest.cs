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
    public class GettingNewsTest
    {
        [Test]
        public void GettingNews()
        {
            CommonConditional commonConditional = new CommonConditional();
            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            CloseBrowser closeBrowser = new CloseBrowser();
            commonConditional.Setup();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.AllNews.Click();
            mangalibMainPage.TransferTitle.Click();
            closeBrowser.CloseBrows();
        }

    }
}
