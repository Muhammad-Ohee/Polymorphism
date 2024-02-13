//Console.WriteLine("Hello, OS");

namespace BasicExample
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }

    public class Child1 : Parent
    {
        //Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }

        //Method Hiding/Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }


    public class Child2 : Parent
    {
        //Method Overriding
        public override void Show()
        {
            //Using Parent class instance to Invoke the Parent Methods
            Parent parent = new Parent();
            parent.Show();
            //Using base keyword to invoke the Parent method
            base.Display();
            Console.WriteLine("Child Class Show Method");
        }

        //Method Hiding/Shadowing
        public new void Display()
        {
            //Using Parent class instance to Invoke the Parent Methods
            Parent parent = new Parent();
            parent.Display();
            //Using base keyword to invoke the Parent method
            base.Show();
            Console.WriteLine("Child Class Display Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child1 obj1 = new Child1();
            obj1.Show();
            obj1.Display();

            Console.WriteLine();
            Console.WriteLine();

            Child2 obj2 = new Child2();
            obj2.Show();
            Console.WriteLine();
            obj2.Display();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Parent parent = new Child1();
            parent.Show(); // Child Class Show Method
            parent.Display(); // Parent Class Display Method
        }
    }
}