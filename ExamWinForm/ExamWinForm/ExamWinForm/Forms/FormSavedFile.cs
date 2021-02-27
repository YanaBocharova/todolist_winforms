using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinForm.Forms
{
    public partial class FormSavedFile : Form
    {
       
            public FormSavedFile()
            {
                InitializeComponent();
                Init();
            }

            private void Init()
            {
                const string pathFolder = "Tasks\\";
                var files = Directory.GetFiles(pathFolder);

                listViewSavedFile.AllowDrop = true;
                listViewSavedFile.DragDrop += ListView_DragDrop;
                listViewSavedFile.DragEnter += ListView_DragEnter;

                var listItems = files.Select(file => new ListViewItem
                {
                    Text = Path.GetFileName(file),
                    Tag = file
                });

                listViewSavedFile.Items.AddRange(listItems.ToArray());
            }

            private void ListView_DragEnter(object sender, DragEventArgs e)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }

            private void ListView_DragDrop(object sender, DragEventArgs e)
            {
                var path = (string[])e.Data.GetData(DataFormats.FileDrop);

                var listItems = path.Select(file => new ListViewItem
                {
                    Text = Path.GetFileName(file),
                    Tag = file
                });
                listViewSavedFile.Items.AddRange(listItems.ToArray());
            }

            private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                var selItem = listViewSavedFile.SelectedItems[0];
                var path = selItem.Tag.ToString();

                Process.Start(path);
            }
        }
    }

