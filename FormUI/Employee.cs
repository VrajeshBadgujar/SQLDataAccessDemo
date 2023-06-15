using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
        public string city { get; set; }

     

        public string FullInfo
        {
            get {
                return $" {name} {gender} {salary} {city}";
                 }
            
        }

    }
}
