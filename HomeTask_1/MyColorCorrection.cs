using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class MyColorCorrection : Form
    {

        public MyColorCorrection()
        {
            InitializeComponent();
        }

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(this.trackBarRed.Value,
                this.trackBarGreen.Value, this.trackBarBlue.Value);
            this.Refresh();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.trackBarRed.Value,
                this.trackBarGreen.Value, this.trackBarBlue.Value);
            this.Refresh();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(this.trackBarRed.Value,
                this.trackBarGreen.Value, this.trackBarBlue.Value);
            this.Refresh();
        }

        public void MyColorCorrection_FormClosed(object sender, FormClosedEventArgs e)
        {
            GasStationForm main = this.Owner as GasStationForm;
            if (main!=null)
            {
                main.BackColor  = this.BackColor;
            }
        }
    }
}
