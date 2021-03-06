﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH.Virtual_ECG_Monitor
{
    public class WaveData_ECG_030 : WaveData_ECG
    {
        public WaveData_ECG_030()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R30";
            Name = "起搏器心室";
            Remark = "";
            Rate = 80;        
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,12] {
{35.09f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f },
{35.06f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{35.04f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{35.02f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{35.00f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.97f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.95f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.93f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.90f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.88f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.86f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.83f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.81f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.79f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.76f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   50.07f,   33.57f,   33.57f,   1.20f},
{0.93f,   34.07f,   0.20f,   33.57f,   34.07f,   34.07f,   66.00f,   66.00f,   80.00f,   1.20f,   33.57f,   47.72f},
{40.25f,   0.10f,   47.27f,   0.20f,   0.20f,   34.07f,   10.31f,   0.00f,   50.07f,   56.26f,   1.20f,   66.00f},
{49.36f,   36.10f,   58.89f,   57.29f,   37.57f,   66.00f,   1.60f,   10.00f,   53.17f,   66.00f,   53.63f,   47.72f},
{54.42f,   46.71f,   64.53f,   64.97f,   42.19f,   22.34f,   1.03f,   26.96f,   43.31f,   61.88f,   64.51f,   34.52f},
{52.93f,   59.46f,   62.50f,   66.00f,   44.68f,   13.20f,   9.28f,   34.52f,   27.84f,   50.07f,   56.72f,   29.45f},
{48.28f,   63.52f,   54.83f,   63.48f,   45.69f,   9.14f,   26.35f,   35.54f,   15.47f,   38.73f,   37.13f,   28.99f},
{42.16f,   57.43f,   44.23f,   56.26f,   42.19f,   9.70f,   35.64f,   37.57f,   13.98f,   33.57f,   28.42f,   28.43f},
{36.05f,   48.74f,   37.12f,   45.38f,   36.10f,   15.79f,   36.09f,   39.60f,   20.17f,   33.00f,   27.84f,   27.98f},
{32.98f,   43.66f,   34.52f,   39.19f,   32.49f,   23.35f,   37.70f,   41.63f,   26.81f,   32.54f,   27.39f,   27.42f},
{27.43f,   37.57f,   31.03f,   31.51f,   24.37f,   36.10f,   39.19f,   43.66f,   29.45f,   31.97f,   26.81f,   26.96f},
{24.36f,   35.54f,   28.99f,   29.91f,   19.29f,   39.60f,   40.79f,   44.68f,   32.54f,   30.94f,   25.78f,   26.96f},
{22.30f,   35.09f,   25.95f,   27.84f,   17.26f,   40.62f,   42.28f,   42.65f,   33.57f,   29.45f,   25.32f,   28.43f},
{19.69f,   35.09f,   24.37f,   25.78f,   19.86f,   38.58f,   43.89f,   39.15f,   33.57f,   28.42f,   25.32f,   31.03f},
{19.21f,   35.09f,   23.92f,   24.75f,   24.93f,   36.10f,   44.34f,   35.54f,   34.60f,   28.42f,   25.32f,   33.06f},
{22.23f,   36.10f,   26.40f,   24.29f,   28.99f,   35.09f,   40.79f,   34.07f,   34.03f,   29.91f,   27.84f,   33.51f},
{27.29f,   36.10f,   30.01f,   26.81f,   31.48f,   35.09f,   37.13f,   34.07f,   32.54f,   31.51f,   30.94f,   34.07f},
{31.33f,   35.09f,   32.04f,   30.48f,   33.06f,   34.52f,   35.06f,   34.07f,   31.97f,   32.54f,   32.54f,   34.07f},
{33.33f,   34.07f,   33.06f,   32.54f,   34.07f,   34.07f,   34.60f,   34.07f,   34.03f,   33.57f,   33.57f,   34.07f},
{34.33f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   34.60f,   33.57f,   33.57f,   34.07f},
{34.30f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.28f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.26f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.23f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.21f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.19f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.16f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.14f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.12f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},
{34.10f,   34.07f,   33.06f,   33.57f,   34.07f,   34.07f,   34.60f,   34.07f,   33.57f,   33.57f,   33.57f,   34.07f},


        };
    }

}
