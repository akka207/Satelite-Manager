namespace ekzamen
{
    partial class MainMap
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
            this.satellitesListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCheckBox = new System.Windows.Forms.CheckBox();
            this.orbitesCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.openButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.worldMap = new ekzamen.WorldMap();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // satellitesListView
            // 
            this.satellitesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.satellitesListView.HideSelection = false;
            this.satellitesListView.Location = new System.Drawing.Point(530, 12);
            this.satellitesListView.Name = "satellitesListView";
            this.satellitesListView.Size = new System.Drawing.Size(231, 277);
            this.satellitesListView.TabIndex = 1;
            this.satellitesListView.UseCompatibleStateImageBehavior = false;
            this.satellitesListView.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.userCheckBox);
            this.panel1.Controls.Add(this.orbitesCheckBox);
            this.panel1.Controls.Add(this.nameCheckBox);
            this.panel1.Location = new System.Drawing.Point(530, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 68);
            this.panel1.TabIndex = 2;
            // 
            // userCheckBox
            // 
            this.userCheckBox.AutoSize = true;
            this.userCheckBox.Location = new System.Drawing.Point(3, 49);
            this.userCheckBox.Name = "userCheckBox";
            this.userCheckBox.Size = new System.Drawing.Size(118, 17);
            this.userCheckBox.TabIndex = 2;
            this.userCheckBox.Text = "Show User Position";
            this.userCheckBox.UseVisualStyleBackColor = true;
            // 
            // orbitesCheckBox
            // 
            this.orbitesCheckBox.AutoSize = true;
            this.orbitesCheckBox.Location = new System.Drawing.Point(3, 26);
            this.orbitesCheckBox.Name = "orbitesCheckBox";
            this.orbitesCheckBox.Size = new System.Drawing.Size(103, 17);
            this.orbitesCheckBox.TabIndex = 1;
            this.orbitesCheckBox.Text = "Show All Orbites";
            this.orbitesCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(3, 3);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(84, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Show Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(530, 296);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(231, 28);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open Selected In New Window";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // worldMap
            // 
            this.worldMap.Location = new System.Drawing.Point(12, 12);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(512, 434);
            this.worldMap.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(530, 418);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(231, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back To Main Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MainMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.satellitesListView);
            this.Controls.Add(this.worldMap);
            this.Name = "MainMap";
            this.Text = "MainMap";
            this.Load += new System.EventHandler(this.MainMap_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WorldMap worldMap;
        private System.Windows.Forms.ListView satellitesListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox userCheckBox;
        private System.Windows.Forms.CheckBox orbitesCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button backButton;
    }
}