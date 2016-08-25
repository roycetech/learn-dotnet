using System;

namespace oop
{

    class Rectangle
    {

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing Rectangle!");
        }
    }

    class Square : Rectangle
    {
        public Square(double width) : base(width, width) {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Square!");
        }

    }

}
