namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {   
            get 
            { 
                if(index >= 0 && index < array.Length) 
                    return array[index];
                return 0;
            }
            set 
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }
    }
}