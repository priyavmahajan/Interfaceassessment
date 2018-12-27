using interfacelibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfaceclass
{
   public class Department:Employee,IDepartment     //derived class Department from Employee and implement interface IDepartment
    {
        public string department { get; set; }
        public override void Accept()
        {
            base.Accept();                    //base class employee methode override
            Console.WriteLine("Enter the Department: ");
            department = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();                   //base class employee methode override
            Console.WriteLine("Department is: " + department);
        }
    }
}
