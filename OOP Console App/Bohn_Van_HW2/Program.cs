// Author: Van Bohn
//Date: 2/14/2019
//Assignment: Homework 2
//Description: Object Oriented Movie Theater Checkout Program
using System;



namespace Bohn_Van_HW2
{
    class Program
    {


        static void Main(string[] args)
        {
            //create variable for customer code
            String strCode;

            //create variable for checking customer code validity
            Boolean boolCodeValid;

            //create var for adult tickets
            String strAdultTic;


            // create bolt num
            String strChildTic;


            //create subtotal childprice variable 
            Decimal decCprice;



            //create subtotal adult price variable
            Decimal decAprice;

            //create subtotal price for Adult + child
            Decimal decB4taxPrice;



            //create tax variable
            Decimal decTax;

            //create total price variable
            Decimal decTot;

            Int32 intResult;
            Int32 intResultC;

            Int32 intTotalItem;

            //flag value to see if the program shouold process child tickets
            Int32 intCflag = 0;
            //check variable for adult tickets


            String strCustomerCode;
            Boolean boolEnumCorrect;
            String strCustomerTypeInput;
            do
            {
                //input
                Console.WriteLine("Which type of order do you want to process (CONSUMER or EVENT)");
                strCustomerTypeInput = Console.ReadLine();

                boolEnumCorrect = Validation.CheckCustomerType(strCustomerTypeInput);
            } while (boolEnumCorrect == false);

            do
            {
                Console.WriteLine("Please enter the number of adult tickets that you want to purchase");
                strAdultTic = Console.ReadLine();
                intResult = Validation.CheckItem(strAdultTic, 1);

                if (intResult == -1)
                {
                    Console.WriteLine("Your Input was invalid");
                }
            } while (intResult == -1);

            do
            {
                Console.WriteLine("Please enter the number of child tickets that you want to purchase");
                strChildTic = Console.ReadLine();
                intResultC = Validation.CheckItem(strChildTic, 0);

                if (intResultC == -1)
                {
                    Console.WriteLine("Your Input was invalid");
                }
            } while (intResultC == -1); 

 
  
            if (strCustomerTypeInput.ToUpper() == "CONSUMER")
            {
                CheckoutConsumer(intResult, intResultC);
            }
            else
            {
                CheckoutEvent(intResult, intResultC);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
        
        //method for the consumer checkout
        public static void CheckoutConsumer(Int32 intAdultTickets, Int32 intChildTickets)
        {
            String strName;

            ConsumerOrder Consumer = new ConsumerOrder();

            Console.WriteLine("What is the name of the customer");
            strName = Console.ReadLine();
            Consumer.CustomerName = strName;
            Consumer.NumberOfAdultTickets = intAdultTickets;
            Consumer.NumberOfChildTickets = intChildTickets;
            Consumer.CalcTotals();

            Console.WriteLine(Consumer.ToString());

        }

        public static void CheckoutEvent(Int32 intAdultTickets, Int32 intChildTickets)
        {
            String strCode;
            Boolean boolCodeValid;
            String strCustomerCode;
            do
            {
                //receive user code
                Console.WriteLine("Please enter your all letter customer code (4,5,or 6 characters)");
                strCode = Console.ReadLine();

                //checking code input using the CheckCode method
                boolCodeValid = Validation.CheckCustomerCode(strCode);
                if (boolCodeValid == false)
                {
                    Console.WriteLine("Invalid Input! Try again.");
                }
            } while (boolCodeValid == false); //loop if there is invalid input

            Decimal decCustCheck;
            Boolean boolPreferCust;

            String strServiceFee;

            do
            {
                Console.WriteLine("Enter the service fee:");
                strServiceFee = Console.ReadLine();


                decCustCheck = Validation.CheckServiceFee(strServiceFee);

            } while (decCustCheck == -1);
            String strPreferCustInput;
            Console.WriteLine("Is this a preferred customer? ('Y or y' for yes and other key for No)");
            strPreferCustInput = Console.ReadLine();
            if (strPreferCustInput == "y" || strPreferCustInput == "Y")
            {
                boolPreferCust = true;
            }
            else
            {
               boolPreferCust = false;
            }
            
        
            EventOrder Event = new EventOrder();
            Event.CustomerCode = strCode;
            Event.NumberOfAdultTickets = intAdultTickets;
            Event.NumberOfChildTickets = intChildTickets;
            Event.ServiceFee = decCustCheck;
            Event.PreferredCustomer = boolPreferCust;
            Event.CalcTotals();
            Console.WriteLine(Event.ToString());

        }


    }
}
