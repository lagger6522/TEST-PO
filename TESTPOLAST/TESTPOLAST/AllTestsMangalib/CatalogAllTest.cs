using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Driver;
using TESTPOLAST.Steps;
using TESTPOLAST.Utils;

namespace TESTPOLAST.AllTestsMangalib
{
    public class CatalogAllTest
    {
        [Test]
        public void CatalogAll()
        {
            CommonConditional commonConditional = new CommonConditional();
            CatalogAll catalogAll = new CatalogAll();
            CloseBrowser closeBrowser = new CloseBrowser();
            commonConditional.Setup();
            catalogAll.CatalogAl();
            closeBrowser.CloseBrows();
        }
    }
}
