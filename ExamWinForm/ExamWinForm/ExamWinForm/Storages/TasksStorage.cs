using ExamWinForm.Entity;
using ExamWinForm.Interfaces;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExamWinForm.Storages
{
    public  class TasksStorage:IStoragesServise<Task>
    {
        //Реализация Singleton
        private static TasksStorage instance;
        public static TasksStorage Instance => instance?? (instance = new TasksStorage());
        static int count = 0;
        private TasksStorage() { }
        //добавление заданий по умолчанию
        public  List<Task> tasks = new List<Task>
        {

           new Task {DateTask=new DateTime(2021,02,23),Priority_Task=Priority.Higth,Comment="To do application C#",Time_Hour="10"},
           new Task {DateTask=new DateTime(2021,03,13),Priority_Task=Priority.Low,Comment="Go to shop",Time_Hour="3"},
           new Task {DateTask=new DateTime(2021,02,23),Priority_Task=Priority.Higth,Comment="To do application Xamarin",Time_Hour="4"},
           new Task {DateTask=new DateTime(2021,02,25),Priority_Task=Priority.Low,Comment="Home work 1",Time_Hour="7"},
           new Task {DateTask=new DateTime(2021,04,25),Priority_Task=Priority.Low,Comment="Home work  2",Time_Hour="67"},
           new Task {DateTask=new DateTime(2021,05,25),Priority_Task=Priority.Low,Comment="Home work 3",Time_Hour="7"},
        };

        //Реализация паттерна Fasad
        #region --IStroragesServise methods--
        public void Add(Task item)
        {
            tasks.Add(item);
        }

        public void Remove(Task item)
        {
            tasks.Remove(item);
        }

        public List<Task> SeachByTimePeriod(string period)
        {
            if (period == "Day")
            {
                return tasks.Where(a => a.DateTask.Day == DateTime.Now.Day &&
                a.DateTask.Year == DateTime.Now.Year
                ).ToList();

            }
            if (period == "Week")
            {
                DateTime time = DateTime.Now.AddDays(7);
                return tasks.Where(a => a.DateTask <= time).ToList();

            }
            if (period == "Month")
            {

                return tasks.Where(a => a.DateTask.Month <= DateTime.Now.Month).ToList();
            }

            return tasks.Where(a => a.DateTask == DateTime.Now).ToList();
        }

        public List<Task> SeachByPriority(string priority)
        {
            return tasks.Where(a => a.Priority_Task.ToString() == priority).ToList();
        }

        public List<Task> GetAll()
        {
            return tasks;
        }
        #endregion
    }
}
