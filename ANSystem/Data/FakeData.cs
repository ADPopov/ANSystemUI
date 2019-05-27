using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Model;
using ANSystem.Helpers;

namespace ANSystem.Data
{
    class FakeData
    {
        public List<Sportsman> SportsmanFakeList { get; set; }

        public FakeData()
        {
            SportsmanFakeList = new List<Sportsman>();
            var sp1 = new Sportsman
            {
                FirstName = "Александр",
                LastName = "Попов",
                Email = "AlexPopov1999@gmail.com",
                DateOfBirth = DateTime.Parse("13.11.1999"),
                Gender = "м",
                Password = "user1",
                Login = "user1",
                SportsCategory = "I",
                UserType = "Администратор",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег у озера",
                        Distance = 5,
                        Description = "Самочувствие отличное. Встретил бабу Нину, скзала что я молодец!)))",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("10.03.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Бег в манеже УрФУ",
                        Distance = 4,
                        Description = "Побегал неплохо, проколол колесо",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("25.04.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Велосипед",
                        Place = "Парк"
                    },
                    new Training
                    {
                        NameTraining = "Прогулка по парку",
                        Distance = 4,
                        Description = "Спокойным шагом",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("05.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Парк"
                    }
                }
            };

            var sp2 = new Sportsman
            {
                FirstName = "Станислав",
                LastName = "Воложанин",
                Email = "email@gmail.com",
                DateOfBirth = DateTime.Parse("28.05.1999"),
                Gender = "м",
                Password = "user2",
                Login = "user2",
                SportsCategory = "I",
                UserType = "Администратор",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег по парку",
                        Distance = 5,
                        Description = "Самочувствие отличное, шел снег",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("10.05.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Поездка на велосипеде",
                        Distance = 4,
                        Description = "Побегал неплохо, проколол колесо",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("23.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Велосипед",
                        Place = "Парк"
                    },
                    new Training
                    {
                    NameTraining = "Прогулка по парку",
                    Distance = 4,
                    Description = "Спокойным шагом",
                    Time = DateTime.Parse("10:20"),
                    Date = DateTime.Parse("05.03.2019"),
                    Duration = DateTime.Parse("01:00:20"),
                    UnitSystem = "км",
                    KindOfSports = "Бег",
                    Place = "Парк"
                    }
               }
            };

            var sp3 = new Sportsman
            {
                FirstName = "Ловской",
                LastName = "Кирилл",
                Email = "emailKirill@gmail.com",
                DateOfBirth = DateTime.Parse("20.10.1999"),
                Gender = "м",
                SportsCategory = "КМС",
                Password = "user3",
                Login = "user3",
                UserType = "Спортсмен",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег вечером",
                        Distance = 5,
                        Description = "Побегал классно, самочувствие отличное",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("20.03.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Бег утром",
                        Distance = 4,
                        Description = "Побегал неплохо, было тяжко",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("23.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Парк"
                    }
                }
            };
            var sp4 = new Sportsman
            {
                FirstName = "Фотеев",
                LastName = "Михаил",
                Email = "MFoteev1999@gmail.com",
                DateOfBirth = DateTime.Parse("12.09.1999"),
                Gender = "м",
                Password = "user4",
                Login = "user4",
                SportsCategory = "I",
                UserType = "Спортсмен",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег в паке",
                        Distance = 3,
                        Description = "Самочувствие отличное",
                        Time = DateTime.Parse("19:10"),
                        Date = DateTime.Parse("13.04.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "На физре",
                        Distance = 3,
                        Description = "Пробежал трешечку",
                        Time = DateTime.Parse("12:10"),
                        Date = DateTime.Parse("25.04.2019"),
                        Duration = DateTime.Parse("00:12:24"),
                        UnitSystem = "км",
                        KindOfSports = "Велосипед",
                        Place = "Стадион УрФУ"
                    },
                    new Training
                    {
                        NameTraining = "Прогулка по парку",
                        Distance = 4,
                        Description = "Спокойным шагом",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("05.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Парк"
                    }
                }
            };
            SportsmanFakeList.Add(sp1);
            SportsmanFakeList.Add(sp2);
            SportsmanFakeList.Add(sp3);
            SportsmanFakeList.Add(sp4);
        }
    }
}
                    
