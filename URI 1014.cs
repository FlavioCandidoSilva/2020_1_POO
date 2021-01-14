using System;

class MainClass {
  public static void Main (string[] args) {
    int a = int.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());

      double c  = a/b;

      Console.WriteLine($"{c:0.000} km/l");

  }
}