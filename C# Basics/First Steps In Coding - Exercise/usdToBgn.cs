using System;

namespace usdToBgn

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      const double usd = 1.79549f;
      
      double dollars_count = double.Parse(Console.ReadLine());
      
      double bgns = dollars_count * usd;
      
      Console.WriteLine(bgns);
    }
  }
}
