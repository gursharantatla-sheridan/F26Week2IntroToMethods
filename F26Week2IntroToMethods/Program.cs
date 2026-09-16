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
            int[] a = { 5, 6, 7 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValues(ref n, s, c, a);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
            Console.WriteLine("a[0] = " + a[0]);

            Console.WriteLine("\n\n");


            // output parameter example

            int r = 5;
            //double circum, area;

            GetCircumAndArea(r, out double circum, out double area);

            Console.WriteLine("Circumference = " + circum.ToString("F"));
            Console.WriteLine("Area = " + area.ToString("F"));
        }


        static void GetCircumAndArea(int r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }



        static void ChangeValues(ref int num, string str, Circle cir, int[] arr)
        {
            num = 100;
            str = "bye";
            cir.radius = 100;
            arr[0] = 100;
        }
    }

    class Circle
    {
        public int radius;
    }
}
