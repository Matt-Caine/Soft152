using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAirBnb
{
    class District
    {
        string DistName;
        int NumberOfNeighsInDist;
        Neighbourhood[] Neighbourhoods;

        //================================================Constructor==============================================//
        public District
            (string theDistName,
            string theNumberOfNeighsInDist,
            Neighbourhood[] DistAllNeighs
            )
        {
            DistName = theDistName;
            setNumberOfPropsInNeigh(theNumberOfNeighsInDist);
            Neighbourhoods = DistAllNeighs;
            
        }


        //==================================================Getters==================================================//
        public string getDistName()
        {
            return DistName;
        }
        public int getNumberOfNeighsInDist()
        {
            return NumberOfNeighsInDist;
        }
        public Neighbourhood[] getNeighbourhoods()
        {
            return Neighbourhoods;
        }


        //==================================================Setters==================================================//

        public void setNeighName(string inDistName)
        {
            DistName = inDistName;
        }
        public void setNumberOfPropsInNeigh(string inNumberOfPropsInNeigh)
        {
            try
            {
                NumberOfNeighsInDist = Convert.ToInt32(inNumberOfPropsInNeigh);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                    e.Message + " Please Input a Valid number.");
            }


        }
        public void setlibBooks(Neighbourhood[] inDistAllNeighs)
        {
            Neighbourhoods = inDistAllNeighs;
        }


    }
}

