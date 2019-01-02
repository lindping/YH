﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH.Simulator.Framework;
namespace YH.Virtual_ECG_Monitor
{
    public class Wave_RESP_022 : Wave_RESP
    {
        public Wave_RESP_022()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R22";
            Name = "心房扑动（AF）";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[42,12] {
{ 2.54f,   36.55f,   30.01f,   34.03f,   32.54f,   30.01f,   28.99f,   31.03f,   33.06f,   35.54f,   35.09f,   32.49f },
{ 3.48f,   35.54f,   31.00f,   33.57f,   32.54f,   30.01f,   30.01f,   31.03f,   33.06f,   34.52f,   34.52f,   32.49f},
{ 6.14f,   34.52f,   32.44f,   32.54f,   33.57f,   30.01f,   30.01f,   31.03f,   33.06f,   33.51f,   33.51f,   30.46f},
{ 7.20f,   33.51f,   35.46f,   31.97f,   33.57f,   31.48f,   30.01f,   32.49f,   34.07f,   33.06f,   32.49f,   30.01f},
{ 8.83f,   32.49f,   37.47f,   30.94f,   33.57f,   33.51f,   30.01f,   33.51f,   34.07f,   31.48f,   32.04f,   31.03f},
{ 8.28f,   31.48f,   36.43f,   29.91f,   33.57f,   34.52f,   30.01f,   32.04f,   33.06f,   31.03f,   32.04f,   32.04f},
{ 6.82f,   30.46f,   35.39f,   28.88f,   34.60f,   33.06f,   32.04f,   30.46f,   32.49f,   32.04f,   32.04f,   33.51f},
{ 5.24f,   30.01f,   34.35f,   28.42f,   34.60f,   32.04f,   33.06f,   30.01f,   32.04f,   34.52f,   32.04f,   35.54f},
{ 4.23f,   31.03f,   33.87f,   28.42f,   34.60f,   32.04f,   30.46f,   30.01f,   31.48f,   36.10f,   33.51f,   35.09f},
{ 3.23f,   34.07f,   32.83f,   30.48f,   34.03f,   33.06f,   29.45f,   30.01f,   30.46f,   37.12f,   35.09f,   34.52f},
{ 2.79f,   36.10f,   32.24f,   33.00f,   32.54f,   34.07f,   28.99f,   29.45f,   29.45f,   37.12f,   35.09f,   33.51f},
{ 2.36f,   35.54f,   32.22f,   35.06f,   31.51f,   34.07f,   30.01f,   28.99f,   28.99f,   36.10f,   34.52f,   32.49f},
{ 1.81f,   34.52f,   34.23f,   35.64f,   32.54f,   35.09f,   30.01f,   31.03f,   30.46f,   35.54f,   34.07f,   31.48f},
{ 3.33f,   33.51f,   31.72f,   34.03f,   33.57f,   35.09f,   30.01f,   33.51f,   36.55f,   34.52f,   33.51f,   30.46f},
{ 5.99f,   32.04f,   18.57f,   32.54f,   33.57f,   35.54f,   30.01f,   25.38f,   44.62f,   33.51f,   32.49f,   30.01f},
{ 8.08f,   31.03f,   29.64f,   30.94f,   33.57f,   34.52f,   31.03f,   12.75f,   14.84f,   33.06f,   31.48f,   33.51f},
{ 8.56f,   30.46f,   33.68f,   29.91f,   33.57f,   34.07f,   34.07f,   20.31f,   27.98f,   33.06f,   31.03f,   51.33f},
{ 7.55f,   30.01f,   33.65f,   28.42f,   33.57f,   33.06f,   25.95f,   31.48f,   33.06f,   38.58f,   33.06f,   58.82f},
{ 7.12f,   33.06f,   33.06f,   27.39f,   33.57f,   32.04f,   15.83f,   33.06f,   34.07f,   66.00f,   66.75f,   34.52f},
{ 6.57f,   41.18f,   32.02f,   30.48f,   34.03f,   32.04f,   25.95f,   33.06f,   33.51f,   22.98f,   47.72f,   33.06f},
{ 6.14f,   45.63f,   31.55f,   34.60f,   40.22f,   32.04f,   30.01f,   33.06f,   32.49f,   33.51f,   27.42f,   33.06f},
{ 6.16f,   31.48f,   31.52f,   36.57f,   44.28f,   32.04f,   31.03f,   33.06f,   32.49f,   36.10f,   28.99f,   32.49f},
{ 6.19f,   33.06f,   32.96f,   22.32f,   36.09f,   32.49f,   31.03f,   33.06f,   32.04f,   36.10f,   34.07f,   32.04f},
{ 6.67f,   34.07f,   35.98f,   27.39f,   34.03f,   33.06f,   31.03f,   34.52f,   32.04f,   35.54f,   33.51f,   32.04f},
{ 3.98f,   34.52f,   35.96f,   30.94f,   33.57f,   34.07f,   32.04f,   36.55f,   33.06f,   35.09f,   33.06f,   32.04f},
{ 2.09f,   33.51f,   34.92f,   31.51f,   33.57f,   35.09f,   32.49f,   38.58f,   35.54f,   35.09f,   32.49f,   32.49f},
{ 7.32f,   32.04f,   33.88f,   30.94f,   34.60f,   35.54f,   34.52f,   39.60f,   37.12f,   37.12f,   32.04f,   34.07f},
{ 8.95f,   31.03f,   33.40f,   29.45f,   34.60f,   33.51f,   34.52f,   37.57f,   38.13f,   39.15f,   33.51f,   35.54f},
{ 0.01f,   33.06f,   33.38f,   28.42f,   34.60f,   22.40f,   32.49f,   35.09f,   37.12f,   40.16f,   35.09f,   37.12f},
{ 9.00f,   36.55f,   32.79f,   29.45f,   34.03f,   28.43f,   32.04f,   34.52f,   35.09f,   41.18f,   36.10f,   38.58f},
{ 7.88f,   38.58f,   31.75f,   32.54f,   33.00f,   35.09f,   31.48f,   34.07f,   33.51f,   41.63f,   37.12f,   40.16f},
{ 5.84f,   38.13f,   32.29f,   34.60f,   32.54f,   33.51f,   31.03f,   33.51f,   32.49f,   41.63f,   38.13f,   40.16f},
{ 5.41f,   38.13f,   34.75f,   34.60f,   33.57f,   33.06f,   31.03f,   33.06f,   32.04f,   40.62f,   39.15f,   36.55f},
{ 6.92f,   38.13f,   36.30f,   34.03f,   34.60f,   34.07f,   31.03f,   34.07f,   33.51f,   38.13f,   39.15f,   33.06f},
{ 8.55f,   37.57f,   35.71f,   33.57f,   35.64f,   35.09f,   31.03f,   35.54f,   35.54f,   36.10f,   37.12f,   31.48f},
{ 0.18f,   36.10f,   34.67f,   33.00f,   35.06f,   35.09f,   31.03f,   37.12f,   37.12f,   35.09f,   35.09f,   33.06f},
{ 9.63f,   33.51f,   33.63f,   31.97f,   34.60f,   34.07f,   32.49f,   36.10f,   36.55f,   36.10f,   33.51f,   35.54f},
{ 7.60f,   31.48f,   32.59f,   30.48f,   34.60f,   32.49f,   32.04f,   34.07f,   35.54f,   37.12f,   33.51f,   36.10f},
{ 4.99f,   34.07f,   31.55f,   28.88f,   34.60f,   31.48f,   30.01f,   32.49f,   34.52f,   36.55f,   35.09f,   35.54f},
{ 4.21f,   36.55f,   31.08f,   29.91f,   33.57f,   31.03f,   28.99f,   32.04f,   33.51f,   35.54f,   35.09f,   34.52f},
{ 3.43f,   36.55f,   30.49f,   33.00f,   32.54f,   30.46f,   28.99f,   31.48f,   33.06f,   35.54f,   35.09f,   33.51f},
{33.43f,   36.55f,   30.01f,   34.03f,   32.54f,   30.01f,   28.99f,   31.03f,   33.06f,   35.54f,   35.09f,   32.49f},

        };
    }

}