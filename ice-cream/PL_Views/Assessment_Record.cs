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



        //Inestance form Assessment_Record
        private static PL_Views.Assessment_Record frm;

        static void frm_AddStation(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static PL_Views.Assessment_Record getAssessment_Record
        {
            get
            {
                if (frm==null)
                {
                    frm = new Assessment_Record();
                    frm.FormClosed += new FormClosedEventHandler(frm_AddStation);
                }
                return frm;
            }
        }


        // Counter to number of Rows in Data Grid View
        public static string actualRowsCount; 



        public Assessment_Record()
        {
            InitializeComponent();

            //Inestance form Assessment_Record
            if (frm == null)
                frm = this;


            // give Data to the Grid View Station ID from Database
            this.dataGridViewStationID.DataSource = dataShow.Datashow();

            actualRowsCount = this.dataGridViewStationID.Rows.Count.ToString();
            lblRowsNewCount.Text = actualRowsCount;
        }




        // Function to select data from database and show the Data in Data Grid view
        public void selectData()
        {
            txtStationID.Text = this.dataGridViewStationID.CurrentRow.Cells[0].Value.ToString();
            txtDate.Text = this.dataGridViewStationID.CurrentRow.Cells[1].Value.ToString();
            txtTarget.Text = this.dataGridViewStationID.CurrentRow.Cells[2].Value.ToString();
            txtActual.Text = this.dataGridViewStationID.CurrentRow.Cells[3].Value.ToString();
            txtVariance.Text = this.dataGridViewStationID.CurrentRow.Cells[4].Value.ToString();
        }




        // Load the Form
        private void Assessment_Record_Load(object sender, EventArgs e)
        {
             selectData();
             TestVariance();
        }



      
    
        
            
        
        //Function to test the Variance and give the Color
        public void TestVariance() {
            try
            {
                int varianceValue = int.Parse(txtVariance.Text);
                int targetValue = int.Parse(txtTarget.Text);
                double testValue = -0.1* targetValue;

                if (varianceValue < 0 && varianceValue <= testValue)
                {
                    txtVariance.ForeColor = Color.Red;
                } 
                else if (varianceValue > 0 && varianceValue>= 0.05 * targetValue)
                {
                    
                    txtVariance.ForeColor = Color.Green;
                }
                else
                {
                    txtVariance.ForeColor = Color.Black;
                }
            }
            catch (Exception ex) {
                ex.GetBaseException();
               
            }
        }






        // Bild the Data Grid View for the Station ID
        private void dataGridViewStationID_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectData();
            TestVariance();
            lblMessage.Visible = false;
        }







        //button to Close the Form
        private void btmClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        
        //Button open the Form Add new Staion
        private void btmAddStation_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            NewStation frm = new NewStation();
            frm.ShowDialog();
        }



        //Button to Refresh the Data
        private void btmRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridViewStationID.DataSource = dataShow.Datashow();
            lblMessage.Visible = false;

            actualRowsCount = this.dataGridViewStationID.Rows.Count.ToString();
            lblRowsNewCount.Text = actualRowsCount;
            lblMessage.Text = "You have "+actualRowsCount+" Stations";
            lblMessage.Visible = true;
            selectData();
            TestVariance();
        }


        //Button to Delete Station
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            try
            {
                BL_Controller.AddStation deleteStation = new BL_Controller.AddStation();
                if (MessageBox.Show("Do you want to delete the station?", "Delete Station", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    deleteStation.DeleteStation(this.dataGridViewStationID.CurrentRow.Cells[0].Value.ToString());
                   this.dataGridViewStationID.DataSource = dataShow.Datashow();
                    txtStationID.Text = "";
                    txtDate.Text = "";
                    txtTarget.Text = "";
                    txtActual.Text = "";
                    txtVariance.Text = "";
                    MessageBox.Show("Delete successfully.", "Delete Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectData();
                    actualRowsCount = this.dataGridViewStationID.Rows.Count.ToString();
                    lblRowsNewCount.Text = actualRowsCount;
                    TestVariance();
                }
                else
                {
                    MessageBox.Show("The deletion from the station was canceled.", "Delete Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {

                ex.GetBaseException();
                MessageBox.Show("There are no more data!", "Delete Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        //Button to Edit the Station
        private void btnEditStation_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            btmAddStation.Visible = false;
            btnDeleteStation.Visible = false;
            btmRefresh.Visible = false;
            btmClose.Visible = false;
            btnEditStation.Visible = false;
            txtActual.Focus();
            txtActual.SelectionStart = 0;
            txtActual.SelectionLength = txtStationID.TextLength;
            txtTarget.BackColor = Color.White;
            txtVariance.BackColor = Color.White;
            btnCancel.Visible = true;
            btnOk.Visible = true;
            txtStationID.ReadOnly = true;
           
        }





        //Cancel Edit
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btmAddStation.Visible = true;
            btnDeleteStation.Visible = true;
            btmRefresh.Visible = true;
            btmClose.Visible = true;
            btnEditStation.Visible = true;
            btnCancel.Visible = false;
            btnOk.Visible = false;
            txtStationID.ReadOnly = false;
           
        }





        //accept Edit
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                BL_Controller.AddStation station = new BL_Controller.AddStation();
                station.EditStation(txtStationID.Text, txtDate.Text, Convert.ToInt32(txtTarget.Text),
                    Convert.ToInt32(txtActual.Text), Convert.ToInt32(txtVariance.Text));

                this.dataGridViewStationID.DataSource = dataShow.Datashow();
                MessageBox.Show("Edited successfully.", "Edit Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btmAddStation.Visible = true;
                btnDeleteStation.Visible = true;
                btmRefresh.Visible = true;
                btmClose.Visible = true;
                btnEditStation.Visible = true;
                btnCancel.Visible = false;
                btnOk.Visible = false;
                selectData();
                TestVariance();
                txtStationID.ReadOnly = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("The Field is Empty!", "Edit Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ex.GetBaseException();
            }






            //Calcolate Variance Value
        }

        private void txtActual_Validated(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtActual.Text);

                int b = Convert.ToInt32(txtTarget.Text);

                int c = a-b;

                txtVariance.Text = Convert.ToString(c);
                txtVariance.ReadOnly = true;
                TestVariance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter both values ​​(Target and Actual)!", "Edit Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarget.Focus();
                ex.GetBaseException();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
    }
}
