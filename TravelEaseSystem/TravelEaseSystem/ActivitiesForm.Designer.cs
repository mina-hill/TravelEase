namespace TravelEaseSystem
{
    partial class ActivitiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesForm));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifPictureBox = new System.Windows.Forms.PictureBox();
            this.pfpPictureBox = new System.Windows.Forms.PictureBox();
            this.TripsButton = new System.Windows.Forms.Button();
            this.TravelHistoryButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.Icon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.DayNum});
            this.dataGridView2.Location = new System.Drawing.Point(15, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(773, 230);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "activityName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Location";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DayNum
            // 
            this.DayNum.HeaderText = "Day Num";
            this.DayNum.Name = "DayNum";
            this.DayNum.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select your preferred activities:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "You\'re booking: Mountain Adventure - Switzerland";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.notifPictureBox);
            this.panel1.Controls.Add(this.pfpPictureBox);
            this.panel1.Controls.Add(this.TripsButton);
            this.panel1.Controls.Add(this.TravelHistoryButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.Icon);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 10;
            // 
            // notifPictureBox
            // 
            this.notifPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.notifPictureBox.ErrorImage = null;
            this.notifPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("notifPictureBox.Image")));
            this.notifPictureBox.InitialImage = null;
            this.notifPictureBox.Location = new System.Drawing.Point(716, 9);
            this.notifPictureBox.Name = "notifPictureBox";
            this.notifPictureBox.Size = new System.Drawing.Size(33, 34);
            this.notifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notifPictureBox.TabIndex = 13;
            this.notifPictureBox.TabStop = false;
            this.notifPictureBox.Click += new System.EventHandler(this.notifPictureBox_Click);
            // 
            // pfpPictureBox
            // 
            this.pfpPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pfpPictureBox.ErrorImage = null;
            this.pfpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pfpPictureBox.Image")));
            this.pfpPictureBox.InitialImage = null;
            this.pfpPictureBox.Location = new System.Drawing.Point(755, 9);
            this.pfpPictureBox.Name = "pfpPictureBox";
            this.pfpPictureBox.Size = new System.Drawing.Size(33, 34);
            this.pfpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfpPictureBox.TabIndex = 10;
            this.pfpPictureBox.TabStop = false;
            // 
            // TripsButton
            // 
            this.TripsButton.AutoSize = true;
            this.TripsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TripsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.TripsButton.ForeColor = System.Drawing.Color.Transparent;
            this.TripsButton.Location = new System.Drawing.Point(281, 12);
            this.TripsButton.Name = "TripsButton";
            this.TripsButton.Size = new System.Drawing.Size(40, 23);
            this.TripsButton.TabIndex = 12;
            this.TripsButton.Text = "Trips";
            this.TripsButton.UseVisualStyleBackColor = false;
            // 
            // TravelHistoryButton
            // 
            this.TravelHistoryButton.AutoSize = true;
            this.TravelHistoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TravelHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.TravelHistoryButton.ForeColor = System.Drawing.Color.Transparent;
            this.TravelHistoryButton.Location = new System.Drawing.Point(402, 12);
            this.TravelHistoryButton.Name = "TravelHistoryButton";
            this.TravelHistoryButton.Size = new System.Drawing.Size(82, 23);
            this.TravelHistoryButton.TabIndex = 12;
            this.TravelHistoryButton.Text = "Travel History";
            this.TravelHistoryButton.UseVisualStyleBackColor = false;
            // 
            // DashboardButton
            // 
            this.DashboardButton.AutoSize = true;
            this.DashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.DashboardButton.ForeColor = System.Drawing.Color.Transparent;
            this.DashboardButton.Location = new System.Drawing.Point(327, 12);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(69, 23);
            this.DashboardButton.TabIndex = 11;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            // 
            // Icon
            // 
            this.Icon.AutoSize = true;
            this.Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.Icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon.Location = new System.Drawing.Point(12, 9);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(162, 31);
            this.Icon.TabIndex = 9;
            this.Icon.Text = "TravelEase";
            // 
            // ActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ActivitiesForm";
            this.Text = "ActivitiesForm";
            this.Load += new System.EventHandler(this.ActivitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox notifPictureBox;
        private System.Windows.Forms.PictureBox pfpPictureBox;
        private System.Windows.Forms.Button TripsButton;
        private System.Windows.Forms.Button TravelHistoryButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label Icon;
    }
}