﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH.Virtual_ECG_Monitor
{
    public class WaveData_ECG_018 : WaveData_ECG
    {
        public WaveData_ECG_018()
            : base()
        {
            // TODO: Complete member initialization

            ID = "R18";
            Name = "三度房室传导阻滞";
            Remark = "";
            Rate = 80;         
            WaveData = resp_00;
        }

        public static float[,] resp_00 = new float[99,12] {
{34.60f,   34.60f,   35.14f,   34.07f,   34.07f,   35.10f,   35.56f,   34.07f,   35.16f,   33.57f,   35.63f,   33.57f } ,
{34.60f,   34.60f,   35.13f,   34.08f,   34.06f,   35.11f,   35.56f,   35.09f,   35.17f,   33.57f,   35.61f,   33.57f},
{34.60f,   34.60f,   35.59f,   34.09f,   34.05f,   35.12f,   35.56f,   35.09f,   35.18f,   33.57f,   35.60f,   33.57f},
{34.60f,   34.60f,   37.21f,   34.10f,   34.04f,   35.13f,   35.56f,   35.09f,   34.61f,   33.57f,   35.59f,   33.57f},
{35.06f,   34.03f,   36.61f,   34.11f,   34.03f,   35.14f,   35.56f,   35.09f,   35.21f,   33.57f,   35.58f,   34.60f},
{36.67f,   33.57f,   36.14f,   34.12f,   35.03f,   35.15f,   34.56f,   34.52f,   35.22f,   33.57f,   35.57f,   34.60f},
{38.16f,   34.60f,   35.08f,   34.13f,   35.02f,   35.16f,   34.56f,   34.07f,   35.23f,   33.57f,   35.56f,   34.60f},
{37.13f,   34.60f,   35.07f,   34.14f,   35.01f,   35.17f,   35.00f,   34.07f,   35.24f,   34.60f,   35.55f,   34.60f},
{35.06f,   35.64f,   36.11f,   34.15f,   35.00f,   33.60f,   35.56f,   34.07f,   35.25f,   34.60f,   36.00f,   34.60f},
{34.03f,   36.67f,   36.10f,   35.18f,   34.99f,   31.13f,   35.56f,   34.07f,   35.26f,   34.60f,   37.59f,   36.09f},
{33.57f,   38.73f,   36.09f,   35.19f,   34.98f,   31.59f,   35.56f,   34.07f,   36.78f,   35.64f,   37.01f,   37.70f},
{33.57f,   38.73f,   36.08f,   34.63f,   34.97f,   33.63f,   35.56f,   34.07f,   38.42f,   37.13f,   35.97f,   37.13f},
{33.57f,   37.70f,   36.06f,   34.19f,   34.96f,   35.22f,   34.56f,   34.07f,   37.85f,   36.09f,   34.93f,   35.06f},
{34.60f,   36.67f,   35.94f,   33.64f,   36.98f,   35.23f,   33.00f,   34.07f,   36.81f,   35.18f,   34.46f,   34.60f},
{34.60f,   36.09f,   35.93f,   33.20f,   38.55f,   35.69f,   31.56f,   34.07f,   35.78f,   34.60f,   34.45f,   34.60f},
{34.60f,   35.64f,   35.92f,   34.22f,   36.96f,   35.25f,   32.56f,   34.07f,   35.32f,   34.60f,   34.44f,   34.60f},
{34.60f,   35.64f,   36.02f,   34.69f,   35.37f,   35.26f,   33.56f,   34.07f,   34.75f,   34.60f,   34.43f,   34.03f},
{34.60f,   35.64f,   36.01f,   35.26f,   34.91f,   35.27f,   34.56f,   34.07f,   34.29f,   34.60f,   34.42f,   34.03f},
{34.60f,   35.64f,   34.95f,   35.27f,   34.90f,   35.28f,   35.00f,   34.07f,   35.35f,   34.03f,   34.41f,   33.57f},
{34.60f,   35.64f,   35.99f,   35.28f,   34.89f,   35.29f,   34.56f,   34.07f,   35.36f,   33.57f,   34.40f,   33.57f},
{34.60f,   35.64f,   35.98f,   35.29f,   34.88f,   35.30f,   35.56f,   35.09f,   35.37f,   33.57f,   35.88f,   34.03f},
{34.60f,   35.64f,   35.97f,   35.30f,   34.87f,   35.31f,   35.00f,   35.09f,   35.38f,   33.57f,   41.02f,   39.19f},
{34.60f,   35.64f,   35.96f,   34.75f,   34.86f,   35.32f,   34.56f,   35.09f,   35.86f,   34.60f,   49.26f,   47.44f},
{34.60f,   35.64f,   35.95f,   34.31f,   34.85f,   35.33f,   34.56f,   35.09f,   34.82f,   40.68f,   54.52f,   54.20f},
{34.60f,   36.67f,   35.82f,   35.33f,   34.84f,   35.34f,   34.56f,   35.09f,   28.08f,   41.36f,   56.00f,   56.72f},
{34.60f,   36.67f,   34.88f,   36.36f,   40.36f,   35.35f,   36.00f,   35.09f,   18.66f,   28.88f,   54.85f,   55.23f},
{34.60f,   36.67f,   34.87f,   28.69f,   50.50f,   35.36f,   36.56f,   35.09f,   1.20f,   17.53f,   51.86f,   51.10f},
{34.60f,   36.67f,   34.86f,   21.15f,   56.58f,   35.37f,   20.00f,   35.09f,   11.37f,   21.66f,   43.60f,   44.34f},
{34.60f,   36.67f,   36.36f,   16.08f,   57.14f,   35.38f,   3.00f,   35.54f,   25.00f,   26.35f,   41.75f,   37.70f},
{34.60f,   36.67f,   33.21f,   10.00f,   58.14f,   35.39f,   5.00f,   37.12f,   33.86f,   28.42f,   36.37f,   33.00f},
{34.60f,   36.67f,   19.58f,   7.98f,   54.52f,   35.40f,   15.56f,   36.55f,   38.06f,   31.05f,   34.29f,   33.57f},
{34.60f,   36.09f,   10.14f,   16.11f,   44.36f,   35.41f,   27.00f,   35.54f,   40.17f,   32.43f,   34.28f,   33.57f},
{34.60f,   35.64f,   6.06f,   29.32f,   35.77f,   34.86f,   35.00f,   35.09f,   41.81f,   34.60f,   34.27f,   33.57f},
{34.60f,   35.64f,   1.27f,   34.86f,   31.70f,   32.84f,   40.00f,   35.09f,   41.82f,   36.67f,   34.26f,   33.00f},
{34.60f,   35.64f,   3.24f,   37.91f,   30.68f,   31.83f,   42.56f,   35.09f,   41.24f,   36.67f,   33.68f,   31.97f},
{34.03f,   35.64f,   16.38f,   40.52f,   30.66f,   30.38f,   43.56f,   35.09f,   41.26f,   36.09f,   32.18f,   30.94f},
{33.57f,   36.67f,   32.67f,   40.98f,   30.65f,   30.39f,   43.56f,   35.09f,   41.85f,   35.64f,   31.71f,   29.91f},
{34.60f,   36.09f,   39.41f,   39.98f,   31.21f,   34.46f,   44.56f,   35.09f,   42.91f,   35.64f,   31.13f,   28.88f},
{34.60f,   35.64f,   41.03f,   38.97f,   30.63f,   37.51f,   44.56f,   35.09f,   42.92f,   35.06f,   30.55f,   26.81f},
{34.60f,   35.64f,   42.07f,   39.54f,   30.06f,   37.98f,   45.56f,   34.52f,   43.97f,   34.60f,   30.08f,   26.35f},
{34.60f,   35.64f,   41.01f,   39.55f,   29.04f,   36.97f,   47.00f,   34.52f,   45.03f,   34.60f,   30.07f,   25.78f},
{34.60f,   35.64f,   42.05f,   40.58f,   28.01f,   36.53f,   49.00f,   35.54f,   45.04f,   34.03f,   30.06f,   25.32f},
{35.06f,   35.64f,   42.04f,   41.61f,   26.98f,   36.54f,   51.00f,   19.29f,   46.10f,   33.57f,   30.05f,   25.32f},
{37.13f,   35.64f,   40.98f,   42.07f,   25.96f,   36.55f,   53.00f,   10.00f,   47.16f,   33.00f,   29.46f,   25.32f},
{37.13f,   35.64f,   40.97f,   43.09f,   25.38f,   37.57f,   55.00f,   1.20f,   47.17f,   32.43f,   28.99f,   25.32f},
{35.64f,   35.64f,   42.00f,   43.67f,   25.37f,   36.57f,   56.56f,   10.00f,   47.18f,   31.51f,   28.41f,   25.32f},
{34.60f,   35.64f,   43.04f,   44.69f,   24.46f,   34.55f,   57.56f,   22.90f,   48.24f,   31.05f,   27.94f,   25.78f},
{33.57f,   37.13f,   44.08f,   44.70f,   24.00f,   33.54f,   58.56f,   34.52f,   48.25f,   30.71f,   28.39f,   27.84f},
{33.57f,   38.73f,   45.58f,   45.73f,   22.86f,   34.57f,   56.56f,   40.16f,   44.07f,   32.43f,   29.98f,   29.91f},
{33.57f,   38.73f,   47.08f,   45.74f,   21.84f,   35.60f,   53.00f,   42.19f,   39.89f,   32.43f,   29.97f,   30.48f},
{33.57f,   37.70f,   47.07f,   46.76f,   22.39f,   36.62f,   51.00f,   43.21f,   37.22f,   31.05f,   29.96f,   30.48f},
{33.57f,   36.67f,   48.23f,   46.77f,   24.41f,   36.63f,   50.00f,   44.23f,   36.18f,   30.48f,   29.95f,   30.48f},
{33.57f,   36.67f,   49.26f,   46.78f,   24.40f,   36.64f,   46.00f,   44.23f,   35.73f,   30.48f,   30.97f,   31.97f},
{33.57f,   36.09f,   50.30f,   46.79f,   22.81f,   36.65f,   43.56f,   44.68f,   35.74f,   30.48f,   31.99f,   33.57f},
{33.57f,   35.64f,   51.34f,   47.82f,   22.35f,   36.66f,   43.56f,   46.71f,   35.75f,   31.51f,   33.02f,   33.57f},
{34.60f,   35.64f,   52.38f,   47.83f,   23.92f,   36.67f,   43.56f,   48.74f,   35.76f,   33.00f,   34.04f,   34.60f},
{39.19f,   35.64f,   52.37f,   47.28f,   25.26f,   36.68f,   43.00f,   50.32f,   35.77f,   33.57f,   34.03f,   34.60f},
{46.98f,   35.64f,   52.36f,   45.82f,   26.38f,   36.69f,   42.00f,   52.35f,   35.78f,   34.60f,   35.05f,   34.60f},
{52.14f,   35.64f,   51.76f,   44.25f,   27.84f,   36.14f,   41.56f,   54.83f,   35.79f,   34.60f,   35.04f,   34.60f},
{52.59f,   35.64f,   50.70f,   43.25f,   29.86f,   35.70f,   41.56f,   56.41f,   35.80f,   34.60f,   35.03f,   34.60f},
{49.50f,   37.13f,   48.60f,   42.24f,   31.43f,   35.71f,   41.00f,   57.88f,   35.81f,   34.60f,   35.02f,   34.60f},
{48.01f,   37.13f,   46.61f,   41.24f,   31.87f,   35.72f,   40.00f,   59.46f,   35.82f,   34.60f,   35.01f,   34.03f},
{43.31f,   31.97f,   44.97f,   40.23f,   33.32f,   35.73f,   39.56f,   59.46f,   35.83f,   34.60f,   35.00f,   33.57f},
{36.67f,   27.84f,   42.28f,   39.22f,   34.44f,   35.74f,   39.00f,   58.89f,   35.84f,   34.60f,   34.99f,   33.57f},
{32.54f,   21.66f,   40.18f,   37.77f,   34.43f,   35.75f,   38.56f,   57.88f,   35.86f,   34.60f,   34.98f,   33.57f},
{31.51f,   15.01f,   38.65f,   36.20f,   35.44f,   35.76f,   38.56f,   55.85f,   35.87f,   34.60f,   34.96f,   33.57f},
{31.97f,   17.53f,   37.01f,   35.76f,   35.43f,   35.77f,   38.56f,   49.75f,   35.88f,   34.60f,   34.96f,   34.60f},
{30.94f,   26.81f,   35.95f,   35.77f,   35.42f,   35.78f,   38.56f,   44.23f,   35.89f,   34.60f,   34.94f,   34.60f},
{30.48f,   34.60f,   35.01f,   35.21f,   35.41f,   35.79f,   38.56f,   42.19f,   35.90f,   34.60f,   34.93f,   34.60f},
{29.45f,   38.16f,   34.42f,   34.77f,   35.40f,   35.80f,   38.00f,   41.18f,   35.91f,   34.60f,   34.92f,   34.60f},
{29.45f,   38.73f,   34.41f,   34.78f,   35.39f,   35.81f,   37.56f,   41.18f,   35.92f,   34.60f,   34.91f,   34.60f},
{28.88f,   39.19f,   33.82f,   34.79f,   35.38f,   35.82f,   37.56f,   41.18f,   35.93f,   34.60f,   34.90f,   34.60f},
{28.42f,   37.70f,   33.34f,   34.80f,   35.37f,   35.83f,   37.56f,   40.62f,   35.94f,   34.60f,   34.89f,   34.60f},
{27.84f,   36.09f,   33.33f,   34.81f,   35.36f,   35.84f,   37.56f,   40.16f,   35.95f,   34.03f,   34.31f,   33.57f},
{27.39f,   35.64f,   33.32f,   34.82f,   35.35f,   35.85f,   37.56f,   40.16f,   35.38f,   33.57f,   33.84f,   33.57f},
{26.81f,   35.64f,   33.31f,   34.83f,   35.34f,   35.86f,   37.00f,   40.16f,   34.92f,   33.57f,   34.86f,   33.57f},
{26.35f,   35.64f,   33.30f,   34.84f,   35.33f,   35.87f,   36.56f,   40.16f,   34.93f,   33.57f,   34.85f,   33.57f},
{25.78f,   36.67f,   33.29f,   34.85f,   35.32f,   35.88f,   36.56f,   40.16f,   34.94f,   33.57f,   34.84f,   34.60f},
{25.32f,   36.67f,   34.79f,   34.86f,   34.74f,   35.89f,   36.56f,   39.60f,   34.95f,   33.57f,   34.83f,   34.60f},
{24.29f,   37.13f,   35.83f,   34.87f,   34.28f,   35.90f,   36.56f,   38.58f,   34.96f,   33.57f,   34.82f,   34.60f},
{25.32f,   37.70f,   34.89f,   35.90f,   34.27f,   35.91f,   36.00f,   37.57f,   34.98f,   33.57f,   34.81f,   34.60f},
{26.35f,   37.70f,   34.29f,   35.91f,   34.26f,   35.92f,   35.56f,   37.12f,   34.99f,   33.57f,   34.80f,   34.60f},
{25.78f,   38.73f,   34.28f,   35.92f,   34.25f,   35.93f,   35.56f,   36.55f,   35.00f,   33.57f,   34.79f,   34.60f},
{24.29f,   38.73f,   35.32f,   35.93f,   34.24f,   35.38f,   35.56f,   36.10f,   36.05f,   34.60f,   34.21f,   34.60f},
{23.26f,   39.76f,   35.31f,   35.94f,   34.23f,   32.90f,   35.56f,   35.54f,   37.58f,   34.60f,   33.74f,   34.60f},
{23.26f,   40.79f,   35.30f,   35.95f,   34.22f,   31.90f,   35.56f,   35.09f,   39.22f,   35.18f,   35.22f,   35.64f},
{24.75f,   42.85f,   35.29f,   35.96f,   34.21f,   32.92f,   34.56f,   35.09f,   38.65f,   36.67f,   36.81f,   36.67f},
{26.35f,   42.28f,   35.28f,   35.97f,   33.63f,   33.95f,   32.56f,   34.07f,   37.61f,   36.67f,   36.23f,   37.13f},
{27.84f,   41.25f,   35.27f,   34.97f,   36.22f,   34.98f,   31.56f,   34.07f,   36.57f,   35.06f,   34.73f,   35.64f},
{29.45f,   40.22f,   35.26f,   34.41f,   37.22f,   36.00f,   31.56f,   34.07f,   36.12f,   34.60f,   33.69f,   34.03f},
{30.48f,   39.76f,   34.78f,   33.97f,   35.18f,   36.01f,   33.00f,   34.07f,   36.13f,   34.60f,   33.68f,   33.57f},
{31.51f,   39.76f,   35.12f,   33.98f,   33.59f,   36.02f,   34.56f,   34.07f,   36.14f,   34.03f,   33.67f,   33.57f},
{32.54f,   39.76f,   35.11f,   35.01f,   33.02f,   36.03f,   34.56f,   35.09f,   36.15f,   33.57f,   34.69f,   34.60f},
{33.57f,   39.76f,   35.10f,   35.02f,   33.01f,   36.04f,   34.56f,   34.52f,   36.16f,   33.57f,   34.68f,   34.60f},
{33.57f,   39.19f,   34.62f,   35.03f,   33.11f,   36.05f,   35.56f,   34.07f,   36.17f,   33.57f,   34.67f,   34.60f},
{34.60f,   38.73f,   34.15f,   35.04f,   32.99f,   36.06f,   35.56f,   34.07f,   36.18f,   33.57f,   34.66f,   34.60f},
{34.60f,   38.16f,   34.14f,   35.05f,   32.98f,   36.07f,   35.56f,   34.07f,   36.19f,   33.57f,   34.65f,   34.60f},
{34.60f,   37.13f,   34.13f,   35.06f,   32.97f,   36.08f,   35.56f,   34.07f,   36.20f,   33.57f,   34.64f,   34.03f},
{34.60f,   36.67f,   34.12f,   35.07f,   32.96f,   36.09f,   35.56f,   35.09f,   36.20f,   33.57f,   34.62f,   33.57f},


        };
    }

}