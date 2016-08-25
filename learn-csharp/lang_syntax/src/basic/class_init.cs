namespace basic
{


    class Square
    {


        public int Width { get; set; }


        public Square(int width)
        {
            Width = width;
        }

        /** A constructor that calls another constructor. */
        public Square() : this(0)
        {
        }

        public void run()
        {
            // 1.
            Square square1 = new Square(5);

            // 2.
            Square square2 = new Square();
            square2.Width = 5;

            // 3.
            Square square3 = new Square()
            {
                Width = 5
            };

        }


    }
}
