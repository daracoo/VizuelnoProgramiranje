using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Lines
    {
        public int Hour {  get; set; }
        public int Minute { get; set; }
        public int Price {  get; set; }
        public string Destination { get; set; }

        public Lines(int hour, int minute, int price, string destination)
        {
            Hour = hour;
            Minute = minute;
            Price = price;
            Destination = destination;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00} - {2} - {3}ден.", Hour, Minute, Destination, Price);
        }
    }
}
