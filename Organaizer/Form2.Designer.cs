﻿namespace Organaizer
{
    partial class Form2
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
            this.groupV = new System.Windows.Forms.GroupBox();
            this.cmbM = new System.Windows.Forms.ComboBox();
            this.groupO = new System.Windows.Forms.GroupBox();
            this.btnFil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.EventsBox = new System.Windows.Forms.DataGridView();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupV.SuspendLayout();
            this.groupO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupV
            // 
            this.groupV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupV.Controls.Add(this.rb2);
            this.groupV.Controls.Add(this.rb1);
            this.groupV.Controls.Add(this.cmbM);
            this.groupV.Location = new System.Drawing.Point(0, 0);
            this.groupV.Name = "groupV";
            this.groupV.Size = new System.Drawing.Size(400, 100);
            this.groupV.TabIndex = 0;
            this.groupV.TabStop = false;
            this.groupV.Text = "Вид";
            // 
            // cmbM
            // 
            this.cmbM.FormattingEnabled = true;
            this.cmbM.Location = new System.Drawing.Point(201, 29);
            this.cmbM.Name = "cmbM";
            this.cmbM.Size = new System.Drawing.Size(154, 21);
            this.cmbM.TabIndex = 5;
            // 
            // groupO
            // 
            this.groupO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupO.Controls.Add(this.btnFil);
            this.groupO.Controls.Add(this.btnAdd);
            this.groupO.Controls.Add(this.btnFin);
            this.groupO.Location = new System.Drawing.Point(0, 412);
            this.groupO.Name = "groupO";
            this.groupO.Size = new System.Drawing.Size(400, 100);
            this.groupO.TabIndex = 0;
            this.groupO.TabStop = false;
            this.groupO.Text = "Операции";
            // 
            // btnFil
            // 
            this.btnFil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFil.Location = new System.Drawing.Point(7, 19);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(125, 60);
            this.btnFil.TabIndex = 0;
            this.btnFil.Text = "Фильтр";
            this.btnFil.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(269, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 60);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFin.Location = new System.Drawing.Point(138, 19);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(125, 60);
            this.btnFin.TabIndex = 1;
            this.btnFin.Text = "Поиск";
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // EventsBox
            // 
            this.EventsBox.AllowUserToOrderColumns = true;
            this.EventsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O,
            this.Дата,
            this.Время,
            this.Event});
            this.EventsBox.Location = new System.Drawing.Point(0, 106);
            this.EventsBox.Name = "EventsBox";
            this.EventsBox.Size = new System.Drawing.Size(400, 300);
            this.EventsBox.TabIndex = 6;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(12, 29);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(122, 17);
            this.rb1.TabIndex = 6;
            this.rb1.TabStop = true;
            this.rb1.Text = "Все по категориям";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(12, 63);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(90, 17);
            this.rb2.TabIndex = 7;
            this.rb2.TabStop = true;
            this.rb2.Text = "Все события";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // O
            // 
            this.O.HeaderText = "O";
            this.O.Name = "O";
            this.O.Width = 30;
            // 
            // Дата
            // 
            this.Дата.FillWeight = 15.19081F;
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.Width = 109;
            // 
            // Время
            // 
            this.Время.FillWeight = 223.4776F;
            this.Время.HeaderText = "Время";
            this.Время.Name = "Время";
            this.Время.Width = 109;
            // 
            // Event
            // 
            this.Event.HeaderText = "События";
            this.Event.Name = "Event";
            this.Event.Width = 109;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 516);
            this.Controls.Add(this.groupO);
            this.Controls.Add(this.EventsBox);
            this.Controls.Add(this.groupV);
            this.Name = "Form2";
            this.Text = "Органайзер";
            this.groupV.ResumeLayout(false);
            this.groupV.PerformLayout();
            this.groupO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupV;
        private System.Windows.Forms.GroupBox groupO;
        private System.Windows.Forms.DataGridView EventsBox;
        private System.Windows.Forms.ComboBox cmbM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn O;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
    }
}