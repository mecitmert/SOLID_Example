using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    internal class Process : Abstract_ShoppingClass, CompositeShop
    {
        IShopping shopping;
        public Process(IShopping shopping) 
        {
            while(true)
            {
                Console.WriteLine("Personel Girisi");
                string username = "mecitmert";
                string password = "mecit123";
                Console.WriteLine("Kullanici adi :");
                string name;
                name = Console.ReadLine();
                Console.WriteLine("Sifre : ");
                string password1;
                password1 = Console.ReadLine(); 
                if(password1==password &&  name==username)
                {
                    Console.WriteLine("Giris Basarili");
                    break;
                }
                Console.WriteLine("Kullanici adi ve sifre yanlis tekrar deneyiniz");

            }
            this.shopping = shopping;
        }

        public override void get_Stock()
        {
            Console.WriteLine("Personel sunucusundan urunun stogu getiriliyor:");
            shopping.get_Stock();
        }

        public override void get_type()
        {
            Console.WriteLine("Personel sunucusundan urunun Turleri getiriliyor:");
            shopping.get_type();
            
        }

       

        public void stock_Delete()
        {
            Console.WriteLine("Personel sunucusundan urunun stok verisi siliniyor :");
            shopping.set_Stock(0);
            Console.WriteLine("Uyari :Stock Silindi");

        }

        public void stock_Update()
        {
            Console.WriteLine("Urun Stok miktari guncelleme");
            Console.WriteLine("Girmek istediginiz stogu yaziniz");
            int convertDegisken;
            convertDegisken = Convert.ToInt32(Console.ReadLine());
            shopping.set_Stock(convertDegisken);

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
