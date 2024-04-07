using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwevle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#12.	WAP to calculate the Gross Salary of an employee.\nAssume Gross Salary=Basic Salary+DA+HRA\nDA=40% of Basic Salary\nHRA=20% of Basic Salary");
            Console.WriteLine("================================================================================================================================================");
            Console.WriteLine("Enter your Basic Salary:->");
            double salary = Convert.ToDouble(Console.ReadLine());
            double DA = salary * (40.0 / 100.0);
            double HRA = salary * (20.0 / 100.0);
            Console.WriteLine(string.Format("The Gross salary is {0} with salary of {1} and Allowances - DA (40%)= {2} and HRA (20%)= {3}",(salary + DA + HRA), salary, DA,HRA));
               
            Console.ReadKey();
        }
    }
}
