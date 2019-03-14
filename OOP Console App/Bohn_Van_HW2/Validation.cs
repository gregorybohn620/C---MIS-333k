using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Bohn_Van_HW2
{

    static class Validation
    {
        //method
        public static Boolean CheckCustomerCode(String strInput)
        {
            if (((strInput.Length < 4) || (strInput.Length > 6)) || !(Regex.IsMatch(strInput, @"^[a-zA-Z]+$")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //method to check if the strInput is one of the enum options
        public static Boolean CheckCustomerType(String strInput)
        {
            strInput = strInput.ToUpper();

            //Enum.IsDefined(typeof(enumname), strinput) returns true if the strInput variable is one of the enum types // else returns false
            return Enum.IsDefined(typeof(CustomerType), strInput);  
        }
        public static Decimal CheckServiceFee(String strInput)
        {
            Decimal decResult;
            try
            {
                decResult = Convert.ToDecimal(strInput);

            }
            catch
            {
                return -1;
            }
            
            if(decResult < 0 )
            {
                return -1;
            }

            else
            {
                return decResult;
            }
        }
        public static Int32 CheckItem(String strInput, Int32 intLowerBound)
        {
            Int32 intResult;
            try
            {
                intResult = Convert.ToInt32(strInput);
            }
            catch
            {
                return -1;
            }
            if (intResult < 0)
            {
                return -1;
            }

            if (intResult < intLowerBound)
            {
                return -1;
            }
            return intResult;
        }


    }

}