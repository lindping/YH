﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH.ECGMonitor.WaveData.RESPWaveData
{
    public class RESPWaveData_016 : RESPWaveData
    {
        public RESPWaveData_016()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R16";
            Name = "二度Ⅰ型房室传导阻滞";
            Remark = "";
            Rate = 8;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,18] {
{33.57f,   33.57f,   33.57f,   33.57f,   34.07f,   34.60f,   34.60f,   34.60f,   34.60f,   33.06f,   34.07f,   33.06f,   34.11f , 32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   33.57f,   33.57f,   33.00f,   34.07f,   34.60f,   34.60f,   34.60f,   34.60f,   33.06f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   33.00f,   33.00f,   32.54f,   34.07f,   34.60f,   34.60f,   34.60f,   34.60f,   33.06f,   33.51f,   32.49f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   32.54f,   32.54f,   32.54f,   34.07f,   34.60f,   34.60f,   35.64f,   34.60f,   32.49f,   32.49f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   32.54f,   32.54f,   32.54f,   35.09f,   34.60f,   35.64f,   35.64f,   35.64f,   32.04f,   32.04f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   32.54f,   32.54f,   31.97f,   35.09f,   34.60f,   35.64f,   35.64f,   35.64f,   32.04f,   32.04f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{34.03f,   31.97f,   32.54f,   31.51f,   35.09f,   34.60f,   35.64f,   35.06f,   36.09f,   32.04f,   31.48f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{35.06f,   31.51f,   33.00f,   31.51f,   35.09f,   34.03f,   35.64f,   35.06f,   38.73f,   32.04f,   31.03f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{36.67f,   31.51f,   34.60f,   31.97f,   35.09f,   31.97f,   35.64f,   36.67f,   40.79f,   33.06f,   31.03f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{37.70f,   32.54f,   35.06f,   33.00f,   35.09f,   31.51f,   35.64f,   37.70f,   36.67f,   35.54f,   32.49f,   32.04f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{36.67f,   35.64f,   33.57f,   32.54f,   35.54f,   31.51f,   36.67f,   36.09f,   35.64f,   36.55f,   35.09f,   32.49f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{34.60f,   37.70f,   32.54f,   32.54f,   38.13f,   32.54f,   34.03f,   35.06f,   35.64f,   35.54f,   36.55f,   34.07f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   38.16f,   32.54f,   32.54f,   38.13f,   33.57f,   33.57f,   34.60f,   35.64f,   34.52f,   36.55f,   35.54f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   35.64f,   33.57f,   32.54f,   36.55f,   34.60f,   33.57f,   34.60f,   35.06f,   33.51f,   35.54f,   36.55f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   34.03f,   33.57f,   33.57f,   34.52f,   34.60f,   33.57f,   34.60f,   34.60f,   33.06f,   34.52f,   35.09f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{35.64f,   33.57f,   33.00f,   33.57f,   34.07f,   34.60f,   33.57f,   35.64f,   34.60f,   33.06f,   34.07f,   33.51f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{43.31f,   33.57f,   31.97f,   33.57f,   34.07f,   34.60f,   34.60f,   40.22f,   34.60f,   32.49f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{53.56f,   33.57f,   34.60f,   31.51f,   34.07f,   30.48f,   34.60f,   35.06f,   35.64f,   36.55f,   34.07f,   33.06f,   34.11f,  33.57f,   33.06f,   34.60f,   33.06f,   34.07f},
{45.38f,   34.60f,   49.50f,   28.42f,   36.10f,   16.50f,   34.60f,   14.44f,   45.95f,   66.00f,   34.52f,   32.49f,   35.62f,  34.03f,   33.06f,   34.60f,   33.06f,   34.07f},
{29.45f,   48.01f,   57.29f,   37.70f,   40.16f,   6.19f,   34.60f,   1.40f,   55.23f,   48.74f,   45.69f,   30.46f,   37.25f,  32.54f,   33.06f,   34.03f,   34.11f,   34.52f},
{24.29f,   62.39f,   46.98f,   54.66f,   42.65f,   21.66f,   28.42f,   16.50f,   45.38f,   30.46f,   66.89f,   43.66f,   38.30f,  31.51f,   32.49f,   31.97f,   34.11f,   36.10f},
{28.88f,   57.32f,   39.19f,   60.84f,   40.62f,   35.06f,   11.92f,   33.00f,   25.78f,   30.46f,   45.24f,   66.38f,   37.25f,  31.51f,   32.04f,   31.51f,   34.11f,   37.12f},
{30.48f,   51.10f,   37.70f,   55.69f,   32.04f,   39.19f,   6.76f,   37.70f,   20.72f,   31.48f,   29.45f,   39.60f,   36.20f,  31.97f,   32.04f,   31.51f,   33.52f,   35.54f},
{31.97f,   36.67f,   36.09f,   39.19f,   28.43f,   39.19f,   10.31f,   40.22f,   26.81f,   34.07f,   31.48f,   30.46f,   34.57f,  32.54f,   32.04f,   32.54f,   33.06f,   35.54f},
{32.54f,   29.45f,   35.06f,   33.57f,   23.92f,   36.09f,   19.14f,   41.82f,   33.57f,   34.52f,   33.51f,   32.49f,   34.11f,  32.54f,   32.04f,   33.57f,   33.06f,   34.52f},
{32.54f,   30.48f,   34.60f,   33.57f,   27.98f,   34.03f,   25.32f,   43.31f,   35.64f,   35.09f,   34.07f,   33.06f,   34.11f,  32.54f,   32.04f,   34.60f,   33.06f,   34.07f},
{33.57f,   31.51f,   34.03f,   33.57f,   32.04f,   33.57f,   30.48f,   44.92f,   37.13f,   36.10f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   31.97f,   33.57f,   33.57f,   34.07f,   33.00f,   34.03f,   45.95f,   37.70f,   36.10f,   35.09f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{34.60f,   32.54f,   33.57f,   33.57f,   35.54f,   32.54f,   35.06f,   47.44f,   38.73f,   37.12f,   35.09f,   34.07f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{35.64f,   32.54f,   33.00f,   33.57f,   36.10f,   31.97f,   35.64f,   49.04f,   38.73f,   38.13f,   35.09f,   34.07f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{37.13f,   33.57f,   32.54f,   34.60f,   36.10f,   30.94f,   35.64f,   50.53f,   39.76f,   39.15f,   36.10f,   34.07f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{39.19f,   33.57f,   32.54f,   34.60f,   35.54f,   29.91f,   35.64f,   52.59f,   41.25f,   40.62f,   37.12f,   35.09f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{41.82f,   34.03f,   31.97f,   34.60f,   35.09f,   28.42f,   35.64f,   54.20f,   43.31f,   42.65f,   38.13f,   36.10f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{43.89f,   34.60f,   31.51f,   34.60f,   36.10f,   26.81f,   35.06f,   52.14f,   45.38f,   44.68f,   39.15f,   37.12f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{42.85f,   36.09f,   30.94f,   35.06f,   36.55f,   24.75f,   34.03f,   48.01f,   46.98f,   46.26f,   40.62f,   38.58f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{38.73f,   38.16f,   31.97f,   35.64f,   38.58f,   24.29f,   33.00f,   42.85f,   48.47f,   44.68f,   42.19f,   40.62f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{35.64f,   39.76f,   33.57f,   36.67f,   40.16f,   26.81f,   31.97f,   38.73f,   48.47f,   42.65f,   42.65f,   41.18f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{34.03f,   39.76f,   34.60f,   36.67f,   40.16f,   30.48f,   30.94f,   37.13f,   44.92f,   38.58f,   39.60f,   39.15f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   38.16f,   35.64f,   36.67f,   39.15f,   33.00f,   30.48f,   36.09f,   40.79f,   36.10f,   36.55f,   36.55f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   35.64f,   35.64f,   36.09f,   37.12f,   33.57f,   31.51f,   35.64f,   37.70f,   34.52f,   35.09f,   34.52f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   34.03f,   35.64f,   35.06f,   35.09f,   33.57f,   33.57f,   35.06f,   36.09f,   34.07f,   34.52f,   33.51f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   33.57f,   35.06f,   34.60f,   34.07f,   33.57f,   34.60f,   34.60f,   35.64f,   33.06f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   33.57f,   34.60f,   34.03f,   34.07f,   33.57f,   34.60f,   34.60f,   35.64f,   33.06f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f},
{33.57f,   33.57f,   34.60f,   33.57f,   34.07f,   33.57f,   34.60f,   34.60f,   35.64f,   33.06f,   34.07f,   33.06f,   34.11f,  32.54f,   33.06f,   34.60f,   33.06f,   34.07f}

        };
    }

}
