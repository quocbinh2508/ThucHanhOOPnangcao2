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

    public static void Main(string[] args)
    {

        Console.Write("Nhap chieu dai hinh chu nhat: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out length) && length > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Console.Write("Nhap chieu rong hinh chu nhat: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out width) && width > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Rectangle rectangle = new Rectangle(length, width);

        Console.Write("Nhap ban kinh hinh tron: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Circle circle = new Circle(radius);

        Console.Write("Nhap canh a hinh tam giac: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out sideA) && sideA > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Console.Write("Nhap canh b hinh tam giac: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out sideB) && sideB > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Console.Write("Nhap canh c hinh tam giac: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out sideC) && sideC > 0)
            {
                break;
            }
            else
            {
                Console.Write("Gia tri nhap khong dung, do dai phai la so duong!");
            }
        }
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        Console.WriteLine("Hinh chu nhat: ");
        Console.WriteLine("Dien tich: " + rectangle.CalculateArea());
        Console.WriteLine("Chu Vi: " + rectangle.CalculateCircumference());
        Console.WriteLine();

        Console.WriteLine("Hinh tron: ");
        Console.WriteLine("Dien tich: " + circle.CalculateArea());
        Console.WriteLine("Chu Vi: " + circle.CalculateCircumference());
        Console.WriteLine();

        Console.WriteLine("Hinh tam giac: ");
        Console.WriteLine("Dien tich: " + triangle.CalculateArea());
        Console.WriteLine("Chu Vi: " + triangle.CalculateCircumference());
        Console.WriteLine();
    }
}