namespace ekzamen
{
    partial class Settings
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
            this.horizontalTrackBar = new System.Windows.Forms.TrackBar();
            this.verticalTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.worldMap = new ekzamen.WorldMap();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.velocityTrackBar = new System.Windows.Forms.TrackBar();
            this.emergencyTrackBar = new System.Windows.Forms.TrackBar();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delayTrackBar = new System.Windows.Forms.TrackBar();
            this.delayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalTrackBar
            // 
            this.horizontalTrackBar.Location = new System.Drawing.Point(17, 530);
            this.horizontalTrackBar.Name = "horizontalTrackBar";
            this.horizontalTrackBar.Size = new System.Drawing.Size(512, 45);
            this.horizontalTrackBar.TabIndex = 1;
            this.horizontalTrackBar.Scroll += new System.EventHandler(this.horizontalTrackBar_Scroll);
            // 
            // verticalTrackBar
            // 
            this.verticalTrackBar.Location = new System.Drawing.Point(535, 90);
            this.verticalTrackBar.Name = "verticalTrackBar";
            this.verticalTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.verticalTrackBar.Size = new System.Drawing.Size(45, 434);
            this.verticalTrackBar.TabIndex = 2;
            this.verticalTrackBar.Scroll += new System.EventHandler(this.verticalTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Position";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(795, 540);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(208, 32);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back To Main Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // worldMap
            // 
            this.worldMap.Location = new System.Drawing.Point(17, 90);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(512, 434);
            this.worldMap.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(586, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Satellite Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(586, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emergency Probability";
            // 
            // velocityTrackBar
            // 
            this.velocityTrackBar.Location = new System.Drawing.Point(797, 90);
            this.velocityTrackBar.Maximum = 100;
            this.velocityTrackBar.Name = "velocityTrackBar";
            this.velocityTrackBar.Size = new System.Drawing.Size(145, 45);
            this.velocityTrackBar.TabIndex = 7;
            this.velocityTrackBar.Scroll += new System.EventHandler(this.velocityTrackBar_Scroll);
            // 
            // emergencyTrackBar
            // 
            this.emergencyTrackBar.Location = new System.Drawing.Point(797, 139);
            this.emergencyTrackBar.Maximum = 100;
            this.emergencyTrackBar.Name = "emergencyTrackBar";
            this.emergencyTrackBar.Size = new System.Drawing.Size(145, 45);
            this.emergencyTrackBar.TabIndex = 8;
            this.emergencyTrackBar.Scroll += new System.EventHandler(this.emergencyTrackBar_Scroll);
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.velocityLabel.Location = new System.Drawing.Point(948, 90);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(18, 20);
            this.velocityLabel.TabIndex = 9;
            this.velocityLabel.Text = "1";
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emergencyLabel.Location = new System.Drawing.Point(948, 139);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(36, 20);
            this.emergencyLabel.TabIndex = 10;
            this.emergencyLabel.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(586, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Satellite Delay";
            // 
            // delayTrackBar
            // 
            this.delayTrackBar.Location = new System.Drawing.Point(797, 191);
            this.delayTrackBar.Maximum = 2000;
            this.delayTrackBar.Minimum = 100;
            this.delayTrackBar.Name = "delayTrackBar";
            this.delayTrackBar.Size = new System.Drawing.Size(145, 45);
            this.delayTrackBar.TabIndex = 12;
            this.delayTrackBar.Value = 100;
            this.delayTrackBar.Scroll += new System.EventHandler(this.delayTrackBar_Scroll);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayLabel.Location = new System.Drawing.Point(948, 191);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(45, 20);
            this.delayLabel.TabIndex = 13;
            this.delayLabel.Text = "1000";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 584);
            this.ControlBox = false;
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delayTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emergencyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.velocityLabel);
            this.Controls.Add(this.verticalTrackBar);
            this.Controls.Add(this.emergencyTrackBar);
            this.Controls.Add(this.horizontalTrackBar);
            this.Controls.Add(this.velocityTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.worldMap);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Settings_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldMap worldMap;
        private System.Windows.Forms.TrackBar horizontalTrackBar;
        private System.Windows.Forms.TrackBar verticalTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar velocityTrackBar;
        private System.Windows.Forms.TrackBar emergencyTrackBar;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label emergencyLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar delayTrackBar;
        private System.Windows.Forms.Label delayLabel;
    }
}