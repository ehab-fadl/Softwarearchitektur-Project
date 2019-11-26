﻿using System;
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







        //button to Close the Form
        private void btmClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        
        //Button open the Form Add new Staion
        private void btmAddStation_Click(object sender, EventArgs e)
        {
            NewStation frm = new NewStation();
            frm.ShowDialog();
        }



        //Button to Refresh the Data
        private void btmRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridViewStationID.DataSource = dataShow.Datashow();

        }


        //Button to Delete Station
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("The station was deleted.", "Delete Station", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
