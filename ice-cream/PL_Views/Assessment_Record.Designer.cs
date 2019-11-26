﻿namespace ice_cream.PL_Views
{
    partial class Assessment_Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStationID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStationID = new System.Windows.Forms.DataGridView();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmAddStation = new System.Windows.Forms.Button();
            this.btmRefresh = new System.Windows.Forms.Button();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVariance);
            this.groupBox1.Controls.Add(this.txtActual);
            this.groupBox1.Controls.Add(this.txtTarget);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtStationID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Show";
            // 
            // txtVariance
            // 
            this.txtVariance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVariance.Location = new System.Drawing.Point(87, 207);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(168, 20);
            this.txtVariance.TabIndex = 19;
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(87, 166);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(168, 20);
            this.txtActual.TabIndex = 18;
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTarget.Location = new System.Drawing.Point(87, 120);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(168, 20);
            this.txtTarget.TabIndex = 17;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(87, 77);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(168, 20);
            this.txtDate.TabIndex = 16;
            // 
            // txtStationID
            // 
            this.txtStationID.Location = new System.Drawing.Point(87, 41);
            this.txtStationID.Name = "txtStationID";
            this.txtStationID.Size = new System.Drawing.Size(168, 20);
            this.txtStationID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Variance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Target";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Station ID";
            // 
            // dataGridViewStationID
            // 
            this.dataGridViewStationID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewStationID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStationID.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewStationID.Name = "dataGridViewStationID";
            this.dataGridViewStationID.ReadOnly = true;
            this.dataGridViewStationID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStationID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStationID.Size = new System.Drawing.Size(196, 203);
            this.dataGridViewStationID.TabIndex = 1;
            this.dataGridViewStationID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStationID_CellClick);
            // 
            // btmClose
            // 
            this.btmClose.Location = new System.Drawing.Point(217, 262);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(98, 23);
            this.btmClose.TabIndex = 2;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmAddStation
            // 
            this.btmAddStation.Location = new System.Drawing.Point(385, 262);
            this.btmAddStation.Name = "btmAddStation";
            this.btmAddStation.Size = new System.Drawing.Size(98, 23);
            this.btmAddStation.TabIndex = 3;
            this.btmAddStation.Text = "Add new Station";
            this.btmAddStation.UseVisualStyleBackColor = true;
            this.btmAddStation.Click += new System.EventHandler(this.btmAddStation_Click);
            // 
            // btmRefresh
            // 
            this.btmRefresh.Location = new System.Drawing.Point(55, 262);
            this.btmRefresh.Name = "btmRefresh";
            this.btmRefresh.Size = new System.Drawing.Size(98, 23);
            this.btmRefresh.TabIndex = 4;
            this.btmRefresh.Text = "Uptate";
            this.btmRefresh.UseVisualStyleBackColor = true;
            this.btmRefresh.Click += new System.EventHandler(this.btmRefresh_Click);
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(385, 291);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteStation.TabIndex = 5;
            this.btnDeleteStation.Text = "Delete Station";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // Assessment_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 317);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.btmRefresh);
            this.Controls.Add(this.btmAddStation);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.dataGridViewStationID);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Assessment_Record";
            this.Text = "Assessment_Record";
            this.Load += new System.EventHandler(this.Assessment_Record_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStationID;
        public System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmAddStation;
        private System.Windows.Forms.Button btmRefresh;
        private System.Windows.Forms.Button btnDeleteStation;
    }
}