using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Strategy
{
    public class AutoInsurance: Iinsurance
    {
        public int point;
        public int year;

       public AutoInsurance()
        {
            Console.WriteLine("Arabaniz Kac Yasinda :");
            int tempYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Surucu Puaniniz  :");
            int tempPoint = Convert.ToInt32(Console.ReadLine());

            this.point = tempPoint;
            this.year = tempYear;
        }

        public double calculate()
        {

            double temp = 100000 / (point + year);
            return temp;
        }

        public void showPrice()
        {
            Console.WriteLine("Araba Kasko Fiyatiniz : " + calculate());
        }

    }
}
