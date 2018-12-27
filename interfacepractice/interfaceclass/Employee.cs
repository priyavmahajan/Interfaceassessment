using interfacelibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceclass
{
    public class Employee:Person,IEmployee            //Child class as Employee inherit Person class and implements IEmployee interface
    {
        public int Empid { get; set; } 
        public override void Accept()
        {
            base.Accept();                            //base class methode override
            Console.WriteLine("Enter EMpID: ");
            Empid = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();                            //base class methode override
            Console.WriteLine("Employee Id: " + Empid);
        }
    }
}
