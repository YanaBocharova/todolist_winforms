using ExamWinForm.Entity;
using ExamWinForm.Forms;
using ExamWinForm.Interfaces;
using ExamWinForm.Models.Services;
using ExamWinForm.Storages;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = ExamWinForm.Entity.Task;

namespace ExamWinForm
{
    public partial class Form1 : Form
    {
        static int count=0;
        IStoragesServise<Task> service = TasksStorage.Instance;

        Priority selPriority;

        string filePathToTask="";

        List<string> period = new List<string>()
        {
        "Day","Week","Month"
        };
        public Form1()
        {
            InitializeComponent();

            Init();
        }
        private void Init()
        {
            lbTasks.DataSource = service.GetAll();

            string[] priority = Enum.GetNames(typeof(Priority));
            cbSearch.DataSource = priority;
            cbPriority.DataSource = priority;
            cbPeriod.DataSource = period;
            tbcomment.Enabled =  tbTag.Enabled = false;
        }

        private void BtnCreate_Task_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbcomment.Text))){
                Entity.Task task = new Entity.Task()
                {

                    Comment = tbcomment.Text,
                    Tag = tbTag.Text,
                    FilePath = filePathToTask,
                    Priority_Task = selPriority,
                    Time_Hour = tbHour.Text,
                    DateTask = dateSelected.Value
                };
                service.Add(task);
                tbcomment.Enabled = tbTag.Enabled = false;
            }
            else
            {
                MessageBox.Show("Опишите коментарий");
                
            }
        }
        // выбор приоритета для показа в списке

        private void CbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selIdx = cbSearch.SelectedIndex;
            if(selIdx!=-1)
            {
                var selItem = cbSearch.SelectedItem.ToString();
                lbTasks.DataSource = service.SeachByPriority(selItem);
            }
        }
        // выбор приоритета для создания задачи
        private void CbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selIdx = cbPriority.SelectedIndex;

            string[] priority = Enum.GetNames(typeof(Priority));

            if (selIdx != -1)
            {
                 selPriority =(Priority)Enum.Parse(typeof(Priority),priority[selIdx]);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            tbcomment.Enabled  = tbTag.Enabled = true;
        }

        private void BtnPathFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {

            };
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                filePathToTask=openFile.FileName;
            }
        }

        private void BtnSave_as(object sender, EventArgs e)
        {
            TypeFileFormcs form = new TypeFileFormcs(service.GetAll());
            form.Show();
        }

        private void CbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string time="";
            var selIdx = cbPeriod.SelectedIndex;
            if(selIdx!=-1)
            {
                time = cbPeriod.SelectedItem.ToString();
                lbTasks.DataSource = service.SeachByTimePeriod(time);
            }

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            FormSavedFile formPDF = new FormSavedFile();

            formPDF.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selIdx = lbTasks.SelectedIndex;
            if (selIdx != -1)
            {
                var selItem = lbTasks.SelectedItem as Task;
                service.Remove(selItem);

                //lbTasks.DataSource = storage.tasks;
            }
        }
    }
}
