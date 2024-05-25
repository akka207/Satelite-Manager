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
    public partial class SelectOrbitForm : Form
    {
        private OrbitPicture orbitPicture;
        private SatellitePicture satelitePicture;
        private bool doDraw = true;

        private Func<float, float, float, float, float, float> OrbitFunc;
        public float A, B, C, D;
        public float StartPosition;


        public SelectOrbitForm()
        {
            InitializeComponent();
        }


        private void SelectOrbitForm_Load(object sender, EventArgs e)
        {
            orbitOffsetTrackBar.Maximum = worldMap.Width / 2;
            orbitAngleKoefTrackBar.Minimum = -worldMap.Height / 2 + 4;
            orbitAngleKoefTrackBar.Maximum = worldMap.Height / 2 - 4;
            startPositionTrackBar.Maximum = worldMap.Width;

            B = worldMap.Width;
            D = worldMap.Height;
        }
        private void SelectOrbitForm_Paint(object sender, PaintEventArgs e)
        {
            if (doDraw)
            {
                DrawOrbit();
                worldMap.DrawElements.Clear();
                worldMap.DrawElements.Add(orbitPicture);
                worldMap.DrawElements.Add(satelitePicture);
                worldMap.DrawMap();
                if (!liveViewCheckBox.Checked)
                {
                    doDraw = false;
                }
            }
        }

        #region TrackBars
        private void orbitAngleKoefTrackBar_Scroll(object sender, EventArgs e)
        {
            orbitAngleKoefValueLabel.Text = orbitAngleKoefTrackBar.Value.ToString();
            A = orbitAngleKoefTrackBar.Value;
            Invalidate();
        }

        private void orbitOffsetTrackBar_Scroll(object sender, EventArgs e)
        {
            orbitOffsetValueLabel.Text = orbitOffsetTrackBar.Value.ToString();
            C = orbitOffsetTrackBar.Value;
            Invalidate();
        }
        private void startPositionTrackBar_Scroll(object sender, EventArgs e)
        {
            startPositionValueLabel.Text = startPositionTrackBar.Value.ToString();
            StartPosition = startPositionTrackBar.Value;
            Invalidate();
        }
        #endregion

        private void selectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void liveViewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (liveViewCheckBox.Checked)
            {
                showMapButton.Enabled = false;
                doDraw = true;
            }
            else
            {
                showMapButton.Enabled = true;
            }
        }
        private void showMapButton_Click(object sender, EventArgs e)
        {
            doDraw = true;
            Invalidate();
        }

        private void DrawOrbit()
        {
            List<float> points = new List<float>();
            OrbitFunc = (float a, float b, float c, float d, float x) => { return (float)(-a * Math.Sin(2 * Math.PI * x / b - c / 100f) + d / 2); };

            for (int i = 0; i < worldMap.Width; i++)
            {
                points.Add(OrbitFunc(A, B, C, D, i));
            }
            orbitPicture = new OrbitPicture(points, Color.Yellow, worldMap.Width);
            satelitePicture = new SatellitePicture(new Point(startPositionTrackBar.Value, (int)OrbitFunc(A, B, C, D, startPositionTrackBar.Value)), 10, Color.Green);
        }
    }
}
