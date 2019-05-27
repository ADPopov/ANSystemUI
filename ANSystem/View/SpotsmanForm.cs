using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using ANSystem.Data;
using ANSystem.Model;
using ANSystem.Helpers;



namespace ANSystem.View
{
    public partial class SpotsmanForm : Form
    {
        public List<Sportsman> SportsmanList;
        
        private bool IsClosed = true;

        public SpotsmanForm()
        {
            InitializeComponent();
            var fd = new FakeData();
            SportsmanList = fd.SportsmanFakeList;
            dataListBox.DataSource = null;
            dataListBox.DataSource = SportsmanList;
            if (SportsmanList != null)
            {
                InfoChange(SportsmanList[0]);
            }
            dataListBox.SelectedIndexChanged += DataListBox_SelectedIndexChanged;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var sa = new SpotsmanAddForm() {Sportsman = new Sportsman() {DateOfBirth = DateTime.Now, }, Label = "Новый спортсмен", Im = Properties.Resources.camera_200 };
            if (sa.ShowDialog(this) == DialogResult.OK)
            {
                SportsmanList.Add(sa.Sportsman);
                dataListBox.DataSource = null;
                dataListBox.DataSource = SportsmanList;
                if (SportsmanList.Count != 0)
                {
                    InfoChange(SportsmanList[0]);
                }
            }
        }

        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBtn.Enabled = dataListBox.SelectedItem is Sportsman;
            editBtn.Enabled = dataListBox.SelectedItem is Sportsman;
        }

        private void DataListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                if (item.Trainings == null)
                {
                    item.Trainings = new List<Training>();
                }
                var tr = new TrainingsForm()
                {
                    TrainigsList = item.Trainings,
                    UserName = item.FirstName + " " + item.LastName,
                    SportsmanList = SportsmanList,
                    FileIsVisible = true
                };
                tr.ShowDialog();
            }
        }

        private void DataListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                InfoChange(item);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int index = dataListBox.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                var ms = new MemoryStream(item.Photo);
                var ff = new SpotsmanAddForm()
                {
                    Sportsman = item,
                    Im = Image.FromStream(ms),
                    Label = "Редактирование",
                    BtnTxt = "Изменить",
                    delPass = true
                };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    SportsmanList.Remove(item);
                    SportsmanList.Insert(index, item);
                    dataListBox.DataSource = null;
                    dataListBox.DataSource = SportsmanList;
                    InfoChange(item);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataListBox.SelectedItem is Sportsman)
            {
                SportsmanList.Remove((Sportsman)dataListBox.SelectedItem);
                dataListBox.DataSource = null;
                dataListBox.DataSource = SportsmanList;
            }
            InfoChange((Sportsman)dataListBox.SelectedItem);
        }
       
        private void SpotsmanForm_Load(object sender, EventArgs e)
        {
           
            SportsmanList = Serialization.Download(SportsmanList);
            dataListBox.DataSource = null;
            dataListBox.DataSource = SportsmanList;
        }

        private void InfoChange(Sportsman item)
        {
            if (item == null) 
            {
                FirstNameTxt.Text = "Фамилия: ";
                LastNameTxt.Text = "Имя: ";
                DateOfBirthTxt.Text = "Дата рождения: ";
                SportCategoryTxt.Text = "Спортивный разряд: ";
                pictureBox.Image = null;
            }
            else
            {
                FirstNameTxt.Text = "Фамилия: " + item.FirstName;
                LastNameTxt.Text = "Имя: " + item.LastName;
                DateOfBirthTxt.Text = "Дата рождения: " + item.DateOfBirth.ToLongDateString();
                SportCategoryTxt.Text = "Спортивный разряд: " + item.SportsCategory;
                pictureBox.Image = ImageChange.ByteToImage(item.Photo);
            }
        }

        private void SpotsmanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClosed)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Serialization.Save(SportsmanList);
                    e.Cancel = true;
                    IsClosed = false;
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Разработчик: Попов Александр. 2019 год", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aut = new AuthorizationForm();
            Close();
            aut.Show();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
