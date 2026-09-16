namespace F26Week2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            Circle c = new Circle();
            c.radius = 5;

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);

            ChangeValues(n, s, c);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
        }

        static void ChangeValues(int num, string str, Circle cir)
        {
            num = 100;
            str = "bye";
            cir.radius = 100;
        }
    }

    class Circle
    {
        public int radius;
    }
}
