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

            ChangeValues(ref n, s, ref c, a);

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

            Console.WriteLine("\n\n");



            // parameter array example

            int i = 3, j = 6, k = 9;

            Console.WriteLine("i = " + i + " j = " + j + " k = " + k);
            Console.WriteLine($"i = {i} j = {j} k = {k}");
            Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);


            int[] b = { 3, 4, 65, 6, 4, 3, 2 };
            PrintArray(b);
            PrintArray(2, 5, 6, 7, 8, 87, 6, 4, 3, 2, 4, 5, 6, 7);
        }


        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\n\nTotal items = " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        static void GetCircumAndArea(int r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }



        static void ChangeValues(ref int num, string str, ref Circle cir, int[] arr)
        {
            num = 100;
            str = "bye";
            //cir.radius = 100;
            arr[0] = 100;

            cir = new Circle();
            cir.radius = 100;
        }
    }

    class Circle
    {
        public int radius;
    }
}
