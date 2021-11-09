
namespace HomeTask_1
{
    partial class Task_6
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_6));
            this.viewBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.taskNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(95, 277);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(340, 30);
            this.viewBtn.TabIndex = 0;
            this.viewBtn.Text = "Просмотреть решение";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(503, 200);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(95, 312);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(340, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Выход";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // taskNumLbl
            // 
            this.taskNumLbl.AutoSize = true;
            this.taskNumLbl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.taskNumLbl.Location = new System.Drawing.Point(12, 20);
            this.taskNumLbl.Name = "taskNumLbl";
            this.taskNumLbl.Size = new System.Drawing.Size(112, 21);
            this.taskNumLbl.TabIndex = 3;
            this.taskNumLbl.Text = "Задание 6 - 7";
            // 
            // Task_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 353);
            this.Controls.Add(this.taskNumLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.viewBtn);
            this.Name = "Task_6";
            this.Text = "День недели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label taskNumLbl;
    }
}