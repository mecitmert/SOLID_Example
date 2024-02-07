using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    public  interface IShopping
    {
        public void get_Stock();
  
        public void get_type();

        public void set_Stock(int a);
        public void set_type(string a); 
        

    }
}
