using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Bus
    {
        public string Registration {  get; set; }
        public string Name { get; set; }

        public List<Lines> Lines;

        public Bus(string registration, string name)
        {
            Registration = registration;
            Name = name;
            Lines = new List<Lines>();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Name, Registration);
        }
    }
}
