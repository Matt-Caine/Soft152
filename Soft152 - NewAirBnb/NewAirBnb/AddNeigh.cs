using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace NewAirBnb
{
    public partial class AddNeigh : Form
    {
        
        Property[] GetallProperties;
        
        public static ArrayList Program = new ArrayList();

        public AddNeigh()
        {
            InitializeComponent();
        }

        private bool NotNullTextBox(TextBox txtCurrent, String userFeedback)
        {
            if (txtCurrent.Text == "")
            {
                MessageBox.Show("Error:" + userFeedback);
                txtCurrent.Focus();
                return false;
            }
            else
                return true;
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           
            bool allInputOK = false;

            string tempNeigh = NewNeighName.Text;
            string tempPropnum = "0";

            allInputOK = NotNullTextBox(NewNeighName, "Neighbourhood");

            if (allInputOK)
            {
                Neighbourhood temp = new Neighbourhood(tempNeigh, "0", GetallProperties);
                
                AddNeigh.Program.Add(temp);
                using(StreamWriter stream = File.AppendText("MaxiDataFile.txt"))
                {
                    stream.WriteLine(tempNeigh);
                    stream.WriteLine(tempPropnum);
                    

                }

                
            }

            MessageBox.Show("NeighbourHood Added");
            Application.Restart();
            

        }

        private void AddNeigh_Load(object sender, EventArgs e)
        {

        }
    }
}
