using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Utilities
{

    public static class Extenions
    {
        public static bool ValidateEmpid(this Models.Empployee e)
        {
            return false;

        }
        public static string  AddString(this string s, string s1)
        {
            s += s1;
            return s;

        }

        public static bool ValidateOrderid(this Models.order o)
        {
            bool flag = false;
            if (o.Orderid>0)
                flag =  true;
            else
                flag = false;

            return flag;


        }
    }


}

namespace Helprs
{
    public class Utils
    {
        public  bool ValidateEmpid(int empid)
        {  return false; }
    }
}
