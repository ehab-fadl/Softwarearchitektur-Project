using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * @Author Ehab Fadl
 * 
 * */
namespace ice_cream.PL_Views
{
    public partial class Assessment_Record : Form
    {

        //Data from Database to showing
        BL_Controller.DataShow dataShow = new BL_Controller.DataShow();

        public Assessment_Record()
        {
            InitializeComponent();
            
            // give Data to the Grid View Station ID from Database
            this.dataGridViewStationID.DataSource = dataShow.Datashow();
        }




       
        // Load th Form
        private void Assessment_Record_Load(object sender, EventArgs e)
        {
        }



      
    
        
            
        
        //Function to test the Variance and give the Color
        public void TestVariance() {
            try
            {
                int value = int.Parse(txtVariance.Text);

                if (value >= 10)
                {
                    txtVariance.ForeColor = Color.Red;
                }
                else if (value < 10)
                {
                    
                    txtVariance.ForeColor = Color.Green;
                }
            }
            catch (Exception ex) {
                ex.GetBaseException();
               
            }
        }







        // Bild the Data Grid View for the Station ID
        private void dataGridViewStationID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStationID.Text = this.dataGridViewStationID.CurrentRow.Cells[0].Value.ToString();
            txtDate.Text = this.dataGridViewStationID.CurrentRow.Cells[1].Value.ToString();
            txtTarget.Text = this.dataGridViewStationID.CurrentRow.Cells[2].Value.ToString();
            txtActual.Text = this.dataGridViewStationID.CurrentRow.Cells[3].Value.ToString();
            txtVariance.Text = this.dataGridViewStationID.CurrentRow.Cells[4].Value.ToString();

            TestVariance();
        }







        //buttom to Close the Form
        private void btmClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        
        //Buttom openthe Form Add new Staion
        private void btmAddStation_Click(object sender, EventArgs e)
        {
            NewStation frm = new NewStation();
            frm.ShowDialog();
        }

        private void btmRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridViewStationID.DataSource = dataShow.Datashow();

        }
    }
}
