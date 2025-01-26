namespace Struct_And_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Point1 p1 = new Point1(10,20);
            Point1 p2 = p1;
            p2.Y = 30;
            Console.WriteLine("X of p1 is {0} and Y of p1 is {1}",p1.X,p1.Y);
            Console.WriteLine("X of p2 is {0} and Y of p2 is {1}", p2.X, p2.Y);
            

            Point2 point1 = new Point2(10,20);
            Point2 point2 = point1;
            point2.Y = 30;
            Console.WriteLine("X of point1 is {0} and Y of point1 is {1}", point1.X, point1.Y);
            Console.WriteLine("X of point2 is {0} and Y of point2 is {1}", point2.X, point2.Y);
            Console.ReadKey();
        }
    }
    struct Point1
    {
        public int X;
        public int Y;
        public Point1(int x,int y) {
            this.X = x;
            this.Y = y;
        }
    }
    class Point2
    {
        public int X;
        public int Y;
        public Point2(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
