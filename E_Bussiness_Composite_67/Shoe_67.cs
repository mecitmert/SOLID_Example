using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    public class Shoe : Abstract_ShoppingClass
    {
        int stock;
        string[] type = {"Spor Ayakkabi " , " Gunluk Ayakkabi"  , "Bot " , "Terlik"};
        public Shoe(int stock) 
        {
            Console.WriteLine("Pontolon Reyonuna Hosgeldiniz");

            this.stock = stock; 
        }

        public override void get_Stock()
        {
            Console.WriteLine("Toplamda " + stock + " kadar ayakkabi var");
        }

        public override void get_type()
        {
         foreach(var  type in type)
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
