using System;

class MainClass {
  public static void Main (string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    double c = a*b;
    double d = c/12;

    Console.WriteLine($"{d:0.000}");

  }
}