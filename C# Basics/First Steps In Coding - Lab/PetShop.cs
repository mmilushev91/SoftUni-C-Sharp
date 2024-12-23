using System;

namespace PetShop

{
  class Program
  
  {
    static void Main(string[] args)
    
    {
      const float dogFoodPackagePrice = 2.5f;
      const int catFoodPackagePrice = 4;
      
      int DogFoodPackages = int.Parse(Console.ReadLine());
      int CatFoodPackages = int.Parse(Console.ReadLine());
      
      int catFoodPrice = CatFoodPackages * catFoodPackagePrice;
      float dogFoodPrice = DogFoodPackages * dogFoodPackagePrice;
      
       Console.WriteLine($"{catFoodPrice} lv.");
        Console.WriteLine($"{dogFoodPrice} lv.");
      
      float finalPrice = catFoodPrice + dogFoodPrice;
      
      Console.WriteLine($"{finalPrice} lv.");
      
    }
  }
}
