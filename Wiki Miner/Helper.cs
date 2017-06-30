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
    public WDriver Driver = new WDriver();
            
    protected IWebElement WaitForElement(By Locator)
    {
            IWebElement Element;
            try
            {
                Element = Driver.CurrentDriver.FindElement(Locator);
                return Element;
            }
            catch
            {
                throw new Exception();
            }
    }
    
    protected IReadOnlyCollection<IWebElement> WaitForElements(By Locator) {
            IReadOnlyCollection<IWebElement> Elements;
            try
            {
                Elements = (IReadOnlyCollection<IWebElement>)Driver.CurrentDriver.FindElement(Locator);
                return Elements;
            }
            catch
            {
                throw new Exception();
            }
        }

    //Not sure if/how this is useful exactly.. but it feels right.
    protected void WaitForElements(List<By> Locators) { 

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
    
    public IWebDriver CurrentDriver { get { return Driver; }  set { Driver = value; } }

    //Some constructor magic!
    public WDriver()
    {
      Driver = new ChromeDriver();
    }
    public WDriver(string Opt) 
    {
      Driver = new ChromeDriver(Opt);
    }     

    public void Dispose() {
      Driver.Quit();
    }
  }
}
