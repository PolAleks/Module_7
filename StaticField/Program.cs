namespace StaticField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Obj
    {
        public string name;
        public string description;
        public static int maxValue = 2000;
    }
}