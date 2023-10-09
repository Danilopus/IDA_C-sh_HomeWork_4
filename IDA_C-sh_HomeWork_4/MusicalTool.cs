using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    abstract internal class MusicalTool
    {
        public string Name_ { set; get; }
        public string Desc_ { set; get; }
        public string Sound_ { set; get; }
        public string History_ { set; get; }
        public virtual void Sound() { Console.WriteLine("Sound: {0}", Sound_); }
        public virtual void Show() { Console.WriteLine("\n*** Device name: {0}", Name_); }
        public virtual void Desc() { Console.WriteLine("Description: {0}", Desc_); }
        public virtual void History() { Console.WriteLine("History: {0}", History_); }

    }
}
