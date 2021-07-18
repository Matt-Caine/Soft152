using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace NewAirBnb
{
    public partial class AddDist : Form
    {


        Neighbourhood[] DistAllNeighs;


        public static ArrayList Program = new ArrayList();

        public AddDist()
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool allInputOK = false;

            string tempDis = NewDistName.Text;
            string tempneighnum = "0";

            allInputOK = NotNullTextBox(NewDistName, "Distrct");

            if (allInputOK)
            {
                District temp = new District(tempDis, "0", DistAllNeighs);
                AddDist.Program.Add(temp);
       
                using(StreamWriter stream = File.AppendText("MaxiDataFile.txt"))
                //using (StreamWriter stream = File.AppendText("TestFile.txt"))
                {
                    stream.WriteLine(tempDis);
                    stream.WriteLine(tempneighnum);


                }
                
            }

            
            MessageBox.Show("Distrct Added");
            Application.Restart();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddDist_Load(object sender, EventArgs e)
        {

        }
    }
}
