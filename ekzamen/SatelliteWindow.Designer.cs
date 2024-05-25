namespace ekzamen
{
    partial class SatelliteWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.logListView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.emergencyPanel = new System.Windows.Forms.Panel();
            this.destroyProgressBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Satellite View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unique ID";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uidLabel.Location = new System.Drawing.Point(121, 73);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(297, 20);
            this.uidLabel.TabIndex = 10;
            this.uidLabel.Text = "00000000000000000000000000000000";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(121, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(121, 132);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 20);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "type";
            // 
            // logListView
            // 
            this.logListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logListView.AutoArrange = false;
            this.logListView.HideSelection = false;
            this.logListView.Location = new System.Drawing.Point(27, 191);
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(602, 245);
            this.logListView.TabIndex = 13;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Log List";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(638, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(203, 32);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Close";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(521, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "State";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(635, 103);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(48, 20);
            this.stateLabel.TabIndex = 17;
            this.stateLabel.Text = "State";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(638, 191);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(203, 32);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(638, 229);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(203, 32);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.Location = new System.Drawing.Point(638, 267);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(203, 32);
            this.reloadButton.TabIndex = 20;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // repairButton
            // 
            this.repairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repairButton.Location = new System.Drawing.Point(638, 305);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(203, 32);
            this.repairButton.TabIndex = 21;
            this.repairButton.Text = "Repair";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(521, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Emergency";
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emergencyLabel.Location = new System.Drawing.Point(635, 136);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(35, 20);
            this.emergencyLabel.TabIndex = 23;
            this.emergencyLabel.Text = "Null";
            // 
            // emergencyPanel
            // 
            this.emergencyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.emergencyPanel.Location = new System.Drawing.Point(525, 157);
            this.emergencyPanel.Name = "emergencyPanel";
            this.emergencyPanel.Size = new System.Drawing.Size(104, 10);
            this.emergencyPanel.TabIndex = 24;
            // 
            // destroyProgressBar
            // 
            this.destroyProgressBar.Location = new System.Drawing.Point(639, 344);
            this.destroyProgressBar.Name = "destroyProgressBar";
            this.destroyProgressBar.Size = new System.Drawing.Size(202, 23);
            this.destroyProgressBar.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(636, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Progress Of Destroying";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(521, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Location = new System.Drawing.Point(638, 72);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(121, 21);
            this.modeComboBox.TabIndex = 28;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // SatelliteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 452);
            this.ControlBox = false;
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.destroyProgressBar);
            this.Controls.Add(this.emergencyPanel);
            this.Controls.Add(this.emergencyLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.repairButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SatelliteWindow";
            this.Text = "SatelliteWindow";
            this.Load += new System.EventHandler(this.SatelliteWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button repairButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label emergencyLabel;
        private System.Windows.Forms.Panel emergencyPanel;
        private System.Windows.Forms.ProgressBar destroyProgressBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox modeComboBox;
    }
}