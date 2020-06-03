namespace WinAnim
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
            this.buttonAW_BLEND = new System.Windows.Forms.Button();
            this.buttonHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.buttonCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAW_BLEND
            // 
            this.buttonAW_BLEND.Location = new System.Drawing.Point(87, 71);
            this.buttonAW_BLEND.Name = "buttonAW_BLEND";
            this.buttonAW_BLEND.Size = new System.Drawing.Size(239, 23);
            this.buttonAW_BLEND.TabIndex = 0;
            this.buttonAW_BLEND.Text = "Проявление";
            this.buttonAW_BLEND.UseVisualStyleBackColor = true;
            this.buttonAW_BLEND.Click += new System.EventHandler(this.buttonAW_BLEND_Click);
            // 
            // buttonHOR_AW_SLIDE
            // 
            this.buttonHOR_AW_SLIDE.Location = new System.Drawing.Point(87, 134);
            this.buttonHOR_AW_SLIDE.Name = "buttonHOR_AW_SLIDE";
            this.buttonHOR_AW_SLIDE.Size = new System.Drawing.Size(239, 23);
            this.buttonHOR_AW_SLIDE.TabIndex = 1;
            this.buttonHOR_AW_SLIDE.Text = "Горизонтальное проявление";
            this.buttonHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.buttonHOR_AW_SLIDE.Click += new System.EventHandler(this.buttonHOR_AW_SLIDE_Click);
            // 
            // buttonCenter_AW_SLIDE
            // 
            this.buttonCenter_AW_SLIDE.Location = new System.Drawing.Point(87, 188);
            this.buttonCenter_AW_SLIDE.Name = "buttonCenter_AW_SLIDE";
            this.buttonCenter_AW_SLIDE.Size = new System.Drawing.Size(239, 23);
            this.buttonCenter_AW_SLIDE.TabIndex = 2;
            this.buttonCenter_AW_SLIDE.Text = "Появление из центра";
            this.buttonCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            this.buttonCenter_AW_SLIDE.Click += new System.EventHandler(this.buttonCenter_AW_SLIDE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCenter_AW_SLIDE);
            this.Controls.Add(this.buttonHOR_AW_SLIDE);
            this.Controls.Add(this.buttonAW_BLEND);
            this.Name = "Form1";
            this.Text = "Анимация формы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAW_BLEND;
        private System.Windows.Forms.Button buttonHOR_AW_SLIDE;
        private System.Windows.Forms.Button buttonCenter_AW_SLIDE;
    }
}

