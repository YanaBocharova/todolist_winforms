using ExamWinForm.Entity;
using ExamWinForm.Interfaces;
using ExamWinForm.Models;
using ExamWinForm.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamWinForm.Forms
{
    public partial class TypeFileFormcs : Form
    {
        IFileManager<List<Task>> fileManager;
        List<Task> items;
        public TypeFileFormcs(List<Task> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if( chkBoxPdf.Checked)
            {
                fileManager= new FileManagerPdf();
            }
            if (chkBoxXml.Checked)
            {
                fileManager = new FileManagerXml();
            }
            if (chkBoxTxt.Checked)
            {
                fileManager = new FileManagerTxt();
            }
            fileManager.SaveToFile(items);

            FormSavedFile savedFile = new FormSavedFile();
            savedFile.Show();
            Close();
        }
    }
}
