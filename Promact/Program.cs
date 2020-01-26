using System;

namespace Promact
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string deptName;

            Console.WriteLine("Enter Id : ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Department Name : ");
            deptName = Console.ReadLine();

            Employee employee1 = new Employee(id, name, deptName);
            employee1.GetId();
            employee1.GetName();
            employee1.GetDeptName();

        }
    }
}
