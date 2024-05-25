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
    public partial class Settings : Form
    {
        public static Point UserPosition { get; set; } = new Point(0, 0);
        public static float Velocity = 1f;
        public static int Emergency = 5;
        public static int SatelliteDelay = 1000;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            horizontalTrackBar.Minimum = 1;
            horizontalTrackBar.Maximum = worldMap.Width - 1;
            verticalTrackBar.Minimum = 1;
            verticalTrackBar.Maximum = worldMap.Height - 1;
            verticalTrackBar.Value = worldMap.Height - 1;
            velocityTrackBar.Value = (int)Velocity * 10;
            emergencyTrackBar.Value = Emergency;
            delayTrackBar.Value = SatelliteDelay;
            UpdateLabels();
        }

        private void horizontalTrackBar_Scroll(object sender, EventArgs e)
        {
            UserPosition = new Point(horizontalTrackBar.Value, UserPosition.Y);
            Invalidate();
        }

        private void verticalTrackBar_Scroll(object sender, EventArgs e)
        {
            UserPosition = new Point(UserPosition.X, worldMap.Height - verticalTrackBar.Value);
            Invalidate();
        }

        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            worldMap.DrawElements.Clear();
            worldMap.DrawElements.Add(new PointPicture(UserPosition, worldMap.Width, worldMap.Height, Color.Red));
            worldMap.DrawMap();
        }

        private void velocityTrackBar_Scroll(object sender, EventArgs e)
        {
            Velocity = velocityTrackBar.Value / 10f;
            velocityLabel.Text = Velocity.ToString();
        }

        private void emergencyTrackBar_Scroll(object sender, EventArgs e)
        {
            Emergency = emergencyTrackBar.Value;
            emergencyLabel.Text = Emergency.ToString();
        }

        private void delayTrackBar_Scroll(object sender, EventArgs e)
        {
            SatelliteDelay = delayTrackBar.Value;
            delayLabel.Text = SatelliteDelay.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UpdateLabels()
        {
            velocityLabel.Text = Velocity.ToString();
            emergencyLabel.Text = Emergency.ToString();
        }
    }
}
