using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Strategy
{
    public class TrafficInsurance :Iinsurance
    {
        int point;
        int year;

        public TrafficInsurance()
        {
            Console.WriteLine("Arabaniz Kac Yasinda :");
            int tempYear=  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Surucu Puaniniz  :");
            int tempPoint = Convert.ToInt32(Console.ReadLine());

            this.point = tempPoint;
            this.year = tempYear;
        }

        public double calculate()
        {

            double temp = 50000 / (point + year);
            return temp;
        }

        public void showPrice()
        {
            Console.WriteLine("Trafik Sigortasi Fiyatiniz : " + calculate());
        }

    }
}
