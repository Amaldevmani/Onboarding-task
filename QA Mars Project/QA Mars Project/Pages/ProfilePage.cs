using NUnit.Framework;
using OpenQA.Selenium;
using QA_Mars_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Mars_Project.Pages
{
    public class ProfilePage
    {
        Wait waitObj = new Wait();
        public void GoToProfilePage(IWebDriver driver)
        {
            //navigate to Profile page
            IWebElement profileTab = driver.FindElement(By.XPath("//a[text()='Profile']"));
            profileTab.Click();
        }

        public void UpdateProfileName(IWebDriver driver)
        {
            //edit name
            IWebElement nameDownArrow = driver.FindElement(By.XPath("//div[@class='title']//i[@class='dropdown icon']"));
            nameDownArrow.Click();
            IWebElement firstName = driver.FindElement(By.Name("firstName"));
            firstName.Click();
            firstName.Clear();
            firstName.SendKeys("Test");
            IWebElement lastName = driver.FindElement(By.Name("lastName"));
            lastName.Click();
            lastName.Clear();
            lastName.SendKeys("Name");
            IWebElement saveButton = driver.FindElement(By.XPath("//*[text()='Save']"));
            saveButton.Click();
            waitObj.WaitForAjax(driver);
            Console.WriteLine("Profile name updated");
        }

        public void AddAvailability(IWebDriver driver)
        {
            IWebElement availabilityWriteIcon = driver.FindElement(By.XPath("//div[@class='extra content']//div//div[2]//i[contains(@class,'write icon')]"));
            availabilityWriteIcon.Click();
            IWebElement availabiltyValue = driver.FindElement(By.XPath("//select//option[text()='Part Time']"));
            availabiltyValue.Click();
            Console.WriteLine("Availability added");
        }

        public void AddHours(IWebDriver driver)
        {
            IWebElement hoursWriteIcon = driver.FindElement(By.XPath("//div[@class='extra content']//div//div[3]//i[contains(@class,'write icon')]"));
            hoursWriteIcon.Click();
            IWebElement hoursValue = driver.FindElement(By.XPath("//select//option[text()='As needed']"));
            hoursValue.Click();
            Console.WriteLine("Hours added");
        }

        public void AddEarnTarget(IWebDriver driver)
        {
            IWebElement earnTargetWriteIcon = driver.FindElement(By.XPath("//div[@class='extra content']//div//div[4]//i[contains(@class,'write icon')]"));
            earnTargetWriteIcon.Click();
            IWebElement earnTargetValue = driver.FindElement(By.XPath("//select//option[text()='More than $1000 per month']"));
            earnTargetValue.Click();
            Console.WriteLine("Earn Target added");
        }

        public void ProfileUserDetailsSuccessfullyUpdated(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            IWebElement titleHolder = driver.FindElement(By.XPath("//div[@class='title']"));
            string titleValue = titleHolder.GetAttribute("innerText");

            if (titleValue == "Test Name")
            {
                Console.WriteLine("Profile Name updated successfully");
            }
            IWebElement PartTimeAvailability = driver.FindElement(By.XPath("//span[text()='Part Time']"));
            if(PartTimeAvailability.Displayed)
            {
                Console.WriteLine("Availability updated to PartTime successfully");
            }
            IWebElement asNeededHours = driver.FindElement(By.XPath("//span[text()='As needed']"));
            if (asNeededHours.Displayed)
            {
                Console.WriteLine("Hours updated to As Needed successfully");
            }
            IWebElement MoreThanET = driver.FindElement(By.XPath("//span[text()='More than $1000 per month']"));
            if (MoreThanET.Displayed)
            {
                Console.WriteLine("Earn Target updated to More than $1000 per month successfully");
            }
        }
    }

    
}

