using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinForm.Interfaces
{
    public interface IStoragesServise<T>
        where T:class
    {
        void Add(T item);
        void Remove(T item);
        List<T> SeachByTimePeriod(string period);
        List<T> SeachByPriority(string priority);
        List<T> GetAll();
    }
}
