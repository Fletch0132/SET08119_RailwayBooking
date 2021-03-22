//Author: Fletcher Thomas Moore
/*Description: Stores the prices as private for the fares, can be accessed through get-set to calculate full price*/
//Start Date: 19/11/2018
//Last Edit: 13/12/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FarePrices
    {
        //Set fares
        private decimal _FareEdinLon = 50.00M, _FareInterStation = 25.00M, _FareFirstClass = 10.00M, _FareSleeper = 10.00M, _FareSleeperCabin = 20.00M;

        //Fare price from Edinburgh to London (Vice versa)
        public decimal fareEdinLon
        {
            get
            {
                return _FareEdinLon;
            }
            set
            {
                _FareEdinLon = value;
            }
        }

        //Fare price from two intermediate stations or Edin/Lon to intermediate (vice versa)
        public decimal fareInterStation
        {
            get
            {
                return _FareInterStation;
            }
            set
            {
                _FareInterStation = value;
            }
        }

        //Fare Surcharge for first class
        public decimal fareFirstClass
        {
            get
            {
                return _FareFirstClass;
            }
            set
            {
                _FareFirstClass = value;
            }
        }

        //Fare surcharge for Sleeper
        public decimal fareSleeper
        {
            get
            {
                return _FareSleeper;
            }
            set
            {
                _FareSleeper = value;
            }
        }

        //Fare surcharge for Sleeper Cabin
        public decimal fareSleeperCabin
        {
            get
            {
                return _FareSleeperCabin;
            }
            set
            {
                _FareSleeperCabin = value;
            }
        }
    }
}
