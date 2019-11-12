namespace GymManagementSystem
{
    partial class ownerveiw
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
            this.reception = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reception.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // reception
            // 
            this.reception.BackColor = System.Drawing.Color.BlueViolet;
            this.reception.Controls.Add(this.pictureBox1);
            this.reception.CustomBackground = true;
            this.reception.CustomForeColor = true;
            this.reception.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reception.Location = new System.Drawing.Point(23, 27);
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(230, 130);
            this.reception.TabIndex = 6;
            this.reception.Text = "Manager";
            this.reception.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.reception.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.reception.Click += new System.EventHandler(this.reception_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroTile1.Controls.Add(this.pictureBox2);
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(292, 27);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(199, 291);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Manthly Report";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.Gold;
            this.metroTile2.Controls.Add(this.pictureBox3);
            this.metroTile2.CustomBackground = true;
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile2.Location = new System.Drawing.Point(23, 188);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(230, 130);
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Back";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GymManagementSystem.Properties.Resources.report1;
            this.pictureBox2.Location = new System.Drawing.Point(26, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GymManagementSystem.Properties.Resources.manager1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GymManagementSystem.Properties.Resources.exit1;
            this.pictureBox3.Location = new System.Drawing.Point(17, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ownerveiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 365);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.reception);
            this.MaximizeBox = false;
            this.Name = "ownerveiw";
            this.Resizable = false;
            this.Text = "Exit";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reception.ResumeLayout(false);
            this.metroTile1.ResumeLayout(false);
            this.metroTile2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile reception;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}