using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firefly.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Firefly.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            //Im using Pagefactory so that I can use annotations to find element and to initialise
            PageFactory.InitElements(Hooks.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement userName { get; set; }

        //create a corresponding method below
        public void Enterusername(string usernametext)
        {
            userName.SendKeys(usernametext);
        }
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passWord { get; set; }

        public void Enterpassword(string passwordtext)
        {
            passWord.SendKeys(passwordtext);
        }
        [FindsBy(How = How.ClassName, Using = "ff-login-submit")]
        private IWebElement login { get; set; }

        public void Clicklogin()
        {
            login.Click();
        }
        [FindsBy(How = How.CssSelector, Using = "span.item__text__18PfR:nth-child(1)")]
        private IWebElement setPersonalTask { get; set; }

        public void ClicksetPersonalTask()
        {
            setPersonalTask.Click();
        }

        [FindsBy(How = How.CssSelector, Using = ".ff_container-dialog__body")]
        private IWebElement Containerdialog { get; set; }

        public bool ContainerDialogisDisplayed()

        {
            try
            {
                return Containerdialog.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }



        }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div[11]/div/div/div/h3/button")]
        private IWebElement closeDialogueBox { get; set; }

        public void ClickcloseDialogueBox()
        {
            closeDialogueBox.Click();
        }

        [FindsBy(How = How.ClassName, Using = ".item__text--user__xi2eJ")]
        private IWebElement userImage { get; set; }

        public void ClickuserImage()
        {
            userImage.Click();
        }

        

        







    }
}
