using interfacelibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceclass
{
    public class Person : IPerson           //person class implements IPerson interface
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Accept()            //Methode of parrent class
        {
            Console.WriteLine("Enter name of person: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age of person: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Display()              //Methode of parrent class
        {
            Console.WriteLine("Name of person is: " + Name);
            Console.WriteLine("Age of person is: " + Age);

        }
    }
}
