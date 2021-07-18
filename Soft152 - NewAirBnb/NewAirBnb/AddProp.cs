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
    public partial class AddProp : Form
    {

        public static ArrayList Program = new ArrayList();
        public AddProp()
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
    }
}
