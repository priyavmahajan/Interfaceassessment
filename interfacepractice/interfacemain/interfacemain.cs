using interfaceclass;
using interfacelibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacemain
{
   public  class interfacemain
    {
        static void Main(string[] args)
        {
            //IDepartment dept = new Department();                //Idepartment interface variable nd department class constructor iscallled
            //Console.WriteLine(dept.department = "xyz");

            //IEmployee emp = new Department();                //IEmployee interface variable nd Department class Constructor is called
            //Console.WriteLine(emp.Empid = 10);

            IPerson person = new Department();           //IPerson interface variable nd Department class Constructor is called
            Console.WriteLine( person.Name = "PQR");
            Console.WriteLine(person.Age = 18);
            
            //Department department = new Department();   //simple department class object is called
            //department.Accept();
            //department.Display();
            Console.ReadLine();
        }
    }
}
