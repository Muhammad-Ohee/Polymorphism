//Console.WriteLine("Hello, OS");

namespace BaseKeywordInOverriding
{
    class FirstClass
    {
        //Virtual Function (Overridable Method)
        public virtual void Display() 
        {
            Console.WriteLine("First Class Called.");
        }
    }

    class SecondClass : FirstClass
    {
        //Overriding Method
        public override void Display()
        {
            base.Display(); //Calling Parent Class Show method
            Console.WriteLine("Second Class Called.");
        }
    }

    class ThirdClass : SecondClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Third Class Called.");
        }
    }

    class FourthClass : FirstClass
    {
        public override void Display()
        {
            FirstClass firstClass = new FirstClass();
            firstClass.Display();
            Console.WriteLine("Fourth Class Called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstClass = new SecondClass();
            //firstClass.Display();

            SecondClass secondClass = new SecondClass();
            //secondClass.Display();

            FirstClass firstClass1 = new ThirdClass();
            firstClass1.Display();

            FirstClass firstClass2 = new FourthClass();
            firstClass2.Display();
        }
    }
}