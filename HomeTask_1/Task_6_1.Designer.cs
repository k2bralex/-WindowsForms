
namespace HomeTask_1
{
    partial class Task_6_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntro = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOutro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBoxTimeLeft = new System.Windows.Forms.TextBox();
            this.lblTimeLeftToDate = new System.Windows.Forms.Label();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.radioButtonMinute = new System.Windows.Forms.RadioButton();
            this.radioButtonSecond = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(26, 19);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(76, 15);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "Введите дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblOutro
            // 
            this.lblOutro.AutoSize = true;
            this.lblOutro.Location = new System.Drawing.Point(26, 76);
            this.lblOutro.Name = "lblOutro";
            this.lblOutro.Size = new System.Drawing.Size(79, 15);
            this.lblOutro.TabIndex = 3;
            this.lblOutro.Text = "День недели:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 4;
            // 
            // tBoxTimeLeft
            // 
            this.tBoxTimeLeft.Location = new System.Drawing.Point(26, 153);
            this.tBoxTimeLeft.Name = "tBoxTimeLeft";
            this.tBoxTimeLeft.Size = new System.Drawing.Size(232, 23);
            this.tBoxTimeLeft.TabIndex = 6;
            // 
            // lblTimeLeftToDate
            // 
            this.lblTimeLeftToDate.AutoSize = true;
            this.lblTimeLeftToDate.Location = new System.Drawing.Point(26, 134);
            this.lblTimeLeftToDate.Name = "lblTimeLeftToDate";
            this.lblTimeLeftToDate.Size = new System.Drawing.Size(120, 15);
            this.lblTimeLeftToDate.TabIndex = 5;
            this.lblTimeLeftToDate.Text = "До выбранной даты:";
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Location = new System.Drawing.Point(3, 13);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(56, 19);
            this.radioButtonYear.TabIndex = 7;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Годах";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButtonYear_CheckedChanged);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(77, 13);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(73, 19);
            this.radioButtonMonth.TabIndex = 8;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Месяцах";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            this.radioButtonMonth.CheckedChanged += new System.EventHandler(this.radioButtonMonth_CheckedChanged);
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(156, 13);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(52, 19);
            this.radioButtonDay.TabIndex = 9;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Днях";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            this.radioButtonDay.CheckedChanged += new System.EventHandler(this.radioButtonDay_CheckedChanged);
            // 
            // radioButtonHour
            // 
            this.radioButtonHour.AutoSize = true;
            this.radioButtonHour.Location = new System.Drawing.Point(3, 38);
            this.radioButtonHour.Name = "radioButtonHour";
            this.radioButtonHour.Size = new System.Drawing.Size(57, 19);
            this.radioButtonHour.TabIndex = 10;
            this.radioButtonHour.TabStop = true;
            this.radioButtonHour.Text = "Часах";
            this.radioButtonHour.UseVisualStyleBackColor = true;
            this.radioButtonHour.CheckedChanged += new System.EventHandler(this.radioButtonHour_CheckedChanged);
            // 
            // radioButtonMinute
            // 
            this.radioButtonMinute.AutoSize = true;
            this.radioButtonMinute.Location = new System.Drawing.Point(77, 38);
            this.radioButtonMinute.Name = "radioButtonMinute";
            this.radioButtonMinute.Size = new System.Drawing.Size(73, 19);
            this.radioButtonMinute.TabIndex = 11;
            this.radioButtonMinute.TabStop = true;
            this.radioButtonMinute.Text = "Минутах";
            this.radioButtonMinute.UseVisualStyleBackColor = true;
            this.radioButtonMinute.CheckedChanged += new System.EventHandler(this.radioButtonMinute_CheckedChanged);
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(156, 38);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(76, 19);
            this.radioButtonSecond.TabIndex = 12;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "Секундах";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            this.radioButtonSecond.CheckedChanged += new System.EventHandler(this.radioButtonSecond_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonYear);
            this.panel1.Controls.Add(this.radioButtonHour);
            this.panel1.Controls.Add(this.radioButtonMinute);
            this.panel1.Controls.Add(this.radioButtonSecond);
            this.panel1.Controls.Add(this.radioButtonMonth);
            this.panel1.Controls.Add(this.radioButtonDay);
            this.panel1.Location = new System.Drawing.Point(26, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 70);
            this.panel1.TabIndex = 13;
            this.panel1.Tag = "";
            // 
            // Task_6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBoxTimeLeft);
            this.Controls.Add(this.lblTimeLeftToDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOutro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIntro);
            this.Name = "Task_6_1";
            this.Text = "День недели";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOutro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tBoxTimeLeft;
        private System.Windows.Forms.Label lblTimeLeftToDate;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.RadioButton radioButtonMinute;
        private System.Windows.Forms.RadioButton radioButtonSecond;
        private System.Windows.Forms.Panel panel1;
    }
}