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
    public class AddMangaInReadlingTest
    {
        [Test]
        public void AddMangaInReadling()
        {
            CommonConditional commonConditional = new CommonConditional();
            CloseBrowser closeBrowser = new CloseBrowser();
            AllBookmarks allBookmarks = new AllBookmarks();
            Login login = new Login();
            commonConditional.Setup();
            login.Log();

            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.SearchButton.Click();
            
            mangalibMainPage.SearchInput.SendKeys("Контракт душ");
            mangalibMainPage.Searching.Click(); 
            //
            closeBrowser.CloseBrows();
        }

    }
}
