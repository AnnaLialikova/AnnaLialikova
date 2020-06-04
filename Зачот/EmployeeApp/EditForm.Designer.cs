namespace EmployeeApp
{
    partial class EditForm
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
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonEnterId = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.label3);
            this.groupBoxEdit.Controls.Add(this.label2);
            this.groupBoxEdit.Controls.Add(this.buttonEnterId);
            this.groupBoxEdit.Controls.Add(this.textBox1);
            this.groupBoxEdit.Controls.Add(this.label1);
            this.groupBoxEdit.Controls.Add(this.textBoxInfo);
            this.groupBoxEdit.Controls.Add(this.textBoxDepartement);
            this.groupBoxEdit.Controls.Add(this.textBoxAdress);
            this.groupBoxEdit.Controls.Add(this.textBoxDate);
            this.groupBoxEdit.Controls.Add(this.textBoxSurname);
            this.groupBoxEdit.Controls.Add(this.textBoxSecondName);
            this.groupBoxEdit.Controls.Add(this.textBoxName);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Controls.Add(this.label6);
            this.groupBoxEdit.Controls.Add(this.label5);
            this.groupBoxEdit.Controls.Add(this.label4);
            this.groupBoxEdit.Controls.Add(this.labelSurname);
            this.groupBoxEdit.Controls.Add(this.labelSecondName);
            this.groupBoxEdit.Controls.Add(this.labelName);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEdit.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(535, 450);
            this.groupBoxEdit.TabIndex = 0;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование анкеты сотрудника:";
            // 
            // buttonEnterId
            // 
            this.buttonEnterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterId.Location = new System.Drawing.Point(440, 38);
            this.buttonEnterId.Name = "buttonEnterId";
            this.buttonEnterId.Size = new System.Drawing.Size(75, 27);
            this.buttonEnterId.TabIndex = 30;
            this.buttonEnterId.Text = "Ввод";
            this.buttonEnterId.UseVisualStyleBackColor = true;
            this.buttonEnterId.Click += new System.EventHandler(this.buttonEnterId_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите ID анкеты для редактирования:";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(167, 325);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(348, 27);
            this.textBoxInfo.TabIndex = 27;
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.Location = new System.Drawing.Point(167, 286);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.Size = new System.Drawing.Size(348, 27);
            this.textBoxDepartement.TabIndex = 26;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(167, 246);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(348, 27);
            this.textBoxAdress.TabIndex = 25;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(167, 205);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(348, 27);
            this.textBoxDate.TabIndex = 24;
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(167, 162);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(348, 27);
            this.textBoxSurname.TabIndex = 23;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(167, 121);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(348, 27);
            this.textBoxSecondName.TabIndex = 22;
            this.textBoxSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondName_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 27);
            this.textBoxName.TabIndex = 21;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "О себе:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Отдел:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Адрес проживания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата рождения:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(12, 162);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 18);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondName.Location = new System.Drawing.Point(12, 121);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(79, 18);
            this.labelSecondName.TabIndex = 15;
            this.labelSecondName.Text = "Отчество:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 18);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Имя:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(574, 319);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(177, 41);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(574, 386);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(177, 41);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти без сохранения";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Для отображения изменений нажмите кнопку ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "\"Обновить таблицу\" на главном окне.";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxEdit);
            this.Name = "EditForm";
            this.Text = "Редактирование существующей анкеты";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonEnterId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}