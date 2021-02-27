using ExamWinForm.Entity;
using ExamWinForm.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ExamWinForm.Models
{
    public class FileManagerTxt : IFileManager<List<Task>>
    {
        static int counter = 0;
        public void SaveToFile(List<Task> items)
        {
            
            var tasks = items.ToArray();
           
            using (StreamWriter writer = new StreamWriter($"Tasks\\Tasks{++counter}.txt"))
            {
                for (int i = 0; i < tasks.Count(); i++)
                {
                    writer.WriteLine($"{items[i]}");
                }
               
            }

        }
    }
}
