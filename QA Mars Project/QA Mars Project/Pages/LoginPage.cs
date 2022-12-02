using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA_Mars_Project.Utilities;

namespace QA_Mars_Project.Pages
{
    public class LoginPage
    {
        Wait waitObj = new Wait();
        public void Loginsteps(IWebDriver driver)
        {
            // navigate to the Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            //Thread.Sleep(1000);
            // click on sign in
            IWebElement signInButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            signInButton.Click();
            // identify username text box and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
            usernameTextbox.SendKeys("amaldevmani@yahoo.com");
            // identify password text box and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Project@1");
            // identify login button and click on it
            IWebElement logginbutton = driver.FindElement(By.XPath("//button[text()='Login']"));
            logginbutton.Click();
            waitObj.WaitToExist(driver, "XPath", "//a[text()='Profile']", 20);
            Console.WriteLine("User logged in successfully");
        }
    }
}

