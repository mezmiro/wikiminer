using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki_Miner
{
  class Program
  {
    static void Main(string[] args)
    {

            Navigation Nav = new Navigation();
            Nav.BaseWikiNavigation();
            Nav.SearchTag("Testing");

            Nav.Driver.CurrentDriver.Dispose();
    }
  }
}
