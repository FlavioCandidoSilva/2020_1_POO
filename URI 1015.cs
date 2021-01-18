using System;

class MainClass {
  public static void Main (string[] args) {
      double x1,x2,y1,y2;
      string e1 = Console.ReadLine();
      string[] l = e1.Split(" ");
      x1 = double.Parse(l[0]);
      y1 = double.Parse(l[1]);
      string e2 = Console.ReadLine();
      string[] l1 = e2.Split(" ");
      x2 = double.Parse(l1[0]);
      y2 = double.Parse(l1[1]);
      
      string d = (Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))).ToString("#0.0000");
      
      Console.WriteLine(d);

  }
}