using System;
using System.Collections.Generic;
using System.Text;

namespace Bohn_Van_HW2
{

    class ConsumerOrder : Order
    {
        //Sales_TAX_RATE is a constant
        const Decimal SALES_TAX_RATE = .085m;

        private Decimal _decTax;
        

        //Constructor
       /// public ConsumerOrder(Int32 intNumberOfAdultTickets, Int32 intNumberOfChildTickets, String strCustomerName )
       // {
         //   NumberOfAdultTickets = intNumberOfAdultTickets;
          //  NumberOfChildTickets = intNumberOfChildTickets;
          //  CustomerName = strCustomerName;

       // }

        //property SalesTaxAmount
        public Decimal SalesTaxAmount
        {
            get{return _decTax; }
        }
        public string CustomerName{ set; get;}

        //method Calctotals() - 
        public void CalcTotals()
        {
            _decTax = SALES_TAX_RATE* Subtotal;
            decTotal = Subtotal + _decTax;
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
            myStringBuilder.Append("Customer Name: " + CustomerName + "\n");
            myStringBuilder.Append("Total Items: " + TotalItem + "\n");
            myStringBuilder.Append("Adult Subtotal: " + AdultSubtotal.ToString("c") + "\n");
            myStringBuilder.Append("Child Subtotal: " + ChildSubtotal.ToString("c") + "\n");
            myStringBuilder.Append("Subtotal: " + Subtotal.ToString("c") + "\n");
            myStringBuilder.Append("Sales Tax:" + SalesTaxAmount.ToString("c") + "\n");
            myStringBuilder.Append("Grand Total: " + Total.ToString("c") + "\n");

            StringVar = myStringBuilder.ToString();

            return StringVar;
        }
    }
}
