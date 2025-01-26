namespace AbstractClassesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
              new Cube(4),
              new Sphere(4)
          };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
               

                Cube cube1 = shape as Cube;

                if(cube1 == null)
                {
                    Console.WriteLine("Not a cube");
                }
                if (cube1 is Cube)
                {
                    Console.WriteLine("Is a cube");
                }

              

            }
            object cube2 = new Cube(7);
            Cube cube3 = (Cube)cube2;
           cube3.GetInfo();

            Console.ReadKey();




        }
    }
}
