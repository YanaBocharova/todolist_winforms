using ExamWinForm.Entity;
using ExamWinForm.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ExamWinForm.Models.Services
{
    public class FileManagerXml : IFileManager<List<Task>>
    {
        static int counter = 0;
        public void SaveToFile(List<Task> items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));

            using (var fs=new FileStream ($"Tasks\\Tasks{ ++counter }.xml",FileMode.Create,FileAccess.Write))
            {
                serializer.Serialize(fs, items);
            }
        }

    }
}
