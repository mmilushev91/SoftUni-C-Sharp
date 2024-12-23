using System;

namespace depositCalculator

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      float depositedMoney = float.Parse(Console.ReadLine());
      int period = int.Parse(Console.ReadLine());
      float interestRate = float.Parse(Console.ReadLine()) / 100 / 12;
      
      float output = depositedMoney + (depositedMoney * interestRate) * period;
      Console.WriteLine(output);

    }
  }
}
