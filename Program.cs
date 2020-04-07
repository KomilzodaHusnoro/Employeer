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
            Console.Write("Enter your position from this list:\n*FirstLieutenant --> 1200 \n*Captain --> 1300 \n*Major--> 1400 \n*LieutenantColonel--1700\n");
            string workersPosition = Console.ReadLine();
            Console.Write("How many years do you work? ");
            int staj = int.Parse(Console.ReadLine());
            Worker.PositionAndStaj(workersPosition,staj);
            Console.ReadKey();
        }
    }
    class Employee
    {
        string [] positionsArr = {"FirstLieutenant", "Captain", "Major", "LieutenantColonel"};
        double [] salary = {1200, 1300, 1400, 1700 };

        public string  Name  { get; set; }
        public string LastName { get; set; }
        public Employee (string Name, string LastName )
        {
            this.Name = Name;
            this.LastName = LastName;
        }
        public Employee (){}
        public void  PositionAndStaj ( string position, int staj)
        {
            double sum = 0;
            for (int i = 0; i < positionsArr.Length; i++)
            {
                if (positionsArr[i] == position){
                    sum += this.salary[i];
                }
                sum += sum*staj/100;
            }
            Console.WriteLine($"{this.Name} \n{this.LastName}\n{position}\n{sum}");
            Console.WriteLine(sum - sum*0.14);
        }       
    }
}
