namespace Solution
{
    //This is the solution for open closed principle as when we will have a new shape we will extend this class and will not make any change in this shape class.
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double height;
        public double width;
        
        public override double CalculateArea()
        {
            return height*width;
        }
    }
    public class Circle : Shape
    {
        public double redius;
        public override double CalculateArea()
        {
            return redius*2*3.14;
        }
    }
}