using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAirBnb
{
    class Property
    {
        private int PropID;
        private string PropName;
        private int HostID;
        private string HostName;
        private int NumberOfPropsOwned;
        private double Latitude;
        private double Longitude;
        private string RoomType;
        private Decimal Price;
        private int MinNightsStay;
        private int DaysAvail;

        //================================================Constructor==============================================//
        public Property
            (string thePropID, string thePropName, string theHostID, string theHostName, string theNumberOfPropsOwned,
            string theLatitude, string theLongitude, string theRoomType, string thePrice, string theMinNightsStay, string theDaysAvail)
        {

            PropName = thePropName;
            HostName = theHostName;
            RoomType = theRoomType;

            setLatitude(theLatitude);
            setLongitude(theLongitude);
            setPrice(thePrice);
            setHostID(theHostID);
            setPropID(thePropID);
            setNumberOfPropsOwned(theNumberOfPropsOwned);
            setMinNightsStay(theMinNightsStay);
            setDaysAvail(theDaysAvail);
        }


        //==================================================Getters==================================================//
        public int getPropID()
        {
            return PropID;
        }
        public string getPropName()
        {
            return PropName;
        }
        public int getHostID()
        {
            return HostID;
        }
        public string getHostName()
        {
            return HostName;
        }
        public int getNumberOfPropsOwned()
        {
            return NumberOfPropsOwned;
        }
        public double getLatitude()
        {
            return Latitude;
        }
        public double getLongitude()
        {
            return Longitude;
        }
        public string getRoomType()
        {
            return RoomType;
        }
        public Decimal getPrice()
        {
            return Price;
        }
        public int getMinNightsStay()
        {
            return MinNightsStay;
        }
        public int getDaysAvail()
        {
            return DaysAvail;
        }


        //==================================================Setters==================================================//
        public void setPropID(string inPropID)
        {
            try
            {
                PropID = Convert.ToInt32(inPropID);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " +
                    e.Message + " Please Input a Valid Property ID");
            }
        }
        public void setPropName(string inPropName)
        {
            PropName = inPropName;
        }
        public void setHostID(string inHostID)
        {
            try
            {
                HostID = Convert.ToInt32(inHostID);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " +
                    e.Message + " Please Input a Valid Host ID");
            }
        }
        public void setHostName(string inHostName)
        {
            HostName = inHostName;
        }
        public void setNumberOfPropsOwned(string inNumberOfPropsOwned)
        {
            try
            {
                NumberOfPropsOwned = Convert.ToInt32(inNumberOfPropsOwned);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " +
                    e.Message + " Please Input a Valid Number");
            };
        }
        public void setLatitude(string inLatitude)
        {
            {
                try
                {
                    Latitude = Convert.ToDouble(inLatitude);
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " +
                        e.Message + " Please Input a Valid Latitude");
                }

            }
        }
        public void setLongitude(string inLongitude)
        {
            {
                try
                {
                    Longitude = Convert.ToDouble(inLongitude);
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " +
                        e.Message + " Please Input a Valid Longitude");
                }

            }
        }
        public void setRoomType(string inRoomType)
        {
            RoomType = inRoomType;
        }
        public void setPrice(string inPrice)
        {
            {
                try
                {
                    Price = Convert.ToDecimal(inPrice);
                }
                catch (FormatException e)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " +
                        e.Message + " Please Input a Valid Price");
                }

            }
        }
        public void setMinNightsStay(string inMinNightsStay)
        {
            try
            {
                MinNightsStay = Convert.ToInt32(inMinNightsStay);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " +
                    e.Message + " Please Input a Valid Number");
            }

        }
        public void setDaysAvail(string inDaysAvail)
        {
            try
            {
                DaysAvail = Convert.ToInt32(inDaysAvail);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " +
                    e.Message + " Please Input a Valid Number");
            }

        }

    }
}

