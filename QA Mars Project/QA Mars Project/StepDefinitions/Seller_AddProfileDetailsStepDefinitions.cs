using System;
using TechTalk.SpecFlow;
using QA_Mars_Project.Pages;
using QA_Mars_Project.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QA_Mars_Project.StepDefinitions
{
    [Binding]
    public class Seller_AddProfileDetailsStepDefinitions :  CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"User is logged into Mars application successfully")]
        public void GivenUserIsLoggedIntoMarsApplicationSuccessfully()
        {
           loginPageObj.Loginsteps(driver);            
        }

        [When(@"User navigate to profile page")]
        public void WhenUserNavigateToProfilePage()
        {
            profilePageObj.GoToProfilePage(driver);
        }

        [When(@"User update the profile name, availability, hours and earn target")]
        public void WhenUserUpdateTheProfileNameAvailabilityHoursAndEarnTarget()
        {
            profilePageObj.UpdateProfileName(driver);
            profilePageObj.AddAvailability(driver);
            profilePageObj.AddHours(driver);
            profilePageObj.AddEarnTarget(driver);
        }
    
        [Then(@"the profile should be updated successfully")]
        public void ThenTheProfileShouldBeUpdatedSuccessfully()
        {
            profilePageObj.ProfileUserDetailsSuccessfullyUpdated(driver);
        }

        [When(@"User update the description")]
        public void WhenUserUpdateTheDescription()
        {
            profilePageObj.AddDescription(driver);
        }

        [Then(@"the profile description should be updated successfully")]
        public void ThenTheProfileDescriptionShouldBeUpdatedSuccessfully()
        {
            profilePageObj.ProfileDiscriptionSuccessfullyUpdated(driver);
        }

        [When(@"User update the languages")]
        public void WhenUserUpdateTheLanguages()
        {
            profilePageObj.AddLanguage(driver);
        }
        
        [Then(@"the profile language should be updated successfully")]
        public void ThenTheProfileLanguageShouldBeUpdatedSuccessfully()
        {
            profilePageObj.ProfileLanguageSuccessfullyUpdated(driver);
        }

    }
}
