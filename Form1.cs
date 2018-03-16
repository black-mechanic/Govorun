using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace Govorun
{
    public partial class Form1 : Form
    {
        public Boolean StartSpeaking = false;
        static string preambula = "Записываем тестовый фрагмент номер ";
        public int speakingstep = 0;
        public int steptime = 0;
        public int stepsForProgress = 10;
        public int timeTrigPeriod = 1000;
        string resultstring;
        Color btStartPassive;
        Color btStartActive = Color.FromName("Chartreuse");
        Color prBarColor = Color.FromName("CornflowerBlue");
        
        public void SaySomething()
        {
            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();
            string curTimeShort = DateTime.Now.ToShortTimeString();
            
            resultstring = preambula + speakingstep.ToString() + "Московское время" + (DateTime.Now.Hour.ToString()) +"часов" + (DateTime.Now.Minute.ToString()) + "минут";
            // Speak a string.
            synth.Speak(resultstring);
        }

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            steptime++;
            if(steptime >= stepsForProgress)   // 10 шагов для прогресс индикатора пройдены, включаем речь
            {
                steptime = 0;
                if (StartSpeaking == true)                  // Если кнопка старт нажата
                {
                    timer1.Interval = timeTrigPeriod;       // Перезарядить таймер
                    speakingstep++;                         // Отобразить номер фрагмента
                    lblStep.Text = speakingstep.ToString(); // на форме
                    SaySomething();                         // Произнести фразу
                    prBar.Value = 1;
                    timer1.Enabled = true;                  // Разрешить работу таймера
                }
                else
                {                                           // Если кнопка стоп нажата
                    timer1.Stop();
                }

            }
            else
            {                                               // Обеспечить шаг прогресс индикатора
                if (StartSpeaking == true)
                {
                    prBar.PerformStep();
                    timer1.Interval = timeTrigPeriod;       // Перезарядить таймер
                    // Increase progress bar
                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            tBPeriod.Text = "10";
            prBar.ForeColor = prBarColor;
            prBar.BackColor = prBarColor;
            timer1.Tick += new EventHandler(TimerEventProcessor);
            btStartPassive = btStart.BackColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartSpeaking = true;
            timer1.Interval = 1000;
            steptime = 0;
            timeTrigPeriod = ((Convert.ToInt32(tBPeriod.Text)) * 60 * 1000) / stepsForProgress;
            prBar.Visible = true;
            prBar.Minimum = 1;
            prBar.Maximum = stepsForProgress;
            prBar.Step = 1;
            prBar.Value = 1;
            timer1.Start();
            btStart.BackColor = btStartActive;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartSpeaking = false;
            btStart.BackColor = btStartPassive;
        }
    }
}
