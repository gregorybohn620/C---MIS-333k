using System;
using System.Collections.Generic;
using System.Text;

namespace Bohn_Van_HW2
{
    public enum CustomerType {CONSUMER = 0 , EVENT = 1 }
    abstract class Order
    {
        //CONSTANTS
        const Decimal ADULTTICKETPRICE = 11m;
        const Decimal CHILDTICKETPRICE = 7m;

        //private to keep outside parties from reassignign the subtotal
        //??Should these be private?? should I have these located here or elsewhere??
        private Decimal _decAdultSubtotal;
        private Decimal _decChildSubtotal;
    
        public Decimal decTotal;

        public Int32 NumberOfAdultTickets { set; get; }
        public Int32 NumberOfChildTickets { set; get; }

        //Constructor
        public Order(Int32 intNumberOfAdultTickets, Int32 intNumberOfChildTickets)
        {
            NumberOfAdultTickets = intNumberOfAdultTickets;
            NumberOfChildTickets = intNumberOfChildTickets;  
        }

        //calculates AdultSUbtotal Cost within propety
        public Decimal AdultSubtotal
        {

            get { return NumberOfAdultTickets * ADULTTICKETPRICE; }

        }
        //Makes ChildSubtotal cost a property
        public Decimal ChildSubtotal
        {
            get { return NumberOfChildTickets * CHILDTICKETPRICE; }
        }
        //Makes Subtotal a property
        public Decimal Subtotal
        {
            get { return AdultSubtotal + ChildSubtotal; }
        }
        //Makes the TotlItems purchased a property

        public Int32 TotalItem
        {
            get { return NumberOfAdultTickets + NumberOfChildTickets; }
        }
        //Makes the Total cost a property
        public Decimal Total
        {
            get
            {
                return decTotal;
            }
        }

        //??Should I create separate methods for each of these calculations or can I do all of the calculatiuons in one method??
        public void CalcTotals()
        { }

        public Order() { }
    }
}

