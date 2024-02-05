namespace Organaizer
{
    partial class Form4
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
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.btnAddE = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmbE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MounthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(30, 244);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(106, 20);
            this.Time.TabIndex = 15;
            // 
            // btnAddE
            // 
            this.btnAddE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddE.Location = new System.Drawing.Point(30, 284);
            this.btnAddE.Name = "btnAddE";
            this.btnAddE.Size = new System.Drawing.Size(480, 55);
            this.btnAddE.TabIndex = 14;
            this.btnAddE.Text = "Добавить";
            this.btnAddE.UseVisualStyleBackColor = true;
            this.btnAddE.Click += new System.EventHandler(this.btnAddE_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(155, 244);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(212, 20);
            this.txtN.TabIndex = 13;
            // 
            // cmbE
            // 
            this.cmbE.FormattingEnabled = true;
            this.cmbE.Location = new System.Drawing.Point(384, 244);
            this.cmbE.Name = "cmbE";
            this.cmbE.Size = new System.Drawing.Size(126, 21);
            this.cmbE.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(381, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Время";
            // 
            // MounthCalendar
            // 
            this.MounthCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.MounthCalendar.Location = new System.Drawing.Point(18, 18);
            this.MounthCalendar.Name = "MounthCalendar";
            this.MounthCalendar.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.btnAddE);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.cmbE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MounthCalendar);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.Button btnAddE;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cmbE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar MounthCalendar;
    }
}