namespace PractikSW
{
    partial class CRMForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.lsBox = new System.Windows.Forms.TextBox();
            this.opendateTime = new System.Windows.Forms.ComboBox();
            this.uslBox = new System.Windows.Forms.ComboBox();
            this.problemBox = new System.Windows.Forms.ComboBox();
            this.closeTimePicker = new System.Windows.Forms.ComboBox();
            this.problemMoreBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(506, 126);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(8, 18);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(68, 20);
            this.idBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата открытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин абонента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Лицевой счет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Услуга";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Тип проблемы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата закрытия";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(179, 18);
            this.loginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(68, 20);
            this.loginBox.TabIndex = 10;
            // 
            // lsBox
            // 
            this.lsBox.Location = new System.Drawing.Point(267, 18);
            this.lsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsBox.Name = "lsBox";
            this.lsBox.Size = new System.Drawing.Size(68, 20);
            this.lsBox.TabIndex = 11;
            // 
            // opendateTime
            // 
            this.opendateTime.FormattingEnabled = true;
            this.opendateTime.Items.AddRange(new object[] {
            "2024-01-27"});
            this.opendateTime.Location = new System.Drawing.Point(79, 16);
            this.opendateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opendateTime.Name = "opendateTime";
            this.opendateTime.Size = new System.Drawing.Size(82, 21);
            this.opendateTime.TabIndex = 12;
            // 
            // uslBox
            // 
            this.uslBox.FormattingEnabled = true;
            this.uslBox.Items.AddRange(new object[] {
            "Интернет",
            "Связь",
            "Телевиденье",
            "Видеонаблюдение"});
            this.uslBox.Location = new System.Drawing.Point(8, 68);
            this.uslBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uslBox.Name = "uslBox";
            this.uslBox.Size = new System.Drawing.Size(82, 21);
            this.uslBox.TabIndex = 13;
            // 
            // problemBox
            // 
            this.problemBox.FormattingEnabled = true;
            this.problemBox.Items.AddRange(new object[] {
            "Консультация",
            "Тех. обслуживание"});
            this.problemBox.Location = new System.Drawing.Point(105, 68);
            this.problemBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(82, 21);
            this.problemBox.TabIndex = 14;
            // 
            // closeTimePicker
            // 
            this.closeTimePicker.FormattingEnabled = true;
            this.closeTimePicker.Items.AddRange(new object[] {
            "2024-01-27"});
            this.closeTimePicker.Location = new System.Drawing.Point(197, 68);
            this.closeTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeTimePicker.Name = "closeTimePicker";
            this.closeTimePicker.Size = new System.Drawing.Size(82, 21);
            this.closeTimePicker.TabIndex = 15;
            // 
            // problemMoreBox
            // 
            this.problemMoreBox.Location = new System.Drawing.Point(305, 68);
            this.problemMoreBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.problemMoreBox.Name = "problemMoreBox";
            this.problemMoreBox.Size = new System.Drawing.Size(211, 20);
            this.problemMoreBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Описание проблемы";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(305, 103);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(65, 23);
            this.Addbutton.TabIndex = 18;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click_1);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(385, 103);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(74, 23);
            this.save.TabIndex = 19;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(451, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "CRM";
            // 
            // CRMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.problemMoreBox);
            this.Controls.Add(this.closeTimePicker);
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.uslBox);
            this.Controls.Add(this.opendateTime);
            this.Controls.Add(this.lsBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CRMForm";
            this.Text = "CRMForm";
            this.Load += new System.EventHandler(this.CRMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox lsBox;
        private System.Windows.Forms.ComboBox opendateTime;
        private System.Windows.Forms.ComboBox uslBox;
        private System.Windows.Forms.ComboBox problemBox;
        private System.Windows.Forms.ComboBox closeTimePicker;
        private System.Windows.Forms.TextBox problemMoreBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label9;
    }
}