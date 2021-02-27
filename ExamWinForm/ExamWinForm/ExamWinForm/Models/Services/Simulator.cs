using ExamWinForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinForm.Models.Services
{
    // Pattern Strategy
    public class Simulator
    {
        IFileManager<List<Task>> fileManader;
        List<Task> items;

        public Simulator(IFileManager<List<Task>> fileManader, List<Task> items)
        {
            this.fileManader = fileManader;
            this.items = items;
        }
        public void Save()
        {
            fileManader.SaveToFile(items);
        }
    }
}
