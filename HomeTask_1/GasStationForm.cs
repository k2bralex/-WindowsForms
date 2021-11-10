using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HomeTask_1.StationClasses;
using Timer = System.Windows.Forms.Timer;

namespace HomeTask_1
{
    public partial class GasStationForm : Form
    {

        private List<Fuel> fuels = new List<Fuel>()
        {
            new Fuel() {Type = "A-95", Price = 35.99},
            new Fuel() {Type = "A-92", Price = 33.49},
            new Fuel() {Type = "Diesel", Price = 34.99},
            new Fuel() {Type = "Gas", Price = 18.99},

        };

        private List<CafeItem> Menu { get; set; } = new List<CafeItem>()
        {
            new CafeItem() { Type = "Кофе", Price = 26.10 },
            new CafeItem() { Type = "Кока-Кола", Price = 18 },
            new CafeItem() { Type = "Хот-Дог", Price = 35.50 },
            new CafeItem() { Type = "Пончик", Price = 15.99 },

        };

        public List<Check> Checks { get; set; } = new List<Check>();

        public GasStationForm()
        {
            InitializeComponent();
            comboBoxStation.Items.AddRange(fuels.ToArray());
            this.ShowInTaskbar = false;
        }

        private void GasStationForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        #region ------FuelStationPart------

        private void comboBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPriceValue.Text = $"{fuels[comboBoxStation.SelectedIndex].Price}";
        }

        private void radioButtonFuelVolume_CheckedChanged(object sender, EventArgs e)
        {

            textBoxAmount.ReadOnly = true;
            textBoxFuelVolume.ReadOnly = false;
            textBoxFuelVolume.Clear();

            if (comboBoxStation.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите тип топлива!");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    Checks.Last().FuelToCheck = fuels[comboBoxStation.SelectedIndex];
                }
                else
                {
                    Check tempCheck = new Check();
                    tempCheck.FuelToCheck = fuels[comboBoxStation.SelectedIndex];
                    Checks.Add(tempCheck);
                }
            }

        }

        private void radioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFuelVolume.ReadOnly = true;
            textBoxAmount.ReadOnly = false;
            textBoxAmount.Clear();

            if (comboBoxStation.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите тип топлива!");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    Checks.Last().FuelToCheck = fuels[comboBoxStation.SelectedIndex];
                }
                else
                {
                    Check tempCheck = new Check();
                    tempCheck.FuelToCheck = fuels[comboBoxStation.SelectedIndex];
                    Checks.Add(tempCheck);
                }

            }

        }

        private void textBoxFuelVolume_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxFuelVolume.Text, out double d);
            Checks.Last().FuelVolume = d;
            Checks.Last().FuelSum = Checks.Last().FuelToCheck.Price * d;
            labelFuelToPay.Text = Checks.Last().FuelSum.ToString("0.00");
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBoxAmount.Text, out double d);
            Checks.Last().FuelSum = d;
            Checks.Last().FuelVolume = d / Checks.Last().FuelToCheck.Price;
            labelFuelToPay.Text = Checks.Last().FuelSum.ToString("0.00");
        }



        #endregion

        #region ------CafePart------

        private void checkBoxCofee_CheckedChanged(object sender, EventArgs e)
        {
            bool result = bool.Parse(textBox1.ReadOnly.ToString());
            if (result == false)
            {
                textBox1.ReadOnly = true;

                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Кофе")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Кофе");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }
            }
            else
            {
                textBox1.ReadOnly = false;
            }


        }
        private void checkBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            bool result = bool.Parse(textBox2.ReadOnly.ToString());
            if (result == false)
            {
                textBox2.ReadOnly = true;

                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Кока-Кола")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Кока-Кола");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }
            }
            else
            {
                textBox2.ReadOnly = false;
            }
        }
        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            bool result = bool.Parse(textBox4.ReadOnly.ToString());
            if (result == false)
            {
                textBox4.ReadOnly = true;

                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Хот-Дог")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Хот-Дог");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }

            }
            else
            {
                textBox4.ReadOnly = false;
            }
        }
        private void checkBoxDonat_CheckedChanged(object sender, EventArgs e)
        {
            bool result = bool.Parse(textBox3.ReadOnly.ToString());
            if (result == false)
            {
                textBox3.ReadOnly = true;

                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Пончик")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Пончик");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }
            }
            else
            {
                textBox3.ReadOnly = false;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                int.TryParse(textBox1.Text, out int i);
                if (i > 0)
                {
                    if (Checks.Count > 0)
                    {
                        Checks.Last().ItemToList.Type = Menu[0].Type;
                        Checks.Last().ItemToList.Price = Menu[0].Price;
                        for (int j = 0; j < i; j++)
                        {
                            Checks.Last().ItemsToCheck.Add(Checks.Last().ItemToList);
                        }
                    }
                    else
                    {
                        Check tempCheck = new Check();
                        tempCheck.ItemToList.Type = Menu[0].Type;
                        tempCheck.ItemToList.Price = Menu[0].Price;
                        for (int j = 0; j < i; j++)
                        {
                            tempCheck.ItemsToCheck.Add(tempCheck.ItemToList);
                        }
                        Checks.Add(tempCheck);
                    }
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(s => s.Type.Contains("Кофе")))
                    {
                        Checks.Last().CafeSum += sum.Price;
                    }
                }
                labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(s => s.Type.Contains("Кофе")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Кофе");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }

            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int.TryParse(textBox2.Text, out int i);
                if (i > 0)
                {
                    if (Checks.Count > 0)
                    {
                        Checks.Last().ItemToList.Type = Menu[1].Type;
                        Checks.Last().ItemToList.Price = Menu[1].Price;
                        for (int j = 0; j < i; j++)
                        {
                            Checks.Last().ItemsToCheck.Add(Checks.Last().ItemToList);
                        }
                    }
                    else
                    {
                        Check tempCheck = new Check();
                        tempCheck.ItemToList.Type = Menu[1].Type;
                        tempCheck.ItemToList.Price = Menu[1].Price;
                        for (int j = 0; j < i; j++)
                        {
                            tempCheck.ItemsToCheck.Add(tempCheck.ItemToList);
                        }
                        Checks.Add(tempCheck);
                    }
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Кока-Кола")))
                    {
                        Checks.Last().CafeSum += sum.Price;
                    }
                }
                labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Кока-Кола")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Кока-Кола");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }

            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                int.TryParse(textBox4.Text, out int i);
                if (i > 0)
                {
                    if (Checks.Count > 0)
                    {
                        Checks.Last().ItemToList.Type = Menu[2].Type;
                        Checks.Last().ItemToList.Price = Menu[2].Price;
                        for (int j = 0; j < i; j++)
                        {
                            Checks.Last().ItemsToCheck.Add(Checks.Last().ItemToList);
                        }
                    }
                    else
                    {
                        Check tempCheck = new Check();
                        tempCheck.ItemToList.Type = Menu[2].Type;
                        tempCheck.ItemToList.Price = Menu[2].Price;
                        for (int j = 0; j < i; j++)
                        {
                            tempCheck.ItemsToCheck.Add(tempCheck.ItemToList);
                        }
                        Checks.Add(tempCheck);
                    }
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Хот-Дог")))
                    {
                        Checks.Last().CafeSum += sum.Price;
                    }
                }
                labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Хот-Дог")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Хот-Дог");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }

            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int.TryParse(textBox3.Text, out int i);
                if (i > 0)
                {
                    if (Checks.Count > 0)
                    {
                        Checks.Last().ItemToList.Type = Menu[3].Type;
                        Checks.Last().ItemToList.Price = Menu[3].Price;
                        for (int j = 0; j < i; j++)
                        {
                            Checks.Last().ItemsToCheck.Add(Checks.Last().ItemToList);
                        }
                    }
                    else
                    {
                        Check tempCheck = new Check();
                        tempCheck.ItemToList.Type = Menu[3].Type;
                        tempCheck.ItemToList.Price = Menu[3].Price;
                        for (int j = 0; j < i; j++)
                        {
                            tempCheck.ItemsToCheck.Add(tempCheck.ItemToList);
                        }
                        Checks.Add(tempCheck);
                    }
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Пончик")))
                    {
                        Checks.Last().CafeSum += sum.Price;
                    }
                }
                labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
            }
            else
            {
                if (Checks.Count > 0)
                {
                    foreach (var sum in Checks.Last().ItemsToCheck.Where(
                        s => s.Type.Contains("Пончик")))
                    {
                        Checks.Last().CafeSum -= sum.Price;
                    }
                    Checks.Last().ItemsToCheck.RemoveAll(s => s.Type == "Пончик");
                    labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
                }

            }
        }
        private void labelCafeAmount_TextChanged(object sender, EventArgs e)
        {
            labelCafeAmount.Text = Checks.Last().CafeSum.ToString("0.00");
        }

        #endregion

        #region -----ToPayPart-----

        private void buttonFinalCount_Click(object sender, EventArgs e)
        {
            double sum = Checks.Last().CafeSum + Checks.Last().FuelSum;
            labelTatoalAmount.Text = sum.ToString("0.00");
            MessageBox.Show($"{Checks.Last().ToString()}");
            ResetForm();
            Checks.Add(new Check());
        }

        #endregion
        
        #region -----StatusStrip-----

        private void изменениеЦветовойГаммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyColorCorrection myColor = new MyColorCorrection();
            myColor.Owner = this;
            myColor.ShowDialog();
            Refresh();
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            деньНеделиToolStripMenuItem.Text = DayOfWeekTranslation.Translation(DateTime.Now);
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripStatusLabelDateTime.RightToLeft == RightToLeft.No)
            {
                toolStripStatusLabelDateTime.Text = DateTime.Now.ToShortDateString();
                toolStripStatusLabelDateTime.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                toolStripStatusLabelDateTime.Text = DateTime.Now.ToShortTimeString();
                toolStripStatusLabelDateTime.RightToLeft = RightToLeft.No;
            }

        }

        #endregion

        #region -----MainMenuStrip------

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
            Checks.Add(new Check());
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fOpen = new OpenFileDialog();
            fOpen.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            fOpen.DefaultExt = ".xml";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");

            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            resources.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name);
            }
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());
            resources.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name);
            }
        }



        #endregion

        #region ------Methods-----

        public void ResetForm()
        {
            comboBoxStation.Text = "";
            textBoxPriceValue.Text = "";
            textBoxFuelVolume.Text = "";
            textBoxAmount.Text = "";
            labelCafeAmount.Text = "";
            labelFuelToPay.Text = "0.00";
            labelTatoalAmount.Text = "0.00";
            radioButtonFuelVolume.Checked = false;
            radioButtonAmount.Checked = false;

            checkBoxCofee.Checked = false;
            checkBoxCocaCola.Checked = false;
            checkBoxHotDog.Checked = false;
            checkBoxDonat.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        #endregion

    }
}
