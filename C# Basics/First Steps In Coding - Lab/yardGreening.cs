using System;

namespace YardGreening

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      const float greeningPricePerM = 7.61f;
      
      float greenYardMeters = float.Parse(Console.ReadLine());
      
      float yardGreeningPrice = greenYardMeters * greeningPricePerM;
      
      float discount = yardGreeningPrice * 0.18f;
      
      float finalPrice = yardGreeningPrice - discount;
      
      Console.WriteLine($"The final price is: {finalPrice} lv.");
      Console.WriteLine($"The discount is: {discount} lv.");
      
    }
  }
}
