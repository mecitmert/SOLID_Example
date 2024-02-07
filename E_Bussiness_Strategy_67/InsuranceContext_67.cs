using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Strategy
{
    public class InsuranceContext
    {
        Iinsurance traffic;
        Iinsurance aoutoIn;
        Iinsurance ndi;

        public InsuranceContext(int temp)
        {
            if (temp == 1)
            {
                traffic = new TrafficInsurance();
                traffic.showPrice();
            }
            else if (temp == 2)
            {
                aoutoIn = new AutoInsurance();
                aoutoIn.showPrice();
            }
            else if (temp == 3) 
            {
                ndi = new NDI();
                ndi.showPrice();    
            }
        }
    }
}
