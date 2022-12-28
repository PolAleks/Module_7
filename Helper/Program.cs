namespace Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1,ref num2);
        }
    }
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;            
        }
    }
}