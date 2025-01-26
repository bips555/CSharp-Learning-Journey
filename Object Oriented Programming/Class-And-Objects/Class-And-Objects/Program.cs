namespace Class_And_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Human human = new Human("bips","subedi","Blue",23);
            Human human2 = new Human("Marry", "Jane", "White", 2);
            human.IntroduceMyself();
            human2.IntroduceMyself();
            Human human3 = new Human();
            Human human4 = new Human("avsk","panta");
            human4.IntroduceMyself();
            Human human5 = new Human("sahal");*/
            /*human5.IntroduceMyself();*/
         /*   Box b = new Box();
            b.Length = 3;
            Console.WriteLine(b.Length);
            b.GetVolume();*/

            Members m = new Members();
            m.Introduction(false);
            
            Console.ReadKey();
        }
    }
}
