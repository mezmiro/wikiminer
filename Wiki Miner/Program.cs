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
      WDriver Test = new WDriver();

      Test.CurrentDriver.Url = "http://www.wikipedia.org/";

      string t = Console.ReadLine();

      Test.Dispose();

    }
  }
}
