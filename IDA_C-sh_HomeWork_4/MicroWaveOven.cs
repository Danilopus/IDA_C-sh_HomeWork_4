using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    internal class MicroWaveOven : Device
    {
        public MicroWaveOven()
        {
            Name_ = "\nMicroWaveOven";
            Desc_ = "\nThis device is used for heating food with microwaves";
            Sound_ = "\nffffff (noise of cooling vent)";
        }
    }
}
