using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Windows.Controls;
using TechTalk.SpecFlow;
using MonopolyGame;
using MonopolyGame.models;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace TestProj
{
    [Binding]
    public class SetupTheGameSteps
    {
        bool m_SuccessfulStartup = false;
        static MonopolyGame.MainWindow win;
        static MonopolyGame.App app;

        [BeforeTestRun]
        static void Setup() {
            var are = new AutoResetEvent(false);
            Helpers.RunCodeAsSTA(are, () => {
                win = new MonopolyGame.MainWindow();
                app = new MonopolyGame.App();
                app.Run(win);
            });
            // give app time to start;
            Thread.Sleep(2000);
        }

        [AfterTestRun]
        static void After() {
            if (app != null) {
                app.Dispatcher.InvokeShutdown();
            }
        }

        [Given(@"Application is started")]
        public void GivenApplicationIsStarted() {
            Assert.IsTrue(app != null);
        }

        [When(@"I start the game")]
        public void WhenIStartTheGame()
        {
            Assert.IsTrue(app != null);
        }
        
        [When(@"Player is prompted for how many players")]
        public void WhenPlayerIsPromptedForHowManyPlayers()
        {
            //Need user test
            return;
        }
        
        [When(@"They enter (.*)")]
        public void WhenTheyEnter(int a_NumberOfPlayers)
        {
            if(Game.ValidateNumberOfPlayers(a_NumberOfPlayers.ToString()))
            {
                m_SuccessfulStartup = true;
            }
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
            MonopolyGame.controls.Board board = null;
            app.Dispatcher.Invoke(() => {
                board = MonopolyGame.utils.UIHelpers.FindChild<MonopolyGame.controls.Board>(win, "Board");
            });

            Assert.IsTrue(board != null);
        }
        
        [When(@"Order is assigned")]
        public void WhenOrderIsAssigned()
        {
            // todo:
        }
        
        [When(@"Player is prompted to pick a token")]
        public void WhenPlayerIsPromptedToPickAToken()
        {
            MonopolyGame.controls.TokenPicker tp = null;
            app.Dispatcher.Invoke(() => {
                tp = MonopolyGame.utils.UIHelpers.FindChild<MonopolyGame.controls.TokenPicker>(win, "TokenPicker");
            });

            Assert.IsTrue(tp != null);
        }
        
        [When(@"Player enters ""(.*)""")]
        public void WhenPlayerEnters(string p0)
        {
            //Window tp = null;
            MonopolyGame.viewmodels.GameViewModel vm;
            bool passed = false;
            app.Dispatcher.Invoke(() => {
                //tp = MonopolyGame.utils.UIHelpers.FindChild<Window>(win, "mainWindow");
                vm = win.DataContext as MonopolyGame.viewmodels.GameViewModel;
                if (vm.TokenSelect == null) return;
                if (TokenMapping.TokenList.Contains(p0))
                    vm.TokenSelect.Execute(TokenMapping.TokenList.IndexOf(p0));
                else vm.TokenSelect.Execute(TokenMapping.TokenList.Count + 1);
                passed = true;
            });

            Assert.IsTrue(passed);
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
        public void ThenIs(uint loc, string name)
        {
            string val;
            Assert.IsTrue(BoardPositions.PositionNames.TryGetValue(loc, out val));
            Assert.IsTrue(val == name);
        }
        
        [Then(@"Available Tokens left are ""(.*)""")]
        public void ThenAvailableTokensLeftAre(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User recieves ""(.*)""")]
        public void ThenUserRecieves(string p0) {
            Label tm = null;
            string content = "";
            app.Dispatcher.Invoke(() => {
                tm = MonopolyGame.utils.UIHelpers.FindChild<Label>(win, "TokenMessage");
                content = tm.Content as string;
            });
            Assert.IsTrue(tm != null);
            if (p0 == "Success") {
                Assert.IsTrue(content != "");
            }
            else if (p0 == "Fail") {
                Assert.IsTrue(content == "");
            }
            else {
                Assert.Fail();
            }

        }
        [Then(@"User receieves ""(.*)""")]
        public void ThenUserReceieves(string p0) {
            ScenarioContext.Current.Pending();

        }

        [Then(@"the board is displayed")]
        public void ThenTheBoardIsDisplayed()
        {
            MonopolyGame.controls.Board board = null;
            app.Dispatcher.Invoke(() => {
                board = MonopolyGame.utils.UIHelpers.FindChild<MonopolyGame.controls.Board>(win, "Board");
            });

            Assert.IsTrue(board != null);
        }
        
        [Then(@"All pieces are on ""(.*)""")]
        public void ThenAllPiecesAreOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Game is started")]
        public void WhenGameIsStarted() {
            Assert.IsTrue(win != null && app != null);
        }

        [Then(@"A monopoly board is shown")]
        public void ThenAMonopolyBoardIsShown() {
            MonopolyGame.controls.Board board = null;
            app.Dispatcher.Invoke(() =>
            {
                board = MonopolyGame.utils.UIHelpers.FindChild<MonopolyGame.controls.Board>(win, "Board");
            });

            Assert.IsTrue(board != null);
        }
    }
}
