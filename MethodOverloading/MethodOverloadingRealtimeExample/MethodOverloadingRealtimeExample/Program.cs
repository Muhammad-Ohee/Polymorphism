//Console.WriteLine("Hello, OS");

namespace MethodOverloadingRealtimeExample
{
    class Logger
    {
        public static void Log(string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, " +
                              $"ClassName: {ClassName}, " +
                              $"MethodName: {MethodName}, " +
                              $"Message: {Message}");
        }

        public static void Log(string UniqueId, string ClassName, string MethodName, string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, " +
                              $"UniqueId: {UniqueId}, " +
                              $"ClassName: {ClassName}, " +
                              $"MethodName: {MethodName}, " +
                              $"Message: {Message}");
        }

        public static void Log(string Message)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, " +
                              $"Message: {Message}");
        }

        public static void Log(string ClassName, string MethodName, Exception ex)
        {
            Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, " +
                              $"ClassName: {ClassName}, " +
                              $"MethodName: {MethodName}, " +
                              $"Exception Message: {ex.Message}, " +
                              $"\nException StackTrace: {ex.StackTrace}");
            // ex.StackTrace: It returns a string representation of the immediate frames on the call stack,
            // along with the source file name and line number of the code where the exception was thrown.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string ClassName = "Program";
            string MethodName = "Main";
            string UniqueId = Guid.NewGuid().ToString();

            Logger.Log(ClassName, MethodName, "Message 1");
            Console.WriteLine();
            Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
            Console.WriteLine();
            Logger.Log("Message 3");
            Console.WriteLine();

            try
            {
                int number1 = 10, number2 = 0;
                int result = number1/number2;
                Logger.Log(UniqueId, ClassName, MethodName, "Message 3");
            }
            catch (Exception ex)
            {
                Logger.Log(ClassName, MethodName, ex);
            }
        }
    }
}