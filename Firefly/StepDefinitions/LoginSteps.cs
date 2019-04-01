using System;
using Firefly.PageObjects;
using Firefly.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Firefly.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        //I declare pageobject page below
        LoginPage Login;
        //I created constructor which is the name of the class steps
        public LoginSteps()
        {
            //Instantiate the page object below and we call the Login
            Login = new LoginPage();
        }



        [Given(@"I Navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            //for this step to navigate, I need a driver to navigate it and maximize
            Hooks.Driver.Navigate().GoToUrl("https://cloud-regression.fireflysolutions.co.uk");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I enter  username")]
        public void WhenIEnterUsername()
        {
            Login.Enterusername("sstudent");
        }
        
        [When(@"I enter  password")]
        public void WhenIEnterPassword()
        {
            Login.Enterpassword("Sp!tf1re");
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            Login.Clicklogin();
        }
        
        [When(@"I click on set personal task")]
        public void WhenIClickOnSetPersonalTask()
        {
            Login.ClicksetPersonalTask();
        }

        [Then(@"I able to view set personal task popup box")]
        public void ThenIAbleToViewSetPersonalTaskPopupBox()
        {
            Assert.IsTrue(Login.ContainerDialogisDisplayed());
        }

        [Then(@"I close dialogue box")]
        public void ThenICloseDialogueBox()
        {
            Login.ClickcloseDialogueBox();
        }

        [Then(@"I click user image")]
        public void ThenIClickUserImage()
        {
            Login.ClickuserImage();
        }

        [Then(@"I click on log out")]
        public void ThenIClickOnLogOut()
        {
            Hooks.Driver.Navigate().GoToUrl("https://cloud-regression.fireflysolutions.co.uk/logout");
        }

        
        
    }
}
