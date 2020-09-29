using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is a number you want checked for weather it is prime or non-prime?");
    double whatami = Convert.ToDouble(Console.ReadLine());
    int logic = 0;

    for (int count = 1; count <= whatami; count++)
    {
      if (whatami % count == 0)
      {
        logic++;
      }
      else
      {} 
    }

    if (logic == 2)
    {
      Console.WriteLine("This number is prime.");
    }
    else
    {
      Console.WriteLine("This number is non-prime.");
    }


  }
}