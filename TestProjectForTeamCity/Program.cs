using System;

namespace TestProjectForTeamCity
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(1,2));
        }
    }
}
