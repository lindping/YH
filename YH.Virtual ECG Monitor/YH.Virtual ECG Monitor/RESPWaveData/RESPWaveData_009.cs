﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH.ECGMonitor.WaveData.RESPWaveData
{
    public class RESPWaveData_009 : RESPWaveData
    {
        public RESPWaveData_009()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R09";
            Name = "伴有右束支阻滞的窦律";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,12] {
{3.55f,   33.57f,   34.60f,   34.60f,   34.07f,   34.11f,   34.60f,   34.60f,   34.05f,   33.57f,   33.57f,   33.57f },
{3.53f,   33.57f,   34.60f,   34.60f,   34.07f,   34.08f,   34.60f,   34.60f,   34.03f,   33.57f,   33.57f,   33.57f},
{3.50f,   33.57f,   34.60f,   34.60f,   34.07f,   34.06f,   34.60f,   34.60f,   34.00f,   33.57f,   33.57f,   33.57f},
{3.48f,   33.57f,   34.60f,   34.60f,   34.07f,   34.03f,   34.60f,   34.60f,   33.98f,   33.57f,   33.57f,   33.57f},
{3.46f,   33.57f,   34.60f,   34.60f,   34.07f,   34.01f,   34.60f,   34.60f,   33.96f,   33.57f,   33.57f,   33.57f},
{3.43f,   33.57f,   34.60f,   34.60f,   34.07f,   33.99f,   34.60f,   34.60f,   33.93f,   33.57f,   33.57f,   33.57f},
{3.41f,   33.57f,   34.60f,   34.60f,   34.07f,   33.96f,   34.60f,   34.60f,   33.91f,   34.60f,   33.57f,   34.60f},
{3.39f,   33.57f,   34.60f,   34.60f,   34.07f,   33.94f,   34.60f,   34.60f,   33.89f,   35.64f,   33.57f,   35.64f},
{5.42f,   33.57f,   35.06f,   34.60f,   35.09f,   33.92f,   34.60f,   35.64f,   34.32f,   34.03f,   34.60f,   35.06f},
{7.92f,   33.57f,   36.67f,   34.60f,   37.12f,   33.89f,   34.60f,   36.67f,   36.32f,   33.00f,   36.67f,   34.03f},
{8.47f,   33.57f,   37.13f,   35.64f,   37.57f,   34.33f,   36.09f,   36.09f,   37.88f,   32.54f,   37.70f,   33.00f},
{6.84f,   33.57f,   35.64f,   35.64f,   36.10f,   36.40f,   37.70f,   34.60f,   36.28f,   32.54f,   37.13f,   32.54f},
{5.33f,   35.06f,   33.57f,   35.06f,   34.07f,   37.43f,   36.09f,   33.00f,   33.77f,   32.54f,   35.64f,   36.09f},
{3.70f,   36.67f,   31.97f,   33.57f,   34.07f,   35.89f,   34.60f,   32.54f,   32.73f,   34.60f,   33.00f,   50.63f},
{3.22f,   36.09f,   31.51f,   32.54f,   34.07f,   34.24f,   33.57f,   32.54f,   32.71f,   37.00f,   32.54f,   59.81f},
{5.26f,   34.60f,   33.00f,   32.54f,   33.51f,   33.75f,   33.57f,   25.78f,   37.76f,   66.00f,   33.00f,   66.00f},
{0.39f,   34.03f,   30.94f,   33.57f,   40.62f,   33.14f,   33.57f,   1.20f,   42.77f,   21.66f,   36.67f,   42.85f},
{3.20f,   33.57f,   9.59f,   34.60f,   49.19f,   31.61f,   34.03f,   30.48f,   17.86f,   23.26f,   54.20f,   31.51f},
{0.34f,   33.57f,   2.33f,   33.57f,   62.44f,   29.49f,   27.84f,   32.54f,   1.58f,   24.29f,   66.00f,   28.88f},
{3.87f,   35.06f,   24.29f,   19.59f,   45.69f,   25.27f,   1.00f,   32.54f,   27.92f,   23.72f,   47.44f,   27.84f},
{4.11f,   39.19f,   31.97f,   7.07f,   39.15f,   8.19f,   34.60f,   32.54f,   28.46f,   21.66f,   28.42f,   26.81f},
{9.96f,   55.59f,   32.54f,   25.78f,   37.12f,   15.21f,   35.06f,   32.54f,   29.46f,   18.56f,   27.39f,   26.35f},
{8.91f,   31.51f,   33.57f,   27.84f,   35.09f,   27.76f,   35.64f,   33.57f,   29.88f,   16.50f,   25.78f,   25.32f},
{7.85f,   12.07f,   34.60f,   29.91f,   33.51f,   29.37f,   36.67f,   36.09f,   29.41f,   15.47f,   25.32f,   23.26f},
{6.80f,   26.81f,   35.64f,   31.51f,   32.61f,   31.90f,   36.67f,   39.19f,   30.40f,   17.07f,   24.29f,   21.66f},
{6.78f,   28.88f,   36.67f,   32.54f,   31.59f,   33.51f,   38.16f,   40.79f,   32.86f,   23.72f,   19.59f,   22.23f},
{6.18f,   30.48f,   38.73f,   33.57f,   30.01f,   33.49f,   40.22f,   40.79f,   35.88f,   30.48f,   15.47f,   26.35f},
{5.13f,   30.48f,   39.76f,   33.57f,   28.54f,   34.51f,   42.28f,   38.73f,   37.44f,   32.54f,   15.47f,   30.48f},
{4.64f,   29.91f,   39.19f,   33.57f,   27.98f,   34.95f,   42.28f,   36.67f,   37.42f,   33.57f,   20.17f,   32.54f},
{6.11f,   29.45f,   37.70f,   34.60f,   28.99f,   37.02f,   39.19f,   35.64f,   35.82f,   33.57f,   26.35f,   33.57f},
{8.72f,   30.94f,   36.09f,   35.64f,   32.04f,   38.63f,   36.67f,   35.06f,   34.78f,   33.57f,   29.91f,   33.57f},
{1.22f,   33.00f,   35.06f,   36.67f,   34.07f,   40.12f,   35.64f,   34.60f,   33.74f,   33.57f,   31.51f,   33.57f},
{2.80f,   34.60f,   34.60f,   36.67f,   35.09f,   39.05f,   35.06f,   34.60f,   33.26f,   33.57f,   32.54f,   33.57f},
{2.78f,   35.64f,   34.60f,   35.64f,   34.52f,   37.51f,   34.60f,   34.60f,   33.24f,   33.57f,   33.57f,   33.57f},
{3.78f,   35.06f,   34.60f,   35.64f,   34.07f,   35.39f,   34.60f,   34.60f,   33.22f,   33.57f,   33.57f,   33.57f},
{3.19f,   34.03f,   34.60f,   35.64f,   34.07f,   33.74f,   34.60f,   34.60f,   33.20f,   33.57f,   33.57f,   33.57f},
{2.71f,   33.57f,   34.60f,   35.64f,   34.07f,   33.25f,   34.60f,   34.60f,   33.17f,   33.57f,   33.57f,   33.57f},
{2.68f,   33.57f,   34.60f,   35.06f,   34.07f,   33.23f,   34.60f,   34.60f,   33.15f,   33.57f,   33.57f,   33.57f},
{2.66f,   33.57f,   34.60f,   34.60f,   34.07f,   33.20f,   34.60f,   34.60f,   33.13f,   33.57f,   33.57f,   33.57f},
{2.64f,   33.57f,   34.60f,   34.60f,   34.07f,   33.18f,   34.60f,   34.60f,   33.10f,   33.57f,   33.57f,   33.57f},
{2.61f,   33.57f,   34.60f,   34.60f,   34.07f,   33.15f,   34.60f,   34.60f,   33.08f,   33.57f,   33.57f,   33.57f},
{2.59f,   33.57f,   34.60f,   34.60f,   34.07f,   33.13f,   34.60f,   34.60f,   33.06f,   33.57f,   33.57f,   33.57f},
{2.57f,   33.57f,   34.60f,   34.60f,   34.07f,   33.11f,   34.60f,   34.60f,   34.03f,   33.57f,   33.57f,   33.57f},
{32.54f,  33.57f,   34.60f,   34.60f,   34.07f,   33.08f,   34.60f,   34.60f,   34.05f,   33.57f,   33.57f,   33.57f}



        };
    }

}
