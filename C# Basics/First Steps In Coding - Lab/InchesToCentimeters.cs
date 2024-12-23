using System;

namespace InchesToCentimeters

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      const float Inch = 2.54f;
      
      float Centimeters = float.Parse(Console.ReadLine());
      
      float Inches = Centimeters * Inch;
      
      Console.WriteLine(Inches);
    }
  }
}
