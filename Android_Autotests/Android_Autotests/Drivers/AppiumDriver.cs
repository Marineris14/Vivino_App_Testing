using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Autotests.Drivers
{
    class AppiumDriver
    {
        AppiumDriver<AndroidElement> _driver;

        public AppiumDriver<AndroidElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Samsung Galaxy S7");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "Appium");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Marina\\Downloads\\vivino.web.app_8.20.10_8201099.apk");
            // start server
            var appiumService = new AppiumServiceBuilder()
                .WithIPAddress("127.0.0.1")
                .UsingAnyFreePort()
                .Build();
            if(!appiumService.IsRunning)
            {
                appiumService.Start();
            }
            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(180));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}
