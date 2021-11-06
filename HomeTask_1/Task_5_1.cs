using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class Task_5_1 : Form
    {
        public Task_5_1()
        {
            InitializeComponent();
        }

        Color penColor = Color.LimeGreen;
        private float penSize = 3f;

        private int rectWidth = 50;
        private int rectHeight = 50;

        private bool isMove = false;

        private Point CurrecntPosition;
        private Point NewPosition;

        private int diagonalIndentValue = 60;
        private int perpendicularIndentValue = 70;
        private int moveIndexValue = 10;


        private void Task_5_1_Paint(object sender, PaintEventArgs e)
        {
            if (isMove == false)
            {
                CurrecntPosition.X = this.Width / 2 - rectWidth / 2;
                CurrecntPosition.Y = this.Height / 2 - rectHeight / 2;
            }
            Pen curPen = new Pen(penColor, penSize);
               e.Graphics.DrawRectangle(curPen, CurrecntPosition.X,
                    CurrecntPosition.Y, rectWidth, rectHeight);

            this.DoubleBuffered = true;
        }

        private void Task_5_1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " " + e.Y.ToString();
            NewPosition = CurrecntPosition;

            if (((e.X < CurrecntPosition.X) && (e.X > CurrecntPosition.X - diagonalIndentValue)) &&
                ((e.Y < CurrecntPosition.Y) && (e.Y > CurrecntPosition.Y - diagonalIndentValue)))
            {
                NewPosition.X += moveIndexValue;
                NewPosition.Y += moveIndexValue;
            }

            if (((e.X > CurrecntPosition.X + rectWidth) && (e.X < CurrecntPosition.X + rectWidth + diagonalIndentValue))&&
                ((e.Y < CurrecntPosition.Y) && (e.Y > CurrecntPosition.Y - diagonalIndentValue)))
            {
                NewPosition.X -= moveIndexValue;
                NewPosition.Y += moveIndexValue;
            }

            if (((e.X > CurrecntPosition.X + rectWidth) && (e.X < CurrecntPosition.X + rectWidth + diagonalIndentValue))&&
                ((e.Y > CurrecntPosition.Y + rectHeight) && (e.Y < CurrecntPosition.Y + rectHeight + diagonalIndentValue)))
            {
                NewPosition.X -= moveIndexValue;
                NewPosition.Y -= moveIndexValue;
            }

            if (((e.X < CurrecntPosition.X) && (e.X > CurrecntPosition.X - diagonalIndentValue)) &&
                ((e.Y > CurrecntPosition.Y + rectHeight) && (e.Y < CurrecntPosition.Y + rectHeight + diagonalIndentValue)))
            {
                NewPosition.X += moveIndexValue;
                NewPosition.Y -= moveIndexValue;
            }

            if (((e.X < CurrecntPosition.X) && (e.X > CurrecntPosition.X - perpendicularIndentValue))&&
                ((e.Y > CurrecntPosition.Y) && (e.Y < CurrecntPosition.Y + rectHeight)))
            {
                NewPosition.X += moveIndexValue;
            }
            if (((e.X > CurrecntPosition.X + rectWidth) && (e.X < CurrecntPosition.X + rectWidth + perpendicularIndentValue)) &&
                ((e.Y > CurrecntPosition.Y) && (e.Y < CurrecntPosition.Y + rectHeight)))
            {
                NewPosition.X -= moveIndexValue;
            }

            if (((e.X > CurrecntPosition.X) && (e.X < CurrecntPosition.X + rectWidth)) &&
                ((e.Y < CurrecntPosition.Y) && (e.Y > CurrecntPosition.Y - perpendicularIndentValue)))
            {
                NewPosition.Y += moveIndexValue;
            }
            if (((e.X > CurrecntPosition.X) && (e.X < CurrecntPosition.X + rectWidth)) &&
                ((e.Y > CurrecntPosition.Y + rectHeight) && (e.Y < CurrecntPosition.Y + rectHeight + perpendicularIndentValue)))
            {
                NewPosition.Y -= moveIndexValue;
            }

            if (NewPosition.X < 40)
                NewPosition.X = 40;
            if (NewPosition.X > this.Width - 40 - rectWidth)
                NewPosition.X = this.Width - 40 - rectWidth;

            if (NewPosition.Y < 40)
                NewPosition.Y = 40;
            if (NewPosition.Y > this.Height - 80 - rectHeight)
                NewPosition.Y = this.Height - 80 - rectHeight;

            CurrecntPosition = NewPosition;
            Refresh();
        }

        private void Task_5_1_MouseClick(object sender, MouseEventArgs e)
        {
            isMove = true;
        }
    }
}
