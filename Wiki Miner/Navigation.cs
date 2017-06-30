using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;

namespace Wiki_Miner
{
    //We will try to divide this into steps.
    class Navigation : Helper {
        string WikiBaseURL = @"https://en.wikipedia.org/wiki/Main_Page";
        string BaseSearchBarXPath = "//input[contains(@name,'search')]";
        IWebElement BaseSearchBar;
                
        public void BaseWikiNavigation() {
            Driver.CurrentDriver.Navigate().GoToUrl(WikiBaseURL);
        }
        public void SearchTag(string Tag) {
            BaseSearchBar = WaitForElement(By.XPath(BaseSearchBarXPath));
            BaseSearchBar.SendKeys(Tag);
            BaseSearchBar.Submit();
        }
        public bool TestIsAmbiguous() {
            string AmbiguousXPath = "";
            IWebElement Ambiguous = WaitForElement(By.XPath(AmbiguousXPath));

            if(Ambiguous == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void NavigateToPage(string URLToNav) {
            Driver.CurrentDriver.Navigate().GoToUrl(URLToNav);
        }
  }
}
