using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ekzamen
{
    public partial class Form1 : Form
    {
        private int panelWidthShort = 41;
        private int panelWidthNormal = 165;
        private AddSatelliteForm sForm = new AddSatelliteForm();
        private MainMap map = new MainMap();
        private Settings settings = new Settings();
        private string path = Path.Combine(Directory.GetCurrentDirectory(), "database.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Width = panelWidthShort;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Width = panelWidthNormal;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (!panel2.ClientRectangle.Contains(panel2.PointToClient(Cursor.Position)))
            {
                panel2.Width = panelWidthShort;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SatellitesManager.Instance.CloseAllSatellites();
                Close();
                return;
            }
            CheckDownMenu();
        }

        private void buttonLaunchNewSatellite_Click(object sender, EventArgs e)
        {
            sForm.Clear();
            if (sForm.ShowDialog() == DialogResult.OK)
            {
                SatellitesManager.Instance.AddSatellite(sForm.ResultSatellite);
                sForm.ResultSatellite.Start();
                sForm.ResultSatellite = new Satellite();
            }
        }
        private void buttonSatellitesMap_Click(object sender, EventArgs e)
        {
            map.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string info = JsonConvert.SerializeObject(SatellitesManager.Instance.GetListToSave(), Formatting.Indented);
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fileDialog.FileName, info);
            }
            CheckDownMenu();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SatellitesManager.Instance.LoadSatellites(JsonConvert.DeserializeObject<List<SatelliteInfo>>(File.ReadAllText(fileDialog.FileName)));
            }
            CheckDownMenu();
        }

        private void CheckDownMenu()
        {
            if (!panel2.ClientRectangle.Contains(panel2.PointToClient(Cursor.Position)))
            {
                panel2.Width = panelWidthShort;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }
    }
}
