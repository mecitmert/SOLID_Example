using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Strategy
{
    public class NDI : Iinsurance//natural disaster insurance(Dogal afet sigortasi)
    {
         public double year;
        public double floor;
        public NDI()
        {
            Console.WriteLine("Eviniz Kac Yasinda :");
            int tempYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kat Sayisi :");
            int tempFloor = Convert.ToInt32(Console.ReadLine());
            year = tempYear;
            floor = tempFloor;
        }

        public double calculate()
        {
            double temp;
            temp = floor / year * 8000;
            return temp;
        }

        public void showPrice()
        {
            Console.WriteLine("Dogal Afet Sigorta Fiyatiniz : " + calculate());
        }
    }
}
