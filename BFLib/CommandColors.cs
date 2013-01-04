﻿using System;
using System.Reflection;
using System.Drawing;

namespace BrainTools
{
    internal static class CommandColors
    {
        internal static Color Right { get { return Color.FromArgb(255, 0, 0); } }
        internal static Color Left { get { return Color.FromArgb(128, 0, 0); } }
        internal static Color Inc { get { return Color.FromArgb(0, 255, 0); } }
        internal static Color Dec { get { return Color.FromArgb(0, 128, 0); } }
        internal static Color Print { get { return Color.FromArgb(0, 0, 255); } }
        internal static Color Read { get { return Color.FromArgb(0, 0, 128); } }
        internal static Color LoopStart { get { return Color.FromArgb(255, 255, 0); } }
        internal static Color LoopEnd { get { return Color.FromArgb(128, 128, 0); } }
        internal static Color RotateCW { get { return Color.FromArgb(0, 255, 255); } }
        internal static Color RotateCCW { get { return Color.FromArgb(0, 128, 128); } }

        internal static bool IsCommandColor(Color clr)
        {
            Type type = typeof(CommandColors);
            FieldInfo[] fields = type.GetFields(BindingFlags.Static);
            foreach (FieldInfo field in fields)
                if (((Color)field.GetValue(null)).Equals(clr))
                    return true;
            return false;
        }
    }
}
