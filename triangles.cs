using System;

class Triangle
{
  public int _sideA;
  public int _sideB;
  public int _sideC;
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number for side A.");
    string stringSideA = Console.ReadLine();
    int sideA = int.Parse(stringSideA);

    Console.WriteLine("Enter a number for side B.");
    string stringSideB = Console.ReadLine();
    int sideB = int.Parse(stringSideB);

    Console.WriteLine("Enter a number for side C.");
    string stringSideC = Console.ReadLine();
    int sideC = int.Parse(stringSideC);
  }
}
