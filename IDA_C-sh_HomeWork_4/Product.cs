using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_HomeWork
{
    /* В целом мне идея в задании 1 не понравилась: как это Product наследник Money?
     Если Money отражает стоимость продукта мне кажется логичнее включить Money композционно как поле:
    Money _price
    */
    internal class Product : Money
    {
        public string prname_ { set; get; } = "abstract product"; 
        public Product(string product_name, string currency_name, long currency_integer, int currency_cents): 
            base(currency_name, currency_integer, currency_cents) { prname_ = product_name; }
        static public Product operator -(Product product_obj, Money money_obj)
        {
            if ((product_obj.integer_ + (double)product_obj.cents_ / 100) - (money_obj.integer_ + (double)money_obj.cents_ / 100) < 0) throw new ArgumentException("Money value couldn't be negative");
                
            return new Product(product_obj.prname_, product_obj.name_, product_obj.integer_ - money_obj.integer_, product_obj.cents_ - money_obj.cents_);
        }
        public void Info()
        {
            if (prname_ != null) 
            {
                Console.Write("\nProduct: " + prname_ + "\nPrice: ");
                COUT();            
            }
        }
    }
}
