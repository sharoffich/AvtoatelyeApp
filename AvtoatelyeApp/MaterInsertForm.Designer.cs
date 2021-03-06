
namespace AvtoatelyeApp
{
    partial class MaterInsertForm
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
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(12, 284);
            this.maskedTextBoxNumber.Mask = "0 (999) 000-00-00";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNumber.TabIndex = 34;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(12, 101);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerTime.TabIndex = 33;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 60);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDate.TabIndex = 32;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(142, 291);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 31;
            this.labelNumber.Text = "Номер телефона";
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Location = new System.Drawing.Point(142, 245);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(54, 13);
            this.labelMiddlename.TabIndex = 30;
            this.labelMiddlename.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(142, 199);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(142, 153);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 28;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(142, 107);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 13);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "Время";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(142, 66);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 26;
            this.labelData.Text = "Дата";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 23);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(12, 322);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(110, 23);
            this.buttonInsert.TabIndex = 24;
            this.buttonInsert.Text = "Добавить запись";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(12, 238);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddlename.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 192);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 22;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 146);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 21;
            // 
            // MaterInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(281, 419);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelMiddlename);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxMiddlename);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Name = "MaterInsertForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.MaterInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}