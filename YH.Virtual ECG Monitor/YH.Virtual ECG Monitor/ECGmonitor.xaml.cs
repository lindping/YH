﻿using HYS.Library;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using YH.ECGMonitor.WaveData.RESPWaveData;
using YH.Simulator.Framework;

namespace YH.Virtual_ECG_Monitor
{
    /// <summary>
    /// ECGmonitor.xaml 的交互逻辑
    /// </summary>
    public partial class ECGmonitor : Window
    {
        MediaPlayer player ;
        Launch launch1;
        Launch soundLauch;
        double addX = 0;//x轴上增量值
        int IndexInterval = 1;   //样本数据的数组索引间隔
        double x = 0; // x坐标
        double y = 0; // y坐标
        int i = 0;    //样本数据的数组索引

        RESPWaveData data;

        int rhythm;  //心率类型
        int wave;    //心律波形索引值

        int dataLength; //数据长度
        int waveCount = 0; //显示波形个数计数器
        int waveCountMax = 8;//显示波形个数上限

        ECGSettingModel setting;
        public ECGmonitor(int rhythm)
        {
            InitializeComponent();

          
            this.rhythm = rhythm;
            setting = Setting.GetSetting();
            this.wave = setting.Lead;
            data = DataToObject.To<RESPWaveData>(rhythm);
            dataLength = data.WaveData.GetLength(0);
            IndexInterval = dataLength > 1000 ? 10 : 1;
            addX = (double)myCanvas.Width / (double)waveCountMax / ((double)dataLength / (double)IndexInterval);

            player = new MediaPlayer();
            player.Volume = setting.QRSVolumn/10;
            soundLauch = new Launch(800);
            soundLauch.OnElapsed += SoundLauch_OnElapsed;
            soundLauch.Start();

            //原始速度
            //double dotCount = waveCount * dataLength * addY;
            //double t = ((double)(1000* 60 * waveCount)) / (double)data.Rate;
            //int interval =(int) (t / dotCount);


            int interval = (int)(1000 / setting.Speed);
            launch1 = new Launch(interval);
            launch1.OnElapsed += Launch1_OnElapsed;
            launch1.Start();
            this.Title = data.Name;
        }

        private void SoundLauch_OnElapsed()
        {
            SoundPlay(Constants.GeneralWaveFile);
        }

        private void Launch1_OnElapsed()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            {

                y = 150 - data.WaveData[i, wave];
                polyline1.Points.Add(new Point(x, y));
                x += addX;
                i += IndexInterval;

                if (i >= dataLength)
                {
                    i = 0;
                    waveCount++;
                }
                if (waveCount >= waveCountMax)
                {
                    waveCount = 0;
                    i = 0;
                    x = 0;
                    polyline1.Points.Clear();
                }

            });
        }

        private void SoundPlay(string waveFilePath)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            {
                player.Open(new Uri(waveFilePath, UriKind.Relative));
                player.Play();
            });
        }
    }


}

