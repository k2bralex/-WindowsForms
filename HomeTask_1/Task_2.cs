using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;

namespace HomeTask_1
{
    public partial class Task_2 : Form
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            do
            {
                MessageBox.Show("Загадайте число от 1 до 2000!");
                int minValue = 1, maxValue = 2000, purposeValue = (minValue + maxValue) / 2;
                bool isGetAnswer = false;
                int countSteps = 0;
                do
                {
                    countSteps++;
                    result = MessageBox.Show($"Загаданое число меньше или равно {purposeValue}?", 
                        $"Шаг {countSteps}",
                        MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.No:
                            minValue = purposeValue + 1;

                            break;
                        case DialogResult.Yes:
                            maxValue = purposeValue;
                            break;
                    }
                    purposeValue = (minValue + maxValue) / 2;
                    if (minValue == maxValue)
                    {
                        result = MessageBox.Show($"Вы загадали число {purposeValue}\n" +
                                                 $"Отгадано с {countSteps} попыток\n\n" +
                                                 $"Хотите попробовать еще раз?", "Ответ",
                            MessageBoxButtons.RetryCancel);
                        isGetAnswer = true;
                    }
                } while (!isGetAnswer);
                
            } while (result==DialogResult.Retry);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
