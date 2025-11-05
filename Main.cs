using System;
namespace MyProject;
class Program {
  static void Main(string[] args)
  {
    // malumot olish
    System.Console.Write("Komunnal xarajatni kiriting: ");
    string? comunnalCost = Console.ReadLine();
    
    System.Console.Write("Oziq ovqat uchun harajat: ");
    string? foodCost = Console.ReadLine();

    System.Console.Write("Qora kun uchun: ");
    string? unexpectedCost = Console.ReadLine();

    // algorithm
    double? communalCostPrice = double.Parse(comunnalCost);
    double? foodCostPrice = double.Parse(foodCost);
    double? unexpectedCostPrice = double.Parse(unexpectedCost);
    double? totalCOst = communalCostPrice + foodCostPrice + unexpectedCostPrice;
    double? smartRightCost = totalCOst * 0.15;

    //showing result
    System.Console.WriteLine("--- Oylik pul yoqolishi ---");
    System.Console.WriteLine($"Kommunal xarajatlar  \t|\t{communalCostPrice}");
    System.Console.WriteLine($"Oziq ovqat xarajatlar\t|\t{foodCostPrice}");
    System.Console.WriteLine($"Qora kun             \t|\t{unexpectedCostPrice}");
    System.Console.WriteLine($"hammasi bo'lib       \t|\t{totalCOst}");
    System.Console.WriteLine($"Investitsiya         \t|\t{smartRightCost}");




  } 
}