using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace testPO9
{
    public partial class Form1 : Form
    {

        IWebDriver ChromeBrowser;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChromeBrowser = new OpenQA.Selenium.Chrome.ChromeDriver();
            ChromeBrowser.Manage().Window.Maximize();
            ChromeBrowser.Navigate().GoToUrl("https://mangalib.me/");
            IWebElement searchButton = ChromeBrowser.FindElement(By.XPath("//*[@id='site_type']/body/div[2]/div/div[2]/div/div[1]/span"));
            searchButton.Click();
            searchButton = ChromeBrowser.FindElement(By.XPath("//*[@id='tippy-2']/div/div/div/a[8]"));
            searchButton.Click();

        }
    }
}
//*[@id="tippy-2"]/div/div/div/a[8]

//*[@id="site_type"]/body/div[2]/div/div[2]/div/div[1]/span