//Console.WriteLine("Hello, OS");

namespace VectorExample
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x = 0, int y= 0)
        {
            X = x;
            Y = y;
        }

        // Overloading the + operator for Vector addition
        public static Vector operator + (Vector V1, Vector V2)
        {
            return new Vector(V1.X + V2.X , V1.Y + V2.Y);
        }

        // Overloading the - operator for Vector subtraction
        public static Vector operator - (Vector V1, Vector V2)
        {
            return new Vector(V1.X - V2.X, V1.Y - V2.Y);
        }

        // Overloading the * operator for Vector multiplication
        public static Vector operator *(Vector V1, Vector V2)
        {
            return new Vector (V1.X * V2.X, V1.Y * V2.Y);
        }

        // Overloading the / operator for Vector multiplication
        public static Vector operator / (Vector V1, Vector V2)
        {
            return new Vector(V1.X / V2.X, V1.Y / V2.Y);
        }

        // Overloading the * operator for Vector scaling
        public static Vector operator *(Vector V1, int number)
        {
            return new Vector(V1.X * number, V1.Y * number);
        }

        // Overloading the == operator for equality comparison
        public static bool operator ==(Vector V1, Vector V2)
        {
            return V1.X == V2.X && V1.Y == V2.Y;
        }

        // Overloading the != operator for inequality comparison
        public static bool operator !=(Vector V1, Vector V2)
        {
            return !(V1 == V2);
        }


        // Overriding the ToString method for a more readable output
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(8, 4);
            Vector vector2 = new Vector(4, 2);

            Vector AdditionVector = vector1 + vector2;
            Console.WriteLine($"Vector Addition: {vector1} + {vector2} = {AdditionVector}");

            Vector subtractionVector = vector1 - vector2;
            Console.WriteLine($"Vector Subtraction: {vector1} - {vector2} = {subtractionVector}");

            Vector multiplicationVector = vector1 * vector2;
            Console.WriteLine($"Vector Subtraction: {vector1} * {vector2} = {multiplicationVector}");

            Vector divisionVector = vector1 / vector2;
            Console.WriteLine($"Vector Subtraction: {vector1} * {vector2} = {divisionVector}");

            Vector scalingVector = vector1 * 4;
            Console.WriteLine($"Vector Subtraction: {vector1} * 4 = {scalingVector}");

            Console.WriteLine($"Equality Comparison: {vector1} == {vector2} ? {vector1 == vector2}");
            Console.WriteLine($"Inequality Comparison: {vector1} == {vector2} ? {vector1 != vector2}");
        }
    }
}