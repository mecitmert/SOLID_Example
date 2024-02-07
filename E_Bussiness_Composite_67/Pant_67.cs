using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    public class Pant : Abstract_ShoppingClass
    {
        int stock;
        string[] type = { "Kot Pantolon ", " Kumas Pantolon", "Esofman ", "Sort" };
        public Pant(int stock)
        {
            Console.WriteLine("Pontolon Reyonuna Hosgeldiniz");
            this.stock = stock;
        }

        public override void get_Stock()
        {
            Console.WriteLine("Toplamda " + stock + " kadar Pantolon var");
        }

        public override void get_type()
        {
            Console.WriteLine("Elimizdeki Pantolon turleri");
            foreach (var type in type)
            {
                Console.WriteLine($"{type}");
            }
        }
      

        public override void set_Stock(int a)
        {
           stock = a;
        }

        public override void set_type(string a)//burada hata var
        {
            while (true) 
            {
                type [type.Length] = a; 
            }
        }
    }
}
