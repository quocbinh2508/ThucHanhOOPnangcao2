using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculateCircumference();
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle (double Length, double Width)
    {
        this.Length = Length;
        this.Width = Width;
    }

    public override double CalculateArea()
    {
        return Length * Width; //tinh dien tich hinh chu nhat
    }

    public override double CalculateCircumference()
    {
        return 2 * (Length + Width); //tinh chu vi hinh chu nhat
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public double PI = Math.PI;

    public Circle(double Radius)
    {
        this.Radius = Radius;
    }
    public override double CalculateArea()
    {
        return PI * Radius * Radius;
    }

    public override double CalculateCircumference()
    {
        return 2 * PI * Radius;
    }
}

class Triangle : Shape
{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public double sideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double CalculateArea()
    {
        return 0.5 * sideA * sideB;
    }

    public override double CalculateCircumference()
    {
        return sideA + sideB + sideC;
    }

}
class Program
{
    private static double length;
    private static double width;
    private static double radius;
    private static double sideA;
    private static double sideB;
    private static double sideC;

    private static double GetValidInput(string prompt)
    {
        double value;
        Console.Write(prompt);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out value) && value > 0) 
            {
                return value;
            }
            else
            {
                Console.WriteLine("Gia tri nhap khong dung. Gia tri phai la so duong!");
                Console.WriteLine(prompt);
            }
        }
    }

    public static void DisplayShapeInfo(string ShapeName, double area, double Circumference)
    {
        Console.WriteLine($"Thong tin cua {ShapeName}");
        Console.WriteLine("Dien tich: " + area);
        Console.WriteLine("Chu vi: " + Circumference);
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        double length = GetValidInput("Nhap chieu dai hinh chu nhat: ");
        double width = GetValidInput("Nhap chieu rong hinh chu nhat: ");
        Rectangle rectangle = new Rectangle(length, width);

        double radius = GetValidInput("Nhap ban kinh hinh tron: ");
        Circle circle = new Circle(radius);

        double sideA = GetValidInput("Nhap chieu dai canh A: ");
        double sideB = GetValidInput("Nhap chieu dai canh B: ");
        double sideC = GetValidInput("Nhap chieu dai canh C: ");
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        DisplayShapeInfo("Hinh chu nhat: ", rectangle.CalculateArea(), rectangle.CalculateCircumference());
        DisplayShapeInfo("Hinh tron: ", circle.CalculateArea(), circle.CalculateCircumference());
        DisplayShapeInfo("Hinh tam giac: ", triangle.CalculateArea(), triangle.CalculateCircumference());
    }
}