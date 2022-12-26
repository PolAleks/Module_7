namespace OperatorOverload
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
        public int value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                value = a.value + b.value
            };
        }

        public static Obj operator - (Obj a, Obj b) 
        {
            return new Obj
            {
                value = a.value - b.value
            };
        }
    }
}