using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
   class customer1
    {
        public int code_customer { set; get; }
        public string fname { set; get; }
        public string lname { set; get; }
        public int tell { set; get; }
        public string adress { set; get; }
       public string show()
           {
            return code_customer + " " + fname + " " + lname + " " + tell + " " + adress;
        }
    }
    class list_saled
    {
        public int code_lsaled_product { set; get; }
       
        public int number_product_s { set; get; }
        public int perproduct { set; get; }


        public string show()
        {
            return code_lsaled_product + " " + number_product_s + " " + perproduct;
        }

    }

    class product
    {
        public int code_product { set; get; }
        public string name_product { set; get; }
        public int price_product { set; get; }
        public string show()
        {
            return code_product + " " +name_product + " " + price_product;
        }
    }



}
