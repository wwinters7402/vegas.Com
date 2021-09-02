using System;
using TechTalk.SpecFlow;
using System.IO;

namespace vegas.Com.FeatureFiles
{
   [Binding]
    public class LogInSteps
    {

        //Step defininitions
        [Given(@"I launch chrome browser")]
        public void GivenILaunchChromeBrowser()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I navigate to vegas\.com")]
        public void GivenINavigateToVegas_Com()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I click on the sign in button")]
        public void ThenIClickOnTheSignInButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I enter my passwored and user name")]
        public void ThenIEnterMyPassworedAndUserName()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I click on the second sign in button")]
        public void ThenIClickOnTheSecondSignInButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify I am signed in\.")]
        public void ThenIVerifyIAmSignedIn_()
        {
            ScenarioContext.Current.Pending();
        }

        

    }
}
