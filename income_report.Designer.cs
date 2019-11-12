namespace GymManagementSystem
{
    partial class income_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GymManagementSystem.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentTableAdapter = new GymManagementSystem.DataSet1TableAdapters.PaymentTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.metroTile3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payment";
            this.PaymentBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GymManagementSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(671, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // PaymentTableAdapter
            // 
            this.PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(365, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.White;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.CustomForeColor = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(9, 75);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 46;
            this.metroLabel9.Text = "Date From";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(306, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Date To";
            // 
            // metroTile3
            // 
            this.metroTile3.BackColor = System.Drawing.Color.Red;
            this.metroTile3.Controls.Add(this.metroLabel7);
            this.metroTile3.Controls.Add(this.metroLabel8);
            this.metroTile3.CustomBackground = true;
            this.metroTile3.CustomForeColor = true;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile3.Location = new System.Drawing.Point(571, 63);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(61, 32);
            this.metroTile3.TabIndex = 48;
            this.metroTile3.Text = "OK";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseMnemonic = false;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 1;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1, 4);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(0, 0);
            this.metroLabel8.TabIndex = 0;
            // 
            // income_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 523);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "income_report";
            this.Resizable = false;
            this.Text = "Member Payment Details  Report";
            this.Load += new System.EventHandler(this.income_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.metroTile3.ResumeLayout(false);
            this.metroTile3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PaymentTableAdapter PaymentTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}