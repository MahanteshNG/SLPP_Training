using System;
using System.Data;

namespace FlightBookingApp //Do not change the namespace name
{
    class Program //Do not change the class name
    {
        static void Main() 
        {
            try
            {
                //Invoke the FlightBLL's GetFlightDetails method to display the flightDetails
            	//And accept the passenger Details from the user and insert the record in the database
            	//using AddBooking method of FlightBLL class
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
