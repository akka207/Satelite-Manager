namespace ekzamen
{
    partial class AddSatelliteForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guidButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.setupButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.orbitStatusPanel = new System.Windows.Forms.Panel();
            this.typeStatusPanel = new System.Windows.Forms.Panel();
            this.nameStatusPanel = new System.Windows.Forms.Panel();
            this.uidStatusPanel = new System.Windows.Forms.Panel();
            this.launchProgressBar = new System.Windows.Forms.ProgressBar();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unique ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satellite Editor";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uidLabel.Location = new System.Drawing.Point(92, 99);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(297, 20);
            this.uidLabel.TabIndex = 2;
            this.uidLabel.Text = "00000000000000000000000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(96, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(129, 26);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // guidButton
            // 
            this.guidButton.Location = new System.Drawing.Point(26, 96);
            this.guidButton.Name = "guidButton";
            this.guidButton.Size = new System.Drawing.Size(60, 23);
            this.guidButton.TabIndex = 6;
            this.guidButton.Text = "Generate";
            this.guidButton.UseVisualStyleBackColor = true;
            this.guidButton.Click += new System.EventHandler(this.guidButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(96, 209);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(129, 28);
            this.typeComboBox.TabIndex = 7;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // setupButton
            // 
            this.setupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setupButton.Location = new System.Drawing.Point(27, 248);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(112, 35);
            this.setupButton.TabIndex = 8;
            this.setupButton.Text = "Set-up Orbit";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.Enabled = false;
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchButton.Location = new System.Drawing.Point(180, 326);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(208, 32);
            this.launchButton.TabIndex = 9;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // orbitStatusPanel
            // 
            this.orbitStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.orbitStatusPanel.Location = new System.Drawing.Point(17, 248);
            this.orbitStatusPanel.Name = "orbitStatusPanel";
            this.orbitStatusPanel.Size = new System.Drawing.Size(10, 35);
            this.orbitStatusPanel.TabIndex = 10;
            // 
            // typeStatusPanel
            // 
            this.typeStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.typeStatusPanel.Location = new System.Drawing.Point(17, 182);
            this.typeStatusPanel.Name = "typeStatusPanel";
            this.typeStatusPanel.Size = new System.Drawing.Size(10, 24);
            this.typeStatusPanel.TabIndex = 11;
            // 
            // nameStatusPanel
            // 
            this.nameStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nameStatusPanel.Location = new System.Drawing.Point(17, 124);
            this.nameStatusPanel.Name = "nameStatusPanel";
            this.nameStatusPanel.Size = new System.Drawing.Size(10, 24);
            this.nameStatusPanel.TabIndex = 11;
            // 
            // uidStatusPanel
            // 
            this.uidStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uidStatusPanel.Location = new System.Drawing.Point(17, 69);
            this.uidStatusPanel.Name = "uidStatusPanel";
            this.uidStatusPanel.Size = new System.Drawing.Size(10, 24);
            this.uidStatusPanel.TabIndex = 11;
            // 
            // launchProgressBar
            // 
            this.launchProgressBar.Location = new System.Drawing.Point(180, 364);
            this.launchProgressBar.Name = "launchProgressBar";
            this.launchProgressBar.Size = new System.Drawing.Size(208, 23);
            this.launchProgressBar.Step = 1;
            this.launchProgressBar.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(180, 407);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(208, 32);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back To Main Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(17, 323);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 35);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AddSatelliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 451);
            this.ControlBox = false;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.launchProgressBar);
            this.Controls.Add(this.uidStatusPanel);
            this.Controls.Add(this.nameStatusPanel);
            this.Controls.Add(this.typeStatusPanel);
            this.Controls.Add(this.orbitStatusPanel);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.guidButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSatelliteForm";
            this.Text = "AddSatelliteForm";
            this.Load += new System.EventHandler(this.AddSatelliteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guidButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Panel orbitStatusPanel;
        private System.Windows.Forms.Panel typeStatusPanel;
        private System.Windows.Forms.Panel nameStatusPanel;
        private System.Windows.Forms.Panel uidStatusPanel;
        private System.Windows.Forms.ProgressBar launchProgressBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
    }
}