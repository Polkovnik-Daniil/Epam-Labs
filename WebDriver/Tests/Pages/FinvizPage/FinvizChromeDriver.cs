using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tests.Pages.AlpariPage {
    public class FinvizChromeDriver : Page {
        private string homeURL = "https://finviz.com/";
        private By logInBtnLocator = By.XPath("//a[@href='/login.ashx']");
        private By logInBtnLocatorNews = By.XPath("//a[@href='/news.ashx']");
        private By logInBtnLocatorHelp = By.XPath("//a[@href='/help/screener.ashx']");
        private By logInBtnLocatorMaps = By.XPath("//a[@href='//map.ashx']");
        private By logInBtnLocatorScreener = By.XPath("//a[@href='/screener.ashx']");
        private By logInBtnLocatorGroups = By.XPath("//a[@href='/groups.ashx']");
        private By logInBtnLocatorFutures = By.XPath("//a[@href='/futures.ashx']");
        private By submitBtnLocator = By.XPath("//input[@value='Log in']");
        private By search = By.XPath("//[input@placeholder ='Search ticker, company or profile']");

        private By emailLocator = By.XPath("//input[@name='email']");
        private By passwordLocator = By.XPath("//input[@type='password']");

        private By valueList = By.XPath("//option[@value='sp500']");
        private By valueBasicMater = By.XPath("//option[@value='basicmaterials']");

        private By demoBtnLocator = By.XPath("//input[@type='radio'][@value='demo']");
        private By inputMoneyFieldLocator = By.XPath("//input[@type='text'][@value='0.00']");
        private By openDemoBtnLocator = By.XPath("//button[@type='submit'][@name='send'][@tabindex='0']");
        private By informationPasswordFieldLocator = By.XPath("//li[contains(text(), 'Пароль:')]");
        private By metaTrader4BtnLocator = By.XPath("//div[contains(@class,'dropdown__control menu-line__text') and contains(text(), 'MetaTrader 4')]");
        private By openTradeBtnLocator = By.XPath("//a[contains(@href,'/ru/platforms/webterminal_mt4/?version=4')]");
        private By logInTradeBtnLocator = By.XPath("//*[@id='login']");



        private By passwordTradeBtnLocator = By.XPath("//*[@id='password']");
        private By okTradeBtnLocator = By.XPath("//button[contains(text(),'OK')]");
        private By polygonLocator = By.XPath("//*[@id='1639587467718_svg']");
        private By demoAccountsLocator = By.XPath("//a[contains(text(),'Учебные') and contains(@class, 'tabs__control ')]");
        private By addMoneyLocator = By.XPath("//button[contains(@data-number, '14649788')]");
        private By countAddMoneyLocator = By.XPath("//*[@id='balance']/input");
        public FinvizChromeDriver(IWebDriver driver, double seconds) : base(driver, seconds) {
        }
        public void OpenPage() {
            OnOpen();
            OpenUrl(homeURL);
        }
        public void Task1() {
            FindElementWithWait(logInBtnLocatorScreener).Click();
            FindElementWithWait(valueList).Click();
            FindElementWithWait(valueBasicMater).Click();
            Thread.Sleep(Sleep);
        }
        int Sleep = 600;
        public void Task2() {
            FindElementWithWait(logInBtnLocatorGroups).Click();
            FindElementWithWait(By.XPath("//option[@value = 'groups.ashx?g=industry&v=210&o=name']")).Click();
            FindElementWithWait(By.XPath("//option[@value = 'groups.ashx?g=industry&v=210&o=marketcap']")).Click();
            FindElementWithWait(By.XPath("//a[@href = 'groups.ashx?g=industry&v=140&o=marketcap']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task3() {
            FindElementWithWait(logInBtnLocatorScreener).Click();
            FindElementWithWait(By.XPath("//option[@value = 'amex']")).Click();
            FindElementWithWait(By.XPath("//option[@value = 'none']")).Click();
            FindElementWithWait(By.XPath("//a[@href = 'screener.ashx?v=131&f=exch_amex,fa_div_none']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task4() {
            FindElementWithWait(logInBtnLocatorFutures).Click();
            FindElementWithWait(By.XPath("//a[@href = '/futures_performance.ashx']")).Click();
            FindElementWithWait(By.XPath("//a[@href = '/futures_performance.ashx?v=12']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task5() {
            FindElementWithWait(logInBtnLocatorFutures).Click();
            FindElementWithWait(By.XPath("//a[@href = '/futures_performance.ashx']")).Click();
            FindElementWithWait(By.XPath("//a[@href = '/futures_performance.ashx?v=12']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task6() {
            IWebElement search1 = FindElementWithWait(search);
            search1.Clear();
            search1.SendKeys("pop");
            FindElementWithWait(By.XPath("//span[@class = 'fa fa-search']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task7() {

            FindElementWithWait(logInBtnLocatorNews).Click();
            FindElementWithWait(By.XPath("//option[@id = 'newsView']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task8() {
            FindElementWithWait(logInBtnLocatorHelp).Click();
            FindElementWithWait(By.XPath("//a[@href = '/help/technical-analysis/introduction.ashx']")).Click();
            FindElementWithWait(By.XPath("//a[@href = '/help/technical-analysis/moving-averages.ashx']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Task9() {
            FindElementWithWait(logInBtnLocatorMaps).Click();
            IWebElement searchmap = FindElementWithWait(emailLocator);
            searchmap.Clear();
            searchmap.SendKeys("PP");
            FindElementWithWait(By.XPath("//input[@placeholder = 'Quick search ticker']")).Click();
            FindElementWithWait(By.XPath("//a[@href= '#']")).Click();
            Thread.Sleep(Sleep);
        }
        public void Login(string login, string password) {
            FindElementWithWait(logInBtnLocator).Click();
            //FindElementWithWait(CLoseAdds).Click();

            IWebElement Email = FindElementWithWait(emailLocator);
            Email.Clear();
            Email.SendKeys(login);
            IWebElement Password = FindElementWithWait(passwordLocator);
            Password.Clear();
            Password.SendKeys(password);
            FindElementWithWait(submitBtnLocator).Click();
        }

        public void OpenAccountPage() {
            //FindElementWithWait(accountBtnLocator).Click();
        }

        public void ChooseDemoAndInput100USD() {
            FindElementWithWait(demoBtnLocator).Click();
            FindElementWithWait(inputMoneyFieldLocator).SendKeys(Keys.Control + Keys.ArrowLeft);
            FindElement(inputMoneyFieldLocator).SendKeys("100");
            FindElementWithWait(openDemoBtnLocator).Click();

        }

        public IWebElement FindAccountInfo() {
            return FindElementWithWait(informationPasswordFieldLocator);
        }

        public void OpenTradingPage() {
            FindElementWithWait(metaTrader4BtnLocator).Click();
            FindElementWithWait(openTradeBtnLocator).Click();
        }

        public void ConnectToTradingAccount(string login, string password) {
            IWebElement Login = FindElementWithWait(logInTradeBtnLocator);
            Login.Clear();
            Login.SendKeys(login);
            IWebElement Password = FindElementWithWait(passwordTradeBtnLocator);
            Password.Clear();
            Password.SendKeys(password);
            FindElementWithWait(okTradeBtnLocator).Click();
        }

        public IWebElement FindTradingInfo() {
            return FindElementWithWait(polygonLocator);
        }

        public IWebElement Add100USDOnTradingAccounts() {
            FindElementWithWait(demoAccountsLocator).Click();
            FindElementWithWait(addMoneyLocator).Click();
            FindElementWithWait(countAddMoneyLocator).SendKeys("100" + Keys.Enter);
            return FindElement(demoAccountsLocator);
        }
    }


}
