using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class Task_6_1 : Form
    {
        public Task_6_1()
        {
            InitializeComponent();
        }

        private List<string> translationsList = new List<string>()
        {
            "Воскресение",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
        };

        private TimeSpan leftToDateSpan;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DayOfWeek dayindex = dateTimePicker1.Value.DayOfWeek;
            textBox1.Text = $"{translationsList[(int)dayindex]}";

            DateTime currecnDateTime = DateTime.Now;
            leftToDateSpan = dateTimePicker1.Value.Subtract(currecnDateTime);
        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            float year = leftToDateSpan.Days / 365;
            tBoxTimeLeft.Text = $"{year}";
        }

        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            float month = leftToDateSpan.Days / 12;
            tBoxTimeLeft.Text = $"{month}";
        }

        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            tBoxTimeLeft.Text = $"{(int)leftToDateSpan.TotalDays}";
        }

        private void radioButtonHour_CheckedChanged(object sender, EventArgs e)
        {
            tBoxTimeLeft.Text = $"{(int)leftToDateSpan.TotalHours}";
        }

        private void radioButtonMinute_CheckedChanged(object sender, EventArgs e)
        {
            tBoxTimeLeft.Text = $"{(int)leftToDateSpan.TotalMinutes}";
        }

        private void radioButtonSecond_CheckedChanged(object sender, EventArgs e)
        {
            tBoxTimeLeft.Text = $"{(int)leftToDateSpan.TotalSeconds}";
        }
    }
}
