using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Firefly.Utilities
{
    [Binding]
    public  class Hooks
    {
        //I instantiate/declare the driver below,make it static so that I can use it anywhere
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //so I use the driver to call our chromedriver
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
