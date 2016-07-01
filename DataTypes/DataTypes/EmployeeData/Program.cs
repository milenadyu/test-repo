using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";// Console.ReadLine();
            string lastName = "Jonson";// Console.ReadLine();
            byte age = 27;// int.Parse(Console.ReadLine());
            char gender = 'f';// Console.ReadLine();
            ulong personaID = 8306112507;// ulong.Parse(Console.ReadLine());
            ulong employeeID = 27563571;// ulong.Parse(Console.ReadLine());
                                        //Console.WriteLine(firstName);
                                        //Console.WriteLine(lastName);
                                        //Console.WriteLine(age);
                                        //Console.WriteLine(gender);
                                        //Console.WriteLine(personaID);
                                        //Console.WriteLine(employeeID);

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personaID);
            Console.WriteLine("Unique Employee number: {0}", employeeID);
        }
    }
}
