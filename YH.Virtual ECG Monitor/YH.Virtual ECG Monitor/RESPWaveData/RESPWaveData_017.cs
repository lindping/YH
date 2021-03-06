﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

YH.Virtual_ECG_Monitor.WaveData.RESPWaveData
{
    public class RESPWaveData_017 : RESPWaveData
    {
        public RESPWaveData_017()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R17";
            Name = "二度Ⅱ型房室传导阻滞";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[160,12] {
{33.57f,   34.11f,   33.06f,   34.11f,   33.46f,   34.60f,   34.60f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.57f,   34.11f,   33.06f,   34.11f,   33.46f,   34.60f,   34.60f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.56f,   34.11f,   33.06f,   34.12f,   33.46f,   34.60f,   34.59f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.55f,   34.11f,   33.06f,   34.13f,   33.46f,   34.60f,   34.59f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.55f,   34.11f,   33.06f,   34.13f,   33.46f,   34.60f,   34.58f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.54f,   34.11f,   33.06f,   34.14f,   33.46f,   34.60f,   34.57f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.53f,   34.11f,   33.06f,   34.15f,   33.46f,   34.60f,   34.57f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.53f,   34.11f,   33.06f,   34.15f,   33.46f,   34.60f,   34.56f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.52f,   34.11f,   33.06f,   34.16f,   33.46f,   34.60f,   34.55f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.51f,   34.11f,   33.06f,   34.16f,   33.46f,   34.60f,   34.55f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.51f,   34.11f,   33.06f,   34.17f,   33.46f,   34.60f,   34.54f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.50f,   34.11f,   33.06f,   34.18f,   33.46f,   33.46f,   34.53f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.50f,   34.11f,   33.06f,   34.18f,   33.46f,   31.51f,   36.02f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{34.52f,   34.11f,   34.11f,   34.19f,   34.03f,   30.48f,   37.61f,   35.06f,   33.57f,   33.06f,   33.46f,   34.60f},
{35.55f,   34.11f,   36.20f,   34.20f,   35.64f,   32.54f,   37.03f,   36.67f,   33.57f,   33.51f,   33.57f,   34.60f},
{34.97f,   35.62f,   34.57f,   34.20f,   35.64f,   34.60f,   33.93f,   37.70f,   34.60f,   35.54f,   33.46f,   34.60f},
{33.47f,   37.25f,   33.06f,   34.21f,   33.46f,   34.60f,   34.50f,   36.67f,   36.67f,   36.10f,   35.06f,   35.64f},
{33.46f,   37.25f,   33.06f,   35.73f,   33.46f,   34.60f,   34.49f,   35.64f,   35.64f,   35.09f,   36.67f,   37.70f},
{33.46f,   36.20f,   33.06f,   37.37f,   33.46f,   34.60f,   34.49f,   35.64f,   34.03f,   33.51f,   35.06f,   37.70f},
{33.45f,   34.11f,   33.06f,   36.79f,   33.46f,   34.60f,   34.48f,   35.64f,   33.57f,   33.06f,   33.46f,   36.67f},
{33.44f,   34.11f,   33.06f,   35.75f,   33.46f,   34.60f,   34.48f,   35.64f,   33.57f,   33.06f,   33.46f,   35.06f},
{33.44f,   34.11f,   33.06f,   34.71f,   33.46f,   34.60f,   34.47f,   35.64f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.43f,   34.11f,   33.06f,   34.25f,   33.46f,   34.60f,   34.46f,   35.06f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.42f,   34.11f,   33.06f,   34.26f,   33.46f,   34.60f,   34.46f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.42f,   34.11f,   33.06f,   34.26f,   33.46f,   34.60f,   34.45f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.41f,   34.11f,   33.06f,   34.27f,   33.46f,   34.60f,   34.44f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.41f,   34.11f,   33.06f,   34.28f,   33.46f,   34.60f,   34.44f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.40f,   34.11f,   33.06f,   34.28f,   33.46f,   34.60f,   34.43f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.39f,   34.11f,   33.06f,   34.29f,   33.46f,   34.60f,   34.42f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.39f,   33.52f,   33.06f,   34.30f,   33.46f,   34.60f,   34.42f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.38f,   33.06f,   33.06f,   34.30f,   33.46f,   34.60f,   34.41f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.37f,   33.06f,   33.06f,   34.31f,   33.46f,   34.60f,   34.40f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.37f,   33.06f,   33.06f,   34.32f,   33.46f,   34.60f,   34.40f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.36f,   33.06f,   33.06f,   34.32f,   33.46f,   34.60f,   34.39f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.35f,   33.06f,   33.06f,   34.33f,   33.46f,   34.60f,   34.39f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.35f,   33.06f,   33.06f,   34.33f,   33.46f,   34.60f,   34.38f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.34f,   33.06f,   33.06f,   34.34f,   33.46f,   34.60f,   34.37f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.33f,   33.06f,   33.06f,   34.35f,   33.46f,   34.60f,   34.37f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.33f,   33.06f,   33.06f,   34.35f,   33.46f,   34.60f,   34.36f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.32f,   33.06f,   33.06f,   34.36f,   33.46f,   34.60f,   34.35f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.31f,   33.06f,   33.06f,   34.37f,   33.46f,   34.60f,   34.35f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.31f,   33.06f,   33.06f,   34.37f,   33.46f,   34.60f,   34.34f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.30f,   33.06f,   33.06f,   34.38f,   33.46f,   34.60f,   34.33f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.30f,   33.06f,   33.06f,   34.39f,   33.46f,   34.60f,   34.33f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.29f,   33.06f,   33.06f,   34.39f,   33.46f,   34.60f,   34.32f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.28f,   33.06f,   33.06f,   34.40f,   33.46f,   34.60f,   34.31f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.28f,   33.06f,   33.06f,   34.41f,   33.46f,   34.60f,   34.31f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.27f,   33.06f,   33.06f,   34.41f,   33.46f,   34.60f,   34.30f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.26f,   33.06f,   33.06f,   34.42f,   33.46f,   34.60f,   34.29f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.26f,   33.06f,   33.06f,   34.43f,   33.46f,   34.60f,   34.29f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.25f,   33.06f,   33.06f,   34.43f,   33.46f,   34.60f,   34.28f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.24f,   33.06f,   33.06f,   34.44f,   33.46f,   34.60f,   34.28f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.24f,   33.06f,   33.06f,   34.45f,   33.46f,   34.60f,   34.27f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.23f,   33.06f,   33.06f,   34.45f,   33.46f,   34.60f,   34.26f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.22f,   33.06f,   33.06f,   34.46f,   33.46f,   34.60f,   34.26f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.22f,   33.06f,   33.06f,   34.47f,   33.46f,   34.60f,   34.25f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.21f,   33.06f,   33.06f,   34.47f,   33.46f,   34.60f,   34.24f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.21f,   33.06f,   33.06f,   34.48f,   33.46f,   34.60f,   34.24f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.20f,   33.06f,   33.06f,   34.49f,   33.46f,   34.60f,   34.23f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.19f,   33.06f,   33.06f,   34.49f,   33.46f,   34.60f,   34.22f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.19f,   33.06f,   33.06f,   34.50f,   33.46f,   34.60f,   34.22f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.18f,   33.06f,   33.06f,   34.51f,   33.46f,   34.60f,   34.21f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.17f,   33.06f,   33.06f,   34.51f,   33.46f,   34.60f,   34.20f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.17f,   33.06f,   33.06f,   34.52f,   33.46f,   34.60f,   34.20f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.16f,   33.06f,   33.06f,   34.52f,   33.46f,   34.60f,   34.19f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.15f,   33.06f,   33.06f,   34.53f,   33.46f,   34.60f,   34.19f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.15f,   33.06f,   33.06f,   34.54f,   33.46f,   34.60f,   34.18f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.14f,   33.06f,   33.06f,   34.54f,   33.46f,   34.60f,   34.17f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.13f,   33.06f,   33.06f,   34.55f,   33.46f,   34.60f,   34.17f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.13f,   33.06f,   33.06f,   34.56f,   33.46f,   34.60f,   34.16f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.12f,   33.06f,   33.06f,   34.56f,   33.46f,   34.60f,   34.15f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.12f,   33.06f,   33.06f,   34.57f,   33.46f,   34.60f,   34.15f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.11f,   33.06f,   33.06f,   34.58f,   33.46f,   34.60f,   34.14f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.10f,   33.06f,   33.06f,   34.58f,   33.46f,   34.60f,   34.13f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.10f,   33.06f,   33.06f,   34.59f,   33.46f,   34.60f,   34.13f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.09f,   33.06f,   33.06f,   34.60f,   33.46f,   34.60f,   34.12f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.08f,   33.06f,   33.06f,   34.60f,   33.46f,   34.60f,   34.11f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.08f,   33.06f,   33.06f,   34.61f,   33.46f,   34.60f,   34.11f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.07f,   33.06f,   33.06f,   34.62f,   33.46f,   34.60f,   34.10f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.06f,   33.06f,   33.06f,   34.62f,   33.46f,   34.60f,   34.09f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.06f,   33.06f,   33.06f,   34.63f,   33.46f,   34.60f,   34.09f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.05f,   33.06f,   33.06f,   34.64f,   33.46f,   34.60f,   34.08f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.04f,   33.06f,   33.06f,   34.64f,   33.46f,   34.60f,   34.08f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.04f,   34.11f,   33.06f,   34.65f,   33.46f,   34.60f,   34.07f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.03f,   34.11f,   33.06f,   34.66f,   33.46f,   34.60f,   34.06f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.03f,   34.11f,   33.06f,   34.66f,   33.46f,   34.60f,   34.06f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{33.02f,   34.11f,   33.06f,   34.67f,   33.46f,   34.60f,   34.05f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.01f,   34.11f,   33.06f,   34.68f,   33.46f,   34.60f,   34.04f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.01f,   34.11f,   33.06f,   34.68f,   33.46f,   34.60f,   34.04f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.00f,   34.11f,   33.06f,   34.69f,   33.11f,   34.60f,   34.03f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.99f,   34.11f,   33.06f,   34.70f,   32.54f,   34.60f,   34.02f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.99f,   34.11f,   33.06f,   34.70f,   32.54f,   34.60f,   34.02f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{32.98f,   34.11f,   33.06f,   34.71f,   32.54f,   34.60f,   34.01f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.97f,   34.11f,   33.06f,   34.71f,   32.54f,   34.60f,   34.00f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.97f,   34.11f,   33.06f,   34.72f,   32.54f,   34.60f,   34.00f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.96f,   34.11f,   33.06f,   34.73f,   32.54f,   34.60f,   33.99f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.95f,   34.11f,   33.06f,   34.73f,   32.54f,   34.60f,   33.99f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.95f,   34.11f,   33.06f,   34.74f,   32.54f,   34.60f,   33.98f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.94f,   34.11f,   33.06f,   34.75f,   32.54f,   34.60f,   33.97f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.93f,   34.11f,   33.06f,   34.75f,   32.54f,   34.60f,   33.97f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.93f,   34.11f,   33.06f,   34.76f,   32.54f,   34.60f,   33.96f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.92f,   34.11f,   33.06f,   34.77f,   32.54f,   34.60f,   33.95f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.92f,   34.11f,   33.06f,   34.77f,   32.54f,   34.60f,   33.95f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.91f,   34.11f,   33.06f,   34.78f,   32.54f,   34.60f,   33.94f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.90f,   34.11f,   33.06f,   34.79f,   32.54f,   34.60f,   33.93f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.90f,   34.11f,   33.06f,   34.79f,   32.54f,   34.60f,   33.93f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.89f,   34.11f,   33.06f,   34.80f,   32.54f,   34.60f,   33.92f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.88f,   34.11f,   33.06f,   34.81f,   32.54f,   34.60f,   33.91f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.88f,   34.11f,   33.06f,   34.81f,   32.54f,   34.60f,   33.91f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.87f,   34.11f,   33.06f,   34.82f,   32.54f,   34.60f,   33.90f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.86f,   34.11f,   33.06f,   34.83f,   32.54f,   34.60f,   33.90f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.86f,   34.11f,   33.06f,   34.83f,   32.54f,   34.03f,   33.89f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.85f,   34.11f,   33.06f,   34.84f,   33.11f,   32.54f,   33.88f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.30f,   34.11f,   33.52f,   34.85f,   33.46f,   30.94f,   35.37f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{34.33f,   34.11f,   35.62f,   34.85f,   34.03f,   32.08f,   36.96f,   36.09f,   33.57f,   33.06f,   33.46f,   34.60f},
{34.32f,   34.11f,   35.15f,   34.86f,   35.64f,   33.46f,   36.38f,   37.70f,   34.60f,   34.52f,   33.46f,   34.60f},
{33.28f,   35.62f,   33.52f,   34.87f,   35.64f,   34.60f,   33.28f,   37.13f,   36.67f,   36.10f,   33.46f,   34.60f},
{32.82f,   37.25f,   33.06f,   34.87f,   33.46f,   34.60f,   33.85f,   36.09f,   35.64f,   35.54f,   35.06f,   35.64f},
{32.81f,   37.25f,   33.06f,   36.39f,   33.46f,   34.60f,   33.84f,   35.06f,   34.03f,   34.07f,   36.67f,   37.70f},
{32.81f,   36.20f,   33.06f,   38.03f,   33.46f,   34.60f,   33.84f,   34.60f,   33.57f,   33.06f,   35.06f,   37.70f},
{32.80f,   33.52f,   33.06f,   37.45f,   33.11f,   33.46f,   33.83f,   34.60f,   33.57f,   33.06f,   33.46f,   36.67f},
{32.79f,   33.06f,   33.06f,   36.41f,   32.08f,   29.45f,   33.82f,   34.60f,   33.57f,   33.06f,   33.46f,   35.06f},
{36.34f,   33.06f,   36.20f,   35.37f,   31.51f,   25.32f,   33.82f,   35.64f,   33.57f,   33.06f,   33.46f,   34.60f},
{48.25f,   34.11f,   39.81f,   34.91f,   66.47f,   24.29f,   26.02f,   25.32f,   34.03f,   35.09f,   33.46f,   34.60f},
{60.04f,   38.76f,   29.33f,   34.92f,   39.76f,   28.42f,   8.48f,   5.00f,   37.24f,   40.16f,   34.03f,   34.60f},
{52.36f,   45.63f,   28.29f,   34.92f,   33.46f,   33.46f,   5.38f,   19.59f,   31.05f,   38.13f,   43.68f,   37.70f},
{35.85f,   39.81f,   1.20f,   35.40f,   32.54f,   34.60f,   21.42f,   32.54f,   20.05f,   24.37f,   39.76f,   45.89f},
{32.75f,   29.33f,   32.01f,   40.18f,   32.54f,   34.60f,   32.18f,   34.60f,   20.63f,   16.87f,   23.81f,   40.79f},
{32.17f,   31.43f,   33.06f,   45.18f,   32.54f,   34.60f,   32.75f,   34.60f,   9.45f,   28.43f,   27.27f,   25.91f},
{31.71f,   33.06f,   33.06f,   24.47f,   32.54f,   34.60f,   33.77f,   34.60f,   16.96f,   32.04f,   32.54f,   32.54f},
{31.70f,   33.06f,   33.06f,   12.39f,   32.54f,   34.60f,   33.77f,   34.60f,   32.43f,   33.06f,   33.46f,   34.60f},
{31.70f,   33.06f,   33.06f,   32.87f,   32.54f,   34.60f,   33.76f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.72f,   33.06f,   33.06f,   32.87f,   33.46f,   34.60f,   33.75f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{32.72f,   33.06f,   33.06f,   33.93f,   33.46f,   34.60f,   33.75f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.71f,   33.06f,   33.06f,   33.94f,   33.46f,   34.03f,   33.74f,   33.57f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.70f,   33.06f,   33.06f,   33.94f,   33.46f,   32.08f,   33.73f,   32.54f,   33.57f,   33.06f,   33.46f,   34.60f},
{33.15f,   33.06f,   33.06f,   33.95f,   33.46f,   31.51f,   32.70f,   30.94f,   33.57f,   33.06f,   33.46f,   34.60f},
{34.75f,   34.11f,   34.11f,   33.96f,   34.60f,   30.94f,   30.63f,   28.88f,   33.57f,   32.49f,   33.46f,   34.60f},
{34.75f,   34.11f,   34.11f,   35.01f,   34.60f,   30.48f,   29.02f,   29.91f,   33.57f,   32.04f,   33.57f,   34.60f},
{34.74f,   35.15f,   34.11f,   35.02f,   34.60f,   31.51f,   28.55f,   31.97f,   33.00f,   31.48f,   33.11f,   34.60f},
{34.73f,   36.20f,   34.11f,   35.02f,   34.60f,   31.51f,   30.04f,   33.57f,   32.08f,   31.03f,   32.54f,   34.60f},
{34.73f,   36.20f,   34.11f,   35.03f,   34.60f,   31.51f,   32.09f,   34.60f,   31.51f,   31.03f,   32.54f,   34.60f},
{34.15f,   36.20f,   33.52f,   36.08f,   34.03f,   32.54f,   33.69f,   34.60f,   31.05f,   31.03f,   32.54f,   35.64f},
{33.68f,   36.20f,   33.06f,   36.09f,   33.46f,   33.46f,   33.68f,   34.60f,   30.48f,   31.03f,   33.46f,   36.67f},
{33.10f,   35.62f,   33.06f,   36.10f,   33.46f,   34.60f,   33.68f,   34.60f,   30.48f,   32.04f,   34.60f,   36.67f},
{32.64f,   35.15f,   33.06f,   36.10f,   33.46f,   34.60f,   33.67f,   34.60f,   30.48f,   32.04f,   34.03f,   35.64f},
{32.63f,   34.11f,   33.06f,   36.11f,   33.46f,   34.60f,   33.66f,   34.60f,   31.51f,   33.06f,   33.46f,   35.06f},
{32.63f,   34.11f,   33.06f,   36.12f,   33.46f,   34.60f,   33.66f,   34.60f,   32.43f,   33.06f,   33.46f,   34.60f},
{32.62f,   34.11f,   33.06f,   35.07f,   33.46f,   34.60f,   33.65f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.61f,   34.11f,   33.06f,   35.08f,   33.46f,   34.60f,   33.64f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.61f,   34.11f,   33.06f,   35.09f,   33.46f,   34.60f,   33.64f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{32.60f,   34.11f,   33.06f,   35.09f,   33.46f,   34.60f,   33.63f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.59f,   34.11f,   33.06f,   35.10f,   33.46f,   34.60f,   33.62f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.59f,   34.11f,   33.06f,   35.11f,   33.46f,   34.60f,   33.62f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.58f,   34.11f,   33.06f,   35.11f,   33.46f,   34.60f,   33.61f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.57f,   34.11f,   33.06f,   35.12f,   33.46f,   34.60f,   33.61f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.57f,   34.11f,   33.06f,   35.13f,   33.46f,   34.60f,   33.60f,   34.60f,   33.57f,   33.06f,   33.57f,   34.60f},
{32.56f,   34.11f,   33.06f,   35.13f,   33.46f,   34.60f,   33.59f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.55f,   34.11f,   33.06f,   35.14f,   33.46f,   34.60f,   33.59f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f},
{32.55f,   34.11f,   33.06f,   35.15f,   33.46f,   34.60f,   33.58f,   34.60f,   33.57f,   33.06f,   33.46f,   34.60f }


        };
    }

}
