using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ANSystem.Helpers;
using ANSystem.Model;

namespace ANSystem.View
{
    public partial class AuthorizationForm : Form
    { 
        public AuthorizationForm()
        {
            InitializeComponent();
            loginBox.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var spotrsmanList = new List<Sportsman>();
            spotrsmanList = Serialization.Download(spotrsmanList);
            string login = loginBox.Text;
            string pass = Serialization.Encrypt(passwordBox.Text);

            foreach (var sportsman in spotrsmanList)
            {
                if (sportsman.UserType == "Администратор" && sportsman.Password == pass && sportsman.Login == login )
                {
                    var sf = new SpotsmanForm();
                    Close();
                    sf.Show();
                    break;
                }
                if (sportsman.UserType == "Спортсмен" && sportsman.Password == pass && sportsman.Login == login)
                {
                    var tf = new TrainingsForm()
                    {
                        TrainigsList = sportsman.Trainings,
                        UserName = sportsman.FirstName + " " + sportsman.LastName,
                        SportsmanList = spotrsmanList
                    };
                    Close();
                    tf.Show();
                    break;
                }
            }
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}