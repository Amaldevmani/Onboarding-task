using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA_Mars_Project.Pages;
using TechTalk.SpecFlow;

namespace QA_Mars_Project.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void LoginActions()
        {
            driver = new ChromeDriver();            
        }

        [AfterScenario]
        public void ClosetestRun()
        {
            driver.Close();
        }
    }
}
