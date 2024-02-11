//Console.WriteLine("Hello, OS");

namespace BasicOverloading
{
    class Program
    {
        public void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        public void Add(float number1, float number2)
        {
            Console.WriteLine(number1 + number2);
        }

        public void Add(string string1, string string2)
        {
            Console.WriteLine(string1 + " " + string2);
        }

        public int GetString(int number)
        {
            return number;
        }

        public string GetString(string number)
        {
            return number;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add(4, 4);
            program.Add(44.44f, 44.44f);
            program.Add("OS", "Loves OS");


            Console.WriteLine(program.GetString(4));
            Console.WriteLine(program.GetString(4).GetType());
            Console.WriteLine(program.GetString("4"));
            Console.WriteLine(program.GetString("4").GetType());

        }
    }
}