using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    abstract internal class Device
    {
        public string Name_ { set; get; }
        public string Desc_ { set; get; }
        public string Sound_ { set; get; }
        public virtual void Sound() { Console.WriteLine("Sound: {0}", Sound_); }
        public virtual void Show() { Console.WriteLine("\nDevice name: {0}", Name_); }
        public virtual void Desc() { Console.WriteLine("Description: {0}", Desc_); }

    }
}
