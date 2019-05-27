namespace ANSystem.View
{
    partial class TrainingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TrListBox = new System.Windows.Forms.ListBox();
            this.AddTrBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.distanceTxt = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.Label();
            this.dateAndTimeTxt = new System.Windows.Forms.Label();
            this.placeTxt = new System.Windows.Forms.Label();
            this.lableDescr = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.kindOfSportsTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренировки";
            // 
            // TrListBox
            // 
            this.TrListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrListBox.FormattingEnabled = true;
            this.TrListBox.ItemHeight = 20;
            this.TrListBox.Location = new System.Drawing.Point(12, 94);
            this.TrListBox.Name = "TrListBox";
            this.TrListBox.Size = new System.Drawing.Size(361, 204);
            this.TrListBox.TabIndex = 1;
            this.TrListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrListBox_MouseClick);
            this.TrListBox.SelectedIndexChanged += new System.EventHandler(this.TrListBox_SelectedIndexChanged);
            // 
            // AddTrBtn
            // 
            this.AddTrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddTrBtn.Location = new System.Drawing.Point(298, 312);
            this.AddTrBtn.Name = "AddTrBtn";
            this.AddTrBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrBtn.TabIndex = 2;
            this.AddTrBtn.Text = "Добавить";
            this.AddTrBtn.UseVisualStyleBackColor = true;
            this.AddTrBtn.Click += new System.EventHandler(this.AddTrBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editBtn.Location = new System.Drawing.Point(217, 312);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delBtn.Location = new System.Drawing.Point(136, 312);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(379, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Подробнее";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.Location = new System.Drawing.Point(381, 94);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(60, 13);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "Название:";
            // 
            // distanceTxt
            // 
            this.distanceTxt.AutoSize = true;
            this.distanceTxt.ForeColor = System.Drawing.Color.Black;
            this.distanceTxt.Location = new System.Drawing.Point(381, 128);
            this.distanceTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.distanceTxt.Name = "distanceTxt";
            this.distanceTxt.Size = new System.Drawing.Size(66, 13);
            this.distanceTxt.TabIndex = 5;
            this.distanceTxt.Text = "Дистанция:";
            // 
            // durationTxt
            // 
            this.durationTxt.AutoSize = true;
            this.durationTxt.ForeColor = System.Drawing.Color.Black;
            this.durationTxt.Location = new System.Drawing.Point(381, 145);
            this.durationTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(114, 13);
            this.durationTxt.TabIndex = 5;
            this.durationTxt.Text = "Продолжительность:";
            // 
            // dateAndTimeTxt
            // 
            this.dateAndTimeTxt.AutoSize = true;
            this.dateAndTimeTxt.ForeColor = System.Drawing.Color.Black;
            this.dateAndTimeTxt.Location = new System.Drawing.Point(381, 162);
            this.dateAndTimeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.dateAndTimeTxt.Name = "dateAndTimeTxt";
            this.dateAndTimeTxt.Size = new System.Drawing.Size(118, 13);
            this.dateAndTimeTxt.TabIndex = 5;
            this.dateAndTimeTxt.Text = "Дата и время начала:";
            // 
            // placeTxt
            // 
            this.placeTxt.AutoSize = true;
            this.placeTxt.ForeColor = System.Drawing.Color.Black;
            this.placeTxt.Location = new System.Drawing.Point(381, 179);
            this.placeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.placeTxt.Name = "placeTxt";
            this.placeTxt.Size = new System.Drawing.Size(42, 13);
            this.placeTxt.TabIndex = 5;
            this.placeTxt.Text = "Место:";
            // 
            // lableDescr
            // 
            this.lableDescr.AutoSize = true;
            this.lableDescr.ForeColor = System.Drawing.Color.Black;
            this.lableDescr.Location = new System.Drawing.Point(381, 196);
            this.lableDescr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lableDescr.Name = "lableDescr";
            this.lableDescr.Size = new System.Drawing.Size(60, 13);
            this.lableDescr.TabIndex = 5;
            this.lableDescr.Text = "Описание:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Enabled = false;
            this.descriptionTxt.Location = new System.Drawing.Point(384, 213);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(225, 77);
            this.descriptionTxt.TabIndex = 6;
            // 
            // kindOfSportsTxt
            // 
            this.kindOfSportsTxt.AutoSize = true;
            this.kindOfSportsTxt.ForeColor = System.Drawing.Color.Black;
            this.kindOfSportsTxt.Location = new System.Drawing.Point(381, 111);
            this.kindOfSportsTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.kindOfSportsTxt.Name = "kindOfSportsTxt";
            this.kindOfSportsTxt.Size = new System.Drawing.Size(91, 13);
            this.kindOfSportsTxt.TabIndex = 7;
            this.kindOfSportsTxt.Text = "Вид тренировки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Спортсмен";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userName.Location = new System.Drawing.Point(131, 24);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 25);
            this.userName.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem,
            this.импортToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.WordToolStripMenuItem_Click);
            // 
            // TrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 347);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kindOfSportsTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.lableDescr);
            this.Controls.Add(this.placeTxt);
            this.Controls.Add(this.dateAndTimeTxt);
            this.Controls.Add(this.durationTxt);
            this.Controls.Add(this.distanceTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.AddTrBtn);
            this.Controls.Add(this.TrListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrainingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrainingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingsForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TrListBox;
        private System.Windows.Forms.Button AddTrBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label distanceTxt;
        private System.Windows.Forms.Label durationTxt;
        private System.Windows.Forms.Label dateAndTimeTxt;
        private System.Windows.Forms.Label placeTxt;
        private System.Windows.Forms.Label lableDescr;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label kindOfSportsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
    }
}