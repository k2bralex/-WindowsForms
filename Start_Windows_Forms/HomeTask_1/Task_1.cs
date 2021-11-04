using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeTask_1
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string resumeText = "";
            string boxStage = "";
            int charCount = 0;
            for (int i = 1; i <= 3; i++)
            {
                charCount += resumeText.Length;
                switch (i)
                {
                    case 1:
                        resumeText = "ФИО: Иванов Иван Иванович\n" +
                                     "Дата рождения: 10/10/1984\n" +
                                     "Город проживания: Николаев\n" +
                                     "Пол: Мужской\n" +
                                     "Семейное положение: Женат\n\n" +
                                     "Хотите продолжить?";
                        break;
                    case 2:
                        resumeText = "Образование: Высшее\n" +
                                     "Учебное заведение: НКИ\n" +
                                     "Факультет: Электротехнически\n" +
                                     "Специальность: Инженер-Электротехник\n" +
                                     "Форма обучения: Очная\n\n" +
                                     "Хотите продолжить?";
                        break;
                    case 3:
                        resumeText = "Опыт работы: ООО АВС\n" +
                                     "Должность: Монтажник-Бездельник\n" +
                                     "             ООО НГЗ\n" +
                                     "Должность: Начальник-Карманы-Набиватель\n" +
                                     "Водительские права: А, В\n" +
                                     "Языки: английский со словарем\n\n" +
                                     "Хотите продолжить?";
                        boxStage = $"/ Символов в резюме: {charCount += resumeText.Length}";

                        break;
                }
                result = MessageBox.Show(resumeText, $"Страница: {i} {boxStage}",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.No) Close();
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
