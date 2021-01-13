using System;

class MainClass {
  public static void Main (string[] args) {
    double b, c, vt;
    string nome = Console.ReadLine();
    c = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    vt = c + b*15/100;
    Console.WriteLine ($"TOTAL = R$ {vt:0.00}");
  }
}
