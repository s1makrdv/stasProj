using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basedata_13
{
    public class Passenger
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public int    FlightNumber;
        public int    BaggageReceiptNumber;
        public int    LuggagePiecesNumber;
        public int    TotalBaggageWeight;

        public Passenger(string FirstName, string LastName, string MiddleName, int FlightNumber, int BaggageReceiptNumber, int LuggagePiecesNumber, int TotalBaggageWeight)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.FlightNumber = FlightNumber;
            this.BaggageReceiptNumber = BaggageReceiptNumber;
            this.LuggagePiecesNumber = LuggagePiecesNumber;
            this.TotalBaggageWeight = TotalBaggageWeight;
        }
    }

}
