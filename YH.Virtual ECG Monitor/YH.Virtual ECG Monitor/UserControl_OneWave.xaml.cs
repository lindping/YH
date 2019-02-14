﻿using HYS.Library;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Linq;

namespace YH.Virtual_ECG_Monitor
{
    /// <summary>
    /// 用于展示波形的控件
    /// </summary>
    public partial class UserControl_OneWave : UserControl
    {
        int interval = 100;    //描点的数据
        Launch launch;    //定时器
        double addX;      // x轴上 点距
        int i = 0;            //
        double x = 0;  // x坐标
        int curWaveCount = 0;  //表示当前第几个波形
        int intervalCount;   //周期内描点个数
        float[] data;   //波形数据

        public int MaxWaveCount { get; set; }   //要展示的波形个数



        public bool IsPause
        {
            get
            {
                return launch._isPause;
            }
        }

        public UserControl_OneWave()
        {
            InitializeComponent();
            MaxWaveCount = 8;
            //       controlHeight = ActualHeight;
        }

        public void Stop()
        {
            if (launch != null)
            {
                launch.Stop();
                launch = null;
            }
        }

        public void Pause()
        {

            launch.Pause();
        }

        public void Start()
        {
            launch.Start();
        }

        public void Run(float[] data, int maxWaveCount, float speed, float gain)
        {

            if (launch == null)
            {
                launch = new Launch();
                launch.Interval = interval;
                launch.OnElapsed += launch_OnElapsed;
            }

            gain = gain / 5;

            float max = data.Max();
            float min = data.Min();
            float valueHeight = max - min;
            this.data = new float[data.Length];

            float controlHeight = (float)myCanvas.ActualHeight * 0.9f;
            for (int i = 0; i < data.Length; i++)
            {
                this.data[i] = controlHeight - ((data[i] - min) / valueHeight) * controlHeight;
                this.data[i] = this.data[i] + 5;
            }

            MaxWaveCount = maxWaveCount * (int)gain;

            int pointAmount = (int)(maxWaveCount * this.data.Length * (speed / 5f));

            if (pointAmount < 60000 / interval)
            {
                interval = 60000 / pointAmount;
                intervalCount = 1;
            }
            else
            {
                intervalCount = pointAmount * interval / 60000;
                if (intervalCount == 0)
                {
                    intervalCount = 1;
                }
            }
            addX = ActualWidth / (double)((maxWaveCount * data.Length)) / gain;
            launch.Start();
        }

        private void launch_OnElapsed()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            {
                if (i >= this.data.GetLength(0))
                {
                    i = 0;
                    curWaveCount++;
                }

                for (int j = 0; j < intervalCount; j++)
                {
                    if (i >= this.data.Length)
                    {
                        break;
                    }
                    float y = this.data[i];
                    polyline.Points.Add(new Point(x, y));
                    x += addX;
                    i++;
                }

                if (curWaveCount >= MaxWaveCount || x > ActualWidth)
                {
                    curWaveCount = 0;
                    i = 0;
                    x = 0;
                    polyline.Points.Clear();
                }
            });
        }
    }
}
