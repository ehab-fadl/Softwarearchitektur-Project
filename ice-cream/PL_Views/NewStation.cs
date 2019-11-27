using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ice_cream.PL_Views
{
    public partial class NewStation : Form
    {
        public NewStation()
        {
            InitializeComponent();
        }
      
        
        
        
        // Button to Add new Station
        private void btmAddStation_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Controller.AddStation station = new BL_Controller.AddStation();
                station.AddNewStation(txtStationID.Text, txtDate.Text, Convert.ToInt32(txtTarget.Text),
                    Convert.ToInt32(txtActual.Text), Convert.ToInt32(txtVariance.Text));
                MessageBox.Show("Add successfully.", "Add Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStationID.Text = "";
                txtDate.Text = "";
                txtTarget.Text = "";
                txtActual.Text = "";
                txtVariance.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Field is Empty!", "Add Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ex.GetBaseException();
            }
        }



      
        //Action to Verify the ID 
        private void txtStationID_Validated(object sender, EventArgs e)
        {

            BL_Controller.AddStation station = new BL_Controller.AddStation();

            DataTable dt = new DataTable();
            dt = station.VerifyStationID(txtStationID.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The ID is already added!\nPlease enter another ID", "Add ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStationID.Focus();
                txtStationID.SelectionStart = 0;
                txtStationID.SelectionLength = txtStationID.TextLength;
            }
        }



        //Action to Verify the Variance
        private void txtActual_Validated(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtActual.Text);

                int b = Convert.ToInt32(txtTarget.Text);

                int c = b - a;

                txtVariance.Text = Convert.ToString(c);
                txtVariance.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter both values ​​(Target and Actual)!", "Add Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarget.Focus();
                ex.GetBaseException();
            }
        }
    }
}
