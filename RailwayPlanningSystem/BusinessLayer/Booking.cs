//Author: Fletcher Thomas Moore
/*Description: Retrieves the user/customer information from the presentation layer and stores it within the data layer as well as 
               displaying the information from the data layer within the presentation layer*/
//Start Date: 19/11/2018
//Last Edit: 04/01/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Booking
    {
        //setting up variables
        private string _bookingFirstName, _bookingLastName, _bookingTrainID, _bookingDepartStation, _bookingArrivalStation, _bookingCoach, _bookingSeat;
        private bool _bookingFirstClass, _bookingCabin;

        //get-set fistName
        public string firstName
        {
            get
            {
                return _bookingFirstName;
            }
            set
            {
                _bookingFirstName = value;
            }
        }

        //get-set lastName
        public string lastName
        {
            get
            {
                return _bookingLastName;
            }
            set
            {
                _bookingLastName = value;
            }
        }

        //get-set booking TrainID
        public string trainID
        {
            get
            {
                return _bookingTrainID;
            }
            set
            {
                _bookingTrainID = value;
            }
        }

        //get-set departStation
        public string departStation
        {
            get
            {
                return _bookingDepartStation;
            }
            set
            {
                _bookingDepartStation = value;
            }
        }

        //get-set arrivalStation
        public string arrivalStation
        {
            get
            {
                return _bookingArrivalStation;
            }
            set
            {
                _bookingArrivalStation = value;
            }
        }

        //get-set coach
        public string coach
        {
            get
            {
                return _bookingCoach;
            }
            set
            {
                _bookingCoach = value;
            }
        }

        //get-set seat
        public string seat
        {
            get
            {
                return _bookingSeat;
            }
            set
            {
                _bookingSeat = value;
            }
        }

        //get-set firstClass
        public bool bookFirstClass
        {
            get
            {
                return _bookingFirstClass;
            }
            set
            {
                _bookingFirstClass = value;
            }
        }

        //get-set cabin
        public bool cabin
        {
            get
            {
                return _bookingCabin;
            }
            set
            {
                _bookingCabin = value;
            }
        }
    }
}
