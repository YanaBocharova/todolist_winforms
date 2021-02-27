namespace ExamWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.tbcomment = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSelected = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.ComboBox();
            this.lab = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPathFile = new System.Windows.Forms.Button();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.lbdays = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 15;
            this.lbTasks.Location = new System.Drawing.Point(239, 66);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(610, 394);
            this.lbTasks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список дел";
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(855, 66);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(163, 23);
            this.cbSearch.TabIndex = 2;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.CbSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сортировка списка по приоритету";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(24, 383);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(77, 45);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "Сохранить";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.BtnCreate_Task_Click);
            // 
            // tbcomment
            // 
            this.tbcomment.Location = new System.Drawing.Point(24, 69);
            this.tbcomment.Name = "tbcomment";
            this.tbcomment.Size = new System.Drawing.Size(209, 23);
            this.tbcomment.TabIndex = 5;
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(24, 113);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(209, 23);
            this.tbTag.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Коментарий";
            // 
            // dateSelected
            // 
            this.dateSelected.Location = new System.Drawing.Point(24, 321);
            this.dateSelected.Name = "dateSelected";
            this.dateSelected.Size = new System.Drawing.Size(209, 23);
            this.dateSelected.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Выбрать файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Приоритет";
            // 
            // tbHour
            // 
            this.tbHour.FormattingEnabled = true;
            this.tbHour.Location = new System.Drawing.Point(24, 282);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(209, 23);
            this.tbHour.TabIndex = 15;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(21, 253);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(146, 17);
            this.lab.TabIndex = 16;
            this.lab.Text = "Кол выделеных часов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Создать задание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnPathFile
            // 
            this.btnPathFile.Location = new System.Drawing.Point(27, 177);
            this.btnPathFile.Name = "btnPathFile";
            this.btnPathFile.Size = new System.Drawing.Size(209, 26);
            this.btnPathFile.TabIndex = 18;
            this.btnPathFile.Text = "Выбрать файл";
            this.btnPathFile.UseVisualStyleBackColor = true;
            this.btnPathFile.Click += new System.EventHandler(this.BtnPathFile_Click);
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(24, 226);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(212, 23);
            this.cbPriority.TabIndex = 19;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.CbPriority_SelectedIndexChanged);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(855, 364);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(163, 45);
            this.btnSaveToFile.TabIndex = 20;
            this.btnSaveToFile.Text = "Сохрать как ";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.BtnSave_as);
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Location = new System.Drawing.Point(855, 206);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(163, 23);
            this.cbPeriod.TabIndex = 21;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.CbPeriod_SelectedIndexChanged);
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Location = new System.Drawing.Point(852, 177);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(160, 17);
            this.lbdays.TabIndex = 22;
            this.lbdays.Text = "Актаульные задание на ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(855, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "Открыть сохранненые PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(855, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 45);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 574);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbdays);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.btnPathFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateSelected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbcomment);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox tbcomment;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbHour;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPathFile;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
    }
}

