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
    public partial class MainMap : Form
    {
        private List<SatelliteWindow> satelliteWindows = new List<SatelliteWindow>();
        private bool doLoadSatellites = false;


        public MainMap()
        {
            InitializeComponent();
        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            LoadSatellites();
        }
        private void Satellite_OnDestroy(object sender, EventArgs e)
        {
            doLoadSatellites = true;
        }

        private void MainMap_Paint(object sender, PaintEventArgs e)
        {
            worldMap.DrawElements.Clear();

            if (userCheckBox.Checked)
                worldMap.DrawElements.Add(new PointPicture(Settings.UserPosition, worldMap.Width, worldMap.Height, Color.Red));
            foreach (ListViewItem item in satellitesListView.Items)
            {
                Satellite satellite = item.Tag as Satellite;
                Tuple<OrbitPicture, SatellitePicture, TextPicture> tuple = SatelliteElement(satellite);
                if (item.Selected || orbitesCheckBox.Checked)
                    worldMap.DrawElements.Add(tuple.Item1);
                worldMap.DrawElements.Add(tuple.Item2);
                if (nameCheckBox.Checked)
                    worldMap.DrawElements.Add(tuple.Item3);
            }

            worldMap.DrawMap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            if (doLoadSatellites)
            {
                LoadSatellites();
                doLoadSatellites = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            foreach (var item in satelliteWindows)
            {
                item.Close();
            }
            DialogResult = DialogResult.OK;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (satellitesListView.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in satellitesListView.SelectedItems)
                {
                    Satellite satellite = item.Tag as Satellite;
                    SatelliteWindow sForm = new SatelliteWindow(satellite);
                    sForm.Show();
                    satelliteWindows.Add(sForm);
                    sForm.OnClose += SForm_OnClose;
                }
            }
        }

        private void SForm_OnClose(object sender, EventArgs e)
        {
            satelliteWindows.Remove(sender as SatelliteWindow);
        }

        private void LoadSatellites()
        {
            satellitesListView.Items.Clear();
            foreach (Satellite satellite in SatellitesManager.Instance.Satellites)
            {
                if (!satellite.Destroyed)
                {
                    satellite.OnDestroy += Satellite_OnDestroy;
                    ListViewItem item = new ListViewItem();
                    item.Tag = satellite;
                    item.Text = satellite.Name;
                    satellitesListView.Items.Add(item);
                }
            }
        }
        private Tuple<OrbitPicture, SatellitePicture, TextPicture> SatelliteElement(Satellite satellite)
        {
            float A = satellite.A;
            float B = satellite.B;
            float C = satellite.C;
            float D = satellite.D;
            List<float> points = new List<float>();
            Func<float, float, float, float, float, float> OrbitFunc = (float a, float b, float c, float d, float x) =>
            { return (float)(-a * Math.Sin(2 * Math.PI * x / b - c / 100f) + d / 2); };

            for (int i = 0; i < worldMap.Width; i++)
            {
                points.Add(OrbitFunc(A, B, C, D, i));
            }
            OrbitPicture orbitPicture = new OrbitPicture(points, Color.Yellow, worldMap.Width);

            Color satelliteColor = Color.Red;
            switch (satellite.State)
            {
                case State.Running:
                    satelliteColor = Color.Green;
                    break;
                case State.Stopped:
                    satelliteColor = Color.LightYellow;
                    break;
                case State.Error:
                    satelliteColor = Color.Red;
                    break;
            }
            SatellitePicture satelitePicture = new SatellitePicture(new Point((int)satellite.OrbitPosition, (int)OrbitFunc(A, B, C, D, satellite.OrbitPosition)), 10, satelliteColor);
            TextPicture textPicture = new TextPicture(satellite.GetPosition(), satellite.Name, new Font(worldMap.Font, FontStyle.Regular), Color.Black);

            return new Tuple<OrbitPicture, SatellitePicture, TextPicture>(orbitPicture, satelitePicture, textPicture);
        }
    }
}
