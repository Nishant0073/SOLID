namespace Problem
{

    public class Rectangle{
        public double hight{get;set;}
        public double width{get;set;}
    }
    public class Circle{
        public double redius;
    }
    
    public class Shape{
        //This will voilet the open closed principle becouse whenever we will add new shape we have to modify this class and method.
        public double CalculteArea(object shape)
        {
            if(shape is Rectangle rectangle)
            {
                return rectangle.hight * rectangle.width;
            }
            if(shape is Circle circle)
            {
                return circle.redius*2*3.14;
            }
            throw new ArgumentException("Unknown shape!");
        }
    }
}