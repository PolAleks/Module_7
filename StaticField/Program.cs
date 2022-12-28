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
        public static string parent;
        public static int daysInWeek;
        public static int maxValue;

        static Obj()
        {
            parent = "System.Object";
            daysInWeek = 7;
            maxValue = 2000;
    }
    }
}