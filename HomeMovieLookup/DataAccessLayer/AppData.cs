using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDataAccessLayer
{
    public class AppData
    {
        public static string DataPath { get; set; }
        public static string MovieListFileName = "movielist.csv";
    }

    internal class DataSource
    {
        public static string GetfilePath()
        {
            string currentPath = AppContext.BaseDirectory + @"moviedata";
            return currentPath;
        }
    }
}
