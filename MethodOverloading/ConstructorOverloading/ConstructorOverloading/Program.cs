//Console.WriteLine("Hello, OS");

namespace ConstructorOverloading
{
    class ConstructorOverloading
    {
        int x, y, z;

        public ConstructorOverloading(int x)
        {
            this.x = x;
            Console.WriteLine("Constructor 1 Called");
        }

        public ConstructorOverloading (int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Constructor 2 Called");
        }

        public ConstructorOverloading (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Constructor 3 Called");
        }

        public void Display()
        {
            Console.WriteLine($"X={x}, Y={y}, Z={z}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConstructorOverloading object1 = new ConstructorOverloading(10);
            object1.Display();
            ConstructorOverloading object2 = new ConstructorOverloading(10, 20);
            object2.Display();
            ConstructorOverloading object3 = new ConstructorOverloading(10, 20, 30);
            object3.Display();
        }
    }
}