namespace GymManagementSystem
{
    partial class ownerlogin
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
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.instructor = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.CustomBackground = true;
            this.username.CustomForeColor = true;
            this.username.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(23, 95);
            this.username.Name = "username";
            this.username.PasswordChar = '*';
            this.username.Size = new System.Drawing.Size(246, 23);
            this.username.Style = MetroFramework.MetroColorStyle.Black;
            this.username.TabIndex = 1;
            // 
            // instructor
            // 
            this.instructor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.instructor.CustomBackground = true;
            this.instructor.CustomForeColor = true;
            this.instructor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructor.Location = new System.Drawing.Point(275, 95);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(78, 23);
            this.instructor.TabIndex = 4;
            this.instructor.Text = "Login";
            this.instructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.instructor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructor.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.instructor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.instructor.UseTileImage = true;
            this.instructor.Click += new System.EventHandler(this.instructor_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(23, 66);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(115, 23);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Owner Password";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseTileImage = true;
            // 
            // ownerlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 163);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.username);
            this.MaximizeBox = false;
            this.Name = "ownerlogin";
            this.Resizable = false;
            this.Text = "Enter Password";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTile instructor;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}