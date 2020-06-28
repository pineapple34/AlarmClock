namespace AlarmClock
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
            this.components = new System.ComponentModel.Container();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.AlarmTime = new System.Windows.Forms.MaskedTextBox();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.StopAlarm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeToAlarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTime.Location = new System.Drawing.Point(65, 26);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(120, 31);
            this.CurrentTime.TabIndex = 0;
            this.CurrentTime.Text = "00:00:00";
            // 
            // AlarmTime
            // 
            this.AlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmTime.Location = new System.Drawing.Point(94, 72);
            this.AlarmTime.Mask = "00:00";
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(60, 30);
            this.AlarmTime.TabIndex = 1;
            this.AlarmTime.ValidatingType = typeof(System.DateTime);
            // 
            // SetAlarm
            // 
            this.SetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetAlarm.Location = new System.Drawing.Point(42, 155);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(171, 29);
            this.SetAlarm.TabIndex = 2;
            this.SetAlarm.Text = "Установить будильник";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // StopAlarm
            // 
            this.StopAlarm.Enabled = false;
            this.StopAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopAlarm.Location = new System.Drawing.Point(42, 201);
            this.StopAlarm.Name = "StopAlarm";
            this.StopAlarm.Size = new System.Drawing.Size(171, 38);
            this.StopAlarm.TabIndex = 3;
            this.StopAlarm.Text = "Остановить будильник";
            this.StopAlarm.UseVisualStyleBackColor = true;
            this.StopAlarm.Click += new System.EventHandler(this.StopAlarm_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeToAlarm
            // 
            this.TimeToAlarm.AutoSize = true;
            this.TimeToAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeToAlarm.Location = new System.Drawing.Point(39, 114);
            this.TimeToAlarm.Name = "TimeToAlarm";
            this.TimeToAlarm.Size = new System.Drawing.Size(0, 17);
            this.TimeToAlarm.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 251);
            this.Controls.Add(this.TimeToAlarm);
            this.Controls.Add(this.StopAlarm);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.AlarmTime);
            this.Controls.Add(this.CurrentTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Будильник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.MaskedTextBox AlarmTime;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.Button StopAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeToAlarm;
    }
}

