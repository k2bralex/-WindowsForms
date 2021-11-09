
namespace HomeTask_1
{
    partial class MyColorCorrection
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
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.labelFormName = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(89, 72);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(288, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBarRed_ValueChanged);
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFormName.Location = new System.Drawing.Point(62, 37);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(229, 21);
            this.labelFormName.TabIndex = 1;
            this.labelFormName.Text = "Измененение цвета формы";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(89, 123);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(288, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBarGreen_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(89, 174);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(288, 45);
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBarBlue_ValueChanged);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRed.Location = new System.Drawing.Point(27, 72);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(56, 15);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "Красный";
            this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGreen.Location = new System.Drawing.Point(27, 123);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(56, 15);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Зеленый";
            this.labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelBlue.Location = new System.Drawing.Point(40, 174);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(43, 15);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "Синий";
            this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyColorCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 239);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.trackBarRed);
            this.Name = "MyColorCorrection";
            this.Text = "Изменение цветовой гаммы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyColorCorrection_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
    }
}