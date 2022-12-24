namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Employee
    {
        public string name;
        public int age;
        public int salary;
    }

    class ProjectManager : Employee
    {
        public string projectName;
    }

    class Developer : Employee
    {
        public string programmingLanguage;
    }
}