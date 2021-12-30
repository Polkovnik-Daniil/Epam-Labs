using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Pages.AlpariPage;

namespace Tests
{
    [TestFixture]
    public class Finviz
    {
        private IWebDriver driver;
        private string login= "0205danik@gmail.com";
        private string password = "w9*8cnf+#JH!sKi";///hQ8K?vZY53#6+dC

        [Test]
        public void CreateDemoAccount()
        {
            FinvizChromeDriver chromeDriver = new FinvizChromeDriver(driver,15);
            chromeDriver.OpenPage();
            chromeDriver.Login(login, password);
            chromeDriver.Task5();

            //chromeDriver.OpenAccountPage();
            //chromeDriver.ChooseDemoAndInput100USD();
            //Assert.IsNotNull(chromeDriver.FindAccountInfo());
        }
        //[Test]
        //public void BeginTrading()
        //{

        //    AlpariChromeDriver chromeDriver = new AlpariChromeDriver(driver, 600);

        //    chromeDriver.OpenPage();
        //    chromeDriver.Login(login, password);
        //    chromeDriver.OpenAccountPage();
        //    chromeDriver.OpenTradingPage();
        //    chromeDriver.ConnectToTradingAccount(loginAccount, passwordAccount);
        //    Assert.IsNotNull(chromeDriver.FindTradingInfo());
        //}
        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }


        [SetUp]
        public void SetupTest()
        {
            ChromeOptions options = new ChromeOptions();

            //options.AddArguments("load-extension=C:\\Users\\Asus\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Extensions\\gighmmpiobklfepjocnamgkkbiglidom\\4.41.0_0");
            //options.AddArgument("user-data-dir=C:\\Users\\Asus\\AppData\\Local\\Google\\Chrome\\User Data");
            options.AddArgument("--enable-javascript");
            driver = new ChromeDriver(options);
        }

    }
}
