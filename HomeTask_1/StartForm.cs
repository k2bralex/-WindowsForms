using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int choise = listBox1.SelectedIndex;
            this.Hide();
            switch (choise)
            {
                case 0:
                    Task_1 t1 = new Task_1();
                    t1.ShowDialog();
                    break;
                case 1:
                    Task_2 t2 = new Task_2();
                    t2.ShowDialog();
                    break;
                case 2:
                    Task_3 t3 = new Task_3();
                    t3.ShowDialog();
                    break;
                case 3:
                    Task_4_1 t4_1 = new Task_4_1();
                    t4_1.ShowDialog();
                    break;
                case 4:
                    Task_5 t5 = new Task_5();
                    t5.ShowDialog();
                    break;
                case 5:
                    Task_6 t6 = new Task_6();
                    t6.ShowDialog();
                    break;
                case 6:
                    GasStationForm t8 = new GasStationForm();
                    t8.ShowDialog();
                    break;

            }
            this.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
