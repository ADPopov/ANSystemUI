using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Helpers;
using ANSystem.Model;

namespace ANSystem.View
{
    public partial class SpotsmanAddForm : Form
    {

        public Sportsman Sportsman { get; set; }
        public string Label;
        public Image Im;
        public bool delPass = false;
        public string BtnTxt = "Добавить";

        public SpotsmanAddForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var it = passwordBox.Text;
            var stream = new MemoryStream();
            imageBox.Image.Save(stream, ImageFormat.Jpeg);
            Sportsman.FirstName = firstNameBox.Text;
            Sportsman.LastName = lastNameBox.Text;
            Sportsman.Login = logInBox.Text;
            if (it != Serialization.Encrypt(passwordBox.Text))
            {
                Sportsman.Password = Serialization.Encrypt(passwordBox.Text);
            }
            Sportsman.Gender = genderBox.Text;
            Sportsman.SportsCategory = sportCantegoryBox.Text;
            Sportsman.DateOfBirth = dateOfBirthBox.Value;
            Sportsman.Photo = stream.ToArray();
            Sportsman.UserType = userTypeBox.Text;
        }

        private void ImageBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewImage();
        }

        private void EditPhotoBtn_Click(object sender, EventArgs e)
        {
            NewImage();
        }

        public void NewImage()
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                imageBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SpotsmanAddForm_Load(object sender, EventArgs e)
        {
            label4.Text = Label;
            AddBtn.Text = BtnTxt;
            firstNameBox.Text = Sportsman.FirstName;
            lastNameBox.Text = Sportsman.LastName;
            logInBox.Text = Sportsman.Login;
            passwordBox.Text = Sportsman.Password;
            genderBox.Text = Sportsman.Gender;
            sportCantegoryBox.Text = Sportsman.SportsCategory;
            dateOfBirthBox.Value = Sportsman.DateOfBirth;
            userTypeBox.Text = Sportsman.UserType;
            imageBox.Image = Im;
            if (delPass)
            {
                passwordBox.Visible = false;
                logInBox.Visible = false;

                loginLabel.Visible = false;
                passwordLabel.Visible = false;
            }
        }

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sportCantegoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
