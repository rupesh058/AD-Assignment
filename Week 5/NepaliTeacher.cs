using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // NepaliTeacher is inheriting from the Teacher class
    public class NepaliTeacher : Teacher
    {
        // overriding the Teaching() method from Teacher class
        // this will print the Nepali teacher's teaching style
        public override void Teaching()
        {
            Console.WriteLine("Nepali teacher teaches in Nepali language");
        }
    }
}
