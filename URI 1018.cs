using System;

class MainClass {
  public static void Main (string[] args) {
   int x = int.Parse(Console.ReadLine());
    int n100,n50,n20,n10,n5,n2,n1,r1,r2,r3,r4,r5,r6,r7;

    n100 = x/100;
    r1 = x%100;

    n50 = r1/50;
    r2 = r1%50;

    n20 = r2/20;
    r3 = r2%20;

    n10 = r3/10;
    r4 = r3%10;

    n5 = r4/5;
    r5 = r4%5;

    n2 = r5/2;
    r6 = r5%2;
    

    n1 = r6/1;
    r7 = n1/1;


    


    Console.WriteLine(x);
    Console.WriteLine(n100 + " nota(s) de R$ 100,00");
    Console.WriteLine(n50 + " nota(s) de R$ 50,00");
    Console.WriteLine(n20+ " nota(s) de R$ 20,00");
    Console.WriteLine(n10 + " nota(s) de R$ 10,00");
    Console.WriteLine(n5 + " nota(s) de R$ 5,00");
    Console.WriteLine(n2 + " nota(s) de R$ 2,00");
    Console.WriteLine(n1 + " nota(s) de R$ 1,00");
  }
}