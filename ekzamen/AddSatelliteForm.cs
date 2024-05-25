using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekzamen
{
    public partial class AddSatelliteForm : Form
    {
        private bool uidGenerated = false;
        private bool nameNotEmpty = false;
        private bool typeSelected = false;
        private bool orbitSelected = false;

        private bool isLaunching = false;

        public Satellite ResultSatellite = new Satellite();
        private DialogResult dialogResult = DialogResult.Cancel;

        public AddSatelliteForm()
        {
            InitializeComponent();
        }

        private void AddSatelliteForm_Load(object sender, EventArgs e)
        {
            typeComboBox.Items.Clear();
            foreach (SatelliteType satelliteType in Enum.GetValues(typeof(SatelliteType)))
                typeComboBox.Items.Add(satelliteType);
        }

        private void guidButton_Click(object sender, EventArgs e)
        {
            uidLabel.Text = Guid.NewGuid().ToString("N");
            uidGenerated = true;
            setStatuses();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && nameTextBox.Text.Length <= 12)
                nameNotEmpty = true;
            else
                nameNotEmpty = false;
            setStatuses();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex != -1)
                typeSelected = true;
            setStatuses();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            SelectOrbitForm sForm = new SelectOrbitForm();
            sForm.ShowDialog();
            ResultSatellite.SetupOrbit(sForm.A, sForm.B, sForm.C, sForm.D);
            ResultSatellite.OrbitPosition = sForm.StartPosition;
            orbitSelected = true;
            setStatuses();
        }

        private void setStatuses()
        {
            if (uidGenerated)
                uidStatusPanel.BackColor = Color.FromArgb(127, 255, 127);
            else
                uidStatusPanel.BackColor = Color.FromArgb(255, 127, 127);

            if (nameNotEmpty)
                nameStatusPanel.BackColor = Color.FromArgb(127, 255, 127);
            else
                nameStatusPanel.BackColor = Color.FromArgb(255, 127, 127);

            if (typeSelected)
                typeStatusPanel.BackColor = Color.FromArgb(127, 255, 127);
            else
                typeStatusPanel.BackColor = Color.FromArgb(255, 127, 127);

            if (orbitSelected)
                orbitStatusPanel.BackColor = Color.FromArgb(127, 255, 127);
            else
                orbitStatusPanel.BackColor = Color.FromArgb(255, 127, 127);


            if (uidGenerated && nameNotEmpty && typeSelected && orbitSelected && !isLaunching)
                launchButton.Enabled = true;
            else
                launchButton.Enabled = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            isLaunching = true;
            uidGenerated = false;
            setStatuses();
            ResultSatellite.ID = uidLabel.Text;
            ResultSatellite.Name = nameTextBox.Text;
            ResultSatellite.SatelliteType = (SatelliteType)typeComboBox.Items[typeComboBox.SelectedIndex];
            launchSatelliteAsync();
        }

        private async void launchSatelliteAsync()
        {
            while (launchProgressBar.Value < launchProgressBar.Maximum)
            {
                launchProgressBar.PerformStep();
                await Task.Delay(100);
            }
            dialogResult = DialogResult.OK;
            isLaunching = false;
            setStatuses();
            MessageBox.Show("New satellite has been launched!", "Informing");
            ResultSatellite.History.Add($"{DateTime.Now} | IsOnOrbit");
            launchProgressBar.Value = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult = dialogResult;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            uidGenerated = false;
            nameNotEmpty = false;
            typeSelected = false;
            orbitSelected = false;
            setStatuses();

            uidLabel.Text = "00000000000000000000000000000000";
            nameTextBox.Text = "";
            typeComboBox.SelectedIndex = -1;
        }
    }
}