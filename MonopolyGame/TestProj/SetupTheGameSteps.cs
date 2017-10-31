using System;
using TechTalk.SpecFlow;

namespace TestProj
{
    [Binding]
    public class SetupTheGameSteps
    {
        [When(@"I start the game")]
        public void WhenIStartTheGame()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player is prompted for how many players")]
        public void WhenPlayerIsPromptedForHowManyPlayers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"They enter (.*)")]
        public void WhenTheyEnter(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player is created")]
        public void WhenPlayerIsCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"All players are created and they receive money")]
        public void WhenAllPlayersAreCreatedAndTheyReceiveMoney()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Number of players is selected")]
        public void WhenNumberOfPlayersIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the board is displayed")]
        public void WhenTheBoardIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Order is assigned")]
        public void WhenOrderIsAssigned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player is prompted to pick a token")]
        public void WhenPlayerIsPromptedToPickAToken()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player enters ""(.*)""")]
        public void WhenPlayerEnters(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Player selects Token ""(.*)""")]
        public void WhenPlayerSelectsToken(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the game is setup")]
        public void WhenTheGameIsSetup()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User receieves Fail")]
        public void ThenUserReceievesFail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Their balance is \$(.*)")]
        public void ThenTheirBalanceIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The bank contains (.*) houses and (.*) hotels")]
        public void ThenTheBankContainsHousesAndHotels(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Order is randomly assigned")]
        public void ThenOrderIsRandomlyAssigned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*) is ""(.*)""")]
        public void ThenIs(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User recieves Success")]
        public void ThenUserRecievesSuccess()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Available Tokens left are ""(.*)""")]
        public void ThenAvailableTokensLeftAre(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the board is displayed")]
        public void ThenTheBoardIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"All pieces are on ""(.*)""")]
        public void ThenAllPiecesAreOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
