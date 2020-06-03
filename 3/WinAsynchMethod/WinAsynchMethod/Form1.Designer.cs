namespace WinAsynchMethod
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(40, 64);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(86, 17);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Значение А";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(397, 64);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(86, 17);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Значение В";
            // 
            // textBoxA
            // 
            this.helpProvider1.SetHelpString(this.textBoxA, "For input integer A");
            this.textBoxA.Location = new System.Drawing.Point(145, 64);
            this.textBoxA.Name = "textBoxA";
            this.helpProvider1.SetShowHelp(this.textBoxA, true);
            this.textBoxA.Size = new System.Drawing.Size(186, 22);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.helpProvider1.SetHelpString(this.textBoxB, "For input integer B");
            this.textBoxB.Location = new System.Drawing.Point(512, 64);
            this.textBoxB.Name = "textBoxB";
            this.helpProvider1.SetShowHelp(this.textBoxB, true);
            this.textBoxB.Size = new System.Drawing.Size(189, 22);
            this.textBoxB.TabIndex = 3;
            // 
            // buttonRun
            // 
            this.helpProvider1.SetHelpString(this.buttonRun, "Sum");
            this.buttonRun.Location = new System.Drawing.Point(43, 106);
            this.buttonRun.Name = "buttonRun";
            this.helpProvider1.SetShowHelp(this.buttonRun, true);
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Сумма";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonWork
            // 
            this.helpProvider1.SetHelpString(this.buttonWork, "Start work");
            this.buttonWork.Location = new System.Drawing.Point(187, 163);
            this.buttonWork.Name = "buttonWork";
            this.helpProvider1.SetShowHelp(this.buttonWork, true);
            this.buttonWork.Size = new System.Drawing.Size(75, 23);
            this.buttonWork.TabIndex = 5;
            this.buttonWork.Text = "Работа";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Анна\\Desktop\\Практика WinC#\\ДЗ\\8. Повышение удобства использования прило" +
    "жений\\3\\WinAsynchMethod\\Help.docx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Асинхронный запуск";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
    }
}

