// See https://aka.ms/new-console-template for more information
//using Problem;
using Solution;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Open Closed Principle");
        //Shape shape = new Shape();
        //Console.WriteLine($"The Area of the rectangle is:{shape.CalculteArea(new Rectangle{hight = 10,width = 10})}");
        Shape shape = new Rectangle { height = 50, width = 50 };
        Console.WriteLine($"The area of the rectangle is: {shape.CalculateArea()}");
    }
}