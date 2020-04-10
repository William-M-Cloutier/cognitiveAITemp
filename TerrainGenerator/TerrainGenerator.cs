﻿using System;
using System.IO;

namespace TerrainGenerator
{
    class TerrainGenerator
    {
        static void Main(string[] args)
        {
            ElevationLandscape landscape = new ElevationLandscape(100, 100, 30, 1000, 3);
            landscape.Initialize();
            landscape.printMap();

            StreamWriter writer = new StreamWriter("landscape.txt");
            writer.WriteLine(landscape.Width);
            writer.WriteLine(landscape.Height);

            for (int i = 0; i < landscape.map.GetLength(0); i++)
            {
                for (int j = 0; j < landscape.map.GetLength(1); j++)
                    writer.Write(landscape.map[i,j] + " ");
            }

            writer.Flush();
            writer.Close();
        }
    }
}
