// The Open/Closed Principle states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
// This means that the behavior of a module can be extended without modifying its source code.
// Example: A class that calculates the area of different shapes can be extended to support new shapes without modifying the existing code.

namespace SOLID.OpenClosePrinciple
{
    class BrokeOpenClosePrinciple
    {
        class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        // This class violates the Open/Closed Principle because if we want to add a new shape, we have to modify the Calculator class.
        class Calculator
        {
            public double CalculateArea(Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
        }
    }

    class OpenClosePrinciple
    {
        interface IShape
        {
            double calculatorteArea();
        }

        // This class adheres to the Open/Closed Principle because we can add new shapes without modifying the Calculator class.
        class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public double calculatorteArea()
            {
                return Width * Height;
            }
        }
        
        class Circle : IShape
        {
            public double Radius { get; set; }
            public double calculatorteArea()
            {
                return 3.14 * Radius * Radius;
            }
        }
    }
}
