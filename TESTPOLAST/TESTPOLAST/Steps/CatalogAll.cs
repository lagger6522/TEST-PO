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
    public class CatalogAll
    {
        public void CatalogAl()
        {
            CommonConditional commonConditional = new CommonConditional();
            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.Catalog.Click();
            mangalibMainPage.CatalogAll.Click();
        }
    }
}
