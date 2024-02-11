//Console.WriteLine("Hello, OS");

namespace InheritanceBasedMethodOverloading
{
    class FirstClass
    {
        public void Add(int number1,  int number2) 
        {
            Console.WriteLine(number1 + number2);
        }

        public void Add(float number1, float number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }

    class SecondClass : FirstClass
    {
        public void Add(string number1, string number2)
        {
            Console.WriteLine(number1 + " " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SecondClass secondClass = new SecondClass();
            secondClass.Add(4, 4);
            secondClass.Add(4.4f, 4.4f);
            secondClass.Add("4", "4");
        }
    }
}