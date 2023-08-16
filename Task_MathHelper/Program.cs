namespace Task_MathHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper math = new();
            var a = math.PrintValue(4, 5);
            Console.WriteLine(a);

            var b = math.PrintValue(false);
            Console.WriteLine(b);

            var c = math.PrintValue(3, 4, 5);
            Console.WriteLine(c);

            math.PrintValue("Kamran", "Zeynalov");
        }
    }
}