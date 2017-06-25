using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Wiki_Miner
{
  class Helper
  {
    IWebDriver Drv;

    Helper(IWebDriver Driver) {
      Drv = Driver;
    }
    
    void WaitForElement(By Locator) { 

    }
    
    void WaitForElements(By Locator) { 

    }

    //Not sure if/how this is useful exactly.. but it feels right.
    void WaitForElements(List<By> Locators) { 

    }

  }

  class Element
  {
    bool Exists;
    bool Visible;
    IWebElement Match;

    IWebElement GetElement() { return Match; }
    void AddElement(IWebElement ElementToAdd) { 

    }
  }

  public class WDriver 
  { 
    IWebDriver Driver;
    ChromeOptions Options;
    string ChromeDriverPath;
    int DefaultWaitTime;
    
    public IWebDriver CurrentDriver { get; set; }

    //Some constructor magic!
    public WDriver()
    {
      //ChromeDriverPath = @"C:\Users\The Keymaster\Desktop\Wiki Miner\Wiki Miner\Wiki Miner\bin\Debug\";
      //Driver = new ChromeDriver(); //ChromeDriverPath);
      IWebDriver Drv = new ChromeDriver();
      Drv.Navigate().GoToUrl("http://www.google.com/");
      Thread.Sleep(2000);
    }
    WDriver(string Opt) 
    {
      Driver = new ChromeDriver(Opt);
    }     

    public void Dispose() {
      
      Driver.Quit();
    }

  }
}
