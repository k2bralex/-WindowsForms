using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class Task_3_1 : Form
    {
        public bool ControlPress { get; set; } = false;

        public Task_3_1()
        {
            InitializeComponent();
        }

        private void Task_3_1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    MessageBox.Show($"Высота окна: {this.Size.Height} pxl\n" +
                                    $"Ширина окна: {this.Size.Width}");
                    break;
                case MouseButtons.Left:
                    if (ControlPress == true)
                    {
                        this.Close();
                    }
                    if ((e.X > 20 && e.X < 780) &&
                        (e.Y > 20 && e.Y < 780))
                    {
                        MessageBox.Show($"X: {e.X}, Y:{e.Y}\n" +
                                        $"Курсор внутри воображаемого прямоугольника");
                    }
                    //if ((e.X < 20 && e.X > 780) &&
                    //    (e.Y < 20 && e.Y > 780))
                    if (e.X<20||e.Y<20||e.X>780||e.Y>780)
                    {
                        MessageBox.Show($"X: {e.X}, Y:{e.Y}\n" +
                                        $"Курсор снаружи воображаемого прямоугольника");
                    }
                    if (e.X == 20 || e.X == 780 || e.Y == 20 || e.Y == 780)
                    {
                        MessageBox.Show($"X: {e.X}, Y:{e.Y}\n" +
                                        $"Курсор на линии воображаемого прямоугольника");
                    }
                    break;
            }

        }

        private void Task_3_1_MouseMove(object sender, MouseEventArgs e)
        {
            int CursorX = Cursor.Position.X;
            int CursorY = Cursor.Position.Y;

            this.Text = "X:" + CursorX.ToString() + " Y:" + CursorY.ToString();
        }

        private void Task_3_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                ControlPress = true;
        }

        private void Task_3_1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                ControlPress = false;
        }
    }



}

