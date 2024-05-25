using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ekzamen
{
    public interface IDrawable
    {
        Color Color { get; set; }
        void Draw(Graphics g);
    }

    public class OrbitPicture : IDrawable
    {
        public List<float> OrbitKeyPoints;
        public Color Color { get; set; }
        public double Width { get; set; }

        public OrbitPicture(List<float> orbitKeyPoints, Color color, float wigth)
        {
            OrbitKeyPoints = orbitKeyPoints;
            Color = color;
            Width = wigth;
        }

        public void Draw(Graphics g)
        {
            float step = (float)Width / OrbitKeyPoints.Count;

            for (int i = 1; i < OrbitKeyPoints.Count; i++)
            {
                g.DrawLine(new Pen(Color, 3f), step * (i - 1), OrbitKeyPoints[i - 1], step * (i), OrbitKeyPoints[i]);
            }
        }
    }

    public class SatellitePicture : IDrawable
    {
        public Point Position { get; set; } = new Point(0, 0);
        public float Size { get; set; }
        public Color Color { get; set; }

        public SatellitePicture(Point position, float size, Color color)
        {
            Position = position;
            Size = size;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color), Position.X - Size / 2, Position.Y - Size / 2, Size, Size);
            g.FillEllipse(new SolidBrush(Color), Position.X - Size / 2, Position.Y - Size / 2, Size, Size);
        }
    }

    public class PointPicture : IDrawable
    {
        public Point Position { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }

        public PointPicture(Point position, float width, float height, Color color)
        {
            Position = position;
            Width = width;
            Height = height;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color), Position.X, 0, Position.X, Height - 1);
            g.DrawLine(new Pen(Color), 0, Position.Y, Width - 1, Position.Y);
        }
    }

    public class TextPicture : IDrawable
    {
        public Point Position { set; get; }
        public string Text { get; set; }
        public Font TextFont { get; set; }
        public Color Color { get; set; }

        public TextPicture(Point position, string text, Font textFont, Color color)
        {
            Position = position;
            Text = text;
            Color = color;
            TextFont = textFont;
        }

        public void Draw(Graphics g)
        {
            g.DrawString(Text, TextFont, new SolidBrush(Color), Position);
        }
    }
}