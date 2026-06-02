// Area Calculator 🟦
// Codédex

using System;

class AreaCalculator
{
  static void Main()
  {
    Console.WriteLine("==================");
    Console.WriteLine("Area Calculator 📐");
    Console.WriteLine("==================");
    Console.WriteLine();

    // ----------------------------
    // RECTANGLE
    // ----------------------------
    Console.Write("Length: ");
    double length = Convert.ToDouble(Console.ReadLine());

    Console.Write("Width: ");
    double width = Convert.ToDouble(Console.ReadLine());

    double area = length * width;

    Console.WriteLine();
    Console.WriteLine("The area is " + area);

    /*
    --------------------------------------------------
    OTHER SHAPES
    --------------------------------------------------

    // SQUARE
    Console.Write("Side: ");
    double side = Convert.ToDouble(Console.ReadLine());

    double squareArea = side * side;
    Console.WriteLine("The area is " + squareArea);



    // TRIANGLE
    Console.Write("Base: ");
    double baseLength = Convert.ToDouble(Console.ReadLine());

    Console.Write("Height: ");
    double height = Convert.ToDouble(Console.ReadLine());

    double triangleArea = (baseLength * height) / 2;
    Console.WriteLine("The area is " + triangleArea);



    // CIRCLE
    Console.Write("Radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    double circleArea = 3.14 * radius * radius;
    Console.WriteLine("The area is " + circleArea);



    --------------------------------------------------
    BONUS CHALLENGE
    --------------------------------------------------

    bool running = true;

    while (running)
    {
      Console.WriteLine("==================");
      Console.WriteLine("Area Calculator 📐");
      Console.WriteLine("==================");
      Console.WriteLine();

      Console.Write("Length: ");
      double length = Convert.ToDouble(Console.ReadLine());

      Console.Write("Width: ");
      double width = Convert.ToDouble(Console.ReadLine());

      double area = length * width;

      Console.WriteLine();
      Console.WriteLine("The area is " + area);

      Console.WriteLine();
      Console.Write("Calculate again? (y/n): ");
      string again = Console.ReadLine();

      if (again != "y")
      {
        running = false;
      }
    }
    */
  }
}