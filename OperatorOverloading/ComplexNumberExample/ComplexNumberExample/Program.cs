//Console.WriteLine("Hello, OS");

namespace ComplexNumberExample
{
    public class Complex
    {
        private int Real;
        private int Imaginary;
        public Complex(int real = 0, int imaginary = 0) 
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex Add(Complex C1, Complex C2)
        {
            Complex temp = new Complex();
            temp.Real = C1.Real + C2.Real;
            temp.Imaginary = C1.Imaginary + C2.Imaginary;
            return temp;
        }

        public static Complex operator +(Complex C1, Complex C2)
        {
            Complex temp = new Complex();
            temp.Real = C1.Real + C2.Real;
            temp.Imaginary = C1.Imaginary + C2.Imaginary;
            return temp;
        }

        public void Display()
        {
            Console.WriteLine($"Complex Number: {Real} + {Imaginary}i");
        }
    }

    class Program
    {
        static void Main(string[] args )
        {
            Complex complexNumberOne = new Complex(4,6);
            complexNumberOne.Display();
            Complex complexNumberTwo = new Complex(2,4);
            complexNumberTwo.Display();
            Console.WriteLine("                -------");
            Complex addition = Complex.Add(complexNumberOne, complexNumberTwo);
            addition.Display();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sum with Operator Overloading");
            Complex sumWithOperatorOverloading = complexNumberOne + complexNumberTwo;
            complexNumberOne.Display();
            complexNumberTwo.Display();
            Console.WriteLine("                -------");
            sumWithOperatorOverloading.Display();
        }
    }
}