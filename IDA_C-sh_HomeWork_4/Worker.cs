using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    abstract internal class Worker
    {
        public string Manifest_ { set; get; } = "I am a ";
        public virtual void Print() { Console.WriteLine(Manifest_); }
    }
}
