namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    
    class Record<TId, tValue>
    {
        public TId id;
        public tValue value;
        public DateTime date;
    }
}