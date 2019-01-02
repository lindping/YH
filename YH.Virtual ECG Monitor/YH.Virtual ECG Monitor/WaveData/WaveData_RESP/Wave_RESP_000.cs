﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH.Simulator.Framework;

namespace YH.Virtual_ECG_Monitor
{
    public class Wave_RESP_000 : Wave_RESP
    {
        public Wave_RESP_000()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R00";
            Name = "正常呼吸";
            Remark = "";
            Rate = 80;
            InspCapacity = 3000;
            Ratio = 67;
            ETCO2 = 40;
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[2000,2]{
             {0f,0f},
{0f,0f},
{0f,0f},
{0f,0f},
{0f,0.05f},
{0f,0.05f },
{0f, 0.05f },
{0f, 0.05f },
{0f, 0.1f  },
{0f, 0.1f  },
{0f, 0.1f  },
{0f, 0.15f },
{0f, 0.15f },
{0f, 0.15f },
{0f, 0.2f  },
{0f, 0.2f  },
{0f, 0.25f },
{0f, 0.25f },
{0f, 0.25f },
{0f, 0.3f  },
{0f, 0.3f  },
{0f, 0.35f },
{0f, 0.35f },
{0f, 0.4f  },
{0f, 0.4f  },
{0f, 0.45f },
{0f, 0.5f  },
{0f, 0.5f  },
{0f, 0.55f },
{0f, 0.55f },
{0f, 0.6f  },
{0f, 0.65f },
{0f, 0.65f },
{0f, 0.7f  },
{0f, 0.75f },
{0f, 0.75f },
{0f, 0.8f  },
{0f, 0.85f },
{0f, 0.9f  },
{0f, 0.9f  },
{0f, 0.95f },
{0f, 1f},
{0f, 1.05f },
{0f, 1.05f },
{0f, 1.1f  },
{0f, 1.15f },
{0f, 1.2f  },
{0f, 1.25f },
{0f, 1.3f  },
{0f, 1.3f  },
{0f, 1.35f },
{0f, 1.4f  },
{0f, 1.45f },
{0f, 1.5f  },
{0f, 1.55f },
{0f, 1.6f  },
{0f, 1.65f },
{0f, 1.7f  },
{0f, 1.75f },
{0f, 1.8f  },
{0f, 1.85f },
{0f, 1.9f  },
{0f, 1.95f },
{0f, 2f},
{0f, 2.05f },
{0f, 2.1f  },
{0f, 2.15f },
{0f, 2.2f  },
{0f, 2.25f },
{0f, 2.3f  },
{0f, 2.35f },
{0f, 2.4f  },
{0f, 2.45f },
{0f, 2.55f },
{0f, 2.6f  },
{0f, 2.65f },
{0f, 2.7f  },
{0f, 2.75f },
{0f, 2.8f  },
{0f, 2.9f  },
{0f, 2.95f },
{0f, 3f},
{0f, 3.05f },
{0f, 3.1f  },
{0f, 3.2f  },
{0f, 3.25f },
{0f, 3.3f  },
{0f, 3.35f },
{0f, 3.4f  },
{0f, 3.5f  },
{0f, 3.55f },
{0f, 3.6f  },
{0f, 3.7f  },
{0f, 3.75f },
{0f, 3.8f  },
{0f, 3.85f },
{0f, 3.95f },
{0f, 4f},
{0f, 4.05f },
{0f, 4.15f },
{0f, 4.2f  },
{0f, 4.25f },
{0f, 4.35f },
{0f, 4.4f  },
{0f, 4.5f  },
{0f, 4.55f },
{0f, 4.6f  },
{0f, 4.7f  },
{0f, 4.75f },
{0f, 4.8f  },
{0f, 4.9f  },
{0f, 4.95f },
{0f, 5.05f },
{0f, 5.1f  },
{0f, 5.2f  },
{0f, 5.25f },
{0f, 5.35f },
{0f, 5.4f  },
{0f, 5.45f },
{0f, 5.55f },
{0f, 5.6f  },
{0f, 5.7f  },
{0f, 5.75f },
{0f, 5.85f },
{0f, 5.9f  },
{0f, 6f},
{0f, 6.05f },
{0f, 6.15f },
{0f, 6.2f  },
{0f, 6.3f  },
{0f, 6.4f  },
{0f, 6.45f },
{0f, 6.55f },
{0f, 6.6f  },
{0f, 6.7f  },
{0f, 6.75f },
{0f, 6.85f },
{0f, 6.95f },
{0f, 7f},
{0f, 7.1f  },
{0f, 7.15f },
{0f, 7.25f },
{0f, 7.35f },
{0f, 7.4f  },
{0f, 7.5f  },
{0f, 7.6f  },
{0f, 7.65f },
{0f, 7.75f },
{0f, 7.8f  },
{0f, 7.9f  },
{0f, 8f},
{0f, 8.05f },
{0f, 8.15f },
{0f, 8.25f },
{0f, 8.3f  },
{0f, 8.4f  },
{0f, 8.5f  },
{0f, 8.55f },
{0f, 8.65f },
{0f, 8.75f },
{0f, 8.85f },
{0f, 8.9f  },
{0f, 9f},
{0f, 9.1f  },
{0f, 9.2f  },
{0f, 9.25f },
{0f, 9.35f },
{0f, 9.45f },
{0f, 9.5f  },
{0f, 9.6f  },
{0f, 9.7f  },
{0f, 9.8f  },
{0f, 9.9f  },
{0f, 9.95f },
{0f, 10.05f},
{0f, 10.15f},
{0f, 10.25f},
{0f, 10.3f },
{0f, 10.4f },
{0f, 10.5f },
{0f, 10.6f },
{0f, 10.7f },
{0f, 10.8f },
{0f, 10.85f},
{0f, 10.95f},
{0f, 11.05f},
{0f, 11.15f},
{0f, 11.25f},
{0f, 11.3f },
{0f, 11.4f },
{0f, 11.5f },
{0f, 11.6f },
{0f, 11.7f },
{0f, 11.8f },
{0f, 11.9f },
{0f, 11.95f},
{0f, 12.05f},
{0f, 12.15f},
{0f, 12.25f},
{0f, 12.35f},
{0f, 12.45f},
{0f, 12.55f},
{0f, 12.65f},
{0f, 12.75f},
{0f, 12.85f},
{0f, 12.9f },
{0f, 13f   },
{0f, 13.1f },
{0f, 13.2f },
{0f, 13.3f },
{0f, 13.4f },
{0f, 13.5f },
{0f, 13.6f },
{0f, 13.7f },
{0f, 13.8f },
{0f, 13.9f },
{0f, 14f   },
{0f, 14.1f },
{0f, 14.2f },
{0f, 14.3f },
{0f, 14.4f },
{0f, 14.5f },
{0f, 14.6f },
{0f, 14.65f},
{0f, 14.75f},
{0f, 14.85f},
{0f, 14.95f},
{0f, 15.05f},
{0f, 15.15f},
{0f, 15.25f},
{0f, 15.35f},
{0f, 15.45f},
{0f, 15.55f},
{0f, 15.65f},
{0f, 15.8f },
{0f, 15.9f },
{0f, 16f   },
{0f, 16.1f },
{0f, 16.2f },
{0f, 16.3f },
{0f, 16.4f },
{0f, 16.5f },
{0f, 16.6f },
{0f, 16.7f },
{0f, 16.8f },
{0f, 16.9f },
{0f, 17f   },
{0f, 17.1f },
{0f, 17.2f },
{0f, 17.3f },
{0f, 17.4f },
{0f, 17.5f },
{0f, 17.6f },
{0f, 17.7f },
{0f, 17.85f},
{0f, 17.95f},
{0f, 18.05f},
{0f, 18.15f},
{0f, 18.25f},
{0f, 18.35f},
{0f, 18.45f},
{0f, 18.55f},
{0f, 18.65f},
{0f, 18.75f},
{0f, 18.9f },
{0f, 19f   },
{0f, 19.1f },
{0f, 19.2f },
{0f, 19.3f },
{0f, 19.4f },
{0f, 19.5f },
{0f, 19.65f},
{0f, 19.75f},
{0f, 19.85f},
{0f, 20f   },
{0f, 20.1f },
{0f, 20.2f },
{0f, 20.35f},
{0f, 20.45f},
{0f, 20.6f },
{0f, 20.7f },
{0f, 20.85f},
{0f, 20.95f},
{0f, 21.1f },
{0f, 21.2f },
{0f, 21.35f},
{0f, 21.45f},
{0f, 21.6f },
{0f, 21.7f },
{0f, 21.85f},
{0f, 21.95f},
{0f, 22.05f},
{0f, 22.2f },
{0f, 22.3f },
{0f, 22.45f},
{0f, 22.55f},
{0f, 22.7f },
{0f, 22.8f },
{0f, 22.95f},
{0f, 23.05f},
{0f, 23.2f },
{0f, 23.3f },
{0f, 23.45f},
{0f, 23.55f},
{0f, 23.65f},
{0f, 23.8f },
{0f, 23.9f },
{0f, 24.05f},
{0f, 24.15f},
{0f, 24.3f },
{0f, 24.4f },
{0f, 24.55f},
{0f, 24.65f},
{0f, 24.8f },
{0f, 24.9f },
{0f, 25.05f},
{0f, 25.15f},
{0f, 25.25f},
{0f, 25.4f },
{0f, 25.5f },
{0f, 25.65f},
{0f, 25.75f},
{0f, 25.9f },
{0f, 26f   },
{0f, 26.15f},
{0f, 26.25f},
{0f, 26.4f },
{0f, 26.5f },
{0f, 26.65f},
{0f, 26.75f},
{0f, 26.9f },
{0f, 27f   },
{0f, 27.1f },
{0f, 27.25f},
{0f, 27.35f},
{0f, 27.5f },
{0f, 27.6f },
{0f, 27.75f},
{0f, 27.85f},
{0f, 28f   },
{0f, 28.1f },
{0f, 28.25f},
{0f, 28.35f},
{0f, 28.5f },
{0f, 28.6f },
{0f, 28.75f},
{0f, 28.85f},
{0f, 28.95f},
{0f, 29.1f },
{0f, 29.2f },
{0f, 29.35f},
{0f, 29.45f},
{0f, 29.6f },
{0f, 29.7f },
{0f, 29.85f},
{0f, 29.95f},
{0f, 30.1f },
{0f, 30.2f },
{0f, 30.35f},
{0f, 30.45f},
{0f, 30.55f},
{0f, 30.7f },
{0f, 30.8f },
{0f, 30.95f},
{0f, 31.05f},
{0f, 31.2f },
{0f, 31.3f },
{0f, 31.45f},
{0f, 31.55f},
{0f, 31.7f },
{0f, 31.8f },
{0f, 31.95f},
{0f, 32.05f},
{0f, 32.2f },
{0f, 32.3f },
{0f, 32.4f },
{0f, 32.55f},
{0f, 32.65f},
{0f, 32.8f },
{0f, 32.9f },
{0f, 33.05f},
{0f, 33.15f},
{0f, 33.3f },
{0f, 33.4f },
{0f, 33.55f},
{0f, 33.65f},
{0f, 33.8f },
{0f, 33.9f },
{0f, 34.05f},
{0f, 34.15f},
{0f, 34.3f },
{0f, 34.4f },
{0f, 34.5f },
{0f, 34.65f},
{0f, 34.75f},
{0f, 34.9f },
{0f, 35f   },
{0f, 35.15f},
{0f, 35.25f},
{0f, 35.4f },
{0f, 35.5f },
{0f, 35.65f},
{0f, 35.75f},
{0f, 35.9f },
{0f, 36f   },
{0f, 36.15f},
{0f, 36.25f},
{0f, 36.35f},
{0f, 36.5f },
{0f, 36.6f },
{0f, 36.75f},
{0f, 36.85f},
{0f, 37f   },
{0f, 37.1f },
{0f, 37.25f},
{0f, 37.35f},
{0f, 37.5f },
{0f, 37.6f },
{0f, 37.75f},
{0f, 37.85f},
{0f, 38f   },
{0f, 38.1f },
{0f, 38.25f},
{0f, 38.35f},
{0f, 38.5f },
{0f, 38.6f },
{0f, 38.7f },
{0f, 38.85f},
{0f, 38.95f},
{0f, 39.1f },
{0f, 39.2f },
{0f, 39.35f},
{0f, 39.45f},
{0f, 39.6f },
{0f, 39.7f },
{0f, 39.85f},
{0f, 39.95f},
{0f, 40.1f },
{0f, 40.2f },
{0f, 40.35f},
{0f, 40.45f},
{0f, 40.55f},
{0f, 40.7f },
{0f, 40.8f },
{0f, 40.95f},
{0f, 41.05f},
{0f, 41.2f },
{0f, 41.3f },
{0f, 41.45f},
{0f, 41.55f},
{0f, 41.7f },
{0f, 41.8f },
{0f, 41.95f},
{0f, 42.05f},
{0f, 42.2f },
{0f, 42.3f },
{0f, 42.45f},
{0f, 42.55f},
{0f, 42.65f},
{0f, 42.8f },
{0f, 42.9f },
{0f, 43.05f},
{0f, 43.15f},
{0f, 43.3f },
{0f, 43.4f },
{0f, 43.55f},
{0f, 43.65f},
{0f, 43.8f },
{0f, 43.9f },
{0f, 44.05f},
{0f, 44.15f},
{0f, 44.3f },
{0f, 44.4f },
{0f, 44.55f},
{0f, 44.65f},
{0f, 44.75f},
{0f, 44.9f },
{0f, 45f   },
{0f, 45.15f},
{0f, 45.25f},
{0f, 45.4f },
{0f, 45.5f },
{0f, 45.65f},
{0f, 45.75f},
{0f, 45.9f },
{0f, 46f   },
{0f, 46.15f},
{0f, 46.25f},
{0f, 46.4f },
{0f, 46.5f },
{0f, 46.6f },
{0f, 46.75f},
{0f, 46.85f},
{0f, 47f   },
{0f, 47.1f },
{0f, 47.25f},
{0f, 47.35f},
{0f, 47.5f },
{0f, 47.6f },
{0f, 47.75f},
{0f, 47.85f},
{0f, 48f   },
{0f, 48.1f },
{0f, 48.25f},
{0f, 48.35f},
{0f, 48.5f },
{0f, 48.6f },
{0f, 48.75f},
{0f, 48.85f},
{0f, 48.95f},
{0f, 49.1f },
{0f, 49.2f },
{0f, 49.35f},
{0f, 49.45f},
{0f, 49.6f },
{0f, 49.7f },
{0f, 49.85f},
{0f, 49.95f},
{0f, 50.1f },
{0f, 50.2f },
{0f, 50.35f},
{0f, 50.45f},
{0f, 50.6f },
{0f, 50.7f },
{0f, 50.85f},
{0f, 50.95f},
{0f, 51.05f},
{0f, 51.2f },
{0f, 51.3f },
{0f, 51.45f},
{0f, 51.55f},
{0f, 51.7f },
{0f, 51.8f },
{0f, 51.95f},
{0f, 52.05f},
{0f, 52.2f },
{0f, 52.3f },
{0f, 52.45f},
{0f, 52.55f},
{0f, 52.7f },
{0f, 52.8f },
{0f, 52.95f},
{0f, 53.05f},
{0f, 53.15f},
{0f, 53.3f },
{0f, 53.4f },
{0f, 53.55f},
{0f, 53.65f},
{0f, 53.8f },
{0f, 53.9f },
{0f, 54.05f},
{0f, 54.15f},
{0f, 54.3f },
{0f, 54.4f },
{0f, 54.55f},
{0f, 54.65f},
{0f, 54.8f },
{0f, 54.9f },
{0f, 55.05f},
{0f, 55.15f},
{0f, 55.25f},
{0f, 55.4f },
{0f, 55.5f },
{0f, 55.65f},
{0f, 55.75f},
{0f, 55.9f },
{0f, 56f   },
{0f, 56.15f},
{0f, 56.25f},
{0f, 56.4f },
{0f, 56.5f },
{0f, 56.65f},
{0f, 56.75f},
{0f, 56.9f },
{0f, 57f   },
{0f, 57.15f},
{0f, 57.25f},
{0f, 57.4f },
{0f, 57.5f },
{0f, 57.6f },
{0f, 57.75f},
{0f, 57.85f},
{0f, 58f   },
{0f, 58.1f },
{0f, 58.25f},
{0f, 58.35f},
{0f, 58.5f },
{0f, 58.6f },
{0f, 58.75f},
{0f, 58.85f},
{0f, 59f   },
{0f, 59.1f },
{0f, 59.25f},
{0f, 59.35f},
{0f, 59.5f },
{0f, 59.6f },
{0f, 59.7f },
{0f, 59.85f},
{0f, 59.95f},
{0f, 60.1f },
{0f, 60.2f },
{0f, 60.35f},
{0f, 60.45f},
{0f, 60.6f },
{0f, 60.7f },
{0f, 60.85f},
{0f, 60.95f},
{0f, 61.1f },
{0f, 61.2f },
{0f, 61.3f },
{0f, 61.45f},
{0f, 61.55f},
{0f, 61.7f },
{0f, 61.8f },
{0f, 61.9f },
{0f, 62.05f},
{0f, 62.15f},
{0f, 62.3f },
{0f, 62.4f },
{0f, 62.5f },
{0f, 62.65f},
{0f, 62.75f},
{0f, 62.9f },
{0f, 63f   },
{0f, 63.1f },
{0f, 63.25f},
{0f, 63.35f},
{0f, 63.5f },
{0f, 63.6f },
{0f, 63.7f },
{0f, 63.85f},
{0f, 63.95f},
{0f, 64.1f },
{0f, 64.2f },
{0f, 64.3f },
{0f, 64.45f},
{0f, 64.55f},
{0f, 64.65f},
{0f, 64.8f },
{0f, 64.9f },
{0f, 65.05f},
{0f, 65.15f},
{0f, 65.25f},
{0f, 65.4f },
{0f, 65.5f },
{0f, 65.65f},
{0f, 65.75f},
{0f, 65.85f},
{0f, 66f   },
{0f, 66.1f },
{0f, 66.2f },
{0f, 66.35f},
{0f, 66.45f},
{0f, 66.6f },
{0f, 66.7f },
{0f, 66.8f },
{0f, 66.95f},
{0f, 67.05f},
{0f, 67.15f},
{0f, 67.3f },
{0f, 67.4f },
{0f, 67.55f},
{0f, 67.65f},
{0f, 67.75f},
{0f, 67.9f },
{0f, 68f   },
{0f, 68.1f },
{0f, 68.25f},
{0f, 68.35f},
{0f, 68.5f },
{0f, 68.6f },
{0f, 68.7f },
{0f, 68.85f},
{0f, 68.95f},
{0f, 69.05f},
{0f, 69.2f },
{0f, 69.3f },
{0f, 69.4f },
{0f, 69.55f},
{0f, 69.65f},
{0f, 69.8f },
{0f, 69.9f },
{0f, 70f   },
{0f, 70.15f},
{0f, 70.25f},
{0f, 70.35f},
{0f, 70.5f },
{0f, 70.6f },
{0f, 70.7f },
{0f, 70.85f},
{0f, 70.95f},
{0f, 71.1f },
{0f, 71.2f },
{0f, 71.3f },
{0f, 71.45f},
{0f, 71.55f},
{0f, 71.65f},
{0f, 71.8f },
{0f, 71.9f },
{0f, 72f   },
{0f, 72.15f},
{0f, 72.25f},
{0f, 72.35f},
{0f, 72.5f },
{0f, 72.6f },
{0f, 72.7f },
{0f, 72.85f},
{0f, 72.95f},
{0f, 73.05f},
{0f, 73.2f },
{0f, 73.3f },
{0f, 73.4f },
{0f, 73.55f},
{0f, 73.65f},
{0f, 73.75f},
{0f, 73.9f },
{0f, 74f   },
{0f, 74.1f },
{0f, 74.25f},
{0f, 74.35f},
{0f, 74.45f},
{0f, 74.6f },
{0f, 74.7f },
{0f, 74.8f },
{0f, 74.95f},
{0f, 75.05f},
{0f, 75.15f},
{0f, 75.3f },
{0f, 75.4f },
{0f, 75.5f },
{0f, 75.65f},
{0f, 75.75f},
{0f, 75.85f},
{0f, 76f   },
{0f, 76.1f },
{0f, 76.2f },
{0f, 76.35f},
{0f, 76.45f},
{0f, 76.55f},
{0f, 76.7f },
{0f, 76.8f },
{0f, 76.9f },
{0f, 77f   },
{0f, 77.15f},
{0f, 77.25f},
{0f, 77.35f},
{0f, 77.5f },
{0f, 77.6f },
{0f, 77.7f },
{0f, 77.85f},
{0f, 77.95f},
{0f, 78.05f},
{0f, 78.2f },
{0f, 78.3f },
{0f, 78.4f },
{0f, 78.5f },
{0f, 78.65f},
{0f, 78.75f},
{0f, 78.85f},
{0f, 79f   },
{0f, 79.1f },
{0f, 79.2f },
{0f, 79.35f},
{0f, 79.45f},
{0f, 79.55f},
{0f, 79.65f},
{0f, 79.8f },
{0f, 79.9f },
{0f, 80f   },
{0f, 80.15f},
{0f, 80.25f},
{0f, 80.35f},
{0f, 80.45f},
{0f, 80.6f },
{0f, 80.7f },
{0f, 80.8f },
{0f, 80.95f},
{0f, 81.05f},
{0f, 81.15f},
{0f, 81.25f},
{0f, 81.4f },
{0f, 81.5f },
{0f, 81.6f },
{0f, 81.7f },
{0f, 81.85f},
{0f, 81.95f},
{0f, 82.05f},
{0f, 82.15f},
{0f, 82.3f },
{0f, 82.4f },
{0f, 82.5f },
{0f, 82.65f},
{0f, 82.75f},
{0f, 82.85f},
{0f, 82.95f},
{0f, 83.1f },
{0f, 83.2f },
{0f, 83.3f },
{0f, 83.4f },
{0f, 83.55f},
{0f, 83.65f},
{0f, 83.75f},
{0f, 83.85f},
{0f, 84f   },
{0f, 84.1f },
{0f, 84.2f },
{0f, 84.3f },
{0f, 84.45f},
{0f, 84.55f},
{0f, 84.65f},
{0f, 84.75f},
{0f, 84.9f },
{0f, 85f   },
{0f, 85.1f },
{0f, 85.2f },
{0f, 85.35f},
{0f, 85.45f},
{0f, 85.55f},
{0f, 85.65f},
{0f, 85.75f},
{0f, 85.9f },
{0f, 86f   },
{0f, 86.1f },
{0f, 86.2f },
{0f, 86.35f},
{0f, 86.45f},
{0f, 86.55f},
{0f, 86.65f},
{0f, 86.75f},
{0f, 86.9f },
{0f, 87f   },
{0f, 87.1f },
{0f, 87.2f },
{0f, 87.35f},
{0f, 87.45f},
{0f, 87.55f},
{0f, 87.65f},
{0f, 87.75f},
{0f, 87.9f },
{0f, 88f   },
{0f, 88.1f },
{0f, 88.2f },
{0f, 88.3f },
{0f, 88.45f},
{0f, 88.55f},
{0f, 88.65f},
{0f, 88.75f},
{0f, 88.85f},
{0f, 89f   },
{0f, 89.1f },
{0f, 89.2f },
{0f, 89.3f },
{0f, 89.4f },
{0f, 89.55f},
{0f, 89.65f},
{0f, 89.75f},
{0f, 89.85f},
{0f, 89.95f},
{0f, 90.05f},
{0f, 90.2f },
{0f, 90.3f },
{0f, 90.4f },
{0f, 90.5f },
{0f, 90.6f },
{0f, 90.7f },
{0f, 90.85f},
{0f, 90.95f},
{0f, 91.05f},
{0f, 91.15f},
{0f, 91.25f},
{0f, 91.35f},
{0f, 91.5f },
{0f, 91.6f },
{0f, 91.7f },
{0f, 91.8f },
{0f, 91.9f },
{0f, 92f   },
{0f, 92.1f },
{0f, 92.25f},
{0f, 92.35f},
{0f, 92.45f},
{0f, 92.55f},
{0f, 92.65f},
{0f, 92.75f},
{0f, 92.85f},
{0f, 93f   },
{0f, 93.1f },
{0f, 93.2f },
{0f, 93.3f },
{0f, 93.4f },
{0f, 93.5f },
{0f, 93.6f },
{0f, 93.7f },
{0f, 93.8f },
{0f, 93.95f},
{0f, 94.05f},
{0f, 94.15f},
{0f, 94.25f},
{0f, 94.35f},
{0f, 94.45f},
{0f, 94.55f},
{0f, 94.65f},
{0f, 94.8f },
{0f, 94.9f },
{0f, 95f   },
{0f, 95.1f },
{0f, 95.2f },
{0f, 95.3f },
{0f, 95.4f },
{0f, 95.5f },
{0f, 95.6f },
{0f, 95.7f },
{0f, 95.8f },
{0f, 95.9f },
{0f, 96.05f},
{0f, 96.15f},
{0f, 96.25f},
{0f, 96.35f},
{0f, 96.45f},
{0f, 96.55f},
{0f, 96.65f},
{0f, 96.75f},
{0f, 96.85f},
{0f, 96.95f},
{0f, 97.05f},
{0f, 97.15f},
{0f, 97.25f},
{0f, 97.35f},
{0f, 97.45f},
{0f, 97.55f},
{0f, 97.65f},
{0f, 97.75f},
{0f, 97.85f},
{0f, 97.95f},
{0f, 98.1f },
{0f, 98.15f},
{0f, 98.3f },
{0f, 98.4f },
{0f, 98.5f },
{0f, 98.6f },
{0f, 98.7f },
{0f, 98.8f },
{0f, 98.9f },
{0f, 99f   },
{0f, 99.1f },
{0f, 99.2f },
{0f, 99.3f },
{0f, 99.4f },
{0f, 99.5f },
{0f, 99.6f },
{0f, 99.7f },
{0f, 99.8f },
{0f, 99.85f},
{0f, 99.95f},
{0f, 100.05f   },
{0f, 100.15f   },
{0f, 100.25f   },
{0f, 100.35f   },
{0f, 100.45f   },
{0f, 100.55f   },
{0f, 100.65f   },
{0f, 100.75f   },
{0f, 100.85f   },
{0f, 100.95f   },
{0f, 101.05f   },
{0f, 101.15f   },
{0f, 101.25f   },
{0f, 101.35f   },
{0f, 101.45f   },
{0f, 101.55f   },
{0f, 101.65f   },
{0f, 101.7f},
{0f, 101.8f},
{0f, 101.9f},
{0f, 102f  },
{0f, 102.1f},
{0f, 102.2f},
{0f, 102.3f},
{0f, 102.35f   },
{0f, 102.45f   },
{0f, 102.55f   },
{0f, 102.65f   },
{0f, 102.75f   },
{0f, 102.85f   },
{0f, 102.9f},
{0f, 103f  },
{0f, 103.1f},
{0f, 103.2f},
{0f, 103.3f},
{0f, 103.4f},
{0f, 103.45f   },
{0f, 103.55f   },
{0f, 103.65f   },
{0f, 103.75f   },
{0f, 103.85f   },
{0f, 103.9f},
{0f, 104f  },
{0f, 104.1f},
{0f, 104.2f},
{0f, 104.3f},
{0f, 104.35f   },
{0f, 104.45f   },
{0f, 104.55f   },
{0f, 104.65f   },
{0f, 104.7f},
{0f, 104.8f},
{0f, 104.9f},
{0f, 105f  },
{0f, 105.05f   },
{0f, 105.15f   },
{0f, 105.25f   },
{0f, 105.35f   },
{0f, 105.4f},
{0f, 105.5f},
{0f, 105.6f},
{0f, 105.7f},
{0f, 105.75f   },
{0f, 105.85f   },
{0f, 105.95f   },
{0f, 106f  },
{0f, 106.1f},
{0f, 106.2f},
{0f, 106.3f},
{0f, 106.35f   },
{0f, 106.45f   },
{0f, 106.55f   },
{0f, 106.6f},
{0f, 106.7f},
{0f, 106.8f},
{0f, 106.85f   },
{0f, 106.95f   },
{0f, 107.05f   },
{0f, 107.1f},
{0f, 107.2f},
{0f, 107.3f},
{0f, 107.35f   },
{0f, 107.45f   },
{0f, 107.55f   },
{0f, 107.6f},
{0f, 107.7f},
{0f, 107.8f},
{0f, 107.85f   },
{0f, 107.95f   },
{0f, 108f  },
{0f, 108.1f},
{0f, 108.2f},
{0f, 108.25f   },
{0f, 108.35f   },
{0f, 108.45f   },
{0f, 108.5f},
{0f, 108.6f},
{0f, 108.65f   },
{0f, 108.75f   },
{0f, 108.85f   },
{0f, 108.9f},
{0f, 109f  },
{0f, 109.05f   },
{0f, 109.15f   },
{0f, 109.2f},
{0f, 109.3f},
{0f, 109.4f},
{0f, 109.45f   },
{0f, 109.55f   },
{0f, 109.6f},
{0f, 109.7f},
{0f, 109.75f   },
{0f, 109.85f   },
{0f, 109.9f},
{0f, 110f  },
{0f, 110.05f   },
{0f, 110.15f   },
{0f, 110.2f},
{0f, 110.3f},
{0f, 110.35f   },
{0f, 110.45f   },
{0f, 110.5f},
{0f, 110.6f},
{0f, 110.65f   },
{0f, 110.75f   },
{0f, 110.8f},
{0f, 110.9f},
{0f, 110.95f   },
{0f, 111.05f   },
{0f, 111.1f},
{0f, 111.2f},
{0f, 111.25f   },
{0f, 111.35f   },
{0f, 111.4f},
{0f, 111.5f},
{0f, 111.55f   },
{0f, 111.6f},
{0f, 111.7f},
{0f, 111.75f   },
{0f, 111.85f   },
{0f, 111.9f},
{0f, 112f  },
{0f, 112.05f   },
{0f, 112.1f},
{0f, 112.2f},
{0f, 112.25f   },
{0f, 112.35f   },
{0f, 112.4f},
{0f, 112.45f   },
{0f, 112.55f   },
{0f, 112.6f},
{0f, 112.65f   },
{0f, 112.75f   },
{0f, 112.8f},
{0f, 112.85f   },
{0f, 112.95f   },
{0f, 113f  },
{0f, 113.05f   },
{0f, 113.15f   },
{0f, 113.2f},
{0f, 113.25f   },
{0f, 113.35f   },
{0f, 113.4f},
{0f, 113.45f   },
{0f, 113.55f   },
{0f, 113.6f},
{0f, 113.65f   },
{0f, 113.75f   },
{0f, 113.8f},
{0f, 113.85f   },
{0f, 113.9f},
{0f, 114f  },
{0f, 114.05f   },
{0f, 114.1f},
{0f, 114.15f   },
{0f, 114.25f   },
{0f, 114.3f},
{0f, 114.35f   },
{0f, 114.4f},
{0f, 114.5f},
{0f, 114.55f   },
{0f, 114.6f},
{0f, 114.65f   },
{0f, 114.75f   },
{0f, 114.8f},
{0f, 114.85f   },
{0f, 114.9f},
{0f, 114.95f   },
{0f, 115f  },
{0f, 115.1f},
{0f, 115.15f   },
{0f, 115.2f},
{0f, 115.25f   },
{0f, 115.3f},
{0f, 115.35f   },
{0f, 115.45f   },
{0f, 115.5f},
{0f, 115.55f   },
{0f, 115.6f},
{0f, 115.65f   },
{0f, 115.7f},
{0f, 115.75f   },
{0f, 115.8f},
{0f, 115.9f},
{0f, 115.95f   },
{0f, 116f  },
{0f, 116.05f   },
{0f, 116.1f},
{0f, 116.15f   },
{0f, 116.2f},
{0f, 116.25f   },
{0f, 116.3f},
{0f, 116.35f   },
{0f, 116.4f},
{0f, 116.45f   },
{0f, 116.5f},
{0f, 116.55f   },
{0f, 116.6f},
{0f, 116.65f   },
{0f, 116.7f},
{0f, 116.75f   },
{0f, 116.8f},
{0f, 116.85f   },
{0f, 116.9f},
{0f, 116.95f   },
{0f, 117f  },
{0f, 117.05f   },
{0f, 117.1f},
{0f, 117.15f   },
{0f, 117.2f},
{0f, 117.25f   },
{0f, 117.3f},
{0f, 117.35f   },
{0f, 117.4f},
{0f, 117.4f},
{0f, 117.45f   },
{0f, 117.5f},
{0f, 117.55f   },
{0f, 117.6f},
{0f, 117.65f   },
{0f, 117.7f},
{0f, 117.75f   },
{0f, 117.75f   },
{0f, 117.8f},
{0f, 117.85f   },
{0f, 117.9f},
{0f, 117.95f   },
{0f, 118f  },
{0f, 118f  },
{0f, 118.05f   },
{0f, 118.1f},
{0f, 118.15f   },
{0f, 118.2f},
{0f, 118.2f},
{0f, 118.25f   },
{0f, 118.3f},
{0f, 118.35f   },
{0f, 118.35f   },
{0f, 118.4f},
{0f, 118.45f   },
{0f, 118.5f},
{0f, 118.5f},
{0f, 118.55f   },
{0f, 118.6f},
{0f, 118.6f},
{0f, 118.65f   },
{0f, 118.7f},
{0f, 118.7f},
{0f, 118.75f   },
{0f, 118.8f},
{0f, 118.8f},
{0f, 118.85f   },
{0f, 118.9f},
{0f, 118.9f},
{0f, 118.95f   },
{0f, 119f  },
{0f, 119f  },
{0f, 119.05f   },
{0f, 119.05f   },
{0f, 119.1f},
{0f, 119.15f   },
{0f, 119.15f   },
{0f, 119.2f},
{0f, 119.2f},
{0f, 119.25f   },
{0f, 119.25f   },
{0f, 119.3f},
{0f, 119.3f},
{0f, 119.35f   },
{0f, 119.35f   },
{0f, 119.4f},
{0f, 119.4f},
{0f, 119.45f   },
{0f, 119.45f   },
{0f, 119.5f},
{0f, 119.5f},
{0f, 119.5f},
{0f, 119.55f   },
{0f, 119.55f   },
{0f, 119.6f},
{0f, 119.6f},
{0f, 119.65f   },
{0f, 119.65f   },
{0f, 119.65f   },
{0f, 119.7f},
{0f, 119.7f},
{0f, 119.7f},
{0f, 119.75f   },
{0f, 119.75f   },
{0f, 119.75f   },
{0f, 119.8f},
{0f, 119.8f},
{0f, 119.8f},
{0f, 119.8f},
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 120f  },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.95f   },
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.9f},
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.85f   },
{0f, 119.8f},
{0f, 119.8f},
{0f, 119.8f},
{0f, 119.75f   },
{0f, 119.75f   },
{0f, 119.75f   },
{0f, 119.7f},
{0f, 119.7f},
{0f, 119.7f},
{0f, 119.65f   },
{0f, 119.65f   },
{0f, 119.6f},
{0f, 119.6f},
{0f, 119.6f},
{0f, 119.55f   },
{0f, 119.55f   },
{0f, 119.5f},
{0f, 119.5f},
{0f, 119.45f   },
{0f, 119.45f   },
{0f, 119.4f},
{0f, 119.4f},
{0f, 119.35f   },
{0f, 119.35f   },
{0f, 119.3f},
{0f, 119.25f   },
{0f, 119.25f   },
{0f, 119.2f},
{0f, 119.2f},
{0f, 119.15f   },
{0f, 119.1f},
{0f, 119.1f},
{0f, 119.05f   },
{0f, 119f  },
{0f, 119f  },
{0f, 118.95f   },
{0f, 118.9f},
{0f, 118.85f   },
{0f, 118.85f   },
{0f, 118.8f},
{0f, 118.75f   },
{0f, 118.7f},
{0f, 118.65f   },
{0f, 118.65f   },
{0f, 118.6f},
{0f, 118.55f   },
{0f, 118.5f},
{0f, 118.45f   },
{0f, 118.4f},
{0f, 118.35f   },
{0f, 118.3f},
{0f, 118.3f},
{0f, 118.25f   },
{0f, 118.2f},
{0f, 118.15f   },
{0f, 118.1f},
{0f, 118.05f   },
{0f, 118f  },
{0f, 117.95f   },
{0f, 117.9f},
{0f, 117.85f   },
{0f, 117.8f},
{0f, 117.7f},
{0f, 117.65f   },
{0f, 117.6f},
{0f, 117.55f   },
{0f, 117.5f},
{0f, 117.45f   },
{0f, 117.4f},
{0f, 117.35f   },
{0f, 117.25f   },
{0f, 117.2f},
{0f, 117.15f   },
{0f, 117.1f},
{0f, 117f  },
{0f, 116.95f   },
{0f, 116.9f},
{0f, 116.85f   },
{0f, 116.75f   },
{0f, 116.7f},
{0f, 116.65f   },
{0f, 116.55f   },
{0f, 116.5f},
{0f, 116.45f   },
{0f, 116.35f   },
{0f, 116.3f},
{0f, 116.2f},
{0f, 116.15f   },
{0f, 116.05f   },
{0f, 116f  },
{0f, 115.95f   },
{0f, 115.85f   },
{0f, 115.75f   },
{0f, 115.7f},
{0f, 115.6f},
{0f, 115.55f   },
{0f, 115.45f   },
{0f, 115.4f},
{0f, 115.3f},
{0f, 115.25f   },
{0f, 115.15f   },
{0f, 115.05f   },
{0f, 115f  },
{0f, 114.9f},
{0f, 114.8f},
{0f, 114.7f},
{0f, 114.65f   },
{0f, 114.55f   },
{0f, 114.45f   },
{0f, 114.35f   },
{0f, 114.3f},
{0f, 114.2f},
{0f, 114.1f},
{0f, 114f  },
{0f, 113.9f},
{0f, 113.85f   },
{0f, 113.75f   },
{0f, 113.65f   },
{0f, 113.55f   },
{0f, 113.45f   },
{0f, 113.35f   },
{0f, 113.25f   },
{0f, 113.15f   },
{0f, 113.05f   },
{0f, 112.95f   },
{0f, 112.85f   },
{0f, 112.75f   },
{0f, 112.65f   },
{0f, 112.55f   },
{0f, 112.45f   },
{0f, 112.35f   },
{0f, 112.2f},
{0f, 112.1f},
{0f, 112f  },
{0f, 111.9f},
{0f, 111.8f},
{0f, 111.7f},
{0f, 111.55f   },
{0f, 111.45f   },
{0f, 111.35f   },
{0f, 111.25f   },
{0f, 111.1f},
{0f, 111f  },
{0f, 110.9f},
{0f, 110.75f   },
{0f, 110.65f   },
{0f, 110.55f   },
{0f, 110.4f},
{0f, 110.3f},
{0f, 110.15f   },
{0f, 110.05f   },
{0f, 109.95f   },
{0f, 109.8f},
{0f, 109.7f},
{0f, 109.55f   },
{0f, 109.45f   },
{0f, 109.3f},
{0f, 109.15f   },
{0f, 109.05f   },
{0f, 108.9f},
{0f, 108.8f},
{0f, 108.65f   },
{0f, 108.5f},
{0f, 108.4f},
{0f, 108.25f   },
{0f, 108.1f},
{0f, 108f  },
{0f, 107.85f   },
{0f, 107.7f},
{0f, 107.55f   },
{0f, 107.45f   },
{0f, 107.3f},
{0f, 107.15f   },
{0f, 107f  },
{0f, 106.85f   },
{0f, 106.7f},
{0f, 106.55f   },
{0f, 106.4f},
{0f, 106.3f},
{0f, 106.15f   },
{0f, 106f  },
{0f, 105.85f   },
{0f, 105.7f},
{0f, 105.55f   },
{0f, 105.4f},
{0f, 105.2f},
{0f, 105.05f   },
{0f, 104.9f},
{0f, 104.75f   },
{0f, 104.6f},
{0f, 104.45f   },
{0f, 104.3f},
{0f, 104.15f   },
{0f, 103.95f   },
{0f, 103.8f},
{0f, 103.65f   },
{0f, 103.5f},
{0f, 103.3f},
{0f, 103.15f   },
{0f, 103f  },
{0f, 102.8f},
{0f, 102.65f   },
{0f, 102.45f   },
{0f, 102.3f},
{0f, 102.1f},
{0f, 101.95f   },
{0f, 101.75f   },
{0f, 101.6f},
{0f, 101.4f},
{0f, 101.25f   },
{0f, 101.05f   },
{0f, 100.9f},
{0f, 100.7f},
{0f, 100.5f},
{0f, 100.35f   },
{0f, 100.15f   },
{0f, 99.95f},
{0f, 99.75f},
{0f, 99.6f },
{0f, 99.4f },
{0f, 99.2f },
{0f, 99f   },
{0f, 98.85f},
{0f, 98.65f},
{0f, 98.45f},
{0f, 98.25f},
{0f, 98.05f},
{0f, 97.85f},
{0f, 97.65f},
{0f, 97.5f },
{0f, 97.3f },
{0f, 97.1f },
{0f, 96.9f },
{0f, 96.7f },
{0f, 96.5f },
{0f, 96.3f },
{0f, 96.1f },
{0f, 95.85f},
{0f, 95.65f},
{0f, 95.45f},
{0f, 95.25f},
{0f, 95.05f},
{0f, 94.85f},
{0f, 94.65f},
{0f, 94.45f},
{0f, 94.2f },
{0f, 94f   },
{0f, 93.8f },
{0f, 93.6f },
{0f, 93.4f },
{0f, 93.15f},
{0f, 92.95f},
{0f, 92.75f},
{0f, 92.55f},
{0f, 92.3f },
{0f, 92.1f },
{0f, 91.9f },
{0f, 91.65f},
{0f, 91.45f},
{0f, 91.2f },
{0f, 91f   },
{0f, 90.8f },
{0f, 90.55f},
{0f, 90.35f},
{0f, 90.1f },
{0f, 89.9f },
{0f, 89.7f },
{0f, 89.45f},
{0f, 89.25f},
{0f, 89f   },
{0f, 88.75f},
{0f, 88.55f},
{0f, 88.3f },
{0f, 88.1f },
{0f, 87.85f},
{0f, 87.65f},
{0f, 87.4f },
{0f, 87.15f},
{0f, 86.95f},
{0f, 86.7f },
{0f, 86.5f },
{0f, 86.25f},
{0f, 86f   },
{0f, 85.8f },
{0f, 85.55f},
{0f, 85.3f },
{0f, 85.05f},
{0f, 84.85f},
{0f, 84.6f },
{0f, 84.35f},
{0f, 84.15f},
{0f, 83.9f },
{0f, 83.65f},
{0f, 83.4f },
{0f, 83.15f},
{0f, 82.95f},
{0f, 82.7f },
{0f, 82.45f},
{0f, 82.2f },
{0f, 81.95f},
{0f, 81.7f },
{0f, 81.45f},
{0f, 81.2f },
{0f, 81f   },
{0f, 80.75f},
{0f, 80.5f },
{0f, 80.25f},
{0f, 80f   },
{0f, 79.75f},
{0f, 79.5f },
{0f, 79.25f},
{0f, 79f   },
{0f, 78.75f},
{0f, 78.5f },
{0f, 78.25f},
{0f, 78f   },
{0f, 77.75f},
{0f, 77.5f },
{0f, 77.25f},
{0f, 77f   },
{0f, 76.75f},
{0f, 76.5f },
{0f, 76.25f},
{0f, 75.95f},
{0f, 75.7f },
{0f, 75.45f},
{0f, 75.2f },
{0f, 74.95f},
{0f, 74.7f },
{0f, 74.45f},
{0f, 74.15f},
{0f, 73.9f },
{0f, 73.65f},
{0f, 73.4f },
{0f, 73.15f},
{0f, 72.85f},
{0f, 72.6f },
{0f, 72.35f},
{0f, 72.1f },
{0f, 71.85f},
{0f, 71.55f},
{0f, 71.3f },
{0f, 71.05f},
{0f, 70.75f},
{0f, 70.5f },
{0f, 70.25f},
{0f, 70f   },
{0f, 69.7f },
{0f, 69.45f},
{0f, 69.2f },
{0f, 68.9f },
{0f, 68.65f},
{0f, 68.4f },
{0f, 68.1f },
{0f, 67.85f},
{0f, 67.6f },
{0f, 67.3f },
{0f, 67.05f},
{0f, 66.75f},
{0f, 66.5f },
{0f, 66.25f},
{0f, 65.95f},
{0f, 65.7f },
{0f, 65.4f },
{0f, 65.15f},
{0f, 64.9f },
{0f, 64.6f },
{0f, 64.35f},
{0f, 64.1f },
{0f, 63.8f },
{0f, 63.55f},
{0f, 63.3f },
{0f, 63f   },
{0f, 62.75f},
{0f, 62.5f },
{0f, 62.2f },
{0f, 61.95f},
{0f, 61.7f },
{0f, 61.4f },
{0f, 61.15f},
{0f, 60.9f },
{0f, 60.6f },
{0f, 60.35f},
{0f, 60.05f},
{0f, 59.8f },
{0f, 59.55f},
{0f, 59.25f},
{0f, 59f   },
{0f, 58.75f},
{0f, 58.45f},
{0f, 58.2f },
{0f, 57.9f },
{0f, 57.65f},
{0f, 57.4f },
{0f, 57.1f },
{0f, 56.85f},
{0f, 56.6f },
{0f, 56.3f },
{0f, 56.05f},
{0f, 55.8f },
{0f, 55.5f },
{0f, 55.25f},
{0f, 54.95f},
{0f, 54.7f },
{0f, 54.45f},
{0f, 54.15f},
{0f, 53.9f },
{0f, 53.65f},
{0f, 53.35f},
{0f, 53.1f },
{0f, 52.8f },
{0f, 52.55f},
{0f, 52.3f },
{0f, 52f   },
{0f, 51.75f},
{0f, 51.45f},
{0f, 51.2f },
{0f, 50.9f },
{0f, 50.65f},
{0f, 50.4f },
{0f, 50.1f },
{0f, 49.85f},
{0f, 49.55f},
{0f, 49.3f },
{0f, 49.05f},
{0f, 48.75f},
{0f, 48.5f },
{0f, 48.2f },
{0f, 47.95f},
{0f, 47.65f},
{0f, 47.4f },
{0f, 47.1f },
{0f, 46.85f},
{0f, 46.6f },
{0f, 46.3f },
{0f, 46.05f},
{0f, 45.75f},
{0f, 45.5f },
{0f, 45.2f },
{0f, 44.95f},
{0f, 44.7f },
{0f, 44.4f },
{0f, 44.15f},
{0f, 43.9f },
{0f, 43.6f },
{0f, 43.35f},
{0f, 43.1f },
{0f, 42.8f },
{0f, 42.55f},
{0f, 42.3f },
{0f, 42f   },
{0f, 41.75f},
{0f, 41.5f },
{0f, 41.25f},
{0f, 40.95f},
{0f, 40.7f },
{0f, 40.45f},
{0f, 40.15f},
{0f, 39.9f },
{0f, 39.65f},
{0f, 39.4f },
{0f, 39.15f},
{0f, 38.85f},
{0f, 38.6f },
{0f, 38.35f},
{0f, 38.1f },
{0f, 37.8f },
{0f, 37.55f},
{0f, 37.3f },
{0f, 37.05f},
{0f, 36.8f },
{0f, 36.55f},
{0f, 36.25f},
{0f, 36f   },
{0f, 35.75f},
{0f, 35.5f },
{0f, 35.25f},
{0f, 35f   },
{0f, 34.75f},
{0f, 34.45f},
{0f, 34.25f},
{0f, 33.95f},
{0f, 33.7f },
{0f, 33.45f},
{0f, 33.2f },
{0f, 32.95f},
{0f, 32.7f },
{0f, 32.45f},
{0f, 32.2f },
{0f, 31.95f},
{0f, 31.7f },
{0f, 31.45f},
{0f, 31.2f },
{0f, 30.95f},
{0f, 30.7f },
{0f, 30.45f},
{0f, 30.2f },
{0f, 29.95f},
{0f, 29.75f},
{0f, 29.5f },
{0f, 29.25f},
{0f, 29f   },
{0f, 28.75f},
{0f, 28.5f },
{0f, 28.25f},
{0f, 28.05f},
{0f, 27.8f },
{0f, 27.55f},
{0f, 27.3f },
{0f, 27.05f},
{0f, 26.85f},
{0f, 26.6f },
{0f, 26.35f},
{0f, 26.15f},
{0f, 25.9f },
{0f, 25.65f},
{0f, 25.4f },
{0f, 25.2f },
{0f, 24.95f},
{0f, 24.75f},
{0f, 24.5f },
{0f, 24.3f },
{0f, 24.05f},
{0f, 23.85f},
{0f, 23.6f },
{0f, 23.4f },
{0f, 23.15f},
{0f, 22.95f},
{0f, 22.7f },
{0f, 22.5f },
{0f, 22.25f},
{0f, 22.05f},
{0f, 21.85f},
{0f, 21.6f },
{0f, 21.4f },
{0f, 21.2f },
{0f, 20.95f},
{0f, 20.75f},
{0f, 20.55f},
{0f, 20.35f},
{0f, 20.1f },
{0f, 19.9f },
{0f, 19.7f },
{0f, 19.5f },
{0f, 19.3f },
{0f, 19.1f },
{0f, 18.85f},
{0f, 18.65f},
{0f, 18.45f},
{0f, 18.25f},
{0f, 18.05f},
{0f, 17.85f},
{0f, 17.65f},
{0f, 17.45f},
{0f, 17.25f},
{0f, 17.05f},
{0f, 16.85f},
{0f, 16.65f},
{0f, 16.45f},
{0f, 16.3f },
{0f, 16.1f },
{0f, 15.9f },
{0f, 15.7f },
{0f, 15.5f },
{0f, 15.3f },
{0f, 15.15f},
{0f, 14.95f},
{0f, 14.75f},
{0f, 14.55f},
{0f, 14.4f },
{0f, 14.2f },
{0f, 14f   },
{0f, 13.85f},
{0f, 13.65f},
{0f, 13.5f },
{0f, 13.3f },
{0f, 13.1f },
{0f, 12.95f},
{0f, 12.75f},
{0f, 12.6f },
{0f, 12.4f },
{0f, 12.25f},
{0f, 12.05f},
{0f, 11.9f },
{0f, 11.75f},
{0f, 11.55f},
{0f, 11.4f },
{0f, 11.2f },
{0f, 11.05f},
{0f, 10.9f },
{0f, 10.7f },
{0f, 10.55f},
{0f, 10.4f },
{0f, 10.25f},
{0f, 10.05f},
{0f, 9.9f  },
{0f, 9.75f },
{0f, 9.6f  },
{0f, 9.45f },
{0f, 9.3f  },
{0f, 9.15f },
{0f, 9f},
{0f, 8.85f },
{0f, 8.65f },
{0f, 8.5f  },
{0f, 8.35f },
{0f, 8.2f  },
{0f, 8.1f  },
{0f, 7.95f },
{0f, 7.8f  },
{0f, 7.65f },
{0f, 7.5f  },
{0f, 7.35f },
{0f, 7.2f  },
{0f, 7.05f },
{0f, 6.95f },
{0f, 6.8f  },
{0f, 6.65f },
{0f, 6.5f  },
{0f, 6.4f  },
{0f, 6.25f },
{0f, 6.1f  },
{0f, 6f},
{0f, 5.85f },
{0f, 5.7f  },
{0f, 5.6f  },
{0f, 5.45f },
{0f, 5.35f },
{0f, 5.2f  },
{0f, 5.1f  },
{0f, 4.95f },
{0f, 4.85f },
{0f, 4.7f  },
{0f, 4.6f  },
{0f, 4.45f },
{0f, 4.35f },
{0f, 4.25f },
{0f, 4.1f  },
{0f, 4f},
{0f, 3.9f  },
{0f, 3.75f },
{0f, 3.65f },
{0f, 3.55f },
{0f, 3.45f },
{0f, 3.3f  },
{0f, 3.2f  },
{0f, 3.1f  },
{0f, 3f},
{0f, 2.9f  },
{0f, 2.8f  },
{0f, 2.7f  },
{0f, 2.6f  },
{0f, 2.5f  },
{0f, 2.4f  },
{0f, 2.3f  },
{0f, 2.2f  },
{0f, 2.1f  },
{0f, 2f},
{0f, 1.9f  },
{0f, 1.8f  },
{0f, 1.7f  },
{0f, 1.6f  },
{0f, 1.55f },
{0f, 1.45f },
{0f, 1.35f },
{0f, 1.25f },
{0f, 1.15f },
{0f, 1.1f  },
{0f, 1f},
{0f, 0.9f  },
{0f, 0.85f },
{0f, 0.75f },
{0f, 0.65f },
{0f, 0.6f  },
{0f, 0.5f  },
{0f, 0.45f },
{0f, 0.35f },
{0f, 0.3f  },
{0f, 0.2f  },
{0f, 0.15f },
{0f, 0.05f },
{0f, 0f}



        };
    }

}