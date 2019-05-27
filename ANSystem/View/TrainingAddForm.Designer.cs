namespace ANSystem.View
{
    partial class TrainingAddForm
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
            this.label = new System.Windows.Forms.Label();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitSystemBox = new System.Windows.Forms.ComboBox();
            this.kindOfSportsBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTrainingBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddTrBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timeTrainingBox = new System.Windows.Forms.DateTimePicker();
            this.durationBox = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.exeptionTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(195, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Новая тренировка";
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(18, 63);
            this.distanceBox.MaxLength = 10;
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(110, 20);
            this.distanceBox.TabIndex = 1;
            this.distanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дистанция*";
            // 
            // UnitSystemBox
            // 
            this.UnitSystemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitSystemBox.FormattingEnabled = true;
            this.UnitSystemBox.Items.AddRange(new object[] {
            "км",
            "м"});
            this.UnitSystemBox.Location = new System.Drawing.Point(134, 62);
            this.UnitSystemBox.Name = "UnitSystemBox";
            this.UnitSystemBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnitSystemBox.Size = new System.Drawing.Size(56, 21);
            this.UnitSystemBox.TabIndex = 3;
            this.UnitSystemBox.SelectedIndexChanged += new System.EventHandler(this.UnitSystemBox_SelectedIndexChanged);
            // 
            // kindOfSportsBox
            // 
            this.kindOfSportsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kindOfSportsBox.FormattingEnabled = true;
            this.kindOfSportsBox.Items.AddRange(new object[] {
            "Бег",
            "Лыжи",
            "Велосипед"});
            this.kindOfSportsBox.Location = new System.Drawing.Point(18, 119);
            this.kindOfSportsBox.Name = "kindOfSportsBox";
            this.kindOfSportsBox.Size = new System.Drawing.Size(172, 21);
            this.kindOfSportsBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Вид тренировки";
            // 
            // dateTrainingBox
            // 
            this.dateTrainingBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTrainingBox.Location = new System.Drawing.Point(220, 119);
            this.dateTrainingBox.Name = "dateTrainingBox";
            this.dateTrainingBox.Size = new System.Drawing.Size(102, 20);
            this.dateTrainingBox.TabIndex = 9;
            this.dateTrainingBox.ValueChanged += new System.EventHandler(this.dateTimeTrBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Время";
            // 
            // nameTr
            // 
            this.nameTr.Location = new System.Drawing.Point(18, 175);
            this.nameTr.MaxLength = 30;
            this.nameTr.Name = "nameTr";
            this.nameTr.Size = new System.Drawing.Size(172, 20);
            this.nameTr.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Название*";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(18, 235);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(370, 86);
            this.descriptionBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Описание";
            // 
            // AddTrBtn
            // 
            this.AddTrBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddTrBtn.Location = new System.Drawing.Point(313, 327);
            this.AddTrBtn.Name = "AddTrBtn";
            this.AddTrBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrBtn.TabIndex = 17;
            this.AddTrBtn.Text = "Добавить";
            this.AddTrBtn.UseVisualStyleBackColor = true;
            this.AddTrBtn.Click += new System.EventHandler(this.AddTrBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timeTrainingBox
            // 
            this.timeTrainingBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeTrainingBox.CustomFormat = "HH:mm";
            this.timeTrainingBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTrainingBox.Location = new System.Drawing.Point(328, 119);
            this.timeTrainingBox.Name = "timeTrainingBox";
            this.timeTrainingBox.ShowUpDown = true;
            this.timeTrainingBox.Size = new System.Drawing.Size(60, 20);
            this.timeTrainingBox.TabIndex = 19;
            this.timeTrainingBox.Value = new System.DateTime(2019, 5, 4, 16, 55, 0, 0);
            // 
            // durationBox
            // 
            this.durationBox.CustomFormat = "HH:mm:ss";
            this.durationBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.durationBox.Location = new System.Drawing.Point(220, 62);
            this.durationBox.Name = "durationBox";
            this.durationBox.ShowUpDown = true;
            this.durationBox.Size = new System.Drawing.Size(111, 20);
            this.durationBox.TabIndex = 20;
            this.durationBox.Value = new System.DateTime(2019, 5, 27, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Продолжительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Место";
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(220, 175);
            this.placeBox.MaxLength = 30;
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(168, 20);
            this.placeBox.TabIndex = 23;
            // 
            // exeptionTxt
            // 
            this.exeptionTxt.AutoSize = true;
            this.exeptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exeptionTxt.ForeColor = System.Drawing.Color.Red;
            this.exeptionTxt.Location = new System.Drawing.Point(15, 332);
            this.exeptionTxt.Name = "exeptionTxt";
            this.exeptionTxt.Size = new System.Drawing.Size(0, 16);
            this.exeptionTxt.TabIndex = 16;
            // 
            // TrainingAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 355);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.timeTrainingBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddTrBtn);
            this.Controls.Add(this.exeptionTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nameTr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTrainingBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kindOfSportsBox);
            this.Controls.Add(this.UnitSystemBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrainingAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TrainingAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitSystemBox;
        private System.Windows.Forms.ComboBox kindOfSportsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTrainingBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddTrBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker timeTrainingBox;
        private System.Windows.Forms.DateTimePicker durationBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.Label exeptionTxt;
    }
}