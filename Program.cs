using System;

namespace Employeer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string workerName = Console.ReadLine();
            Console.Write("Enter your last Name: ");
            string workerLastName = Console.ReadLine();
            Employee Worker = new Employee( workerName, workerLastName);
            Console.Write("Enter your position: ");
            string workersPosition = Console.ReadLine();
            Console.Write("How many years do you work? ");
            int staj = int.Parse(Console.ReadLine());


        }
    }
    class Employee
    {
        string [] positionsArr = {};
        public string  Name  { get; set; }
        public string LastName { get; set; }
        public Employee (string Name, string LastName )
        {
            this.Name = Name;
            this.LastName = LastName;
        }
        public Employee (){}
        public 

    }
}
