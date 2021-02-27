using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinForm.Entity
{
    public enum Priority 
    { 
      Low,
      Medium,
      Higth
    }

    [Serializable]
    public class Task
    {
        private DateTime dateTime = DateTime.Now;
        public DateTime DateTask {

            get
            {
                return dateTime;
            }

            set
            {
                if(value >= DateTime.Now)
                {
                    dateTime = value;
                }
            } 
        } //дата выполнения
        public string Time_Hour { get; set; } //время  выполнения 
        public Priority Priority_Task { get; set; }
        public string Tag { get; set; } = "";
        public string Comment{ get; set; }
        public string FilePath { get; set; } = "";


        public override string ToString()
        {
            return $"Задача - {Comment} .Приоритет -{Priority_Task.ToString()}.Дата выполнения {DateTask.ToShortDateString()}Кол-ство часов {Time_Hour}.";
        }
    }
}
