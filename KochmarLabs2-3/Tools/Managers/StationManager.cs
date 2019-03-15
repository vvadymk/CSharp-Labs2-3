using System;
using System.Windows;
using KochmarLab2;

namespace KochmarLabs2_3.Tools.Managers
{
    static class StationManager
    {
        internal static Person CurrentUser { get; set; }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}
