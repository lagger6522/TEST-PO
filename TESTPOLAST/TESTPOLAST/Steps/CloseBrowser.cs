using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.Driver;
using TESTPOLAST.Utils;

namespace TESTPOLAST.Steps
{
    public class CloseBrowser
    {
        public void CloseBrows()
        {
            CommonConditional commonConditional = new CommonConditional();
            commonConditional.logging.logstr = "Test AddBookBiblioTest Success";
            commonConditional.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
