using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string year { get; set; } = "Default value";
        public string make { get; set; } = "Default value";
        public string model { get; set; } = "Default value";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive");

        }
        
    }
}
