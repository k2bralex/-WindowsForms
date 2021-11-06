using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class Task_4 : Form
    {
        public Task_4()
        {
            InitializeComponent();
        }

        public class DrawingRectangle
        {
            public Point StartPosition { get; set; }
            public Point FinalPosition { get; set; }
            public int Widht { get; set; }
            public int Height { get; set; }
            public int Area { get; set; }

        }

        List<DrawingRectangle> DrawingRectangles { get; set; } = new List<DrawingRectangle>();

        Color penColor = Color.LimeGreen;
        private float penSize = 3f;
        private bool isPrint = false;

        private void Task_4_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawingRectangles.Add(new DrawingRectangle()
                    { StartPosition = e.Location });
            }
        }

        private void Task_4_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawingRectangles.Last().FinalPosition = e.Location;
            }
            DrawingRectangles.Last().Widht = Math.Abs(DrawingRectangles.Last().FinalPosition.X -
                                                      DrawingRectangles.Last().StartPosition.X);
            DrawingRectangles.Last().Height = Math.Abs(DrawingRectangles.Last().FinalPosition.Y - 
                                                       DrawingRectangles.Last().StartPosition.Y);
            DrawingRectangles.Last().Area = DrawingRectangles.Last().Widht * 
                                            DrawingRectangles.Last().Height;
            isPrint = true;
            Refresh();
        }



        private void Task_4_Paint(object sender, PaintEventArgs e)
        {
            if (isPrint == true)
            {
                Pen curPen = new Pen(penColor, penSize);
                int x, y;
                foreach (var rect in DrawingRectangles)
                {
                    x = Math.Min(rect.StartPosition.X, rect.FinalPosition.X);
                    y = Math.Min(rect.StartPosition.Y, rect.FinalPosition.Y);
                    e.Graphics.DrawRectangle(curPen, x, y, rect.Widht, rect.Height);
                }


            }
        }

        private void Task_4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var messageBox = from r in DrawingRectangles
                    where ((e.X > Math.Min(r.StartPosition.X, r.FinalPosition.X) &&
                            e.X < Math.Max(r.StartPosition.X, r.FinalPosition.X)) &&
                           (e.Y > Math.Min(r.StartPosition.Y, r.FinalPosition.Y) &&
                            e.Y < Math.Max(r.StartPosition.Y, r.FinalPosition.Y)))
                    select r;

                MessageBox.Show($"Прямоугольник №: {DrawingRectangles.IndexOf(messageBox.Last())+1}\n" +
                                $"Площадь: {messageBox.Last().Area} pxl");
            }
        }
    }
}