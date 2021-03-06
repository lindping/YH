﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YH.Simulator.Framework.DataDictionary;

namespace YH.Virtual_ECG_Monitor
{
    /// <summary>
    /// ECGRunSetting.xaml 的交互逻辑
    /// </summary>
    public partial class ECGRunSetting : Window
    {
        public Rhythm Rhythm { get; set; }
        public int  HeartRate{ get; set; }
        public ECGRunSetting(Rhythm rhythm,int heartRate)
        {
            InitializeComponent();          

            Rhythm = rhythm;
            HeartRate = heartRate;

            cbRhythm.ItemsSource = MyDictionary.Rhythm_Basic.Select(p=>p.Value);
            cbRhythm.SelectedIndex = (int)rhythm;
            txtHeartRate.Value = heartRate;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rhythm = (Rhythm)cbRhythm.SelectedIndex;
            HeartRate = txtHeartRate.Value;       
            this.DialogResult = true;        
            Close();          
        }
    }
}
