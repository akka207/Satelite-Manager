using System;
using System.IO;
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
    public partial class WorldMap : UserControl
    {
        public List<IDrawable> DrawElements = new List<IDrawable>();

        public WorldMap()
        {
            InitializeComponent();
        }

        public void DrawMap()
        {
            Invalidate();
        }

        private void WorldMap_Paint(object sender, PaintEventArgs e)
        {
            picture.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "map.bmp"));
            Graphics g = Graphics.FromImage(picture.Image);

            foreach (var item in DrawElements)
            {
                item.Draw(g);
            }
        }
    }
}
