using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAirBnb
{
    class Neighbourhood
    {
        string NeighName;
        int NumberOfPropsInNeigh;
        Property[] Properties;
        

        //================================================Constructor==============================================//
        public Neighbourhood
            (string theNeighName,
            string theNumberOfPropsInNeigh,
            Property[] NeighAllProps)
        {
            NeighName = theNeighName;
            setNumberOfPropsInNeigh(theNumberOfPropsInNeigh);
            Properties = NeighAllProps;
        }


        //==================================================Getters==================================================//
        public string getNeighName()
        {
            return NeighName;
        }
        public int getNumberOfPropsInNeigh()
        {
            return NumberOfPropsInNeigh;
        }
        public Property[] getProperties()
        {
            return Properties;
        }


        //==================================================Setters==================================================//

        public void setNeighName(string inNeighName)
        {
            NeighName = inNeighName;
        }
        public void setNumberOfPropsInNeigh(string inNumberOfPropsInNeigh)
        {
            try
            {
                NumberOfPropsInNeigh = Convert.ToInt32(inNumberOfPropsInNeigh);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                    e.Message + " Please Input a Valid number.");
            }
        }
    }
}
