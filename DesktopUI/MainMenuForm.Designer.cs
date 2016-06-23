namespace DesktopUI
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.pctSave = new System.Windows.Forms.PictureBox();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.pctArchive = new System.Windows.Forms.PictureBox();
            this.pctBug = new System.Windows.Forms.PictureBox();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.lblArchivedTaskNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSave
            // 
            this.pctSave.Enabled = false;
            this.pctSave.Image = global::DesktopUI.Properties.Resources.User_Interface_Save_As_icon;
            this.pctSave.Location = new System.Drawing.Point(88, 2);
            this.pctSave.Name = "pctSave";
            this.pctSave.Size = new System.Drawing.Size(32, 32);
            this.pctSave.TabIndex = 5;
            this.pctSave.TabStop = false;
            this.pctSave.Click += new System.EventHandler(this.pctSave_Click);
            // 
            // pctSettings
            // 
            this.pctSettings.Image = global::DesktopUI.Properties.Resources.Very_Basic_Settings_icon;
            this.pctSettings.Location = new System.Drawing.Point(280, 2);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(32, 32);
            this.pctSettings.TabIndex = 4;
            this.pctSettings.TabStop = false;
            this.pctSettings.Click += new System.EventHandler(this.pctSettings_Click);
            // 
            // pctArchive
            // 
            this.pctArchive.Image = global::DesktopUI.Properties.Resources.Very_Basic_Archive_icon;
            this.pctArchive.Location = new System.Drawing.Point(242, 2);
            this.pctArchive.Name = "pctArchive";
            this.pctArchive.Size = new System.Drawing.Size(32, 32);
            this.pctArchive.TabIndex = 3;
            this.pctArchive.TabStop = false;
            this.pctArchive.Click += new System.EventHandler(this.pctArchive_Click);
            // 
            // pctBug
            // 
            this.pctBug.Image = global::DesktopUI.Properties.Resources.Programming_Bug_2_icon;
            this.pctBug.Location = new System.Drawing.Point(12, 2);
            this.pctBug.Name = "pctBug";
            this.pctBug.Size = new System.Drawing.Size(32, 32);
            this.pctBug.TabIndex = 2;
            this.pctBug.TabStop = false;
            this.pctBug.Click += new System.EventHandler(this.pctBug_Click);
            // 
            // pctImage
            // 
            this.pctImage.Image = global::DesktopUI.Properties.Resources.Photo_Video_Slr_Camera_2_icon;
            this.pctImage.Location = new System.Drawing.Point(50, 2);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(32, 32);
            this.pctImage.TabIndex = 1;
            this.pctImage.TabStop = false;
            this.pctImage.Click += new System.EventHandler(this.pctImage_Click);
            // 
            // lblArchivedTaskNumber
            // 
            this.lblArchivedTaskNumber.AutoSize = true;
            this.lblArchivedTaskNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblArchivedTaskNumber.Location = new System.Drawing.Point(256, 20);
            this.lblArchivedTaskNumber.Name = "lblArchivedTaskNumber";
            this.lblArchivedTaskNumber.Size = new System.Drawing.Size(13, 13);
            this.lblArchivedTaskNumber.TabIndex = 6;
            this.lblArchivedTaskNumber.Text = "0";
            this.lblArchivedTaskNumber.Visible = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 35);
            this.Controls.Add(this.lblArchivedTaskNumber);
            this.Controls.Add(this.pctSave);
            this.Controls.Add(this.pctSettings);
            this.Controls.Add(this.pctArchive);
            this.Controls.Add(this.pctBug);
            this.Controls.Add(this.pctImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pctSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.PictureBox pctBug;
        private System.Windows.Forms.PictureBox pctArchive;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.PictureBox pctSave;
        private System.Windows.Forms.Label lblArchivedTaskNumber;
    }
}