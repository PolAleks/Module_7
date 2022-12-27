namespace ComputerPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Процессор");
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Материнская плата");
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Видеокарта");
        }
    }
}