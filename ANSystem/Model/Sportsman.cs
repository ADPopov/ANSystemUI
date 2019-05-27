using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSystem.Model
{
    /// <summary>
    /// Спортсмен 
    /// </summary>
    public class Sportsman
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Спортивный разряд
        /// </summary>
        public string SportsCategory { get; set; }
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// Персональные рекорды
        /// </summary>
        public List<Training> Trainings { get; set; }
        /// <summary>
        /// Пип пользователя
        /// </summary>
        public string UserType { get; set; }

     
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
