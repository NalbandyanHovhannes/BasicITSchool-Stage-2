using System;

namespace AttributeExample
{


    [DeBugInfo(45, "Davit", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Syuzanna", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }


        [DeBugInfoAttribute(55, "Davit", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }



        [DeBugInfoAttribute(56, "Davit", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}