using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Autotests
{
    public class Registration_Page
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        public Registration_Page(AppiumDriver<AndroidElement> webDriver)
            {
               _driver = webDriver;
            }
        [FindsBy(How = How.Id, Using = "")]
        private AndroidElement searchText;

        public Registration_Page Search(string text)
        {
            searchText.SendKeys(text);
            return this;    
        }
    }
}
