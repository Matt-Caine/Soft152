using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;




namespace NewAirBnb
{
    public partial class Form1 : Form
    {
        //Data IN

        public static string theFile = ("MaxiDataFile.txt");
        public bool endOfDist = false;
        public bool endOfNeigh = false;

        //public static System.Drawing.Color Red { get; }
        public int selDictrict;
        public int selNeigh;


        StreamReader inTheFile = new StreamReader(theFile);
        int LinCount = File.ReadLines(theFile).Count();

        //Arrays

        Property[] allProps;
        Neighbourhood[] allNeighs;
        District[] allDists;


        public Form1()
        {
            InitializeComponent();
            setupMain();
            
        }
         

        //Distrcit

        private District getDistrict()
        {

            District tempDistrict;


            string tempDistrictName = inTheFile.ReadLine();
            string tempNeighbourhoodNum = inTheFile.ReadLine();




            int NeighbourhoodsInDistrict = Convert.ToInt32(tempNeighbourhoodNum);

            Neighbourhood[] allNeighbourhoods = new Neighbourhood[NeighbourhoodsInDistrict];
            if (tempDistrictName == null)
            {
                endOfDist = true;

            }


            //Neighbourhood 
            for (int i = 0; i < NeighbourhoodsInDistrict; i++)
            {


                Neighbourhood tempNeighbourhood;

                string tempNeighbourhoodName = inTheFile.ReadLine();
                string tempNumOfProperties = inTheFile.ReadLine();

                int propertiesInNeighbourhood = Convert.ToInt32(tempNumOfProperties);

                Property[] allProperties = new Property[propertiesInNeighbourhood];

                //property

                for (int ii = 0; ii < propertiesInNeighbourhood; ii++)
                {
                    Property tempProperty;


                    string tempPropertyID = inTheFile.ReadLine();
                    string tempPropertyName = inTheFile.ReadLine();
                    string hostID = inTheFile.ReadLine();
                    string hostName = inTheFile.ReadLine();
                    string tempNumOfHostProperties = inTheFile.ReadLine();
                    string tempLatitude = inTheFile.ReadLine();
                    string tempLongitude = inTheFile.ReadLine();
                    string tempRoomType = inTheFile.ReadLine();
                    string tempPrice = inTheFile.ReadLine();
                    string tempMinNightNum = inTheFile.ReadLine();
                    string tempDaysAvailable = inTheFile.ReadLine();


                    tempProperty = new Property(tempPropertyID, tempPropertyName,
                        hostID, hostName, tempNumOfHostProperties, tempLatitude,
                        tempLongitude, tempRoomType, tempPrice, tempMinNightNum,
                        tempDaysAvailable);


                    allProperties[ii] = tempProperty;

                }



                tempNeighbourhood = new Neighbourhood(tempNeighbourhoodName,
                        tempNumOfProperties, allProperties);

                allNeighbourhoods[i] = tempNeighbourhood;
            }

            tempDistrict = new District(tempDistrictName, tempNeighbourhoodNum, allNeighbourhoods);
            
            return tempDistrict;
        }



        //SetMain
        private void setupMain()
        {
            inTheFile = new StreamReader(theFile);
            allDists = new District[0];
            allNeighs = new Neighbourhood[0];
            allProps = new Property[0];

            while (endOfDist == false)
            {
                Array.Resize(ref allDists, allDists.Length + 1);
                allDists[allDists.Length - 1] = getDistrict();


                string tempName = allDists[allDists.Length - 1].getDistName();


                if (tempName == null)
                {
                    Array.Resize(ref allDists, allDists.Length - 1);
                }


            }

            inTheFile.Close();
            
        }

        










        //Buttons
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        //Selected Boxs
        private void lstDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNeigh.Items.Clear();
            selDictrict = lstDist.SelectedIndex;
            


            try
            {
                District tempDistrict = allDists[selDictrict];
                Neighbourhood[] tempNeigh = tempDistrict.getNeighbourhoods();


                foreach (Neighbourhood n in tempNeigh)
                {
                    lstNeigh.Items.Add(n.getNeighName() + "  " + "(" + n.getNumberOfPropsInNeigh() + ")");
                }
            }
            catch
            {
                MessageBox.Show("Please choose a valid option", "Invalid Selection");
            }
        }

        private void lstNeigh_SelectedIndexChanged(object sender, EventArgs e)
        {


            lstV.Items.Clear();

            selNeigh = lstNeigh.SelectedIndex;

            District tempDistrict = allDists[selDictrict];
            Neighbourhood[] tempNeighbourhoodArray = tempDistrict.getNeighbourhoods();

            int numNeighbourhoods = tempDistrict.getNumberOfNeighsInDist();

            //Add to listview / make it look pretty 

            try
            {
                Neighbourhood tempNeighborhood = tempNeighbourhoodArray[selNeigh];
                Array.Resize(ref allNeighs, numNeighbourhoods);
                Property[] tempPropertieArray = tempNeighborhood.getProperties();

                foreach (Property p in tempPropertieArray)
                {
                    ListViewItem lvi = new ListViewItem("🏡");

                    string PropID = Convert.ToString(p.getPropID());
                    lvi.SubItems.Add("𝗜𝗗: " + PropID);



                    lvi.SubItems.Add(p.getPropName());

                    if (p.getRoomType() == "Entire home/apt")
                    {
                        lvi.SubItems.Add("Home/Apt");
                    }
                    else
                    {
                        lvi.SubItems.Add(p.getRoomType());

                    }



                    string Price = Convert.ToString(p.getPrice());
                    lvi.SubItems.Add("£" + Price + ".00");

                    string Avail = Convert.ToString(p.getDaysAvail());

                    if (Avail == "0")
                    {
                        lvi.SubItems.Add("❌  Fully Booked ");
                        //lvi.BackColor = Red;
                    }
                    else if (Avail == "1")
                    {
                        lvi.SubItems.Add("✔️ " + Avail + " Day Left");
                    }
                    else
                    {
                        lvi.SubItems.Add("✔️  " + Avail + " Days Left");
                    }


                    string Cordslong = Convert.ToString(p.getLongitude());
                    string Cordslat = Convert.ToString(p.getLatitude());
                    lvi.SubItems.Add(Cordslat + "  " + Cordslong);

                    string minNight = Convert.ToString(p.getMinNightsStay());
                    if (minNight == "1")
                    {
                        lvi.SubItems.Add(minNight + " Night");
                    }
                    else
                    {
                        lvi.SubItems.Add(minNight + " Nights");
                    }


                    lvi.SubItems.Add("👤");

                    string HostID = Convert.ToString(p.getHostID());
                    lvi.SubItems.Add("𝗜𝗗: " + HostID);

                    lvi.SubItems.Add(p.getHostName());



                    string propsowned = Convert.ToString(p.getNumberOfPropsOwned());
                    lvi.SubItems.Add(propsowned);


                    //.lstV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, 
                    //System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    lstV.Items.Add(lvi);

                    
                }
            }
            catch
            {
                MessageBox.Show("Please choose a valid option", "Invalid Selection");
               
            }
        }

        //onload

        private void Form1_Load(object sender, EventArgs e)
        {
            


            //lstDist.SelectedIndex = 0;
            //lstNeigh.SelectedIndex = 0;

            
            lstNeigh.Items.Clear();
            lstV.Items.Clear();

            





            this.Controls.Clear();
            this.InitializeComponent();




            for (int i = 0; i < allDists.Length; i++)
            {
                District dis = allDists[i];
                lstDist.Items.Add(dis.getDistName() + "  " + "(" + dis.getNumberOfNeighsInDist() + ")");
                lstDist.SetSelected(0, true);
                lstNeigh.SetSelected(0, true);

            }


        }


        //buttons
       

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            Analysis tempysis = new Analysis();
            tempysis.Show();
        }



        private void btnAddDist_Click(object sender, EventArgs e)
        {
            AddDist TempAddDist = new AddDist();
            TempAddDist.Show();
            
        }

        

        private void btnAddNeigh_Click(object sender, EventArgs e)
        {
            AddNeigh TempAddneigh = new AddNeigh();
            TempAddneigh.Show();
            
        }

  
        // Search Boxs
        private bool firsttime = true;

        private void SearchBoxText_TextChanged(object sender, EventArgs e)
        {
            


            if (firsttime)
            {
                SearchBoxText.Clear();
                firsttime = false;
            }

            string searchString = SearchBoxText.Text;

            if (!string.IsNullOrEmpty(searchString))
            {
                int index = lstDist.FindString(searchString);
                if (index != -1)
                    lstDist.SetSelected(index, true);
                
                
            }

        }

        private void SearchBoxTextNeigh_TextChanged(object sender, EventArgs e)
        {
            if (firsttime)
            {
                SearchBoxTextNeigh.Clear();
                firsttime = false;
            }
            
            
            string searchStringNeigh = SearchBoxTextNeigh.Text;

            if (!string.IsNullOrEmpty(searchStringNeigh))
            {
                int index = lstNeigh.FindString(searchStringNeigh);
                if (index != -1)
                    lstNeigh.SetSelected(index, true);
            }
            
        }

        

        //Delete Buttons
       
            
        
     
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete the selected Properites? " , "Confirmation", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {

                foreach (ListViewItem eachItem in lstV.SelectedItems)
                {
                    lstV.Items.Remove(eachItem);
                }

            }
            else
            {
                return;
            }


            inTheFile.Close();
        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            AddProp temppropadd = new AddProp();
            temppropadd.Show();
        }
    }
}

