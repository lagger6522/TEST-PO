using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTPOLAST.model;
using TESTPOLAST.Pages;
using TESTPOLAST.Utils;
using TESTPOLAST.model;

namespace TESTPOLAST.Steps
{
    public class Login
    {
        public void Log()
        {
            CommonConditional commonConditional = new CommonConditional();
            MangalibMainPage mangalibMainPage = new MangalibMainPage();
            MangalibLoginPage mangalibLoginPage = new MangalibLoginPage();
            PageFactory.InitElements(commonConditional.driver, mangalibMainPage);
            mangalibMainPage.LoginButton.Click();
            PageFactory.InitElements(commonConditional.driver, mangalibLoginPage);
            mangalibLoginPage.LoginInput.SendKeys("shulyak.1975@bk.ru");
            mangalibLoginPage.PasswordInput.SendKeys("123452");
            mangalibLoginPage.ButtonEnter.Click();
        }
    }
}
