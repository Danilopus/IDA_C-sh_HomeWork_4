using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDA_C_sh_HomeWork
{
    internal class Car : Device
    {
        public Car()
        {            
                Name_ = "\nCar";
                Desc_ = "\nThis device is used for moving on the roads";
                Sound_ = "\nrrrrrrrrr (noise of engine)";            
        }
    }
    
}
