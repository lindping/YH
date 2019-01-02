﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH.Simulator.Framework;
namespace YH.Virtual_ECG_Monitor
{
    public class Wave_RESP_006 : Wave_RESP
    {
        public Wave_RESP_006()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R06";
            Name = "有前壁急性心肌梗死的窦律，迟";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[44,12] {
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   36.20f,   34.58f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.03f,   34.60f,   34.60f,   33.46f,   36.20f,   34.56f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.03f,   34.60f,   34.60f,   33.46f,   35.62f,   34.53f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   34.51f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   34.49f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   34.46f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   34.44f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.03f,   33.46f,   34.57f,   34.42f,   34.60f,   34.60f,   33.59f,   35.64f },
{33.57f,   34.60f,   34.60f,   34.60f,   33.46f,   32.54f,   33.52f,   34.39f,   35.06f,   34.60f,   33.59f,   36.67f },
{34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   32.08f,   33.06f,   34.37f,   36.67f,   34.60f,   34.66f,   36.09f },
{35.64f,   35.64f,   34.60f,   35.06f,   33.57f,   31.51f,   33.52f,   35.38f,   37.13f,   35.64f,   34.66f,   35.06f },
{35.06f,   36.67f,   35.64f,   35.64f,   33.46f,   32.54f,   35.15f,   34.78f,   36.09f,   36.67f,   34.66f,   34.60f },
{34.03f,   37.13f,   35.64f,   35.64f,   33.46f,   33.46f,   35.15f,   34.30f,   35.64f,   37.70f,   34.06f,   34.03f },
{33.57f,   36.09f,   34.60f,   35.06f,   34.60f,   33.46f,   35.15f,   34.28f,   35.64f,   37.13f,   33.59f,   30.94f },
{31.51f,   35.06f,   34.60f,   34.03f,   34.60f,   33.46f,   34.57f,   33.68f,   35.06f,   36.09f,   33.59f,   25.32f },
{26.81f,   34.60f,   34.60f,   33.57f,   34.03f,   34.60f,   31.43f,   32.17f,   29.91f,   35.06f,   31.46f,   66.00f },
{41.25f,   32.54f,   34.60f,   33.57f,   33.11f,   26.81f,   19.90f,   26.41f,   11.92f,   34.60f,   38.32f,   40.79f },
{65.94f,   28.42f,   36.09f,   34.03f,   32.54f,   15.47f,   9.43f,   20.16f,   3.20f,   34.03f,   55.10f,   30.48f },
{46.98f,   38.16f,   41.19f,   37.13f,   32.08f,   21.66f,   17.81f,   4.20f,   26.35f,   22.23f,   30.20f,   33.57f },
{27.39f,   50.01f,   28.88f,   40.73f,   35.64f,   32.08f,   26.19f,   28.96f,   33.00f,   13.41f,   18.88f,   34.60f },
{30.94f,   39.19f,   20.75f,   29.91f,   55.50f,   34.03f,   31.43f,   33.06f,   34.60f,   21.20f,   30.40f,   35.64f },
{33.00f,   33.00f,   32.54f,   26.42f,   42.50f,   33.46f,   33.52f,   33.49f,   35.64f,   27.39f,   33.59f,   35.64f },
{34.03f,   32.54f,   34.60f,   30.94f,   31.40f,   33.00f,   35.15f,   35.53f,   35.64f,   31.97f,   34.66f,   35.64f },
{34.60f,   32.54f,   36.09f,   31.97f,   28.57f,   32.54f,   35.15f,   36.08f,   35.64f,   33.57f,   34.66f,   34.60f },
{34.60f,   33.57f,   35.64f,   33.57f,   31.51f,   32.54f,   35.62f,   35.48f,   35.64f,   35.64f,   35.72f,   31.97f },
{34.60f,   34.60f,   35.64f,   34.60f,   32.54f,   32.54f,   34.57f,   33.40f,   35.06f,   36.67f,   35.13f,   26.81f },
{33.57f,   34.60f,   35.64f,   34.60f,   33.46f,   32.08f,   34.11f,   31.89f,   33.00f,   36.09f,   34.06f,   23.72f },
{30.94f,   34.60f,   35.64f,   34.60f,   34.60f,   30.94f,   35.15f,   31.86f,   30.94f,   34.60f,   31.46f,   23.26f },
{25.78f,   33.57f,   35.64f,   35.64f,   35.06f,   29.91f,   36.20f,   31.84f,   29.91f,   31.97f,   27.68f,   25.78f },
{22.69f,   30.48f,   36.67f,   36.67f,   34.60f,   29.45f,   37.25f,   32.85f,   29.45f,   28.88f,   24.48f,   30.48f },
{22.23f,   28.42f,   36.67f,   37.70f,   34.03f,   29.45f,   37.71f,   33.85f,   30.94f,   26.35f,   22.95f,   33.57f },
{24.75f,   28.88f,   37.70f,   37.70f,   33.11f,   31.51f,   36.67f,   33.83f,   32.54f,   25.32f,   23.42f,   34.60f },
{29.45f,   30.94f,   37.13f,   37.13f,   32.54f,   33.46f,   35.62f,   34.27f,   34.03f,   26.81f,   26.14f,   34.60f },
{32.54f,   33.00f,   36.09f,   36.09f,   32.54f,   34.60f,   35.15f,   33.78f,   34.60f,   30.48f,   29.81f,   34.60f },
{33.57f,   34.60f,   35.06f,   35.06f,   32.54f,   34.60f,   35.15f,   33.76f,   34.60f,   32.54f,   32.53f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   33.46f,   34.60f,   35.15f,   33.74f,   34.60f,   33.57f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   34.03f,   36.20f,   33.71f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   36.20f,   33.69f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   36.20f,   33.67f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.03f,   34.60f,   34.60f,   33.46f,   36.20f,   33.64f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.03f,   34.60f,   34.60f,   33.46f,   35.62f,   33.62f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   33.60f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   33.57f,   34.60f,   34.60f,   33.59f,   34.60f },
{33.57f,   34.60f,   34.60f,   34.60f,   34.60f,   33.46f,   35.15f,   34.58f,   34.60f,   34.60f,   33.59f,   34.60f}


        };
    }

}