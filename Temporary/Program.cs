namespace Temporary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Display();
        }
    }
    /// <summary>
    /// 7.1.6 - Пример заполнения конструктора с полями совпадающими с передаваемыми параметрами
    /// </summary>
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }
    /// <summary>
    /// 7.1.10 - Пример работы this и base в конструкторе
    /// </summary>
    class BaseClass
    {
        protected string Name;
        
        public virtual int Counter
        {
            get;
            set;
        }

        public BaseClass(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 7.2.3 - Виртуальный метод
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;
        private int counter;

        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0) 
                    counter = 0;
                counter = value;
            }
        }

        public DerivedClass() : this("Lada", "Vachina", 10)
        {

        }

        public DerivedClass(string name, string description) : base (name) 
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }

        public override void Display()
        {   
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }

}