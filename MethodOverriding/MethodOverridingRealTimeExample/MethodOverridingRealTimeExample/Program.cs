//Console.WriteLine("Hello, OS");

namespace MethodOverridingRealTimeExample
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Designation { get; set; }
        public double Salary { get; set; }

        public virtual double GetBonus(double Salary)
        {
            return 50000;
        }
    }

    public class Developer : Employee
    {
        public override double GetBonus(double Salary)
        {
            double BaseBonus = base.GetBonus(Salary);
            double CalculateBonus = Salary * 0.20;
            if (CalculateBonus >= BaseBonus)
            {
                return CalculateBonus;
            }
            else
            {
                return BaseBonus;
            }
        }
    }

    public class Manager : Employee
    {
        public override double GetBonus(double Salary)
        {
            double BaseBonus = base.GetBonus(Salary);
            double CalculateBonus = Salary * 0.25;
            if (CalculateBonus >= BaseBonus)
            {
                return CalculateBonus;
            }
            else
            {
                return BaseBonus;
            }
        }
    }

    public class Admin : Employee
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee DeveloperEmployee1 = new Developer
            {
                Id = 1001,
                Name = "Jhon Doe",
                Age = 26,
                Designation = "Developer",
                Salary = 500000
            };

            double Bonus = DeveloperEmployee1.GetBonus(DeveloperEmployee1.Salary);
            Console.WriteLine($"ID: {DeveloperEmployee1.Id}" +
                              $"\nName: {DeveloperEmployee1.Name}" +
                              $"\nAge: {DeveloperEmployee1.Age}" +
                              $"\nDesignation: {DeveloperEmployee1.Designation}" +
                              $"\nSalary: {DeveloperEmployee1.Salary}" +
                              $"\nBonus: {Bonus}");
            Console.WriteLine();


            Employee Manager1 = new Manager 
            {
                Id = 1002,
                Name = "Angelina",
                Age = 30,
                Designation = "Manager",
                Salary = 800000
            };
            Bonus = Manager1.GetBonus(Manager1.Salary);
            Console.WriteLine($"ID: {Manager1.Id}" +
                              $"\nName: {Manager1.Name}" +
                              $"\nAge: {Manager1.Age}" +
                              $"\nDesignation: {Manager1.Designation}" +
                              $"\nSalary: {Manager1.Salary}" +
                              $"\nBonus: {Bonus}");

            Console.WriteLine();


            Employee Admin1 = new Admin
            {
                Id = 1003,
                Name = "Cindrella",
                Age = 40,
                Designation = "Admin",
                Salary = 300000
            };
            Bonus = Admin1.GetBonus(Admin1.Salary);
            Console.WriteLine($"ID: {Admin1.Id}" +
                              $"\nName: {Admin1.Name}" +
                              $"\nAge: {Admin1.Age}" +
                              $"\nDesignation: {Admin1.Designation}" +
                              $"\nSalary: {Admin1.Salary}" +
                              $"\nBonus: {Bonus}");

            Console.WriteLine();


            Employee DeveloperEmployee2 = new Developer
            {
                Id = 1004,
                Name = "Tom Crusie",
                Age = 29,
                Designation = "Developer",
                Salary = 200000
            };

            Bonus = DeveloperEmployee2.GetBonus(DeveloperEmployee2.Salary);
            Console.WriteLine($"ID: {DeveloperEmployee2.Id}" +
                              $"\nName: {DeveloperEmployee2.Name}" +
                              $"\nAge: {DeveloperEmployee2.Age}" +
                              $"\nDesignation: {DeveloperEmployee2.Designation}" +
                              $"\nSalary: {DeveloperEmployee2.Salary}" +
                              $"\nBonus: {Bonus}");
        }
    }
}