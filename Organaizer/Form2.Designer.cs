namespace Organaizer
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
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkE = new System.Windows.Forms.CheckBox();
            this.groupO = new System.Windows.Forms.GroupBox();
            this.btnFil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupV.SuspendLayout();
            this.groupO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupV
            // 
            this.groupV.Controls.Add(this.cmbM);
            this.groupV.Controls.Add(this.checkC);
            this.groupV.Controls.Add(this.checkE);
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
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(17, 29);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(123, 17);
            this.checkC.TabIndex = 3;
            this.checkC.Text = "Всё по категориям";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // checkE
            // 
            this.checkE.AutoSize = true;
            this.checkE.Location = new System.Drawing.Point(17, 62);
            this.checkE.Name = "checkE";
            this.checkE.Size = new System.Drawing.Size(91, 17);
            this.checkE.TabIndex = 4;
            this.checkE.Text = "Все события";
            this.checkE.UseVisualStyleBackColor = true;
            // 
            // groupO
            // 
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
            this.btnFil.Location = new System.Drawing.Point(7, 19);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(125, 60);
            this.btnFil.TabIndex = 0;
            this.btnFil.Text = "Фильтр";
            this.btnFil.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 60);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(138, 19);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(125, 60);
            this.btnFin.TabIndex = 1;
            this.btnFin.Text = "Поиск";
            this.btnFin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Дата,
            this.Время,
            this.Event});
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // Дата
            // 
            this.Дата.FillWeight = 15.19081F;
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.Width = 119;
            // 
            // Время
            // 
            this.Время.FillWeight = 223.4776F;
            this.Время.HeaderText = "Время";
            this.Время.Name = "Время";
            this.Время.Width = 119;
            // 
            // Event
            // 
            this.Event.HeaderText = "События";
            this.Event.Name = "Event";
            this.Event.Width = 119;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 516);
            this.Controls.Add(this.groupO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupV);
            this.Name = "Form2";
            this.Text = "Органайзер";
            this.groupV.ResumeLayout(false);
            this.groupV.PerformLayout();
            this.groupO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupV;
        private System.Windows.Forms.GroupBox groupO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbM;
        private System.Windows.Forms.CheckBox checkE;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
    }
}