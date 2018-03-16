namespace Govorun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPeriod = new System.Windows.Forms.TextBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(15, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(70, 30);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(106, 12);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(70, 30);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N фрагмента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Период (мин.)";
            // 
            // tBPeriod
            // 
            this.tBPeriod.Location = new System.Drawing.Point(106, 55);
            this.tBPeriod.Name = "tBPeriod";
            this.tBPeriod.Size = new System.Drawing.Size(59, 20);
            this.tBPeriod.TabIndex = 4;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(103, 92);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(13, 13);
            this.lblStep.TabIndex = 5;
            this.lblStep.Text = "1";
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(16, 118);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(160, 17);
            this.prBar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 146);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.tBPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Govorun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPeriod;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.ProgressBar prBar;
    }
}

