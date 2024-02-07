using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Composite
{
    public abstract class Abstract_ShoppingClass : IShopping
    {
        int stock;
        string[] type;


        public abstract void set_Stock(int a);
        
        
        public abstract void get_Stock();
        public abstract void  get_type();

        public abstract void set_type(string a);
      
    }
}
