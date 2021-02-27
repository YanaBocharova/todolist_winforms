using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinForm.Interfaces
{
    // интерфейс для паттерна стратегия
    public interface IFileManager<T>
    {
        void SaveToFile(T items);
    }
}
