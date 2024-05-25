namespace ekzamen
{
    partial class SelectOrbitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.orbitAngleKoefTrackBar = new System.Windows.Forms.TrackBar();
            this.orbitAngleKoefValueLabel = new System.Windows.Forms.Label();
            this.orbitOffsetValueLabel = new System.Windows.Forms.Label();
            this.orbitOffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.showMapButton = new System.Windows.Forms.Button();
            this.liveViewCheckBox = new System.Windows.Forms.CheckBox();
            this.worldMap = new ekzamen.WorldMap();
            this.startPositionValueLabel = new System.Windows.Forms.Label();
            this.startPositionTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orbitAngleKoefTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orbitOffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPositionTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(552, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orbit Angle Koef";
            // 
            // orbitAngleKoefTrackBar
            // 
            this.orbitAngleKoefTrackBar.Location = new System.Drawing.Point(556, 54);
            this.orbitAngleKoefTrackBar.Maximum = 70;
            this.orbitAngleKoefTrackBar.Minimum = -70;
            this.orbitAngleKoefTrackBar.Name = "orbitAngleKoefTrackBar";
            this.orbitAngleKoefTrackBar.Size = new System.Drawing.Size(310, 45);
            this.orbitAngleKoefTrackBar.TabIndex = 2;
            this.orbitAngleKoefTrackBar.Scroll += new System.EventHandler(this.orbitAngleKoefTrackBar_Scroll);
            // 
            // orbitAngleKoefValueLabel
            // 
            this.orbitAngleKoefValueLabel.AutoSize = true;
            this.orbitAngleKoefValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orbitAngleKoefValueLabel.Location = new System.Drawing.Point(872, 54);
            this.orbitAngleKoefValueLabel.Name = "orbitAngleKoefValueLabel";
            this.orbitAngleKoefValueLabel.Size = new System.Drawing.Size(24, 26);
            this.orbitAngleKoefValueLabel.TabIndex = 3;
            this.orbitAngleKoefValueLabel.Text = "0";
            // 
            // orbitOffsetValueLabel
            // 
            this.orbitOffsetValueLabel.AutoSize = true;
            this.orbitOffsetValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orbitOffsetValueLabel.Location = new System.Drawing.Point(872, 130);
            this.orbitOffsetValueLabel.Name = "orbitOffsetValueLabel";
            this.orbitOffsetValueLabel.Size = new System.Drawing.Size(24, 26);
            this.orbitOffsetValueLabel.TabIndex = 6;
            this.orbitOffsetValueLabel.Text = "0";
            // 
            // orbitOffsetTrackBar
            // 
            this.orbitOffsetTrackBar.Location = new System.Drawing.Point(556, 130);
            this.orbitOffsetTrackBar.Maximum = 70;
            this.orbitOffsetTrackBar.Name = "orbitOffsetTrackBar";
            this.orbitOffsetTrackBar.Size = new System.Drawing.Size(310, 45);
            this.orbitOffsetTrackBar.TabIndex = 5;
            this.orbitOffsetTrackBar.Scroll += new System.EventHandler(this.orbitOffsetTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(552, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Orbit Offset";
            // 
            // showMapButton
            // 
            this.showMapButton.Enabled = false;
            this.showMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMapButton.Location = new System.Drawing.Point(556, 414);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(125, 31);
            this.showMapButton.TabIndex = 8;
            this.showMapButton.Text = "Show Map";
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // liveViewCheckBox
            // 
            this.liveViewCheckBox.AutoSize = true;
            this.liveViewCheckBox.Checked = true;
            this.liveViewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.liveViewCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liveViewCheckBox.Location = new System.Drawing.Point(557, 387);
            this.liveViewCheckBox.Name = "liveViewCheckBox";
            this.liveViewCheckBox.Size = new System.Drawing.Size(86, 21);
            this.liveViewCheckBox.TabIndex = 9;
            this.liveViewCheckBox.Text = "Live View";
            this.liveViewCheckBox.UseVisualStyleBackColor = true;
            this.liveViewCheckBox.CheckedChanged += new System.EventHandler(this.liveViewCheckBox_CheckedChanged);
            // 
            // worldMap
            // 
            this.worldMap.Location = new System.Drawing.Point(12, 12);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(512, 434);
            this.worldMap.TabIndex = 7;
            // 
            // startPositionValueLabel
            // 
            this.startPositionValueLabel.AutoSize = true;
            this.startPositionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPositionValueLabel.Location = new System.Drawing.Point(872, 206);
            this.startPositionValueLabel.Name = "startPositionValueLabel";
            this.startPositionValueLabel.Size = new System.Drawing.Size(24, 26);
            this.startPositionValueLabel.TabIndex = 12;
            this.startPositionValueLabel.Text = "0";
            // 
            // startPositionTrackBar
            // 
            this.startPositionTrackBar.Location = new System.Drawing.Point(556, 206);
            this.startPositionTrackBar.Maximum = 70;
            this.startPositionTrackBar.Name = "startPositionTrackBar";
            this.startPositionTrackBar.Size = new System.Drawing.Size(310, 45);
            this.startPositionTrackBar.TabIndex = 11;
            this.startPositionTrackBar.Scroll += new System.EventHandler(this.startPositionTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(552, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Position";
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.Location = new System.Drawing.Point(771, 414);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(125, 31);
            this.selectButton.TabIndex = 13;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectOrbitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 457);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.startPositionValueLabel);
            this.Controls.Add(this.startPositionTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.liveViewCheckBox);
            this.Controls.Add(this.showMapButton);
            this.Controls.Add(this.worldMap);
            this.Controls.Add(this.orbitOffsetValueLabel);
            this.Controls.Add(this.orbitOffsetTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orbitAngleKoefValueLabel);
            this.Controls.Add(this.orbitAngleKoefTrackBar);
            this.Controls.Add(this.label1);
            this.Name = "SelectOrbitForm";
            this.Text = "SelectOrbitForm";
            this.Load += new System.EventHandler(this.SelectOrbitForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectOrbitForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.orbitAngleKoefTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orbitOffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPositionTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar orbitAngleKoefTrackBar;
        private System.Windows.Forms.Label orbitAngleKoefValueLabel;
        private System.Windows.Forms.Label orbitOffsetValueLabel;
        private System.Windows.Forms.TrackBar orbitOffsetTrackBar;
        private System.Windows.Forms.Label label3;
        private WorldMap worldMap;
        private System.Windows.Forms.Button showMapButton;
        private System.Windows.Forms.CheckBox liveViewCheckBox;
        private System.Windows.Forms.Label startPositionValueLabel;
        private System.Windows.Forms.TrackBar startPositionTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectButton;
    }
}