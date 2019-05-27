using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ANSystem.Model
{
    /// <summary>
    /// Тренировка
    /// </summary>
    public class Training
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Время
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Дистанция пройденная спортсменом
        /// </summary>
        public int Distance { get; set; }
        /// <summary>
        /// Продолжительность тренировки
        /// </summary>
        public DateTime Duration { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public string KindOfSports { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string NameTraining { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Место
        /// </summary>
        public string Place { get; set; }

        public string UnitSystem { get; set; }

        //class DateTimer
        //{
        //    public DateTimer()
        //    {
        //        DateTime dt = new DateTime();
        //        string st = Hour + ":" + Minute + ":" + ":" + Second;
        //        dt = DateTime.Parse(st);
        //    }

        //    public int Hour { get; set; }
        //    public int Minute { get; set; }
        //    public int Second { get; set; }
        //}


        public override string ToString()
        {
            return NameTraining + " | " + Distance + ' ' + UnitSystem;
        }
    }
}
