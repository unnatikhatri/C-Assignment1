using System;
using System.Collections.Generic;
using System.Text;

namespace Promact
{
    public class Employee
    {
        private int id;
        private string name;
        private string deptName;

        public Employee(int id_ex, string name_ex, string deptName_ex)
        {
            Id = id_ex;
            Name = name_ex;
            DeptName = deptName_ex;
        }
        public void GetId()
        {
            Console.WriteLine("GetId() method called.");
            Console.WriteLine(Id);
        }

        public void GetName()
        {
            Console.WriteLine("GetName() mathod called.");
            Console.WriteLine(Name);
        }

        public void GetDeptName()
        {
            Console.WriteLine("GetDeptName() mathod called.");
            Console.WriteLine(DeptName);
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }
 
            

    }
}
