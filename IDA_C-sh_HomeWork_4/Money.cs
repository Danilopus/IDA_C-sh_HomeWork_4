using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    internal class Money
    {
        public string name_ { get; set; } = "Abstract currency";
        //public long integer_ { get; set; } = 1;
        public long integer_ { set; get; } = 1;
        int _cents;
        Money() { }
        public Money(string name, long integer, int cents)
        {
            name_ = name;
            integer_ = integer + cents / 100;
            _cents = cents % 100;
        }
        public int cents_
        {
            get { return _cents;}
            set 
            {
                _cents = value%100;
                integer_ += value/100;
            }
        }
        public void COUT()
        {
            Console.Write(integer_ + (double)(_cents) / 100 + " " + name_);
            
        }
        public override string ToString()
        {
            //return (Math.Round((integer_ + (double)(_cents) / 100), 2) + " " + name_).ToString().PadLeft(4);
            return (Math.Round((integer_ + (double)(_cents) / 100), 2) + " " + name_);
        }    
        static public Money operator +(Money a, Money b) 
        {
            if (a.name_ != b.name_) throw new ArgumentException("Cannot operate: different currencies");
            return new Money(a.name_, a.integer_+b.integer_, a._cents + b._cents);
        }
    }
}
