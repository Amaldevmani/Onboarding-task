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
            waitObj.WaitForAjax(driver);
            IWebElement availabilityWriteIcon = driver.FindElement(By.XPath("//div[@class='extra content']//div//div[2]//i[contains(@class,'write icon')]"));
            availabilityWriteIcon.Click();
            IWebElement availabiltyValue = driver.FindElement(By.XPath("//select//option[text()='Part Time']"));
            availabiltyValue.Click();
            Console.WriteLine("Availability added");
        }

        public void AddHours(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            IWebElement hoursWriteIcon = driver.FindElement(By.XPath("//div[@class='extra content']//div//div[3]//i[contains(@class,'write icon')]"));
            hoursWriteIcon.Click();
            IWebElement hoursValue = driver.FindElement(By.XPath("//select//option[text()='As needed']"));
            hoursValue.Click();
            Console.WriteLine("Hours added");
        }

        public void AddEarnTarget(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
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
                Console.WriteLine("Profile Name updated successfully -Verified");
            }

            IWebElement partTimeAvailabilityHolder = driver.FindElement(By.XPath("//div[@class='extra content']/div/div[2]/div/span"));
            string availabilityValue = partTimeAvailabilityHolder.GetAttribute("innerText");

            if (availabilityValue.Contains("Part Time"))
            {
                Console.WriteLine("Availability updated to PartTime successfully -Verified");
            }

            IWebElement hoursHolder = driver.FindElement(By.XPath("//div[@class='extra content']/div/div[3]/div/span"));
            string hoursValue = hoursHolder.GetAttribute("innerText");


            if (hoursValue.Contains("As needed"))
            {
                Console.WriteLine("Availability updated to PartTime successfully -Verified");
            }

            IWebElement eTHolder = driver.FindElement(By.XPath("//div[@class='extra content']/div/div[4]/div/span"));
            string eTValue = eTHolder.GetAttribute("innerText");

            if (eTValue.Contains("More than $1000 per month"))
            {
                Console.WriteLine("Earn Target updated to More than $1000 per month successfully -Verified");
            }
        }
        public void AddDescription(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            //Add description
            IWebElement descriptionIcon = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            descriptionIcon.Click();
            IWebElement descriptionBox = driver.FindElement(By.XPath("//div[@class='field  ']//textarea"));
            descriptionBox.Clear();
            descriptionBox.SendKeys("test description");
            driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button")).Click();
            Console.WriteLine("Added profile description");
        }
        public void ProfileDiscriptionSuccessfullyUpdated(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            IWebElement descValue = driver.FindElement(By.XPath("//span[text()='test description']"));
            if (descValue.Displayed)
            {
                Console.WriteLine("Description successfully updated -Verified");
            }
        }

        public void AddLanguage(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            IWebElement languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
            languagesTab.Click();
            IWebElement landAddNew = driver.FindElement(By.XPath("(//div[text()='Add New'])[1]"));
            landAddNew.Click();
            IWebElement langHolder = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            langHolder.Clear();
            langHolder.SendKeys("English");
            //IWebElement ChooseLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            //ChooseLevelDropDown.Click();
            IWebElement FluentLevelOption = driver.FindElement(By.XPath("//select//option[@value='Fluent']"));
            FluentLevelOption.Click();
            IWebElement AddButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            AddButton.Click();
            Console.WriteLine("Language added");
        }

        public void ProfileLanguageSuccessfullyUpdated(IWebDriver driver)
        {
            waitObj.WaitForAjax(driver);
            IWebElement langInfo = driver.FindElement(By.XPath("//td[text()='English']//following-sibling::td[text()='Fluent']"));
            if (langInfo.Displayed)
            {
                Console.WriteLine("Language successfully updated -Verified");
            }
        }
    }
}

