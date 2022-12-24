namespace Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Food { }

    class Fruit : Food { }

    class Vagetable : Food { }

    class Apple : Fruit { }

    class Banana : Fruit { }

    class Pear : Fruit { }

    class Potato : Vagetable { }

    class Carrot : Vagetable { }
}