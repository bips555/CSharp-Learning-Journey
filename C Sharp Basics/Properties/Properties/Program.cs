namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Properties  p =new Properties(2,3,5);
            p.DisplayInfo();
            p.Length = 5;
            p.Width = 10;
            p.Height = 10;
            Console.WriteLine(p.FrontSurface);
            p.DisplayInfo();
            int volume = p.CalculateVolume();
            Console.WriteLine("Volume is {0}", volume);*/
           Members mb = new Members();
            mb.MemberName="Biplove Subedi";
            mb.MemberAge = 23;
            mb.Introducing(true);

            
        }
    }
}
