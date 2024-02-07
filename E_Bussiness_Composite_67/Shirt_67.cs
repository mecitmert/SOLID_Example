using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    public class Shirt : Abstract_ShoppingClass
    {
        int stock;
        string[] type = { "Beyaz Gomlek ", " Kareli Gomlek", "Oduncu Gomlek ", "Kisa Kollu Gomlek" };
        public Shirt(int stock) 
        {
            Console.WriteLine("Gomlek Reyonuna Hosgeldiniz");
            this.stock = stock; 
        }

        public override void get_Stock()
        {
            Console.WriteLine("Toplamda " + stock + " kadar gomlek var");
        }

        public override void get_type()
        {
            Console.WriteLine("Elimizdeki Gomlek Turleri");
            foreach (var type in type)
            {
                Console.WriteLine(type.ToString());
            }
        }
    
        public override void set_Stock(int a)
        {
            throw new NotImplementedException();
        }

        public override void set_type(string a)
        {
            throw new NotImplementedException();
        }
    }
}
