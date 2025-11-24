using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Teacher
    {
        // private field to store the name of the teacher
        private string name;

        // public property to get and set the name
        public string Name
        {
            get { return name; }   // return name value
            set { name = value; }  // set name value
        }

        // virtual method so child classes can override this and give their own version
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // this method cannot be overridden because it is not virtual
        // sealed keyword cannot be used here because only overridden methods can be sealed
        public void SalaryInfo()
        {
            Console.WriteLine("Salary information: Teachers only get salary after completion of three months.");
        }
    }
}
