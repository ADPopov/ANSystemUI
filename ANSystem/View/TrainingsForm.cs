using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Helpers;
using ANSystem.Model;
using Microsoft.Office.Interop.Word;

namespace ANSystem.View
{
    public partial class TrainingsForm : Form
    {
        public List<Training> TrainigsList;
        public List<Sportsman> SportsmanList;
        public string UserName;
        public bool FileIsVisible = false;

        public TrainingsForm()
        {
            InitializeComponent();
            if (TrainigsList != null)
            {
                InfoChange(TrainigsList[0]);
            }

        }

        private void AddTrBtn_Click(object sender, EventArgs e)
        {
            var tr = new TrainingAddForm() { Training = new Training() {Date = DateTime.Now, Time = DateTime.Now, Duration = DateTime.Now} };
            if (tr.ShowDialog(this) == DialogResult.OK)
            {
                TrainigsList.Add(tr.Training);
                TrListBox.DataSource = null;
                TrListBox.DataSource = TrainigsList;
                if (TrainigsList.Count != 0)
                {
                    InfoChange(TrainigsList[0]);
                }
            }
        }

        private void TrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBtn.Enabled = TrListBox.SelectedItem is Training;
            editBtn.Enabled = TrListBox.SelectedItem is Training;
            TrListBox.DataSource = null;
            TrListBox.DataSource = TrainigsList;
        }

        private void TrainingsForm_Load(object sender, EventArgs e)
        {
            if (FileIsVisible)
            {
                FileToolStripMenuItem.Visible = false;
            }
            userName.Text = UserName;
            TrListBox.DataSource = null;
            TrListBox.DataSource = TrainigsList;
        }




        private void TrListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = TrListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Training)TrListBox.Items[index];
                InfoChange(item);
            }
        }

        private void InfoChange(Training item)
        {
            if (item == null)
            {
                nameTxt.Text = "Название: ";
                distanceTxt.Text = "Дистанция: ";
                durationTxt.Text = "Продолжительность:";
                dateAndTimeTxt.Text = "Дата и время начала: ";
                descriptionTxt.Text = "";
                placeTxt.Text = "Место: ";
                kindOfSportsTxt.Text = "Вид тренировки: ";
            }
            else
            {
                nameTxt.Text = "Название: " + item.NameTraining;
                distanceTxt.Text = "Дистанция: " + item.Distance;
                durationTxt.Text = "Продолжительность:" + item.Duration.ToLongTimeString();
                dateAndTimeTxt.Text = "Дата и время начала: " + item.Date.ToLongDateString() + " " + item.Time.ToLongTimeString();
                descriptionTxt.Text = item.Description;
                placeTxt.Text = "Место: " + item.Place;
                kindOfSportsTxt.Text = "Вид тренировки: " + item.KindOfSports;
            }
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (TrListBox.SelectedItem is Training)
            {
                TrainigsList.Remove((Training)TrListBox.SelectedItem);
                TrListBox.DataSource = null;
                TrListBox.DataSource = TrainigsList;
            }
            InfoChange((Training)TrListBox.SelectedItem);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var index = TrListBox.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var item = (Training)TrListBox.Items[index];
                var ff = new TrainingAddForm() { Training = item, Label = "Редактирование", Button = "Изменить" };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    TrainigsList.Remove(item);
                    TrainigsList.Insert(index, item);
                    TrListBox.DataSource = null;
                    TrListBox.DataSource = TrainigsList;
                    InfoChange(item);
                }
            }
        }

        private void TrainingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialization.Save(SportsmanList);
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aut = new AuthorizationForm();
            Close();
            aut.Show();
        }

        public void SaveToWord()
        {
            var wdApp = new Microsoft.Office.Interop.Word.Application();
            wdApp.Visible = true;

            wdApp.Documents.Add();

            var docum = wdApp.Documents.get_Item(1);
            var wdRng= docum.Content;
            docum.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
            var range = docum.Range(0, 0);
            var tables = docum.Tables.Add(range, TrainigsList.Count+1, 6);
            tables.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
            tables.Borders.InsideLineStyle = WdLineStyle.wdLineStyleDouble;
            wdRng.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            tables.Cell(1, 1).Range.Text = "Название";
            tables.Cell(1, 2).Range.Text = "Дистанция (км)";
            tables.Cell(1, 3).Range.Text = "Продолжительность";
            tables.Cell(1, 4).Range.Text = "Дата и время начала";
            tables.Cell(1, 5).Range.Text = "Место";
            tables.Cell(1, 6).Range.Text = "Вид тренировки";

            for (int k = 1; k < 7; k++)
            {
                tables.Cell(1, k).Shading.BackgroundPatternColorIndex = WdColorIndex.wdGray25;
                tables.Cell(1, k).Row.Alignment = WdRowAlignment.wdAlignRowCenter;
            }
             
            for (int i = 2, j = 0; j < TrainigsList.Count; i++, j++)
            {
                tables.Cell(i, 1).Range.Text = TrainigsList[j].NameTraining;
                tables.Cell(i, 1).Range.Font.Size = 12;
                tables.Cell(i, 2).Range.Text = TrainigsList[j].Distance.ToString();
                tables.Cell(i, 3).Range.Text = TrainigsList[j].Duration.ToLongTimeString();
                tables.Cell(i, 4).Range.Text = TrainigsList[j].Date.ToLongDateString();
                tables.Cell(i, 5).Range.Text = TrainigsList[j].Place;
                tables.Cell(i, 6).Range.Text = TrainigsList[j].KindOfSports;
            }
        }

        private void WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToWord();
        }
    }
}
