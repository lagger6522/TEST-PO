using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Driver;
using TESTPOLAST.Utils;
using TESTPOLAST.model;
using TESTPOLAST.service;
using TESTPOLAST.Steps;
using TESTPOLAST.Pages;

namespace TESTPOLAST.AllTestsMangalib
{
    public class AllBookmarksTest
    {
        [Test]
        public void AllBookmarks()
        {
            CommonConditional commonConditional = new CommonConditional();
            CloseBrowser closeBrowser = new CloseBrowser();
            AllBookmarks allBookmarks = new AllBookmarks();
            Login login = new Login();
            commonConditional.Setup();        
            login.Log();
            allBookmarks.AllBookmarksStep();
            closeBrowser.CloseBrows();
        }
    }
}
