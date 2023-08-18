using System;

class NegativeValueException : Exception
{
    public NegativeValueException(string message) : base(message)
    {
    }
}

class Rectangle
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        if (width < 0 || height < 0)
        {
            throw new NegativeValueException("Width and height must be positive values.");
        }
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height of rectangle: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        catch (NegativeValueException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}