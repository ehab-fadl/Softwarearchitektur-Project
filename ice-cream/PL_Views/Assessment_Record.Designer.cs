namespace ice_cream.PL_Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assessment_Record));
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
            this.btnEditStation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblRowsNewCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtVariance
            // 
            this.txtVariance.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtVariance, "txtVariance");
            this.txtVariance.Name = "txtVariance";
            // 
            // txtActual
            // 
            resources.ApplyResources(this.txtActual, "txtActual");
            this.txtActual.Name = "txtActual";
            this.txtActual.Validated += new System.EventHandler(this.txtActual_Validated);
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtTarget, "txtTarget");
            this.txtTarget.Name = "txtTarget";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Name = "txtDate";
            // 
            // txtStationID
            // 
            resources.ApplyResources(this.txtStationID, "txtStationID");
            this.txtStationID.Name = "txtStationID";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridViewStationID
            // 
            this.dataGridViewStationID.AllowUserToResizeColumns = false;
            this.dataGridViewStationID.AllowUserToResizeRows = false;
            this.dataGridViewStationID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewStationID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStationID.ColumnHeadersVisible = false;
            this.dataGridViewStationID.GridColor = System.Drawing.Color.DarkOliveGreen;
            resources.ApplyResources(this.dataGridViewStationID, "dataGridViewStationID");
            this.dataGridViewStationID.MultiSelect = false;
            this.dataGridViewStationID.Name = "dataGridViewStationID";
            this.dataGridViewStationID.ReadOnly = true;
            this.dataGridViewStationID.RowHeadersVisible = false;
            this.dataGridViewStationID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStationID.TabStop = false;
            this.dataGridViewStationID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStationID_CellClick);
            // 
            // btmClose
            // 
            this.btmClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btmClose, "btmClose");
            this.btmClose.Name = "btmClose";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmAddStation
            // 
            resources.ApplyResources(this.btmAddStation, "btmAddStation");
            this.btmAddStation.Name = "btmAddStation";
            this.btmAddStation.UseVisualStyleBackColor = true;
            this.btmAddStation.Click += new System.EventHandler(this.btmAddStation_Click);
            // 
            // btmRefresh
            // 
            resources.ApplyResources(this.btmRefresh, "btmRefresh");
            this.btmRefresh.Name = "btmRefresh";
            this.btmRefresh.UseVisualStyleBackColor = true;
            this.btmRefresh.Click += new System.EventHandler(this.btmRefresh_Click);
            // 
            // btnDeleteStation
            // 
            resources.ApplyResources(this.btnDeleteStation, "btnDeleteStation");
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // btnEditStation
            // 
            resources.ApplyResources(this.btnEditStation, "btnEditStation");
            this.btnEditStation.Name = "btnEditStation";
            this.btnEditStation.UseVisualStyleBackColor = true;
            this.btnEditStation.Click += new System.EventHandler(this.btnEditStation_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblMessage.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Name = "lblMessage";
            // 
            // lblRowsNewCount
            // 
            resources.ApplyResources(this.lblRowsNewCount, "lblRowsNewCount");
            this.lblRowsNewCount.Name = "lblRowsNewCount";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 12000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Assessment_Record
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRowsNewCount);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditStation);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.btmRefresh);
            this.Controls.Add(this.btmAddStation);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.dataGridViewStationID);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Assessment_Record";
            this.Load += new System.EventHandler(this.Assessment_Record_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmAddStation;
        private System.Windows.Forms.Button btmRefresh;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.Button btnEditStation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.DataGridView dataGridViewStationID;
        public System.Windows.Forms.TextBox txtStationID;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Label lblRowsNewCount;
        public System.Windows.Forms.TextBox txtActual;
        public System.Windows.Forms.TextBox txtTarget;
        public System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}