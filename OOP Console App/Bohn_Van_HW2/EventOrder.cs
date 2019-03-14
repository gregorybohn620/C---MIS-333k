using System;
using System.Collections.Generic;
using System.Text;

namespace Bohn_Van_HW2
{
    class EventOrder:Order
    {
        public String CustomerCode { get; set; }
        public Decimal ServiceFee { get; set; }
        public Boolean PreferredCustomer { get; set;}

        //Constructor
        //public EventOrder(Int32 intNumberOfAdultTickets, Int32 intNumberOfChildTickets, String strCustomerCode, Decimal decServiceFee, Boolean boolPreferredCustomer)
        //{
          //  NumberOfAdultTickets = intNumberOfAdultTickets;
            //NumberOfChildTickets = intNumberOfChildTickets;
            //CustomerCode = strCustomerCode;
            //ServiceFee = decServiceFee;
            //PreferredCustomer = boolPreferredCustomer;   
        //}

        public void CalcTotals()
        {   
            //?????is it wrong to do the PreferredCustomer / Service Fee method logic in the CalcTotals() method?????
            if(PreferredCustomer = true)
            {
                ServiceFee = 0.0m;
            }
            decTotal = Subtotal + ServiceFee;
        }
        public override string ToString()
        {   
            //Creates a variable to be used to convert the myStringBuilder into a string
            String StringVar;

            //instatiates an object of the StringBuilder class
            StringBuilder myStringBuilder = new StringBuilder();

            //Adding to String
            myStringBuilder.Append("\n");
            myStringBuilder.Append("Customer Type: EVENT \n");
            myStringBuilder.Append("Customer Code: " + CustomerCode + "\n");
            myStringBuilder.Append("Total Items: " + TotalItem + "\n");
            myStringBuilder.Append("Adult Subtotal: " + AdultSubtotal.ToString("c") + "\n" );
            myStringBuilder.Append("Child Subtotal: " + ChildSubtotal.ToString("c") + "\n");
            myStringBuilder.Append("Subtotal: " + Subtotal.ToString("c") + "\n");
            myStringBuilder.Append("Service Fee:" + ServiceFee.ToString("c") + "\n");
            myStringBuilder.Append("Grand Total: " + Total.ToString("c") + "\n");

            StringVar = myStringBuilder.ToString();

            return StringVar;
        }
    }

}
