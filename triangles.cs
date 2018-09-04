using System;

class Triangle
{
  public int _sideA;
  public int _sideB;
  public int _sideC;

  public bool IsNotTriangle()
  {
    if (_sideA + _sideB < _sideC || _sideA + _sideC < _sideB || _sideC + _sideB < _sideA)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool IsEquilateral()
  {
    if (_sideA == _sideB && _sideA == _sideC && _sideB == _sideC)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool IsIsosceles()
  {
    if (_sideA == _sideB || _sideA == _sideC || _sideB == _sideC)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool IsScalene()
  {
    if (_sideA + _sideB > _sideC || _sideA + _sideC > _sideB || _sideC + _sideB > _sideA)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter a number for side A.");
    string stringSideA = Console.ReadLine();
    int sideA = int.Parse(stringSideA);
    myTriangle._sideA = sideA;

    Console.WriteLine("Enter a number for side B.");
    string stringSideB = Console.ReadLine();
    int sideB = int.Parse(stringSideB);
    myTriangle._sideB = sideB;

    Console.WriteLine("Enter a number for side C.");
    string stringSideC = Console.ReadLine();
    int sideC = int.Parse(stringSideC);
    myTriangle._sideC = sideC;

    if (myTriangle.IsNotTriangle())
    {
      Console.WriteLine("This is not a triangle!");
    }
    else if (myTriangle.IsEquilateral())
    {
      Console.WriteLine("This is an equilateral triangle.");
    }
    else if (myTriangle.IsIsosceles())
    {
      Console.WriteLine("This is an isosceles triangle.");
    }
    else if (myTriangle.IsScalene())
    {
      Console.WriteLine("This is a scalene triangle.");
    }
  }
}
