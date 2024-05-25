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
    public partial class SatelliteWindow : Form
    {
        public event EventHandler OnClose;
        private Satellite satellite;
        private bool doClearLog = false;

        public SatelliteWindow()
        {
            InitializeComponent();
        }

        public SatelliteWindow(Satellite satellite)
        {
            InitializeComponent();
            this.satellite = satellite;
            satellite.OnStateChanged += Satellite_OnStateChanged;
        }


        private void Satellite_OnStateChanged(object sender, string e)
        {
            doClearLog = true;
        }

        private void SatelliteWindow_Load(object sender, EventArgs e)
        {
            uidLabel.Text = satellite.ID;
            nameLabel.Text = satellite.Name;
            typeLabel.Text = satellite.SatelliteType.ToString();
            LoadLogs();
            CheckButtons();
            foreach(var item in Enum.GetValues(typeof(Mode)))
            {
                modeComboBox.Items.Add(item);
            }
            modeComboBox.SelectedItem = modeComboBox.Items[0];
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadLogs();
            stateLabel.Text = satellite.State.ToString();
            emergencyLabel.Text = satellite.Emergency.ToString();
            if (satellite.Emergency != EmergencyType.Null)
            {
                emergencyPanel.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                emergencyPanel.BackColor = Color.FromArgb(128, 255, 128);
            }
            CheckButtons();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            destroyProgressBar.Value = satellite.DestroyProgress <= destroyProgressBar.Maximum ? satellite.DestroyProgress : destroyProgressBar.Maximum;
        }

        private void LoadLogs()
        {
            if (doClearLog)
            {
                logListView.Items.Clear();
                doClearLog = false;
            }
            if (logListView.Items.Count < satellite.History.Count)
            {
                for (int i = logListView.Items.Count; i < satellite.History.Count; i++)
                {
                    logListView.Items.Add(satellite.History[i]);
                }
            }
        }

        private void CheckButtons()
        {
            if (satellite.State == State.Error)
            {
                startButton.Enabled = false;
                stopButton.Enabled = false;
                reloadButton.Enabled = false;
                repairButton.Enabled = true;
                return;
            }
            else
            {
                reloadButton.Enabled = true;
                repairButton.Enabled = false;
            }

            if (satellite.State == State.Running)
                startButton.Enabled = false;
            else
                startButton.Enabled = true;

            if (satellite.State == State.Stopped)
                stopButton.Enabled = false;
            else
                stopButton.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            satellite.Start();
            CheckButtons();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            satellite.Stop();
            CheckButtons();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            satellite.Reload();
            CheckButtons();
        }

        private void repairButton_Click(object sender, EventArgs e)
        {
            satellite.Repair();
            CheckButtons();
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            satellite.SetOperationMode((Mode)(modeComboBox.SelectedItem as Mode?));
        }
    }
}
