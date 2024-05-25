namespace ekzamen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLaunchNewSatellite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSatellitesMap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLaunchNewSatellite
            // 
            this.buttonLaunchNewSatellite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLaunchNewSatellite.FlatAppearance.BorderSize = 0;
            this.buttonLaunchNewSatellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaunchNewSatellite.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunchNewSatellite.ForeColor = System.Drawing.Color.White;
            this.buttonLaunchNewSatellite.Location = new System.Drawing.Point(0, 0);
            this.buttonLaunchNewSatellite.Name = "buttonLaunchNewSatellite";
            this.buttonLaunchNewSatellite.Size = new System.Drawing.Size(263, 39);
            this.buttonLaunchNewSatellite.TabIndex = 0;
            this.buttonLaunchNewSatellite.Text = "Launch New Satellite";
            this.buttonLaunchNewSatellite.UseVisualStyleBackColor = true;
            this.buttonLaunchNewSatellite.Click += new System.EventHandler(this.buttonLaunchNewSatellite_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonSatellitesMap);
            this.panel1.Controls.Add(this.buttonLaunchNewSatellite);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 117);
            this.panel1.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(0, 78);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(263, 39);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSatellitesMap
            // 
            this.buttonSatellitesMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSatellitesMap.FlatAppearance.BorderSize = 0;
            this.buttonSatellitesMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatellitesMap.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSatellitesMap.ForeColor = System.Drawing.Color.White;
            this.buttonSatellitesMap.Location = new System.Drawing.Point(0, 39);
            this.buttonSatellitesMap.Name = "buttonSatellitesMap";
            this.buttonSatellitesMap.Size = new System.Drawing.Size(263, 39);
            this.buttonSatellitesMap.TabIndex = 1;
            this.buttonSatellitesMap.Text = "Satellites Map";
            this.buttonSatellitesMap.UseVisualStyleBackColor = true;
            this.buttonSatellitesMap.Click += new System.EventHandler(this.buttonSatellitesMap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 117);
            this.panel2.TabIndex = 2;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 78);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(186, 39);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoad.Location = new System.Drawing.Point(0, 39);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(186, 39);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            this.buttonLoad.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.buttonLoad.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 39);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Satellites Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunchNewSatellite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSatellitesMap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
    }
}

