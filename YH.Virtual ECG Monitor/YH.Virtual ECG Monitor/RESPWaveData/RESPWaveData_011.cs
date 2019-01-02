﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

YH.Virtual_ECG_Monitor.WaveData.RESPWaveData
{
    public class RESPWaveData_011 : RESPWaveData
    {
        public RESPWaveData_011()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R11";
            Name = "高血钾的窦律";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,12] {
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.06f,   34.60f,   33.06f,   33.57f } ,
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.08f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.11f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   33.13f,   34.60f,   33.06f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   33.15f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   33.18f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   34.69f,   33.67f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   34.11f,   34.27f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   32.54f,   34.60f,   34.11f,   34.30f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   35.54f,   33.57f,   30.94f,   34.60f,   34.11f,   33.74f,   34.60f,   35.09f,   35.06f},
{34.60f,   35.54f,   35.06f,   37.12f,   33.57f,   30.48f,   34.60f,   34.11f,   35.86f,   35.18f,   35.54f,   36.67f},
{34.60f,   37.12f,   37.13f,   36.10f,   35.06f,   31.51f,   35.06f,   34.11f,   36.46f,   37.13f,   33.51f,   35.06f},
{36.09f,   37.57f,   37.13f,   34.07f,   37.13f,   33.00f,   36.09f,   34.69f,   34.39f,   36.09f,   33.06f,   33.57f},
{37.70f,   36.10f,   35.06f,   35.09f,   35.64f,   34.03f,   37.70f,   36.67f,   33.37f,   34.60f,   34.07f,   33.57f},
{37.13f,   34.52f,   34.60f,   35.09f,   33.57f,   35.64f,   36.67f,   37.71f,   32.81f,   34.60f,   34.52f,   33.57f},
{34.60f,   35.09f,   35.06f,   35.09f,   34.60f,   35.06f,   34.60f,   35.15f,   32.37f,   34.60f,   47.65f,   40.22f},
{34.60f,   37.01f,   36.67f,   30.01f,   36.67f,   30.94f,   33.57f,   34.11f,   32.39f,   35.64f,   38.13f,   54.44f},
{35.64f,   41.07f,   35.06f,   21.32f,   40.22f,   21.66f,   33.57f,   34.11f,   26.60f,   30.94f,   21.32f,   29.45f},
{41.82f,   49.75f,   25.78f,   10.72f,   48.01f,   8.38f,   34.60f,   34.11f,   15.09f,   19.59f,   10.20f,   19.14f},
{62.59f,   56.80f,   12.38f,   6.66f,   64.78f,   12.95f,   33.57f,   35.62f,   6.27f,   9.85f,   17.26f,   12.01f},
{36.67f,   41.63f,   2.64f,   19.29f,   46.41f,   24.75f,   30.48f,   31.54f,   1.52f,   4.13f,   27.42f,   21.20f},
{30.94f,   29.90f,   13.41f,   29.45f,   31.97f,   31.97f,   21.66f,   18.39f,   13.65f,   16.04f,   31.03f,   30.94f},
{29.45f,   22.87f,   17.53f,   31.03f,   28.42f,   32.54f,   12.95f,   6.05f,   28.34f,   30.36f,   31.03f,   32.54f},
{31.97f,   32.61f,   33.57f,   31.03f,   30.94f,   32.54f,   22.69f,   1.16f,   32.56f,   31.51f,   31.03f,   32.54f},
{33.57f,   32.04f,   35.64f,   32.04f,   32.54f,   32.54f,   31.51f,   16.30f,   33.63f,   32.54f,   32.04f,   33.57f},
{33.57f,   32.04f,   35.64f,   33.06f,   32.54f,   33.00f,   33.57f,   34.11f,   33.65f,   33.46f,   33.06f,   33.57f},
{33.57f,   33.06f,   36.09f,   36.55f,   32.54f,   29.45f,   33.57f,   34.11f,   35.77f,   34.03f,   34.52f,   34.60f},
{36.09f,   37.12f,   37.70f,   40.62f,   30.48f,   26.81f,   33.57f,   35.15f,   38.94f,   36.55f,   39.60f,   38.16f},
{39.76f,   41.07f,   40.79f,   42.19f,   26.81f,   26.35f,   34.60f,   36.20f,   41.52f,   39.76f,   43.21f,   42.28f},
{41.82f,   42.08f,   43.31f,   41.18f,   25.32f,   26.81f,   38.16f,   37.25f,   43.18f,   42.28f,   40.16f,   42.85f},
{41.25f,   40.62f,   42.85f,   39.15f,   26.35f,   29.45f,   41.82f,   40.86f,   41.11f,   42.28f,   35.09f,   40.22f},
{39.76f,   39.60f,   40.79f,   37.12f,   27.84f,   31.97f,   41.25f,   44.00f,   36.36f,   39.76f,   32.49f,   36.09f},
{37.70f,   37.12f,   38.73f,   35.09f,   30.94f,   33.57f,   38.16f,   42.95f,   34.29f,   37.13f,   32.04f,   34.03f},
{36.09f,   35.54f,   36.67f,   33.06f,   33.57f,   33.00f,   35.64f,   37.83f,   33.26f,   35.64f,   31.48f,   33.57f},
{35.64f,   34.07f,   35.06f,   33.06f,   34.03f,   32.54f,   35.06f,   35.15f,   32.82f,   34.60f,   32.04f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.89f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.92f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.94f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.96f,   34.60f,   33.06f,   33.57f},
{35.64f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   33.99f,   34.60f,   33.06f,   33.57f},
{34.60f,   34.07f,   34.60f,   33.06f,   33.57f,   33.57f,   34.60f,   35.15f,   34.01f,   34.60f,   33.06f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   34.03f,   34.60f,   33.06f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   34.06f,   34.60f,   34.07f,   33.57f},
{34.60f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   34.60f,   35.15f,   34.08f,   34.60f,   34.07f,   33.57f}


        };
    }

}
