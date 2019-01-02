﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH.Virtual_ECG_Monitor
{
    public class Wave_RESP_014 : Wave_RESP
    {
        public Wave_RESP_014()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R14";
            Name = "延长QT时间的窦律";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,12] {
{34.60f,   32.94f,   32.49f,   35.64f,   34.60f,   30.48f,   29.45f,   54.71f,   47.44f,   47.44f,   42.26f,   41.82f },
{34.60f,   32.94f,   32.04f,   35.64f,   34.60f,   32.52f,   29.91f,   53.63f,   46.98f,   45.95f,   39.25f,   41.82f},
{34.60f,   32.94f,   31.48f,   36.67f,   34.60f,   33.53f,   30.94f,   52.59f,   45.38f,   43.89f,   36.60f,   40.68f},
{34.60f,   32.94f,   31.48f,   36.67f,   35.06f,   33.50f,   32.54f,   49.50f,   40.79f,   40.79f,   35.08f,   38.16f},
{34.60f,   32.94f,   32.04f,   37.13f,   35.64f,   33.48f,   33.57f,   44.92f,   37.70f,   37.70f,   33.34f,   37.13f},
{36.09f,   34.57f,   33.51f,   36.67f,   37.70f,   34.49f,   33.57f,   40.22f,   36.09f,   36.09f,   33.32f,   35.06f},
{38.16f,   36.20f,   35.09f,   36.09f,   36.67f,   34.46f,   33.57f,   39.19f,   35.06f,   34.60f,   33.41f,   33.57f},
{37.13f,   35.74f,   35.54f,   34.49f,   35.06f,   33.41f,   33.57f,   36.09f,   34.03f,   34.60f,   33.27f,   33.57f},
{36.67f,   33.52f,   35.54f,   33.46f,   34.60f,   30.29f,   33.57f,   34.60f,   33.57f,   34.60f,   33.25f,   33.57f},
{34.49f,   32.59f,   34.52f,   33.46f,   34.60f,   28.21f,   33.57f,   34.60f,   33.57f,   34.60f,   34.83f,   33.57f},
{33.46f,   31.54f,   34.07f,   33.46f,   34.60f,   29.21f,   33.57f,   34.60f,   33.57f,   35.06f,   35.84f,   33.57f},
{32.54f,   30.96f,   34.07f,   33.46f,   35.06f,   30.68f,   33.00f,   34.60f,   33.57f,   37.13f,   36.84f,   34.60f},
{32.54f,   29.33f,   34.07f,   33.11f,   36.09f,   32.72f,   31.97f,   34.60f,   35.06f,   37.70f,   35.33f,   35.64f},
{37.13f,   36.67f,   34.52f,   33.11f,   40.33f,   33.27f,   30.94f,   35.64f,   35.64f,   36.67f,   34.73f,   37.13f},
{46.52f,   52.96f,   36.55f,   32.08f,   42.85f,   34.28f,   30.48f,   37.70f,   36.09f,   35.06f,   33.11f,   36.09f},
{56.25f,   62.86f,   36.10f,   31.51f,   42.28f,   34.25f,   30.48f,   37.70f,   34.60f,   34.60f,   33.20f,   35.06f},
{44.34f,   58.20f,   34.52f,   31.51f,   41.25f,   34.23f,   30.48f,   35.64f,   33.57f,   34.60f,   32.14f,   34.03f},
{30.94f,   50.46f,   34.07f,   32.54f,   34.03f,   35.24f,   31.51f,   35.06f,   33.57f,   34.60f,   31.09f,   33.57f},
{25.78f,   45.05f,   33.51f,   33.11f,   28.29f,   27.42f,   32.54f,   34.60f,   33.57f,   34.03f,   38.17f,   33.00f},
{26.35f,   33.52f,   32.49f,   32.54f,   21.26f,   14.57f,   30.94f,   34.60f,   33.57f,   37.13f,   48.69f,   33.00f},
{30.36f,   28.87f,   31.48f,   32.54f,   26.81f,   4.69f,   20.63f,   36.09f,   40.79f,   46.98f,   60.92f,   31.05f},
{32.54f,   29.92f,   30.46f,   29.91f,   30.48f,   12.91f,   10.01f,   37.70f,   44.34f,   66.00f,   66.80f,   43.44f},
{33.57f,   30.96f,   30.01f,   27.84f,   33.00f,   28.93f,   3.73f,   41.25f,   55.63f,   39.19f,   57.76f,   50.53f},
{33.57f,   32.01f,   36.55f,   30.02f,   34.60f,   35.55f,   6.76f,   38.73f,   50.07f,   29.45f,   38.03f,   66.00f},
{34.60f,   32.01f,   52.35f,   44.46f,   35.64f,   38.17f,   10.89f,   31.51f,   41.82f,   31.97f,   28.27f,   40.22f},
{34.60f,   32.94f,   58.86f,   63.63f,   36.67f,   39.17f,   20.17f,   19.59f,   23.72f,   33.57f,   30.30f,   33.46f},
{34.60f,   32.94f,   51.78f,   39.76f,   36.67f,   35.48f,   26.35f,   1.20f,   18.20f,   35.64f,   31.89f,   32.08f},
{34.60f,   32.94f,   42.19f,   33.46f,   36.67f,   33.97f,   30.94f,   33.57f,   27.84f,   35.64f,   32.89f,   33.57f},
{35.64f,   34.11f,   39.15f,   33.46f,   36.67f,   33.38f,   31.97f,   39.76f,   31.51f,   36.67f,   32.87f,   33.57f},
{36.67f,   34.11f,   37.57f,   33.46f,   35.64f,   32.89f,   33.57f,   40.22f,   34.03f,   36.67f,   32.85f,   33.57f},
{38.16f,   34.11f,   36.55f,   33.46f,   35.64f,   32.30f,   34.60f,   41.82f,   35.64f,   37.70f,   33.74f,   33.57f},
{40.33f,   35.15f,   35.54f,   33.46f,   36.67f,   31.81f,   34.60f,   42.85f,   36.67f,   37.70f,   33.72f,   34.03f},
{42.28f,   36.67f,   35.09f,   33.46f,   36.67f,   31.79f,   34.60f,   42.85f,   36.67f,   37.70f,   33.81f,   34.60f},
{43.31f,   37.25f,   34.52f,   33.46f,   38.16f,   31.20f,   34.60f,   44.34f,   37.70f,   38.73f,   33.67f,   34.60f},
{44.92f,   38.30f,   34.07f,   33.46f,   39.30f,   30.14f,   34.60f,   45.38f,   37.70f,   39.76f,   34.79f,   34.60f},
{44.34f,   39.34f,   34.07f,   34.60f,   40.68f,   30.12f,   34.60f,   46.41f,   37.70f,   40.79f,   34.77f,   34.60f},
{41.25f,   39.34f,   34.07f,   34.60f,   41.25f,   29.06f,   34.60f,   47.44f,   38.73f,   41.25f,   35.78f,   35.64f},
{38.27f,   37.83f,   33.51f,   34.60f,   40.33f,   26.98f,   34.03f,   49.04f,   39.76f,   42.85f,   35.75f,   36.09f},
{36.09f,   35.15f,   33.06f,   34.60f,   39.30f,   25.92f,   33.00f,   50.53f,   41.25f,   44.34f,   37.22f,   37.13f},
{35.06f,   33.52f,   33.06f,   34.60f,   37.70f,   24.87f,   33.00f,   52.59f,   42.28f,   46.41f,   37.77f,   38.27f},
{34.60f,   32.94f,   33.06f,   34.60f,   35.64f,   23.81f,   31.97f,   53.17f,   43.89f,   46.98f,   39.35f,   39.65f},
{34.60f,   33.06f,   32.49f,   34.60f,   35.06f,   23.79f,   30.94f,   54.66f,   45.38f,   47.44f,   40.70f,   41.25f},
{34.60f,   32.94f,   32.04f,   34.60f,   34.60f,   26.40f,   30.48f,   54.71f,   46.98f,   47.44f,   41.82f,   41.82f},
{34.60f,   32.94f,   31.48f,   34.60f,   34.60f,   27.87f,   29.91f,   54.71f,   47.44f,   47.44f,   42.26f,   41.82f},


        };
    }

}
