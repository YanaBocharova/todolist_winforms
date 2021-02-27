
namespace ExamWinForm.Forms
{
    partial class TypeFileFormcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxPdf = new System.Windows.Forms.CheckBox();
            this.chkBoxXml = new System.Windows.Forms.CheckBox();
            this.chkBoxTxt = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип файла";
            // 
            // chkBoxPdf
            // 
            this.chkBoxPdf.AutoSize = true;
            this.chkBoxPdf.Location = new System.Drawing.Point(42, 117);
            this.chkBoxPdf.Name = "chkBoxPdf";
            this.chkBoxPdf.Size = new System.Drawing.Size(47, 21);
            this.chkBoxPdf.TabIndex = 1;
            this.chkBoxPdf.Text = "Pdf";
            this.chkBoxPdf.UseVisualStyleBackColor = true;
            // 
            // chkBoxXml
            // 
            this.chkBoxXml.AutoSize = true;
            this.chkBoxXml.Location = new System.Drawing.Point(187, 117);
            this.chkBoxXml.Name = "chkBoxXml";
            this.chkBoxXml.Size = new System.Drawing.Size(50, 21);
            this.chkBoxXml.TabIndex = 2;
            this.chkBoxXml.Text = "Xml";
            this.chkBoxXml.UseVisualStyleBackColor = true;
            // 
            // chkBoxTxt
            // 
            this.chkBoxTxt.AutoSize = true;
            this.chkBoxTxt.Location = new System.Drawing.Point(351, 117);
            this.chkBoxTxt.Name = "chkBoxTxt";
            this.chkBoxTxt.Size = new System.Drawing.Size(45, 21);
            this.chkBoxTxt.TabIndex = 3;
            this.chkBoxTxt.Text = "Txt";
            this.chkBoxTxt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnNot_Click);
            // 
            // TypeFileFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 307);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkBoxTxt);
            this.Controls.Add(this.chkBoxXml);
            this.Controls.Add(this.chkBoxPdf);
            this.Controls.Add(this.label1);
            this.Name = "TypeFileFormcs";
            this.Text = "TypeFileFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxPdf;
        private System.Windows.Forms.CheckBox chkBoxXml;
        private System.Windows.Forms.CheckBox chkBoxTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}