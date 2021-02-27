
namespace ExamWinForm.Forms
{
    partial class FormSavedFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewSavedFile = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSavedFile
            // 
            this.listViewSavedFile.HideSelection = false;
            this.listViewSavedFile.Location = new System.Drawing.Point(67, 87);
            this.listViewSavedFile.Name = "listViewSavedFile";
            this.listViewSavedFile.Size = new System.Drawing.Size(526, 315);
            this.listViewSavedFile.TabIndex = 0;
            this.listViewSavedFile.UseCompatibleStateImageBehavior = false;
            this.listViewSavedFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "У Вас есть возможность перетягить на форму допольнительные файлы вручную";
            // 
            // FormSavedFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSavedFile);
            this.Name = "FormSavedFile";
            this.Text = "FormSavedFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSavedFile;
        private System.Windows.Forms.Label label1;
    }
}